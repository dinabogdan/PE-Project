using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Programming_Engineering_Project
{
	interface ICustomersDAO
	{
		void addCustomer(Customer customer, SQLiteConnection connection);
		List<Customer> getAllCustomers(SQLiteConnection connection);
	}
}
