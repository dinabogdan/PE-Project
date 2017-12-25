using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Programming_Engineering_Project
{
	class Utils
	{
		public static Dictionary<String, String> validateCustInfo(Customer customer)
		{
			Dictionary<String, String> errors = new Dictionary<String, String>();

			if (customer.FirstName != null && customer.FirstName.Length > 0)
			{
				Regex regex = new Regex(@"^[a-zA-Z- ]{3,30}$");
				if (!regex.IsMatch(customer.FirstName)) { errors.Add("firstNameErr", "First name is not valid!"); }
			}
			else
			{
				errors.Add("firstNameErr", "First name is empty!");
			}

			if (customer.LastName != null && customer.LastName.Length > 0)
			{
				Regex regex = new Regex(@"^[a-zA-Z- ]{3,30}$");
				if (!regex.IsMatch(customer.LastName)) { errors.Add("lastNameErr", "Last name is not valid!"); }
			}
			else
			{
				errors.Add("lastNameErr", "Last name is empty!");
			}

			if (customer.Cnp != null && customer.Cnp.Length > 0)
			{
				Regex regex = new Regex(@"^[0-9]{13}$");
				if (!regex.IsMatch(customer.Cnp)) { errors.Add("cnpErr", "CNP is not valid!"); }
			}
			else
			{
				errors.Add("cnpErr", "CNP is empty!");
			}

			if (customer.BirthDate == null || customer.BirthDate.Length > 0) { errors.Add("birthDateErr", "Birthdate is empty!"); }

			return errors;
		}
	}
}
