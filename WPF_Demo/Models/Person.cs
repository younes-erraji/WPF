using System;

namespace WPF_Demo.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string Identity { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }

        public Person() { }
        public Person(int ID, string Identity, string FirstName, string LastName, int? Age)
        {
            this.ID = ID;
            this.Identity = Identity;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
        }
    }
}
