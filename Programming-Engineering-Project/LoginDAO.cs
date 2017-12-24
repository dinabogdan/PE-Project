using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Engineering_Project
{
	class LoginDAO : ILoginDAO
	{
		public bool isUser(string username, string password, SQLiteConnection connection)
		{
			SQLiteCommand command = new SQLiteCommand(null, connection);

			command.CommandText = "SELECT * FROM Users WHERE username = @username AND password = @password";
			SQLiteParameter usernameParam = new SQLiteParameter("@username", DbType.String);
			SQLiteParameter passwordParam = new SQLiteParameter("@password", DbType.String);
			usernameParam.Value = username;
			passwordParam.Value = password;
			command.Parameters.Add(usernameParam);
			command.Parameters.Add(passwordParam);
			command.Prepare();
			object result = command.ExecuteScalar();
			return Convert.ToInt16(result) > 0;
		}
	}
}
