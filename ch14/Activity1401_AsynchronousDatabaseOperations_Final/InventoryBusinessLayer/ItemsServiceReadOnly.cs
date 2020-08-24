using AutoMapper;
using InventoryDatabaseLayer;
using InventoryModels.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InventoryBusinessLayer
{
    public class ItemsServiceReadOnly : IItemsServiceReadOnly
    {
        private readonly InventoryDatabaseDapperRepo _dbRepo;
        private readonly IMapper _mapper;

        public ItemsServiceReadOnly(InventoryDatabaseDapperRepo dbRepo, IMapper mapper)
        {
            _dbRepo = dbRepo;
            _mapper = mapper;
        }

        public async Task<List<GetItemsForListingDto>> GetItemsForListingFromProcedure(DateTime minDateValue, DateTime maxDateValue)
        {
            throw new NotImplementedException();
        }

        public async Task<List<GetItemsForListingWithDateDto>> GetItemsForListingLinq(DateTime minDateValue, DateTime maxDateValue)
        {
            throw new NotImplementedException();
        }

        public async Task<AllItemsPipeDelimitedStringDto> GetItemsPipeDelimitedString(bool isActive)
        {
            throw new NotImplementedException();
        }

        public async Task<List<GetItemsTotalValueDto>> GetItemsTotalValues(bool isActive)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ItemsWithGenresDto>> GetItemsWithGenres()
        {
            throw new NotImplementedException();
        }

        public async Task<List<CategoryDto>> ListCategoriesAndColors()
        {
            return await _dbRepo.ListCategoriesAndColors();
        }

        public async Task<List<ItemDto>> ListInventory()
        {
            var items = await _dbRepo.ListInventory();
            return _mapper.Map<List<ItemDto>>(items);
        }
    }
}
