using AutoMapper;
using InventoryDatabaseLayer;
using InventoryModels;
using InventoryModels.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InventoryBusinessLayer
{
    public class ItemsService : IItemsService
    {
        private readonly IInventoryDatabaseRepo _dbRepo;
        private readonly IMapper _mapper;

        public ItemsService(IInventoryDatabaseRepo dbRepo, IMapper mapper)
        {
            _dbRepo = dbRepo;
            _mapper = mapper;
        }

        public async Task<List<GetItemsForListingDto>> GetItemsForListingFromProcedure(DateTime minDateValue, DateTime maxDateValue)
        {
            return await _dbRepo.GetItemsForListingFromProcedure(minDateValue, maxDateValue);
        }

        public async Task<List<GetItemsForListingWithDateDto>> GetItemsForListingLinq(DateTime minDateValue, DateTime maxDateValue)
        {
            return await _dbRepo.GetItemsForListingLinq(minDateValue, maxDateValue);
        }

        public async Task<AllItemsPipeDelimitedStringDto> GetItemsPipeDelimitedString(bool isActive)
        {
            var items = await ListInventory();
            var sb = new StringBuilder();

            foreach (var item in items)
            {
                if (sb.Length > 0)
                {
                    sb.Append("|");
                }
                sb.Append(item.Name);
            }

            var output = new AllItemsPipeDelimitedStringDto();
            output.AllItems = sb.ToString();
            return output;
        }

        public async Task<List<GetItemsTotalValueDto>> GetItemsTotalValues(bool isActive)
        {
            return await _dbRepo.GetItemsTotalValues(isActive);
        }

        public async Task<List<ItemsWithGenresDto>> GetItemsWithGenres()
        {
            return await _dbRepo.GetItemsWithGenres();
        }

        public async Task<List<CategoryDto>> ListCategoriesAndColors()
        {
            return await _dbRepo.ListCategoriesAndColors();
        }

        public async Task<List<ItemDto>> ListInventory()
        {
            var result = await _dbRepo.ListInventory();
            return _mapper.Map<List<ItemDto>>(result);
        }

        public async Task<int> InsertOrUpdateItem(CreateOrUpdateItemDto item)
        {
            if (item.CategoryId <= 0)
            {
                throw new ArgumentException("Please set the category id before insert or update");
            } 
            return await _dbRepo.InsertOrUpdateItem(_mapper.Map<Item>(item));
        }

        public async Task InsertOrUpdateItems(List<CreateOrUpdateItemDto> items)
        {
            await _dbRepo.InsertOrUpdateItems(_mapper.Map<List<Item>>(items));
        }

        public async Task DeleteItem(int id)
        {
            if (id <= 0) 
            {
                throw new ArgumentException("Please set a valid item id before deleting");
            }
            await _dbRepo.DeleteItem(id);
        }

        public async Task DeleteItems(List<int> itemIds)
        {
            try
            {
                await _dbRepo.DeleteItems(itemIds);
            }
            catch (Exception ex)
            {
                //TODO: better logging/not squelching
                Console.WriteLine($"The transaction has failed: {ex.Message}");
            }
        }
    }
}
