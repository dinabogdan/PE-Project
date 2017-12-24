using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Engineering_Project
{
	class CustomersDAO : ICustomersDAO
	{
		public List<Customer> getAllCustomers(SQLiteConnection connection)
		{
			List<Customer> customers = new List<Customer>();
			SQLiteCommand command = new SQLiteCommand(null, connection);
			command.CommandText = "SELECT * FROM USERS u";

			return customers;
		}
	}
}
