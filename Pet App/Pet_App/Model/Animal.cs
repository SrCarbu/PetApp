using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_App.Model
{
    public class Animal
    {

        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private Location _location;

        public Location Location
        {
            get { return _location; }
            set { _location = value; }
        }

        private string _race;

        public string Race
        {
            get { return _race; }
            set { _race = value; }
        }


    }
}
