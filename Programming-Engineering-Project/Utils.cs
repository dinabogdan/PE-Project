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

			if (!String.IsNullOrEmpty(customer.FirstName))
			{
				Regex regex = new Regex(@"^[a-zA-Z- ]{3,30}$");
				if (!regex.IsMatch(customer.FirstName)) { errors.Add("firstNameErr", "First name is not valid!"); }
			}
			else
			{
				errors.Add("firstNameErr", "First name is empty!");
			}

			if (!String.IsNullOrEmpty(customer.LastName))
			{
				Regex regex = new Regex(@"^[a-zA-Z- ]{3,30}$");
				if (!regex.IsMatch(customer.LastName)) { errors.Add("lastNameErr", "Last name is not valid!"); }
			}
			else
			{
				errors.Add("lastNameErr", "Last name is empty!");
			}

			if (!String.IsNullOrWhiteSpace(customer.Cnp))
			{
				Regex regex = new Regex(@"^[0-9]{13}$");
				if (!regex.IsMatch(customer.Cnp)) { errors.Add("cnpErr", "CNP is not valid!"); }
			}
			else
			{
				errors.Add("cnpErr", "CNP is empty!");
			}

			if (String.IsNullOrWhiteSpace(customer.BirthDate)) { errors.Add("birthDateErr", "Birthdate is empty!"); }

			return errors;
		}
		public static Dictionary<String, String> validateCustDetails(Customer customer)
		{
			Dictionary<String, String> errors = new Dictionary<string, string>();
			if (!String.IsNullOrWhiteSpace(customer.Phone))
			{
				Regex regex = new Regex(@"^[0-10]{10}$");
				if (!regex.IsMatch(customer.Phone)) { errors.Add("phoneErr", "Phone is not valid!"); }
			}
			else
			{
				errors.Add("phoneErr", "Phone is empty!");
			}

			if (!String.IsNullOrWhiteSpace(customer.Email))
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

			if (!String.IsNullOrWhiteSpace(customer.Country))
			{
				if (!customer.Country.Equals("Romania")) { errors.Add("countryErr", "Country must be 'Romania'!"); }
			}
			else
			{
				errors.Add("countryErr", "Country is empty!");
			}

			if (String.IsNullOrWhiteSpace(customer.County))
			{
				errors.Add("countyErr", "County is empty!");
			}

			if (!String.IsNullOrWhiteSpace(customer.Locality))
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
		public static Dictionary<String, String> validateCustAccount(Account account)
		{
			Dictionary<String, String> errors = new Dictionary<String, String>();

			if (account.AccountNo > 0)
			{
				Regex regex = new Regex(@"^[0-9]{6}$");
				if (!regex.IsMatch(account.AccountNo.ToString())) { errors.Add("accountNoErr", "Account No. is not valid!"); }
			}
			else
			{
				errors.Add("accountNoErr", "Account No. is empty!");
			}

			if (!String.IsNullOrEmpty(account.AccountType))
			{
				Regex regex = new Regex(@"^[a-zA-Z ]{3,15}$");
				if (!regex.IsMatch(account.AccountType)) { errors.Add("accountTypeErr", "Account Type is not valid!"); }
			}
			else
			{
				errors.Add("accountTypeErr", "Account type is empty!");
			}

			if (!String.IsNullOrEmpty(account.Currency))
			{
				if (!("RON".Equals(account.Currency) || "EUR".Equals(account.Currency) || "USD".Equals(account.Currency)))
				{
					errors.Add("currencyErr", "Currency is not valid!");
				}
			}
			else
			{
				errors.Add("currencyErr", "Currency is empty!");
			}

			if (String.IsNullOrEmpty(account.Ammount.ToString()))
			{
				errors.Add("amountErr", "Amount is empty!");
			}

			return errors;
		}
	}
}
