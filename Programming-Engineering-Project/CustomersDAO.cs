using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Engineering_Project
{
	class CustomersDAO : ICustomersDAO
	{
		public void addCustomer(Customer customer, SQLiteConnection connection)
		{
			SQLiteCommand command = new SQLiteCommand(null, connection);
			command.CommandText = "INSERT INTO Customers (FIRST_NAME, LAST_NAME, CNP, BIRTHDATE) " +
										"VALUES (@firstName, @lastName, @cnp, @birthDate)";

			SQLiteParameter firstNameParam = new SQLiteParameter("@firstName", DbType.String);
			SQLiteParameter lastNameParam = new SQLiteParameter("@lastName", DbType.String);
			SQLiteParameter cnpParam = new SQLiteParameter("@cnp", DbType.String);
			SQLiteParameter birthDateParam = new SQLiteParameter("@birthDate", DbType.String);

			firstNameParam.Value = customer.FirstName;
			lastNameParam.Value = customer.LastName;
			cnpParam.Value = customer.Cnp;
			birthDateParam.Value = customer.BirthDate;

			command.Parameters.Add(firstNameParam);
			command.Parameters.Add(lastNameParam);
			command.Parameters.Add(cnpParam);
			command.Parameters.Add(birthDateParam);

			command.Prepare();
			command.ExecuteNonQuery();
		}

		public void addCustomerAccounts(Customer customer, SQLiteConnection connection)
		{
			SQLiteCommand command = new SQLiteCommand(null, connection);
			command.CommandText = "INSERT INTO Cust_Account (CUSTOMER_ID, ACCOUNT_NUMBER, ACCOUNT_TYPE, CURRENCY, AMOUNT, OPEN_DATE) " +
								"VALUES ((SELECT MAX(CUSTOMER_ID) FROM CUSTOMERS), @accountNo, @accountType, @currency, @amount, DATE('now'))";
			foreach (Account account in customer.CustomerAccounts)
			{
				SQLiteParameter accountNoParam = new SQLiteParameter("@accountNo", DbType.Int32);
				SQLiteParameter accountTypeParam = new SQLiteParameter("@accountType", DbType.Int16);
				SQLiteParameter currencyParam = new SQLiteParameter("@currency", DbType.String);
				SQLiteParameter amountParam = new SQLiteParameter("@amount", DbType.Decimal);

				accountNoParam.Value = account.AccountNo;
				accountTypeParam.Value = account.AccountType;
				currencyParam.Value = account.Currency;
				amountParam.Value = account.Ammount;

				command.Parameters.Add(accountNoParam);
				command.Parameters.Add(accountTypeParam);
				command.Parameters.Add(currencyParam);
				command.Parameters.Add(amountParam);

				command.Prepare();
				command.ExecuteNonQuery();
			}

		}

		public void addCustomerDetails(Customer customer, SQLiteConnection connection)
		{
			SQLiteCommand command = new SQLiteCommand(null, connection);
			command.CommandText = "INSERT INTO Cust_Details (CUSTOMER_ID, PHONE, EMAIL, COUNTRY, COUNTY, CITY, LOCALITY, STREET, STREET_NO) " +
									"VALUES ((SELECT MAX(CUSTOMER_ID) FROM CUSTOMERS), @phone, @email, @country, @county, @city, @locality, @street, @streetNo)";

			SQLiteParameter phoneParam = new SQLiteParameter("@phone", DbType.String);
			SQLiteParameter emailParam = new SQLiteParameter("@email", DbType.String);
			SQLiteParameter countryParam = new SQLiteParameter("@country", DbType.String);
			SQLiteParameter countyParam = new SQLiteParameter("@county", DbType.String);
			SQLiteParameter cityParam = new SQLiteParameter("@city", DbType.String);
			SQLiteParameter localityParam = new SQLiteParameter("@locality", DbType.String);
			SQLiteParameter streetParam = new SQLiteParameter("@street", DbType.String);
			SQLiteParameter streetNoParam = new SQLiteParameter("@streetNo", DbType.Int16);

			phoneParam.Value = customer.Phone;
			emailParam.Value = customer.Email;
			countryParam.Value = customer.Country;
			countyParam.Value = customer.County;
			cityParam.Value = customer.City;
			localityParam.Value = customer.Locality;
			streetParam.Value = customer.Street;
			streetNoParam.Value = customer.StreetNo;

			command.Parameters.Add(phoneParam);
			command.Parameters.Add(emailParam);
			command.Parameters.Add(countryParam);
			command.Parameters.Add(countyParam);
			command.Parameters.Add(cityParam);
			command.Parameters.Add(localityParam);
			command.Parameters.Add(streetParam);
			command.Parameters.Add(streetNoParam);

			command.Prepare();
			command.ExecuteNonQuery();
		}

		public List<Customer> getAllCustomers(SQLiteConnection connection)
		{
			List<Customer> customers = new List<Customer>();
			SQLiteCommand command = new SQLiteCommand(null, connection);
			command.CommandText = "SELECT * FROM USERS u";

			return customers;
		}
	}
}
