using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

			Dictionary<String, String> errors = Utils.validateCustInfo(customer);

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

			errors = Utils.validateCustDetails(customer);

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

			errors = Utils.validateCustAccount(account);
			if (errors.Count != 0)
			{
				String errorMessage = null;
				errors.TryGetValue(errors.Keys.First<string>(), out errorMessage);
				this.LblAccountInfo.Text = errorMessage;
				this.LblAccountInfo.Visible = true;
				return;
			}
		}
	}
}
