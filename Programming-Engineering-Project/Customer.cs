using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Engineering_Project
{
	class Customer
	{
		private int customerId;
		private String firstName;
		private String lastName;
		private String cnp;
		private String birthDate;
		private String phone;
		private String email;
		private String country;
		private String county;
		private String city;
		private String locality;
		private String street;
		private int streetNo;
		private List<Account> customerAccounts;

		public Customer() { }

		public int CustomerId { get { return this.customerId; } set { this.customerId = value; } }

		public String FirstName { get { return this.firstName; } set { this.firstName = value; } }

		public String LastName { get { return this.lastName; } set { this.lastName = value; } }

		public String Cnp { get { return this.cnp; } set { this.cnp = value; } }

		public String BirthDate { get { return this.birthDate; } set { this.birthDate = value; } }

		public String Phone { get { return this.phone; } set { this.phone = value; } }

		public String Email { get { return this.email; } set { this.email = value; } }

		public String Country { get { return this.country; } set { this.country = value; } }

		public String County { get { return this.county; } set { this.county = value; } }

		public String City { get { return this.city; } set { this.city = value; } }

		public String Locality { get { return this.locality; } set { this.locality = value; } }

		public String Street { get { return this.street; } set { this.street = value; } }

		public int StreetNo { get { return this.streetNo; } set { this.streetNo = value; } }

		public List<Account> CustomerAccounts { get { return this.customerAccounts; } set { this.customerAccounts = value; } }
	}
}
