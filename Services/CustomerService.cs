using Mud_Blazor.Context;
using Mud_Blazor.Data;
using Mud_Blazor.Interface;

namespace Mud_Blazor.Services
{
	public class CustomerService : ICustomer
	{
		private readonly DatabaseContext _context;

		public CustomerService(DatabaseContext context)
		{
			_context = context;
		}

		public void Delete(int CustomerID)
		{
			var customer = _context.Customers.FirstOrDefault(x=>x.CustomerID==CustomerID);

			if (customer!=null)
			{
				_context.Customers.Remove(customer);
                _context.SaveChanges();
            }
			
		}

		public Customer GetById(int CustomerID)
		{
			return _context.Customers.SingleOrDefault(x=>x.CustomerID==CustomerID);
		}

		public HashSet<Customer> GetCustomers()
		{
			return _context.Customers.ToHashSet();
		}

		public void Save(Customer customer)
		{
			if (customer.CustomerID == 0) _context.Customers.Add(customer);
			else _context.Customers.Update(customer);
			_context.SaveChanges();

		}
	}
}
