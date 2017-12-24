﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Engineering_Project
{
	class Account
	{
		private int accountNo;
		private int accountType;
		private String currency;
		private float ammount;
		private String openDate;

		public Account() { }

		public int AccountNo { get { return this.accountNo; }  set { this.accountNo = value; } }
		
		public int AccountType { get { return this.accountType; } set { this.accountType = value; } }

		public String Currency { get { return this.currency; } set { this.currency = value;  } }

		public float Ammount { get { return this.ammount; } set { this.ammount = value; } }

		public String OpenDate { get { return this.openDate; } set { this.openDate = value; } } 
	}
}