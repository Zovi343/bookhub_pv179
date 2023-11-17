using DataAccessLayer.Data;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
	[ApiController]
	[Route("api/Customers")]
	public class CustomerController : ControllerBase
	{
		private readonly BookHubDBContext _dbContext;

		public CustomerController(BookHubDBContext dbContext)
		{
			_dbContext = dbContext;
		}

        private async Task<List<CustomerModel>> GetCustomersCommonQuery(IQueryable<Customer> query)
        {
            return await query
                .Include(c => c.Reviews)
                .Include(c => c.Wishlists)
                .Include(c => c.PurchaseHistories)
                .Select(c => new CustomerModel
                {
                    Id = c.Id,
                    Username = c.Username,
                    Reviews = c.Reviews.Select(w => new ReviewModel
                    {
                        Id = w.Id,
                        CustomerUsername = w.Customer.Username,
                        BookTitle = w.Book.Title,
                        Rating = w.Rating,
                        Comment = w.Comment

                    }).ToList(),
                    PurchaseHistories = c.PurchaseHistories.Select(w => new PurchaseHistoryModel
                    {
                        Id = w.Id,
                        BookTitle = w.Book.Title,
                        CustomerUsername = w.Customer.Username,
                        PurchaseDate = w.PurchaseDate

                    }).ToList(),
                    Wishlists = c.Wishlists.Select(w => new WishListModel
                    {
                        Id = w.Id,
                        CustomerName = w.Customer.Username
                    }).ToList()
                })
                .ToListAsync();
        }

		[HttpGet]
		public async Task<IActionResult> GetCustomerList()
		{
			var customers = await GetCustomersCommonQuery(_dbContext.Customers);

			if (customers == null || !customers.Any())
			{
				return BadRequest("No customers were found.");
			}

			return Ok(customers);
		}

		[HttpGet]
		[Route("{id}")]
		public async Task<IActionResult> GetCustomer(int id)
		{
			var customer = await GetCustomersCommonQuery(_dbContext.Customers.Where(c => c.Id == id));

			if (customer == null || !customer.Any())
			{
				return BadRequest($"No customer with ID {id} was found.");
			}

			return Ok(customer);
		}

		[HttpPost]
		public async Task<IActionResult> CreateCustomer(CustomerModel model)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			var customer = new Customer
			{
				Username = model.Username,
				Password = model.Password
			};

			_dbContext.Customers.Add(customer);
			await _dbContext.SaveChangesAsync();

			return Ok(customer);
		}

		[HttpPut]
		[Route("{id}")]
		public async Task<IActionResult> UpdateCustomer(int id, CustomerModel model)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			var customer = await _dbContext.Customers.FindAsync(id);

			if (customer == null)
			{
				return BadRequest($"No customer with ID {id} was found.");
			}

			customer.Username = model.Username;

			customer.Password = model.Password;

			_dbContext.Customers.Update(customer);
			await _dbContext.SaveChangesAsync();

			return Ok(customer);
		}

		[HttpDelete]
		[Route("{id}")]
		public async Task<IActionResult> DeleteCustomer(int id)
		{
			var customer = await _dbContext.Customers.FindAsync(id);

			if (customer == null)
			{
				return BadRequest($"No customer with ID {id} was found.");
			}

			_dbContext.Customers.Remove(customer);
			await _dbContext.SaveChangesAsync();

			return Ok();
		}
	}
}
