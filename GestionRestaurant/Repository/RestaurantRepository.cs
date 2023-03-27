using GestionRestaurant.Models;
using System;
using System.Collections.Generic;


namespace GestionRestaurant.Repository
{
    public class RestaurantRepository : IRestaurantRepository
    {
        public List<Restaurant>  Restaurants { get; set; }
        public RestaurantRepository() {
            Restaurants = new List<Restaurant>()
            {
                new Restaurant{Id=0, Name="R1",Address="Hay Ryad1",Cuisines = new string[] { "Italian1", "Mexican1", "Chinese1" } },
                new Restaurant{Id=2,Name="R2" ,Address="Hay Ryad2",Cuisines = new string[] { "Italian2", "Mexican2", "Chinese2" }},
                new Restaurant{Id=3, Name="R3",Address="Hay Ryad3",Cuisines = new string[] { "Italian3", "Mexican3", "Chinese3" }},
            };
        }
        public void AddRestaurant(Restaurant restaurant)
        {
            this.Restaurants.Add(restaurant);
        }


        public void DeleteRestaurant(int id)
        {
            this.Restaurants.RemoveAll(r => r.Id == id);
        }

        public Restaurant GetRestaurant(int id)
        {
            return Restaurants[0];
            //return Restaurants.First(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetRestaurants()
        {
            return Restaurants;
        }

       
        public void UpdateRestaurant(Restaurant restaurant)
        {
            var existingRestaurant = Restaurants.FirstOrDefault(r => r.Id == restaurant.Id);
            if (existingRestaurant != null)
            {
                existingRestaurant.Name = restaurant.Name;
                existingRestaurant.Id = restaurant.Id;
                existingRestaurant.Address = restaurant.Address;
            }
        }



    }



}


