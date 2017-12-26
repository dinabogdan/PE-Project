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
		private String username;

		public String Username
		{
			get
			{
				return this.username;
			}

			set
			{
				this.username = value;
			}
		}

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			this.LblWelcome.Text = this.LblWelcome.Text + this.username + " ! ";
		}

		private void btnAllCustomers_Click(object sender, EventArgs e)
		{
			SQLiteConnection connection = DatabaseConnection.getConnection();
			connection.Open();
			Console.WriteLine("### Connection is: " + connection.State.ToString());
			connection.Close();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			AddCustomer addCustomerForm = new AddCustomer();
			this.Hide();
			addCustomerForm.Show();
		}
	}
}
