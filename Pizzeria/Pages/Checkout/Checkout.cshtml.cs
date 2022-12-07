using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pizzeria.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        public string PizzaName { get; set; }
        public double PizzaPrice { get; set; }
        public string ImageTitle { get; set; }

        public void OnGet()
        {
        }
    }
}
