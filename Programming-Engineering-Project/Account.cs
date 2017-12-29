using System;

namespace Programming_Engineering_Project
{
	class Account
	{
		private int accountNo;
		private String accountType;
		private String currency;
		private float ammount;
		private String openDate;

		public Account() { }

		public int AccountNo { get { return this.accountNo; }  set { this.accountNo = value; } }
		
		public String AccountType { get { return this.accountType; } set { this.accountType = value; } }

		public String Currency { get { return this.currency; } set { this.currency = value;  } }

		public float Ammount { get { return this.ammount; } set { this.ammount = value; } }

		public String OpenDate { get { return this.openDate; } set { this.openDate = value; } } 
	}
}
