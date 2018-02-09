using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_App.Model
{
    public class Person
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private DateTime yearBirth;

        public DateTime YearBirth
        {
            get { return yearBirth; }
            set { yearBirth = value; }
        }

        private Location location;

        public Location Location
        {
            get { return location; }
            set { location = value; }
        }

        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }


        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


    }
}
