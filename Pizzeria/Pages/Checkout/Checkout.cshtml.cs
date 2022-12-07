using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzeria.Data;
using Pizzeria.Models;

namespace Pizzeria.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;
        public CheckoutModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string PizzaName { get; set; }
        public double PizzaPrice { get; set; }
        public string ImageTitle { get; set; }

        public void OnGet()
        {
            PizzaOrder order = new PizzaOrder()
            {
                PizzaName = PizzaName,
                BasePrice = PizzaPrice
            };

            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();   
        }
    }
}
