using InventoryModels.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InventoryBusinessLayer
{
    public interface IItemsServiceReadOnly
    {
        Task<List<GetItemsForListingWithDateDto>> GetItemsForListingLinq(DateTime minDateValue, DateTime maxDateValue);
        Task<List<GetItemsForListingDto>> GetItemsForListingFromProcedure(DateTime minDateValue, DateTime maxDateValue);
        Task<AllItemsPipeDelimitedStringDto> GetItemsPipeDelimitedString(bool isActive);
        Task<List<GetItemsTotalValueDto>> GetItemsTotalValues(bool isActive);
        Task<List<ItemsWithGenresDto>> GetItemsWithGenres();
        Task<List<CategoryDto>> ListCategoriesAndColors();
        Task<List<ItemDto>> ListInventory();
    }

    public interface IItemsServiceWriteOnly
    {
        Task<int> InsertOrUpdateItem(CreateOrUpdateItemDto item);
        Task InsertOrUpdateItems(List<CreateOrUpdateItemDto> item);
        Task DeleteItem(int id);
        Task DeleteItems(List<int> itemIds);
    }

    public interface IItemsService : IItemsServiceReadOnly, IItemsServiceWriteOnly
    {
    }

}
