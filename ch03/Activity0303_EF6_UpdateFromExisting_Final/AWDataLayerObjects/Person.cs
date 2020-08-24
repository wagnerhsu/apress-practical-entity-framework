namespace AWDataLayerObjects
{
    public class Person
    {
        //again, in the real world there would be a much more robust implementation here
        //perhaps even with some mixed-in business logic because of the original design
        //in fact, these object may not even be in their own project.

        public int BusinessEntityID { get; set; }
        public string PersonType { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        //...other properties

        public string GetFullName() 
        {
            //remember, this is simulating older code.
            return string.IsNullOrWhiteSpace(Suffix)
                        ? string.IsNullOrWhiteSpace(LastName)
                            ? string.IsNullOrWhiteSpace(FirstName) ? string.Empty : FirstName
                            : string.IsNullOrWhiteSpace(FirstName) ? LastName
                                                                   : string.Format("{0} {1}", FirstName, LastName)
                        : string.Format("{0} {1} {2}", FirstName, LastName, Suffix);
        }
    }
}
