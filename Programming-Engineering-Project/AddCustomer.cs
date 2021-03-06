﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Programming_Engineering_Project
{
	public partial class AddCustomer : Form
	{
		public AddCustomer()
		{
			InitializeComponent();
		}

		private void btnNewCustomer_Click(object sender, EventArgs e)
		{
			Customer customer = new Customer();
			customer.LastName = this.TxtBoxLastName.Text;
			customer.FirstName = this.TxtBoxFirstName.Text;
			customer.Cnp = this.TxtBoxCnp.Text;
			customer.BirthDate = this.DpBirthdate.Text;

			Dictionary<String, String> errors = Validations.validateCustInfo(customer);

			if (errors.Count != 0)
			{
				String errorMessage = null;
				errors.TryGetValue(errors.Keys.First<string>(), out errorMessage);
				this.LblCustInfoError.Text = errorMessage;
				this.LblCustInfoError.Visible = true;
				return;
			}

			customer.Phone = this.TxtBoxPhone.Text;
			customer.Email = this.TxtBoxEmail.Text;
			customer.Country = this.TxtBoxCountry.Text;
			customer.County = this.TxtBoxCounty.Text;
			customer.City = this.TxtBoxCity.Text;
			customer.Locality = this.TxtBoxLocality.Text;
			customer.Street = this.TxtBoxStreet.Text;
			customer.StreetNo = Int32.Parse(this.NudStreetNo.Value.ToString());

			errors = Validations.validateCustDetails(customer);

			if (errors.Count != 0)
			{
				String errorMessage = null;
				errors.TryGetValue(errors.Keys.First<string>(), out errorMessage);
				this.LblCustDetailsError.Text = errorMessage;
				this.LblCustDetailsError.Visible = true;
				return;
			}

			Account account = new Account();
			int accountNo = 0; Int32.TryParse(this.TxtBoxAccountNo.Text, out accountNo); account.AccountNo = accountNo;
			account.AccountType = this.CbAccountType.SelectedValue.ToString();
			account.Currency = this.CbCurrency.SelectedValue.ToString();
			float amount = 0f; float.TryParse(TxtBoxAmount.Text.ToString(), out amount); account.Ammount = amount;

			errors = Validations.validateCustAccount(account);
			if (errors.Count != 0)
			{
				String errorMessage = null;
				errors.TryGetValue(errors.Keys.First<string>(), out errorMessage);
				this.LblAccountInfoError.Text = errorMessage;
				this.LblAccountInfoError.Visible = true;
				return;
			}


			if (errors.Count == 0)
			{
				SQLiteConnection connection = DatabaseConnection.getConnection();
				connection.Open();
				SQLiteTransaction transaction = connection.BeginTransaction();
				ICustomersDAO customersDao = new CustomersDAO();
				List<Account> custAccounts = new List<Account>();
				custAccounts.Add(account);
				customer.CustomerAccounts = custAccounts;

				try
				{
					customersDao.addCustomer(customer, connection);
					customersDao.addCustomerDetails(customer, connection);
					customersDao.addCustomerAccounts(customer, connection);
					transaction.Commit();

					this.LblConfirmationMessage.Visible = true;
					this.LblConfirmationMessage.Text = "Success!";
					this.LblConfirmationMessage.ForeColor = System.Drawing.Color.Green;
				}
				catch (SQLiteException)
				{
					transaction.Rollback();

					this.LblConfirmationMessage.Visible = true;
					this.LblConfirmationMessage.Text = "Error";
					this.LblConfirmationMessage.ForeColor = System.Drawing.Color.Red;
				}
				connection.Close();
			}

		}

		private void AddCustomer_Load(object sender, EventArgs e)
		{
			var accountTypeDataSource = new Dictionary<int, String>();
			accountTypeDataSource.Add(1, "Checking account");
			accountTypeDataSource.Add(2, "Savings account");
			accountTypeDataSource.Add(3, "Certificate of Deposit");
			accountTypeDataSource.Add(4, "Money market account");
			accountTypeDataSource.Add(5, "Individual Retirement Accounts");
			this.cbAccountType.DataSource = new BindingSource(accountTypeDataSource, null);
			this.cbAccountType.DisplayMember = "Value";
			this.cbAccountType.ValueMember = "Key";

			var currencyDataSource = new Dictionary<int, String>();
			currencyDataSource.Add(1, "RON");
			currencyDataSource.Add(2, "EUR");
			currencyDataSource.Add(3, "USD");
			currencyDataSource.Add(4, "GPB");
			this.cbCurrency.DataSource = new BindingSource(currencyDataSource, null);
			this.cbCurrency.DisplayMember = "Value";
			this.cbCurrency.ValueMember = "Key";
		}
	}
}
