using AutoMapper;
using InventoryDatabaseLayer;
using InventoryModels.Dtos;
using System;
using System.Collections.Generic;

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

        public List<GetItemsForListingDto> GetItemsForListingFromProcedure(DateTime minDateValue, DateTime maxDateValue)
        {
            throw new NotImplementedException();
        }

        public List<GetItemsForListingWithDateDto> GetItemsForListingLinq(DateTime minDateValue, DateTime maxDateValue)
        {
            throw new NotImplementedException();
        }

        public AllItemsPipeDelimitedStringDto GetItemsPipeDelimitedString(bool isActive)
        {
            throw new NotImplementedException();
        }

        public List<GetItemsTotalValueDto> GetItemsTotalValues(bool isActive)
        {
            throw new NotImplementedException();
        }

        public List<ItemsWithGenresDto> GetItemsWithGenres()
        {
            throw new NotImplementedException();
        }

        public List<CategoryDto> ListCategoriesAndColors()
        {
            return _dbRepo.ListCategoriesAndColors();
        }

        public List<ItemDto> ListInventory()
        {
            return _mapper.Map<List<ItemDto>>(_dbRepo.ListInventory());
        }
    }
}
