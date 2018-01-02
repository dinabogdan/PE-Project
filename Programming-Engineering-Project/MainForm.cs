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
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;

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
			lvMain.View = View.Details;
			Utils.initCustListViewHeaders(lvMain);
			ICustomersDAO customersDao = new CustomersDAO();
			List<Customer> customers = customersDao.getAllCustomers(connection);
			Utils.addCustomersToListView(lvMain, customers);     
			connection.Close();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			AddCustomer addCustomerForm = new AddCustomer();
			this.Hide();
			addCustomerForm.Show();
		}

		private void btnAllAccounts_Click(object sender, EventArgs e)
		{
			SQLiteConnection connection = DatabaseConnection.getConnection();
			connection.Open();
			lvMain.View = View.Details;
			Utils.initAcctListViewHeaders(lvMain);
			IAccountsDAO accountsDao = new AccountsDAO();
			List<Account> accounts = accountsDao.getAllAccounts(connection);
			Utils.addAccountsToListView(lvMain, accounts);
			connection.Close();
		}

		private void btnExportXls_Click(object sender, EventArgs e)
		{

		}
	}
}
