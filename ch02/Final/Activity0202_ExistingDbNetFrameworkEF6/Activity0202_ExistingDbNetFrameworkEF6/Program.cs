using EF_Activity01_NetFramework;
using System;
using System.Linq;

namespace Activity0202_ExistingDbNetFrameworkEF6
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AdventureWorksEntities())
            {
                var people = db.People.OrderByDescending(x => x.LastName).Take(20);

                foreach (var person in people)
                {
                    Console.WriteLine($"{person.FirstName} {person.LastName}");
                }
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
        }
    }
}
