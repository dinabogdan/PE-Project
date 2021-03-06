﻿using System;
using System.Windows.Forms;

using System.Data.SQLite;

namespace Programming_Engineering_Project
{
	public partial class LoginForm : Form
	{
		public LoginForm()
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
					this.Hide();
					MainForm mainForm = new MainForm();
					mainForm.Username = this.TextBoxUsername.Text;
					mainForm.Show();
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
