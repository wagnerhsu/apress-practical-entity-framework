using EF_Activity001;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;

namespace Activity0301_EFCore
{
    public class Program
    {
        static IConfigurationRoot _configuration;
        static DbContextOptionsBuilder<AdventureWorksContext> _optionsBuilder;

        static void Main(string[] args)
        {
            BuildOptions();
            ListPeople();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }


        static void BuildOptions()
        {
            _configuration = ConfigurationBuilderSingleton.ConfigurationRoot;
            _optionsBuilder = new DbContextOptionsBuilder<AdventureWorksContext>();
            _optionsBuilder.UseSqlServer(_configuration.GetConnectionString("AdventureWorks"));
        }

        static void ListPeople()
        {
            using (var db = new AdventureWorksContext(_optionsBuilder.Options))
            {
                var people = db.Person.OrderByDescending(x => x.LastName).Take(20).ToList();

                foreach (var person in people)
                {
                    Console.WriteLine($"{person.FirstName} {person.LastName}");
                }
            }
        }
    }
}
