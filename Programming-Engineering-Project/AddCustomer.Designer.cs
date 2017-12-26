using System.Windows.Forms;

namespace Programming_Engineering_Project
{
	partial class AddCustomer
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.mainPanel = new System.Windows.Forms.Panel();
			this.lblCustDetailsError = new System.Windows.Forms.Label();
			this.lblCustInfoError = new System.Windows.Forms.Label();
			this.btnNewCustomer = new System.Windows.Forms.Button();
			this.cbCurrency = new System.Windows.Forms.ComboBox();
			this.cbAccountType = new System.Windows.Forms.ComboBox();
			this.txtBoxAmount = new System.Windows.Forms.TextBox();
			this.txtBoxAccountNo = new System.Windows.Forms.TextBox();
			this.lblAmount = new System.Windows.Forms.Label();
			this.lblCurrency = new System.Windows.Forms.Label();
			this.lblAccountType = new System.Windows.Forms.Label();
			this.lblAccountNo = new System.Windows.Forms.Label();
			this.lblAccountInfo = new System.Windows.Forms.Label();
			this.nudStreetNo = new System.Windows.Forms.NumericUpDown();
			this.txtBoxStreet = new System.Windows.Forms.TextBox();
			this.txtBoxLocality = new System.Windows.Forms.TextBox();
			this.txtBoxCity = new System.Windows.Forms.TextBox();
			this.txtBoxCounty = new System.Windows.Forms.TextBox();
			this.txtBoxCountry = new System.Windows.Forms.TextBox();
			this.txtBoxEmail = new System.Windows.Forms.TextBox();
			this.txtBoxPhone = new System.Windows.Forms.TextBox();
			this.lblStreetNo = new System.Windows.Forms.Label();
			this.lblStreet = new System.Windows.Forms.Label();
			this.lblLocality = new System.Windows.Forms.Label();
			this.lblCity = new System.Windows.Forms.Label();
			this.lblCounty = new System.Windows.Forms.Label();
			this.lblCountry = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblPhone = new System.Windows.Forms.Label();
			this.lblCustomerDetails = new System.Windows.Forms.Label();
			this.dpBirthdate = new System.Windows.Forms.DateTimePicker();
			this.txtBoxCnp = new System.Windows.Forms.TextBox();
			this.lblBirthdate = new System.Windows.Forms.Label();
			this.lblCnp = new System.Windows.Forms.Label();
			this.txtBoxFirstName = new System.Windows.Forms.TextBox();
			this.txtBoxLastName = new System.Windows.Forms.TextBox();
			this.lblLastName = new System.Windows.Forms.Label();
			this.lblFirstName = new System.Windows.Forms.Label();
			this.lblCustomerInfo = new System.Windows.Forms.Label();
			this.lblAccountInfoError = new System.Windows.Forms.Label();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudStreetNo)).BeginInit();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.lblAccountInfoError);
			this.mainPanel.Controls.Add(this.lblCustDetailsError);
			this.mainPanel.Controls.Add(this.lblCustInfoError);
			this.mainPanel.Controls.Add(this.btnNewCustomer);
			this.mainPanel.Controls.Add(this.cbCurrency);
			this.mainPanel.Controls.Add(this.cbAccountType);
			this.mainPanel.Controls.Add(this.txtBoxAmount);
			this.mainPanel.Controls.Add(this.txtBoxAccountNo);
			this.mainPanel.Controls.Add(this.lblAmount);
			this.mainPanel.Controls.Add(this.lblCurrency);
			this.mainPanel.Controls.Add(this.lblAccountType);
			this.mainPanel.Controls.Add(this.lblAccountNo);
			this.mainPanel.Controls.Add(this.lblAccountInfo);
			this.mainPanel.Controls.Add(this.nudStreetNo);
			this.mainPanel.Controls.Add(this.txtBoxStreet);
			this.mainPanel.Controls.Add(this.txtBoxLocality);
			this.mainPanel.Controls.Add(this.txtBoxCity);
			this.mainPanel.Controls.Add(this.txtBoxCounty);
			this.mainPanel.Controls.Add(this.txtBoxCountry);
			this.mainPanel.Controls.Add(this.txtBoxEmail);
			this.mainPanel.Controls.Add(this.txtBoxPhone);
			this.mainPanel.Controls.Add(this.lblStreetNo);
			this.mainPanel.Controls.Add(this.lblStreet);
			this.mainPanel.Controls.Add(this.lblLocality);
			this.mainPanel.Controls.Add(this.lblCity);
			this.mainPanel.Controls.Add(this.lblCounty);
			this.mainPanel.Controls.Add(this.lblCountry);
			this.mainPanel.Controls.Add(this.lblEmail);
			this.mainPanel.Controls.Add(this.lblPhone);
			this.mainPanel.Controls.Add(this.lblCustomerDetails);
			this.mainPanel.Controls.Add(this.dpBirthdate);
			this.mainPanel.Controls.Add(this.txtBoxCnp);
			this.mainPanel.Controls.Add(this.lblBirthdate);
			this.mainPanel.Controls.Add(this.lblCnp);
			this.mainPanel.Controls.Add(this.txtBoxFirstName);
			this.mainPanel.Controls.Add(this.txtBoxLastName);
			this.mainPanel.Controls.Add(this.lblLastName);
			this.mainPanel.Controls.Add(this.lblFirstName);
			this.mainPanel.Controls.Add(this.lblCustomerInfo);
			this.mainPanel.Location = new System.Drawing.Point(13, 13);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(485, 398);
			this.mainPanel.TabIndex = 0;
			// 
			// lblCustDetailsError
			// 
			this.lblCustDetailsError.AutoSize = true;
			this.lblCustDetailsError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCustDetailsError.ForeColor = System.Drawing.Color.Red;
			this.lblCustDetailsError.Location = new System.Drawing.Point(249, 113);
			this.lblCustDetailsError.Name = "lblCustDetailsError";
			this.lblCustDetailsError.Size = new System.Drawing.Size(0, 24);
			this.lblCustDetailsError.TabIndex = 37;
			// 
			// lblCustInfoError
			// 
			this.lblCustInfoError.AutoSize = true;
			this.lblCustInfoError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCustInfoError.ForeColor = System.Drawing.Color.Red;
			this.lblCustInfoError.Location = new System.Drawing.Point(249, 16);
			this.lblCustInfoError.Name = "lblCustInfoError";
			this.lblCustInfoError.Size = new System.Drawing.Size(0, 24);
			this.lblCustInfoError.TabIndex = 36;
			this.lblCustInfoError.Visible = false;
			// 
			// btnNewCustomer
			// 
			this.btnNewCustomer.Location = new System.Drawing.Point(207, 359);
			this.btnNewCustomer.Name = "btnNewCustomer";
			this.btnNewCustomer.Size = new System.Drawing.Size(75, 23);
			this.btnNewCustomer.TabIndex = 35;
			this.btnNewCustomer.Text = "Add";
			this.btnNewCustomer.UseVisualStyleBackColor = true;
			this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
			// 
			// cbCurrency
			// 
			this.cbCurrency.FormattingEnabled = true;
			this.cbCurrency.Location = new System.Drawing.Point(346, 289);
			this.cbCurrency.Name = "cbCurrency";
			this.cbCurrency.Size = new System.Drawing.Size(100, 21);
			this.cbCurrency.TabIndex = 34;
			// 
			// cbAccountType
			// 
			this.cbAccountType.FormattingEnabled = true;
			this.cbAccountType.Location = new System.Drawing.Point(111, 315);
			this.cbAccountType.Name = "cbAccountType";
			this.cbAccountType.Size = new System.Drawing.Size(100, 21);
			this.cbAccountType.TabIndex = 33;
			// 
			// txtBoxAmount
			// 
			this.txtBoxAmount.Location = new System.Drawing.Point(346, 316);
			this.txtBoxAmount.Name = "txtBoxAmount";
			this.txtBoxAmount.Size = new System.Drawing.Size(100, 20);
			this.txtBoxAmount.TabIndex = 32;
			// 
			// txtBoxAccountNo
			// 
			this.txtBoxAccountNo.Location = new System.Drawing.Point(111, 290);
			this.txtBoxAccountNo.Name = "txtBoxAccountNo";
			this.txtBoxAccountNo.Size = new System.Drawing.Size(100, 20);
			this.txtBoxAccountNo.TabIndex = 31;
			// 
			// lblAmount
			// 
			this.lblAmount.AutoSize = true;
			this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAmount.Location = new System.Drawing.Point(270, 316);
			this.lblAmount.Name = "lblAmount";
			this.lblAmount.Size = new System.Drawing.Size(53, 16);
			this.lblAmount.TabIndex = 30;
			this.lblAmount.Text = "Amount";
			// 
			// lblCurrency
			// 
			this.lblCurrency.AutoSize = true;
			this.lblCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurrency.Location = new System.Drawing.Point(270, 290);
			this.lblCurrency.Name = "lblCurrency";
			this.lblCurrency.Size = new System.Drawing.Size(61, 16);
			this.lblCurrency.TabIndex = 29;
			this.lblCurrency.Text = "Currency";
			// 
			// lblAccountType
			// 
			this.lblAccountType.AutoSize = true;
			this.lblAccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAccountType.Location = new System.Drawing.Point(15, 316);
			this.lblAccountType.Name = "lblAccountType";
			this.lblAccountType.Size = new System.Drawing.Size(91, 16);
			this.lblAccountType.TabIndex = 28;
			this.lblAccountType.Text = "Account Type";
			// 
			// lblAccountNo
			// 
			this.lblAccountNo.AutoSize = true;
			this.lblAccountNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAccountNo.Location = new System.Drawing.Point(15, 290);
			this.lblAccountNo.Name = "lblAccountNo";
			this.lblAccountNo.Size = new System.Drawing.Size(80, 16);
			this.lblAccountNo.TabIndex = 27;
			this.lblAccountNo.Text = "Account No.";
			// 
			// lblAccountInfo
			// 
			this.lblAccountInfo.AutoSize = true;
			this.lblAccountInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAccountInfo.Location = new System.Drawing.Point(16, 256);
			this.lblAccountInfo.Name = "lblAccountInfo";
			this.lblAccountInfo.Size = new System.Drawing.Size(186, 24);
			this.lblAccountInfo.TabIndex = 26;
			this.lblAccountInfo.Text = "Account informations";
			// 
			// nudStreetNo
			// 
			this.nudStreetNo.Location = new System.Drawing.Point(346, 225);
			this.nudStreetNo.Name = "nudStreetNo";
			this.nudStreetNo.Size = new System.Drawing.Size(100, 20);
			this.nudStreetNo.TabIndex = 25;
			// 
			// txtBoxStreet
			// 
			this.txtBoxStreet.Location = new System.Drawing.Point(346, 200);
			this.txtBoxStreet.Name = "txtBoxStreet";
			this.txtBoxStreet.Size = new System.Drawing.Size(100, 20);
			this.txtBoxStreet.TabIndex = 24;
			// 
			// txtBoxLocality
			// 
			this.txtBoxLocality.Location = new System.Drawing.Point(346, 174);
			this.txtBoxLocality.Name = "txtBoxLocality";
			this.txtBoxLocality.Size = new System.Drawing.Size(100, 20);
			this.txtBoxLocality.TabIndex = 23;
			// 
			// txtBoxCity
			// 
			this.txtBoxCity.Location = new System.Drawing.Point(346, 148);
			this.txtBoxCity.Name = "txtBoxCity";
			this.txtBoxCity.Size = new System.Drawing.Size(100, 20);
			this.txtBoxCity.TabIndex = 22;
			// 
			// txtBoxCounty
			// 
			this.txtBoxCounty.Location = new System.Drawing.Point(111, 226);
			this.txtBoxCounty.Name = "txtBoxCounty";
			this.txtBoxCounty.Size = new System.Drawing.Size(100, 20);
			this.txtBoxCounty.TabIndex = 21;
			// 
			// txtBoxCountry
			// 
			this.txtBoxCountry.Location = new System.Drawing.Point(111, 200);
			this.txtBoxCountry.Name = "txtBoxCountry";
			this.txtBoxCountry.Size = new System.Drawing.Size(100, 20);
			this.txtBoxCountry.TabIndex = 20;
			// 
			// txtBoxEmail
			// 
			this.txtBoxEmail.Location = new System.Drawing.Point(111, 174);
			this.txtBoxEmail.Name = "txtBoxEmail";
			this.txtBoxEmail.Size = new System.Drawing.Size(100, 20);
			this.txtBoxEmail.TabIndex = 19;
			// 
			// txtBoxPhone
			// 
			this.txtBoxPhone.Location = new System.Drawing.Point(111, 148);
			this.txtBoxPhone.Name = "txtBoxPhone";
			this.txtBoxPhone.Size = new System.Drawing.Size(100, 20);
			this.txtBoxPhone.TabIndex = 18;
			// 
			// lblStreetNo
			// 
			this.lblStreetNo.AutoSize = true;
			this.lblStreetNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStreetNo.Location = new System.Drawing.Point(270, 224);
			this.lblStreetNo.Name = "lblStreetNo";
			this.lblStreetNo.Size = new System.Drawing.Size(67, 16);
			this.lblStreetNo.TabIndex = 17;
			this.lblStreetNo.Text = "Street No.";
			// 
			// lblStreet
			// 
			this.lblStreet.AutoSize = true;
			this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStreet.Location = new System.Drawing.Point(270, 199);
			this.lblStreet.Name = "lblStreet";
			this.lblStreet.Size = new System.Drawing.Size(43, 16);
			this.lblStreet.TabIndex = 16;
			this.lblStreet.Text = "Street";
			// 
			// lblLocality
			// 
			this.lblLocality.AutoSize = true;
			this.lblLocality.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLocality.Location = new System.Drawing.Point(270, 173);
			this.lblLocality.Name = "lblLocality";
			this.lblLocality.Size = new System.Drawing.Size(54, 16);
			this.lblLocality.TabIndex = 15;
			this.lblLocality.Text = "Locality";
			// 
			// lblCity
			// 
			this.lblCity.AutoSize = true;
			this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCity.Location = new System.Drawing.Point(270, 148);
			this.lblCity.Name = "lblCity";
			this.lblCity.Size = new System.Drawing.Size(30, 16);
			this.lblCity.TabIndex = 14;
			this.lblCity.Text = "City";
			// 
			// lblCounty
			// 
			this.lblCounty.AutoSize = true;
			this.lblCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCounty.Location = new System.Drawing.Point(15, 224);
			this.lblCounty.Name = "lblCounty";
			this.lblCounty.Size = new System.Drawing.Size(49, 16);
			this.lblCounty.TabIndex = 13;
			this.lblCounty.Text = "County";
			// 
			// lblCountry
			// 
			this.lblCountry.AutoSize = true;
			this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCountry.Location = new System.Drawing.Point(15, 199);
			this.lblCountry.Name = "lblCountry";
			this.lblCountry.Size = new System.Drawing.Size(53, 16);
			this.lblCountry.TabIndex = 12;
			this.lblCountry.Text = "Country";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmail.Location = new System.Drawing.Point(15, 173);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(42, 16);
			this.lblEmail.TabIndex = 11;
			this.lblEmail.Text = "Email";
			// 
			// lblPhone
			// 
			this.lblPhone.AutoSize = true;
			this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPhone.Location = new System.Drawing.Point(15, 148);
			this.lblPhone.Name = "lblPhone";
			this.lblPhone.Size = new System.Drawing.Size(47, 16);
			this.lblPhone.TabIndex = 10;
			this.lblPhone.Text = "Phone";
			// 
			// lblCustomerDetails
			// 
			this.lblCustomerDetails.AutoSize = true;
			this.lblCustomerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCustomerDetails.Location = new System.Drawing.Point(15, 113);
			this.lblCustomerDetails.Name = "lblCustomerDetails";
			this.lblCustomerDetails.Size = new System.Drawing.Size(149, 24);
			this.lblCustomerDetails.TabIndex = 9;
			this.lblCustomerDetails.Text = "Customer details";
			// 
			// dpBirthdate
			// 
			this.dpBirthdate.Location = new System.Drawing.Point(346, 75);
			this.dpBirthdate.Name = "dpBirthdate";
			this.dpBirthdate.Size = new System.Drawing.Size(100, 20);
			this.dpBirthdate.TabIndex = 8;
			// 
			// txtBoxCnp
			// 
			this.txtBoxCnp.Location = new System.Drawing.Point(346, 52);
			this.txtBoxCnp.Name = "txtBoxCnp";
			this.txtBoxCnp.Size = new System.Drawing.Size(100, 20);
			this.txtBoxCnp.TabIndex = 7;
			// 
			// lblBirthdate
			// 
			this.lblBirthdate.AutoSize = true;
			this.lblBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBirthdate.Location = new System.Drawing.Point(270, 76);
			this.lblBirthdate.Name = "lblBirthdate";
			this.lblBirthdate.Size = new System.Drawing.Size(61, 16);
			this.lblBirthdate.TabIndex = 6;
			this.lblBirthdate.Text = "Birthdate";
			// 
			// lblCnp
			// 
			this.lblCnp.AutoSize = true;
			this.lblCnp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCnp.Location = new System.Drawing.Point(270, 52);
			this.lblCnp.Name = "lblCnp";
			this.lblCnp.Size = new System.Drawing.Size(36, 16);
			this.lblCnp.TabIndex = 5;
			this.lblCnp.Text = "CNP";
			// 
			// txtBoxFirstName
			// 
			this.txtBoxFirstName.Location = new System.Drawing.Point(111, 75);
			this.txtBoxFirstName.Name = "txtBoxFirstName";
			this.txtBoxFirstName.Size = new System.Drawing.Size(100, 20);
			this.txtBoxFirstName.TabIndex = 4;
			// 
			// txtBoxLastName
			// 
			this.txtBoxLastName.Location = new System.Drawing.Point(111, 51);
			this.txtBoxLastName.Name = "txtBoxLastName";
			this.txtBoxLastName.Size = new System.Drawing.Size(100, 20);
			this.txtBoxLastName.TabIndex = 3;
			// 
			// lblLastName
			// 
			this.lblLastName.AutoSize = true;
			this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLastName.Location = new System.Drawing.Point(16, 52);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size = new System.Drawing.Size(73, 16);
			this.lblLastName.TabIndex = 2;
			this.lblLastName.Text = "Last Name";
			// 
			// lblFirstName
			// 
			this.lblFirstName.AutoSize = true;
			this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFirstName.Location = new System.Drawing.Point(16, 75);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.Size = new System.Drawing.Size(73, 16);
			this.lblFirstName.TabIndex = 1;
			this.lblFirstName.Text = "First Name";
			// 
			// lblCustomerInfo
			// 
			this.lblCustomerInfo.AutoSize = true;
			this.lblCustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCustomerInfo.Location = new System.Drawing.Point(14, 16);
			this.lblCustomerInfo.Name = "lblCustomerInfo";
			this.lblCustomerInfo.Size = new System.Drawing.Size(197, 24);
			this.lblCustomerInfo.TabIndex = 0;
			this.lblCustomerInfo.Text = "Customer informations";
			// 
			// lblAccountInfoError
			// 
			this.lblAccountInfoError.AutoSize = true;
			this.lblAccountInfoError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAccountInfoError.ForeColor = System.Drawing.Color.Red;
			this.lblAccountInfoError.Location = new System.Drawing.Point(249, 256);
			this.lblAccountInfoError.Name = "lblAccountInfoError";
			this.lblAccountInfoError.Size = new System.Drawing.Size(0, 24);
			this.lblAccountInfoError.TabIndex = 38;
			this.lblAccountInfoError.Visible = false;
			// 
			// AddCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(510, 420);
			this.Controls.Add(this.mainPanel);
			this.Name = "AddCustomer";
			this.Text = "Add Customer";
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudStreetNo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Panel mainPanel;
		public Panel MainPanel { get { return this.mainPanel; } }

		private Label lblCustomerInfo;
		public Label LblCustomerInfo { get { return this.LblCustomerInfo; } }

		private Label lblLastName;
		public Label LblLastName { get { return this.LblLastName; } }

		private Label lblFirstName;
		public Label LblFirstName { get { return this.LblFirstName; } }

		private TextBox txtBoxFirstName;
		public TextBox TxtBoxFirstName { get { return this.TxtBoxFirstName; } }

		private TextBox txtBoxLastName;
		public TextBox TxtBoxLastName { get { return this.txtBoxLastName; } }

		private Label lblCnp;
		public Label LblCnp { get { return this.lblCnp; } }

		private Label lblBirthdate;
		public Label LblBirthDate { get { return this.lblBirthdate; } }

		private DateTimePicker dpBirthdate;
		public DateTimePicker DpBirthdate { get { return this.dpBirthdate; } }

		private TextBox txtBoxCnp;
		public TextBox TxtBoxCnp { get { return this.txtBoxCnp; } }

		private Label lblCustomerDetails;
		public Label LblCustomerDetails { get { return this.lblCustomerDetails; } }

		private Label lblStreetNo;
		public Label LblStreetNo { get { return this.lblStreetNo; } }

		private Label lblStreet;
		public Label LblStreet { get { return this.lblStreet; } }

		private Label lblLocality;
		public Label LblLocality { get { return this.lblLocality; } }

		private Label lblCity;
		public Label LblCity { get { return this.lblCity; } }

		private Label lblCounty;
		public Label LblCounty { get { return this.lblCounty; } }

		private Label lblCountry;
		public Label LblCountry { get { return this.lblCountry; } }

		private Label lblEmail;
		public Label LblEmail { get { return this.lblEmail; } }

		private Label lblPhone;
		public Label LblPhone { get { return this.lblPhone; } }

		private NumericUpDown nudStreetNo;
		public NumericUpDown NudStreetNo { get { return this.nudStreetNo; } }

		private TextBox txtBoxStreet;
		public TextBox TxtBoxStreet { get { return this.txtBoxStreet; } }

		private TextBox txtBoxLocality;
		public TextBox TxtBoxLocality { get { return this.txtBoxLocality; } }

		private TextBox txtBoxCity;
		public TextBox TxtBoxCity { get { return this.txtBoxCity; } }

		private TextBox txtBoxCounty;
		public TextBox TxtBoxCounty { get { return this.txtBoxCounty; } }

		private TextBox txtBoxCountry;
		public TextBox TxtBoxCountry { get { return this.txtBoxCountry; } }

		private TextBox txtBoxEmail;
		public TextBox TxtBoxEmail { get { return this.txtBoxEmail; } }

		private TextBox txtBoxPhone;
		public TextBox TxtBoxPhone { get { return this.txtBoxPhone; } }

		private Label lblAccountInfo;
		public Label LblAccountInfo { get { return this.lblAccountInfo; } }

		private Label lblAccountNo;
		public Label LblAccountNo { get { return this.lblAccountNo; } }

		private Label lblAccountType;
		public Label LblAccountType { get { return this.lblAccountType; } }

		private Label lblCurrency;
		public Label LblCurrency { get { return this.lblCurrency; } }

		private Label lblAmount;
		public Label LblAmount { get { return this.lblAmount; } }

		private ComboBox cbCurrency;
		public ComboBox CbCurrency { get { return this.cbCurrency; } }

		private ComboBox cbAccountType;
		public ComboBox CbAccountType { get { return this.cbAccountType; } }

		private TextBox txtBoxAmount;
		public TextBox TxtBoxAmount { get { return this.txtBoxAmount; } }

		private TextBox txtBoxAccountNo;
		public TextBox TxtBoxAccountNo { get { return this.txtBoxAccountNo; } }

		private Button btnNewCustomer;
		public Button BtnNewCustomer { get { return this.btnNewCustomer; } }

		private Label lblCustInfoError;
		public Label LblCustInfoError { get { return this.lblCustInfoError; } }

		private Label lblCustDetailsError;
		public Label LblCustDetailsError { get { return this.lblCustDetailsError; } }

		private Label lblAccountInfoError;
		public Label LblAccountInfoError { get { return this.lblAccountInfoError; } }
	}
}