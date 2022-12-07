using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzeria.Models;

namespace Pizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> pizzaDb = new List<PizzasModel>()
        {
            new PizzasModel(){
                ImageTitle = "Margerita",
                Name = "Margerita",
                BasePrice = 8,
                TomatoSauce = true,
                Cheese = true
            },
            new PizzasModel(){
                ImageTitle = "Vegetarian",
                Name = "Vegetarian",
                BasePrice = 6,
                Mushroom = true
            },
            new PizzasModel(){
                ImageTitle = "MeatFeast",
                Name = "MeatFeast",
                BasePrice = 12,
                Cheese = true,
                Ham = true
            },
        };
        public void OnGet()
        {
        }
    }
}
