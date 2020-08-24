﻿using AutoMapper;
using InventoryModels;
using InventoryModels.Dtos;

namespace Activity0902_SettingUpAutomapper
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
