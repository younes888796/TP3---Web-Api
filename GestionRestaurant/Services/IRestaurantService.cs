using GestionRestaurant.Models;

namespace GestionRestaurant.Services
{
    public interface IRestaurantService
    {
        IEnumerable<Restaurant> GetRestaurants();
        Restaurant GetRestaurant(int id);
        void AddRestaurant(Restaurant restaurant);
        void UpdateRestaurant(Restaurant restaurant);
        void DeleteRestaurant(int id);


    }
}
