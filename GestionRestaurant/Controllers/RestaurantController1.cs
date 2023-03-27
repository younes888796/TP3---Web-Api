using GestionRestaurant.Models;
using GestionRestaurant.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionRestaurant.Controllers
{
    public class RestaurantController1 : Controller
    {
        private readonly IRestaurantService _restaurantService;

        public RestaurantController1(IRestaurantService restaurantService)
        {
            this._restaurantService = restaurantService;
        }

        // GET: RestaurantController1
        public ActionResult Index()
        {
            var model = _restaurantService.GetRestaurants();
            return View(model);
        }

        // GET: RestaurantController1/Details/5
        public ActionResult Details(int id)
        {
            var model = _restaurantService.GetRestaurant(id);
            
            //return PartialView("listCuisine", model);

            return View(model);
        }

        // GET: RestaurantController1/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: RestaurantController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Restaurant collection)
        {
            try
            {
                _restaurantService.AddRestaurant(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RestaurantController1/Edit/5
        public ActionResult Edit(int id)
        {
            var restaurant = _restaurantService.GetRestaurant(id);
            return View(restaurant);
        }

        // POST: RestaurantController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, Restaurant collection)
        {
            try
            {
                _restaurantService.UpdateRestaurant(collection);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RestaurantController1/Delete/5
        public ActionResult Delete(int id)
        {
            _restaurantService.DeleteRestaurant(id);
            return RedirectToAction(nameof(Index));
            //return View();
        }

    }
}
