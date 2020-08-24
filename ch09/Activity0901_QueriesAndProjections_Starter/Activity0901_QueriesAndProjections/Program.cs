﻿using EF_Activity001;
using InventoryHelpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;

namespace Activity0901_QueriesAndProjections
{
    class Program
    {
        static IConfigurationRoot _configuration;
        static DbContextOptionsBuilder<AdventureWorksContext> _optionsBuilder;
        static void BuildOptions()
        {
            _configuration = ConfigurationBuilderSingleton.ConfigurationRoot;
            _optionsBuilder = new DbContextOptionsBuilder<AdventureWorksContext>();
            _optionsBuilder.UseSqlServer(_configuration.GetConnectionString("AdventureWorks"));
        }

        static void Main(string[] args)
        {
            BuildOptions();
            Console.WriteLine("Would you like to view all salespeople? [y/n]");
            var input = Console.ReadLine();
            if (input.StartsWith("y", StringComparison.OrdinalIgnoreCase))
            {
                ShowAllSalesPeople();
            }
        }

        private static void ShowAllSalesPeople()
        {
            using (var db = new AdventureWorksContext(_optionsBuilder.Options))
            {
                var salesPeople = db.SalesPerson.Take(20).ToList();
                foreach (var sp in salesPeople)
                {
                    Console.WriteLine(sp);
                }
            }
        }
    }
}