using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzeria.Models;

namespace Pizzeria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            Pizza.FinalPrice = Pizza.BasePrice;

            if (Pizza.TomatoSauce) Pizza.FinalPrice += 1;
            if (Pizza.Cheese) Pizza.FinalPrice += 1;
            if (Pizza.Peperoni) Pizza.FinalPrice += 1;
            if (Pizza.Mushroom) Pizza.FinalPrice += 1;
            if (Pizza.Tuna) Pizza.FinalPrice += 1;
            if (Pizza.Pineapple) Pizza.FinalPrice += 10;
            if (Pizza.Ham) Pizza.FinalPrice += 1;
            if (Pizza.Beef) Pizza.FinalPrice += 1;

            if (string.IsNullOrWhiteSpace(Pizza.Name))
            {
                Pizza.Name = "Custom";
            }
            if (string.IsNullOrWhiteSpace(Pizza.ImageTitle))
            {
                Pizza.ImageTitle = "Create";
            }

            return RedirectToPage("/Checkout/Checkout", new
            {
                PizzaName = Pizza.Name,
                PizzaPrice = Pizza.FinalPrice,
                ImageTitle = Pizza.ImageTitle
            });
        }
    }
}
