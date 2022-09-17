using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pojistovna.Model
{
    public class User : object
    {
        public User(string firstName, string lastName, int age, string phoneNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.PhoneNumber = phoneNumber;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int Age { get; private set; }

        public string PhoneNumber { get; private set; }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Age.ToString() + " " + PhoneNumber;
        }
    }
}
