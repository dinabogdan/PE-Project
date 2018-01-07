using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Programming_Engineering_Project
{
	public partial class EditCustomer : Form
	{
		public EditCustomer()
		{
			InitializeComponent();
		}

		private void btnEdit_Click(object sender, EventArgs e)
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
				MessageBox.Show(errorMessage);
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
				MessageBox.Show(errorMessage);
				return;
			}

			if (errors.Count == 0)
			{
				SQLiteConnection connection = DatabaseConnection.getConnection();
				connection.Open();
				SQLiteTransaction transaction = connection.BeginTransaction();
				ICustomersDAO customersDao = new CustomersDAO();
				try
				{
					customersDao.updateCustomer(customer, connection);
					transaction.Commit();
					MessageBox.Show("The Customer was successfully added!");
				}
				catch (SQLiteException exception)
				{
					Console.WriteLine(exception.Message);
					transaction.Rollback();
					MessageBox.Show("The Customer can't be update!");
				}

				connection.Close();
			}
		}
	}
}
