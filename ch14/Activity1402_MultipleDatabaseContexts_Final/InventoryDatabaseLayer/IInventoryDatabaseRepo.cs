using InventoryModels;
using InventoryModels.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InventoryDatabaseLayer
{
    public interface IInventoryDatabaseRepoReadOnly
    {
        Task<List<GetItemsForListingDto>> GetItemsForListingFromProcedure(DateTime dateDateValue, DateTime maxDateValue);
        Task<List<GetItemsForListingWithDateDto>> GetItemsForListingLinq(DateTime minDateValue, DateTime maxDateValue);
        Task<List<GetItemsTotalValueDto>> GetItemsTotalValues(bool isActive);
        Task<List<ItemsWithGenresDto>> GetItemsWithGenres();
        Task<List<CategoryDto>> ListCategoriesAndColors();
        Task<List<Item>> ListInventory();
    }

    public interface IInventorDatabaseRepoWriteOnly
    {
        Task<int> InsertOrUpdateItem(Item item);
        Task InsertOrUpdateItems(List<Item> items);
        Task DeleteItem(int id);
        Task DeleteItems(List<int> itemIds);
    }

    public interface IInventoryDatabaseRepo : IInventoryDatabaseRepoReadOnly, IInventorDatabaseRepoWriteOnly
    {

    }
}
