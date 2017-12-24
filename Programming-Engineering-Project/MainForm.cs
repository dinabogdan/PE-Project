using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;

namespace Programming_Engineering_Project
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (this.TextBoxUsername.Text.Length > 0 && this.TextBoxPassword.Text.Length > 0)
			{
				SQLiteConnection connection = DatabaseConnection.getConnection();
				connection.Open();
				Console.WriteLine("### Connection is: " + connection.State.ToString());
				ILoginDAO loginDao = new LoginDAO();
				Boolean isUser = loginDao.isUser(this.TextBoxUsername.Text, this.TextBoxPassword.Text, connection);
				connection.Close();

				if (isUser)
				{
					Console.WriteLine("### IsUser: " + isUser);
				}
				else
				{
					this.LabelError.Visible = true;
				}
			}
			else
			{
				this.LabelError.Visible = true;
			}
		}
	}
}
