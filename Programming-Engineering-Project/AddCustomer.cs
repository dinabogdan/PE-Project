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
				this.LblAccountInfoError.Text = errorMessage;
				this.LblAccountInfoError.Visible = true;
				return;
			}

			
		}
	}
}
