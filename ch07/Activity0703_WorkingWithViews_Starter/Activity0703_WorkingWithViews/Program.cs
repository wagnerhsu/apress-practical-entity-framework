﻿using InventoryDatabaseCore;
using InventoryHelpers;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;

namespace Activity0703_WorkingWithViews
{
    class Program
    {
        static IConfigurationRoot _configuration;
        static DbContextOptionsBuilder<InventoryDbContext> _optionsBuilder;

        static void Main(string[] args)
        {
            BuildOptions();
            ListInventory();
            GetItemsForListingWithParams();
            AllActiveItemsPipeDelimitedString();
            GetItemsTotalValues();
        }

        static void BuildOptions()
        {
            _configuration = ConfigurationBuilderSingleton.ConfigurationRoot;
            _optionsBuilder = new DbContextOptionsBuilder<InventoryDbContext>();
            _optionsBuilder.UseSqlServer(_configuration.GetConnectionString("InventoryManager"));
        }

        static void ListInventory()
        {
            using (var db = new InventoryDbContext(_optionsBuilder.Options))
            {
                var items = db.Items.Take(5).OrderBy(x => x.Name).ToList();
                items.ForEach(x => Console.WriteLine($"New Item: {x.Name}"));
            }
        }

        static void GetItemsForListingWithParams()
        {
            var minDate = new SqlParameter("minDate", new DateTime(2020, 1, 1));
            var maxDate = new SqlParameter("maxDate", new DateTime(2021, 1, 1));

            using (var db = new InventoryDbContext(_optionsBuilder.Options))
            {
                var results = db.ItemsForListing
                                .FromSqlRaw("EXECUTE dbo.GetItemsForListing @minDate, @maxDate", minDate, maxDate)
                                .ToList();
                foreach (var item in results)
                {
                    Console.WriteLine($"ITEM {item.Name} - {item.Description}");
                }
            }
        }

        static void AllActiveItemsPipeDelimitedString()
        {
            using (var db = new InventoryDbContext(_optionsBuilder.Options))
            {
                var isActiveParm = new SqlParameter("IsActive", 1);

                var result = db.AllItemsOutput
                                .FromSqlRaw("SELECT [dbo].[ItemNamesPipeDelimitedString] (@IsActive) AllItems", isActiveParm)
                                .FirstOrDefault();

                Console.WriteLine($"All active Items: {result.AllItems}");
            }
        }

        static void GetItemsTotalValues()
        {
            using (var db = new InventoryDbContext(_optionsBuilder.Options))
            {
                var isActiveParm = new SqlParameter("IsActive", 1);

                var result = db.GetItemsTotalValues
                                .FromSqlRaw("SELECT * from [dbo].[GetItemsTotalValue] (@IsActive)", isActiveParm)
                                .ToList();

                foreach (var item in result)
                {
                    Console.WriteLine($"New Item] {item.Id,-10}" +
                                        $"|{item.Name,-50}" +
                                        $"|{item.Quantity,-4}" +
                                        $"|{item.TotalValue,-5}");
                }
            }
        }
    }
}
