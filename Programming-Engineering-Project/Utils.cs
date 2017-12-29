using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace Programming_Engineering_Project
{
	class Utils
	{
		internal static void initCustListViewHeaders(ListView listView)
		{
			listView.Columns.Clear();
			listView.Columns.Add("First Name", 70, HorizontalAlignment.Center);
			listView.Columns.Add("Last Name", 70, HorizontalAlignment.Center);
			listView.Columns.Add("CNP", 70, HorizontalAlignment.Center);
			listView.Columns.Add("Birthdate", 70, HorizontalAlignment.Center);
			listView.Columns.Add("Phone", 50, HorizontalAlignment.Center);
			listView.Columns.Add("Email", 50, HorizontalAlignment.Center);
			listView.Columns.Add("Country", 50, HorizontalAlignment.Center);
			listView.Columns.Add("County", 50, HorizontalAlignment.Center);
			listView.Columns.Add("City", 50, HorizontalAlignment.Center);
			listView.Columns.Add("Locality", 50, HorizontalAlignment.Center);
			listView.Columns.Add("Street", 50, HorizontalAlignment.Center);
			listView.Columns.Add("Street No.", 30, HorizontalAlignment.Center);
		}

		internal static void addCustomersToListView(ListView lvMain, List<Customer> customers)
		{
			lvMain.Items.Clear();
			foreach (Customer customer in customers)
			{
				ListViewItem lvItem = new ListViewItem(customer.FirstName.ToUpper());
				lvItem.SubItems.Add(customer.LastName.ToUpper());
				lvItem.SubItems.Add(customer.Cnp.ToUpper());
				lvItem.SubItems.Add(customer.BirthDate.ToUpper());
				lvItem.SubItems.Add(customer.Phone.ToUpper());
				lvItem.SubItems.Add(customer.Email.ToUpper());
				lvItem.SubItems.Add(customer.Country.ToUpper());
				lvItem.SubItems.Add(customer.County.ToUpper());
				lvItem.SubItems.Add(customer.City.ToUpper());
				lvItem.SubItems.Add(customer.Locality.ToUpper());
				lvItem.SubItems.Add(customer.Street.ToUpper());
				lvItem.SubItems.Add(customer.StreetNo.ToString());
				lvMain.Items.Add(lvItem);
			}

		}

		internal static void addAccountsToListView(ListView lvMain, List<Account> accounts)
		{
			lvMain.Items.Clear();
			foreach (Account account in accounts)
			{
				ListViewItem lvItem = new ListViewItem(account.AccountNo.ToString());
				lvItem.SubItems.Add(account.AccountType.ToUpper());
				lvItem.SubItems.Add(account.Currency.ToUpper());
				lvItem.SubItems.Add(account.Ammount.ToString());
				lvItem.SubItems.Add(account.OpenDate.ToString());
				lvMain.Items.Add(lvItem);
			}
		}

		internal static void initAcctListViewHeaders(ListView listView)
		{
			listView.Columns.Clear();
			listView.Columns.Add("Account No.", 70, HorizontalAlignment.Center);
			listView.Columns.Add("Account Type", 120, HorizontalAlignment.Center);
			listView.Columns.Add("Currency", 40, HorizontalAlignment.Center);
			listView.Columns.Add("Amount", 40, HorizontalAlignment.Center);
			listView.Columns.Add("Open Date", 60, HorizontalAlignment.Center);
		}

		internal static string getStringCurrencyFromString(String currency)
		{
			switch (currency)
			{
				case "1":
					return "RON";
				case "2":
					return "EUR";
				case "3":
					return "USD";
				case "4":
					return "GPB";
				default:
					return null;
			}
		}

		internal static string getStringAccTypeFromInt(int accountType)
		{
			switch (accountType)
			{
				case 1:
					return "Checking account";
				case 2:
					return "Savings account";
				case 3:
					return "Certificate of Deposit";
				case 4:
					return "Money market account";
				case 5:
					return "Individual Retirement Accounts";
				default:
					return null;
			}
		}
	}
}
