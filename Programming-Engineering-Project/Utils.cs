using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace Programming_Engineering_Project
{
	class Utils
	{
		public static void initCustListViewHeaders(ListView listView)
		{
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
	}
}
