using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using System.Runtime.CompilerServices;

namespace Programming_Engineering_Project
{
	class DatabaseConnection
	{
		private static SQLiteConnection connection = null;

		[MethodImpl(MethodImplOptions.Synchronized)]
		public static SQLiteConnection getConnection()
		{
			if (connection == null)
			{
				connection = new SQLiteConnection("data source=C:\\DevTools\\SQLite\\ip-db.db");
			}

			return connection;
		}
	}
}
