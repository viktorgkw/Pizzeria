using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzeria.Data;
using Pizzeria.Models;

namespace Pizzeria.Pages
{
    public class OrdersModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;
        public OrdersModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<PizzaOrder> pizzaOrders = new List<PizzaOrder>();

        public void OnGet()
        {
            pizzaOrders = _dbContext.Orders.ToList();
        }
    }
}
