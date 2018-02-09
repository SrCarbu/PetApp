using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_App.Model
{
    public class Location
    {
        private string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        private string cp;

        public string CP
        {
            get { return cp; }
            set { cp = value; }
        }

        private string street;

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        private string streetNumber;

        public string StreetNumber
        {
            get { return streetNumber; }
            set { streetNumber = value; }
        }

        private string floorNumber;

        public string FloorNumber
        {
            get { return floorNumber; }
            set { floorNumber = value; }
        }

        private int doorNumber;

        public int DoorNumber
        {
            get { return doorNumber; }
            set { doorNumber = value; }
        }


    }
}
