using Mud_Blazor.Data;

namespace Mud_Blazor.Interface
{
	public interface ICustomer
	{
		HashSet<Customer> GetCustomers();
		Customer GetById(int CustomerID);
		void Save(Customer customer);
		string Delete(int CustomerID);
	}
}
