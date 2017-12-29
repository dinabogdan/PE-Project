using System.Collections.Generic;
using System.Data.SQLite;

namespace Programming_Engineering_Project
{
	interface IAccountsDAO
	{
		List<Account> getAllAccounts(SQLiteConnection connection);
	}
}
