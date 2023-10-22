namespace Hosting_System_of_a_Hotel_at_C_Sharp.Model
{
    public class Person
    {
        public Person() {}

        public Person(string  name)
        {
            Name = name;
        }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fullname => $"{Name} {Surname}".ToUpper();
    }
}