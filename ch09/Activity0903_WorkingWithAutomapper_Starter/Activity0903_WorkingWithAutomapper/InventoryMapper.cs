using AutoMapper;
using InventoryModels;
using InventoryModels.Dtos;

namespace Activity0903_WorkingWithAutomapper
{
    public class InventoryMapper : Profile
    {
        public InventoryMapper()
        {
            CreateMaps();
        }

        private void CreateMaps()
        {
            CreateMap<Item, ItemDto>();
            CreateMap<Category, CategoryDto>();
        }
    }
}
