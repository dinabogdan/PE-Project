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
			if (lvMain.Columns[0].Text.Equals("First Name"))
			{
				List<Customer> customers = new List<Customer>();
				for (int i = 0; i < lvMain.Items.Count; i++)
				{
					Customer customer = new Customer();
					customer.FirstName = lvMain.Items[i].Text;
					customer.LastName = lvMain.Items[i].SubItems[1].Text;
					customer.Cnp = lvMain.Items[i].SubItems[2].Text;
					customer.BirthDate = lvMain.Items[i].SubItems[3].Text;
					customer.Phone = lvMain.Items[i].SubItems[4].Text;
					customer.Email = lvMain.Items[i].SubItems[5].Text;
					customer.Country = lvMain.Items[i].SubItems[6].Text;
					customer.County = lvMain.Items[i].SubItems[7].Text;
					customer.City = lvMain.Items[i].SubItems[8].Text;
					customer.Locality = lvMain.Items[i].SubItems[9].Text;
					customer.Street = lvMain.Items[i].SubItems[10].Text;
					customer.StreetNo = System.Int32.Parse(lvMain.Items[i].SubItems[11].Text);
					customers.Add(customer);
				}
				ExportListViewToXLS.exportCustomers(customers);
			}
			else if (lvMain.Columns[0].Text.Equals("Account No."))
			{
				List<Account> accounts = new List<Account>();
				for (int i = 0; i < lvMain.Items.Count; i++)
				{
					Account account = new Account();
					account.AccountNo = System.Int32.Parse(lvMain.Items[i].Text);
					account.AccountType = lvMain.Items[i].SubItems[1].Text;
					account.Currency = lvMain.Items[i].SubItems[2].Text;
					account.Ammount = float.Parse(lvMain.Items[i].SubItems[3].Text);
					account.OpenDate = lvMain.Items[i].SubItems[4].Text;
					accounts.Add(account);
				}
				ExportListViewToXLS.exportAccounts(accounts);
			}
		}
	}
}
