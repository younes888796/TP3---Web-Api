namespace GestionRestaurant.Models
{
    public class Restaurant
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }


        // add listCuisine
        public string[] Cuisines { get; set; }



    }
}
