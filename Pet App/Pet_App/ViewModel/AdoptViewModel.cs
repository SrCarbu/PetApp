using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pet_App.Model;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Pet_App.ViewModel
{
    class AdoptViewModel : ViewModelBase
    {
        public INavigation Navigation { get; set; }

        public List<Animal> AnimalList;

        public AdoptViewModel(string animalType)
        {

            string type = "";

            if (animalType == "Gatos")
            {
                type = "Cat";
            }

            List<Animal> Animals = new List<Animal>()
            {
                new Animal()
                {
                    Name = "Polla",
                    Age = 12,
                    Location = new Location()
                    {
                        City = "Barcelona"
                    },
                    Type = "Cat"
                },

                new Animal()
                {
                    Name = "Mew",
                    Age = 9,
                    Location = new Location()
                    {
                        City = "Barcelona"
                    },
                    Type = "Cat"
                },

                new Animal()
                {
                    Name = "Gorda",
                    Age = 6,
                    Location = new Location()
                    {
                        City = "Manersa"
                    },
                    Race = "Pastor Aleman",
                    Type = "Dog"
                },

                new Animal()
                {
                    Name = "Juancho",
                    Age = 100,
                    Location = new Location()
                    {
                        City = "Jandemor"
                    },
                    Race = "Lagarto",
                    Type = "Reptile"
                }
            };

            AnimalList = Animals.Where(s => s.Type == type).ToList();

        }


    }
}