﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Pet_App.Model;
using Pet_App.View;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Pet_App.ViewModel
{

    class AdoptViewModel : ViewModelBase
    {
        public INavigation Navigation { get; set; }

        public ObservableCollection<Animal> AnimalView { get; set; }

        private string _animalType;

        public AdoptViewModel(string animalType)
        {

            SetAnimalType(animalType);

            AnimalView = new ObservableCollection<Animal>();

            ObservableCollection<Animal> Animals = new ObservableCollection<Animal>()
            {
                new Animal(){ Name = "Misha", Age = 12, Location = new Location() {City = "Barcelona"}, Type = "Cat", Image = "https://www.radiorojacanarfm.com/wp-content/uploads/2018/01/99735192_gettyimages-459467912.jpg"},

                new Animal(){ Name = "Mew", Age = 9,Location = new Location() {City = "Barcelona"}, Type = "Cat", Image = "http://cdn7.viralscape.com/wp-content/uploads/2015/04/Flying-Cat-19.jpg"},

                new Animal(){ Name = "Kira", Age = 6, Location = new Location(){City = "Manersa"}, Race = "Pastor Aleman", Type = "Dog", Image="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ9zt7es9UnNPbPSakvoDh7zZ8IiQZa8KDTlUd81gIR7b7ppdVc" },

                new Animal(){ Name = "Juancho", Age = 100, Location = new Location(){City = "Jandemor"}, Race = "Lagarto", Type = "Reptile", Image="http://www.dibujos.tv/images/dibuteca/img/77." }
            };

            for (int i = 0; i < Animals.Count; i++)
            {
                if(Animals[i].Type == _animalType)
                AnimalView.Add(Animals[i]);
            }

        }

        public Animal SelectedItem
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                _selectedItem = value;

                if (_selectedItem == null)
                    return;

                OnSelected();

                SelectedItem = null;
            }
        }

        private Animal _selectedItem;

        private async void OnSelected()
        {
            try
            {
                await Navigation.PushAsync(new LoginView());
            }
            catch (Exception e)
            {


            }
        }


        private void SetAnimalType(string animal)
        {
            if (animal == "Gatos")
            {
                _animalType = "Cat";
            }
            else if (animal == "Perros")
            {
                _animalType = "Dog";
            }
            else if (animal == "Reptiles")
            {
                _animalType = "Reptile";
            }
            else if (animal == "Pajaros")
            {
                _animalType = "Bird";
            }
            else
            {
                _animalType = "Rodent";
            }
        }


    }
}