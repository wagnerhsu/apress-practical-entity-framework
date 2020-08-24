using System;
using System.Data;
using AWDataAccessLayer;
using System.Configuration;
using System.Collections.Generic;
using AWEFDataAccessLayer;
using Person = AWDataLayerObjects.Person;
using System.Linq;

namespace Activity0303_EF6_UpdateFromExisting
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet people = GetPeopleOriginal();
            var x = 0;
            foreach (DataTable dt in people.Tables)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Person p1 = GetPersonOriginal(Convert.ToInt32(dr["BusinessEntityID"]));

                    Console.WriteLine(string.Format("Found Person: {0}", p1.GetFullName()));
                    x++;
                    if (x >= 5) break; //quick out
                }
                break; //quick out
            }

            var efPeople = GetPeopleEF();
            efPeople.ForEach(p => Console.WriteLine($"Next Person: {p.GetFullName()}"));

            Console.WriteLine("Completed.  Press any key to exit");
            Console.ReadKey();
        }

        public static DataSet GetPeopleOriginal()
        {
            PersonDataAccess dal = new PersonDataAccess();
            string cnstr = ConfigurationManager.ConnectionStrings["AdventureWorksDb"].ToString();
            return dal.GetPeople("G", cnstr);
        }

        private static Person GetPersonOriginal(int id)
        {
            PersonDataAccess dal = new PersonDataAccess();
            string cnstr = ConfigurationManager.ConnectionStrings["AdventureWorksDb"].ToString();
            return dal.GetPerson(id, cnstr);
        }

        private static List<Person> GetPeopleEF()
        {
            var people = new List<Person>();
            using (var context = new AdventureWorks())
            {
                var result = context.People
                                    .Where(x => x.LastName.StartsWith("G"))
                                    .Take(5)
                                    .OrderBy(x => x.LastName).ToList();


                foreach (var p in result)
                {
                    var person = new Person()
                    {
                        BusinessEntityID = p.BusinessEntityID,
                        FirstName = p.FirstName,
                        LastName = p.LastName,
                        PersonType = p.PersonType,
                        Suffix = p.Suffix,
                        Title = p.Title
                    };
                    people.Add(person);
                }
            }
            return people;
        }

    }
}
