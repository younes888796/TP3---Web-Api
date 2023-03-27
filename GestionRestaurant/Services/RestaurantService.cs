using GestionRestaurant.Models;
using GestionRestaurant.Repository;

namespace GestionRestaurant.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRestaurantRepository _restaurantRepository;

        public RestaurantService(IRestaurantRepository restaurantRepository)
        {
            this._restaurantRepository = restaurantRepository;
        }

        public void AddRestaurant(Restaurant restaurant)
        {
            _restaurantRepository.AddRestaurant(restaurant);
        }

        public void DeleteRestaurant(int id)
        {
            _restaurantRepository.DeleteRestaurant(id);
        }

       
        public Restaurant GetRestaurant(int id)
        {
            return _restaurantRepository.GetRestaurant(id);
        }

      

        public IEnumerable<Restaurant> GetRestaurants()
        {
            return _restaurantRepository.GetRestaurants();
        }

        public void UpdateRestaurant(Restaurant restaurant)
        {
             _restaurantRepository.UpdateRestaurant(restaurant);
        }


    }
}
