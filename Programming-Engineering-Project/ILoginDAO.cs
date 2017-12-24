using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Programming_Engineering_Project
{
	public interface ILoginDAO
	{
		Boolean isUser(String username, String password, SQLiteConnection connection);
	}
}
