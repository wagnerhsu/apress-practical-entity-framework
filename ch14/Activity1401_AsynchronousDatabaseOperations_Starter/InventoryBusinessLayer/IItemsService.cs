using InventoryModels.Dtos;
using System;
using System.Collections.Generic;

namespace InventoryBusinessLayer
{
    public interface IItemsServiceReadOnly
    {
        List<GetItemsForListingWithDateDto> GetItemsForListingLinq(DateTime minDateValue, DateTime maxDateValue);
        List<GetItemsForListingDto> GetItemsForListingFromProcedure(DateTime minDateValue, DateTime maxDateValue);
        AllItemsPipeDelimitedStringDto GetItemsPipeDelimitedString(bool isActive);
        List<GetItemsTotalValueDto> GetItemsTotalValues(bool isActive);
        List<ItemsWithGenresDto> GetItemsWithGenres();
        List<CategoryDto> ListCategoriesAndColors();
        List<ItemDto> ListInventory();
    }

    public interface IItemsServiceWriteOnly
    {
        int InsertOrUpdateItem(CreateOrUpdateItemDto item);
        void InsertOrUpdateItems(List<CreateOrUpdateItemDto> item);
        void DeleteItem(int id);
        void DeleteItems(List<int> itemIds);
    }

    public interface IItemsService : IItemsServiceReadOnly, IItemsServiceWriteOnly
    {
    }

}
