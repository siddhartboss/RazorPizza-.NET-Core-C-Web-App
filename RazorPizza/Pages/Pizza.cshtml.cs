using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Models;

namespace RazorPizza.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> PizzaDB = new List<PizzasModel>()
        {
            new PizzasModel()
            {
                ImageTitle = "Margerita",
                PizzaName = "Magerita",
                BasePrice = 2,
                TomatoSouce= true,
                Chees = true,
                FinalPrice= 4},

            new PizzasModel()
            {
                ImageTitle = "Carbonara",
                PizzaName = "Carbonara",
                BasePrice = 2,
                TomatoSouce= true,
                Pineapple= true,
                Chees = true,
                FinalPrice= 10},

            new PizzasModel()
            {
                ImageTitle = "Mushroom",
                PizzaName = "Mushroom",
                BasePrice = 2,
                Mushroom=true,
                TomatoSouce= true,
                Chees = true,
                FinalPrice= 15},

            new PizzasModel()
            {
                ImageTitle = "Pepperoni",
                PizzaName = "Pepperoni",
                BasePrice = 2,
                Peperoni=true,
                TomatoSouce= true,
                Chees = true,
                FinalPrice= 10},

            new PizzasModel()
            {
                ImageTitle = "MeatFeast",
                PizzaName = "MeatFeast",
                BasePrice = 2,
                Beef=true,
                TomatoSouce= true,
                Chees = true,
                FinalPrice= 5},

            new PizzasModel()
            {
                ImageTitle = "Bolognese",
                PizzaName = "Bolognese",
                Ham = true,
                BasePrice = 2,
                TomatoSouce= true,
                Chees = true,
                FinalPrice= 10}

        };
        public void OnGet()
        {
        }
    }
}
