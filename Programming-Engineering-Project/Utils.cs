using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net.Mail;

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
		public static Dictionary<String, String> validateCustDetails(Customer customer)
		{
			Dictionary<String, String> errors = new Dictionary<string, string>();
			if (customer.Phone != null && customer.Phone.Length > 0)
			{
				Regex regex = new Regex(@"^[0-10]{10}$");
				if (!regex.IsMatch(customer.Phone)) { errors.Add("phoneErr", "Phone is not valid!"); }
			}
			else
			{
				errors.Add("phoneErr", "Phone is empty!");
			}

			if (customer.Email != null && customer.Email.Length > 0)
			{
				try
				{
					MailAddress m = new MailAddress(customer.Email);
				}
				catch (FormatException)
				{
					errors.Add("emailErr", "Email is not valid!");
				}
			}
			else
			{
				errors.Add("emailErr", "The Email is empty!");
			}

			if (customer.Country != null && customer.Country.Length > 0)
			{
				if (!customer.Country.Equals("Romania")) { errors.Add("countryErr", "Country must be 'Romania'!"); }
			}
			else
			{
				errors.Add("countryErr", "Country is empty!");
			}

			if (!(customer.County != null && customer.County.Length > 0))
			{
				errors.Add("countyErr", "County is empty!");
			}

			if (customer.Locality != null && customer.Locality.Length > 0)
			{
				Regex regex = new Regex(@"^[a-zA-Z -]{3, 50}$");
				if (!regex.IsMatch(customer.Locality)) { errors.Add("localityErr", "Locality is not valid!"); }
			}
			else
			{
				errors.Add("localityErr", "Locality is empty!");
			}

			if (!(customer.StreetNo > 0))
			{
				errors.Add("streetNo", "Street No. is empty!");
			}


			return errors;
		}
	}
}
