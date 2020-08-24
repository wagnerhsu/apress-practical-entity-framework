using AutoMapper;
using AutoMapper.QueryableExtensions;
using InventoryDatabaseCore;
using InventoryModels;
using InventoryModels.Dtos;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace InventoryDatabaseLayer
{
    public class InventoryDatabaseRepo : IInventoryDatabaseRepo
    {
        private readonly InventoryDbContext _context;
        private readonly IMapper _mapper;

        public InventoryDatabaseRepo(InventoryDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<GetItemsForListingDto>> GetItemsForListingFromProcedure(DateTime dateDateValue, DateTime maxDateValue)
        {
            var minDateParam = new SqlParameter("minDate", dateDateValue);
            var maxDateParam = new SqlParameter("maxDate", maxDateValue);

            return await _context.ItemsForListing
                        .FromSqlRaw("EXECUTE dbo.GetItemsForListing @minDate, @maxDate"
                                        , minDateParam, maxDateParam)
                        .ToListAsync();
        }

        public async Task<List<GetItemsForListingWithDateDto>> GetItemsForListingLinq(DateTime minDateValue, DateTime maxDateValue)
        {
            var result = await _context.Items.Include(x => x.Category)
                .Select(x => new GetItemsForListingWithDateDto
                {
                    CreatedDate = x.CreatedDate,
                    CategoryName = x.Category.Name,
                    Description = x.Description,
                    IsActive = x.IsActive,
                    IsDeleted = x.IsDeleted,
                    Name = x.Name,
                    Notes = x.Notes
                })
                .Where(x => x.CreatedDate >= minDateValue && x.CreatedDate <= maxDateValue)
                .ToListAsync();

            return result.OrderBy(y => y.CategoryName).ThenBy(z => z.Name).ToList();
        }

        public async Task<List<GetItemsTotalValueDto>> GetItemsTotalValues(bool isActive)
        {
            var isActiveParm = new SqlParameter("IsActive", isActive);

            return await _context.GetItemsTotalValues
                           .FromSqlRaw("SELECT * from [dbo].[GetItemsTotalValue] (@IsActive)", isActiveParm)
                           .ToListAsync();
        }

        public async Task<List<CategoryDto>> ListCategoriesAndColors()
        {
            return await _context.Categories
                            .Include(x => x.CategoryColor)
                            .ProjectTo<CategoryDto>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public async Task<List<Item>> ListInventory()
        {
            var result = await _context.Items.Include(x => x.Category)
                        .Where(x => !x.IsDeleted).ToListAsync();
            return result.AsEnumerable().OrderBy(x => x.Name).ToList();
        }

        public async Task<List<ItemsWithGenresDto>> GetItemsWithGenres()
        {
            return await _context.ItemsWithGenres.ToListAsync();
        }

        public async Task<int> InsertOrUpdateItem(Item item)
        {
            if (item.Id > 0)
            {
                return await UpdateItem(item);
            }
            return await CreateItem(item);
        }

        private async Task<int> CreateItem(Item item)
        {
            await _context.Items.AddAsync(item);
            await _context.SaveChangesAsync();
            var newItem = await _context.Items.SingleOrDefaultAsync(x => x.Name.ToLower()
                            .Equals(item.Name.ToLower()));

            if (newItem == null) throw new Exception("Could not Create the item as expected");

            return newItem.Id;
        }

        private async Task<int> UpdateItem(Item item)
        {
            var dbItem = await _context.Items.SingleOrDefaultAsync(x => x.Id == item.Id);
            dbItem.CategoryId = item.CategoryId;
            dbItem.CurrentOrFinalPrice = item.CurrentOrFinalPrice;
            dbItem.Description = item.Description;
            dbItem.IsActive = item.IsActive;
            dbItem.IsDeleted = item.IsDeleted;
            dbItem.IsOnSale = item.IsOnSale;
            dbItem.Name = item.Name;
            dbItem.Notes = item.Notes;
            dbItem.PurchasedDate = item.PurchasedDate;
            dbItem.PurchasePrice = item.PurchasePrice;
            dbItem.Quantity = item.Quantity;
            dbItem.SoldDate = item.SoldDate;
            await _context.SaveChangesAsync();
            return item.Id;
        }

        public async Task InsertOrUpdateItems(List<Item> items)
        {
            using (var scope = new TransactionScope(TransactionScopeOption.Required
                        , new TransactionOptions 
                            { IsolationLevel = IsolationLevel.ReadUncommitted }))
            {
                try
                {
                    foreach (var item in items)
                    {
                        var success = await InsertOrUpdateItem(item) > 0;
                        if (!success) throw new Exception($"Error saving the item {item.Name}");
                    }

                    scope.Complete();
                }
                catch (Exception ex)
                {
                    //log it:
                    Debug.WriteLine(ex.ToString());
                    throw ex;
                }
            }
        }

        public async Task DeleteItem(int id)
        {
            var item = await _context.Items.SingleOrDefaultAsync(x => x.Id == id);
            if (item == null) return;
            item.IsDeleted = true;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteItems(List<int> itemIds)
        {
            using (var scope = new TransactionScope(TransactionScopeOption.Required
                        , new TransactionOptions
                        { IsolationLevel = IsolationLevel.ReadUncommitted }))
            { 
                try
                {
                    foreach (var itemId in itemIds)
                    {
                        await DeleteItem(itemId);
                    }

                    scope.Complete();
                }
                catch (Exception ex)
                {
                    //log it:
                    Debug.WriteLine(ex.ToString());
                    throw ex;  //make sure it is known that the transaction failed
                }
            }
        }

    }
}
