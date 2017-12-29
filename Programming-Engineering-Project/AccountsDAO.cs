using System.Collections.Generic;
using System.Data.SQLite;

namespace Programming_Engineering_Project
{
	class AccountsDAO : IAccountsDAO
	{
		public List<Account> getAllAccounts(SQLiteConnection connection)
		{
			List<Account> accounts = new List<Account>();
			SQLiteCommand command = new SQLiteCommand(null, connection);
			command.CommandText = "SELECT ACCOUNT_NUMBER, ACCOUNT_TYPE, CURRENCY, AMOUNT, OPEN_DATE FROM CUST_ACCOUNT";

			using (SQLiteDataReader dataReader = command.ExecuteReader())
			{
				while (dataReader.Read())
				{
					Account account = new Account();
					account.AccountNo = dataReader.GetInt32(0);
					account.AccountType = Utils.getStringAccTypeFromInt(dataReader.GetInt32(1));
					account.Currency = Utils.getStringCurrencyFromString(dataReader.GetString(2));
					account.Ammount = dataReader.GetFloat(3);
					account.OpenDate = dataReader.GetString(4);
					accounts.Add(account);
				}
			}

			return accounts;
		}
	}
}
