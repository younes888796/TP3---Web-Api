using GestionRestaurant.Models;

namespace GestionRestaurant.Repository
{
    public interface IRestaurantRepository
    {
        IEnumerable<Restaurant> GetRestaurants();
        Restaurant GetRestaurant(int id);
        void AddRestaurant(Restaurant restaurant);
        void UpdateRestaurant(Restaurant restaurant);
        void DeleteRestaurant(int id);
    }
}
