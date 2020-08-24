using AutoMapper;
using AutoMapper.QueryableExtensions;
using InventoryBusinessLayer;
using InventoryDatabaseCore;
using InventoryHelpers;
using InventoryModels;
using InventoryModels.Dtos;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Activity1101_LayeringOurSolution
{
    class Program
    {
        static IConfigurationRoot _configuration;
        static DbContextOptionsBuilder<InventoryDbContext> _optionsBuilder;
        private static MapperConfiguration _mapperConfig;
        private static IMapper _mapper;
        private static IServiceProvider _serviceProvider;

        static void Main(string[] args)
        {
            BuildOptions();
            BuildMapper();

            var minDate = new DateTime(2020, 1, 1);
            var maxDate = new DateTime(2021, 1, 1);

            using (var db = new InventoryDbContext(_optionsBuilder.Options))
            {
                var svc = new ItemsService(db, _mapper);
                Console.WriteLine("List Inventory");
                var inventory = svc.ListInventory();
                inventory.ForEach(x => Console.WriteLine($"New Item: {x}"));

                Console.WriteLine("List inventory with Linq");
                var items = svc.GetItemsForListingLinq(minDate, maxDate);
                items.ForEach(x => Console.WriteLine($"ITEM| {x.CategoryName}| {x.Name} - {x.Description}"));

                Console.WriteLine("List Inventory from procedure");
                var procItems = svc.GetItemsForListingFromProcedure(minDate, maxDate);
                procItems.ForEach(x => Console.WriteLine($"ITEM| {x.Name} - {x.Description}"));

                Console.WriteLine("Item Names Pipe Delimited String");
                var pipedItems = svc.GetItemsPipeDelimitedString(true);
                Console.WriteLine(pipedItems.AllItems);

                Console.WriteLine("Get Items Total Values");
                var totalValues = svc.GetItemsTotalValues(true);
                totalValues.ForEach(item => Console.WriteLine($"New Item] {item.Id,-10}" +
                                        $"|{item.Name,-50}" +
                                        $"|{item.Quantity,-4}" +
                                        $"|{item.TotalValue,-5}"));

                Console.WriteLine("Get Items With Genres");
                var itemsWithGenres = svc.GetItemsWithGenres();
                itemsWithGenres.ForEach(item => Console.WriteLine($"New Item] {item.Id,-10}" +
                                        $"|{item.Name,-50}" +
                                        $"|{item.Genre?.ToString().PadLeft(4)}"));

                Console.WriteLine("List Categories And Colors");
                var categoriesAndColors = svc.ListCategoriesAndColors();
                categoriesAndColors.ForEach(c => Console.WriteLine($"{c.Category} | {c.CategoryColor.Color}"));
            }
        }


        static void BuildOptions()
        {
            _configuration = ConfigurationBuilderSingleton.ConfigurationRoot;
            _optionsBuilder = new DbContextOptionsBuilder<InventoryDbContext>();
            _optionsBuilder.UseSqlServer(_configuration.GetConnectionString("InventoryManager"));
            _mapperConfig = new MapperConfiguration(cfg => {
                cfg.AddProfile<InventoryMapper>();
            });
            _mapperConfig.AssertConfigurationIsValid();
            _mapper = _mapperConfig.CreateMapper();
        }

        static void BuildMapper()
        {
            var services = new ServiceCollection();
            services.AddAutoMapper(typeof(InventoryMapper));
            _serviceProvider = services.BuildServiceProvider();
        }
    }
}
