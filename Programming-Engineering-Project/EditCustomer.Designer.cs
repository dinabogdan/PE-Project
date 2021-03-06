﻿using System.Windows.Forms;

namespace Programming_Engineering_Project
{
	partial class EditCustomer
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
			this.btnEdit = new System.Windows.Forms.Button();
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
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudStreetNo)).BeginInit();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.btnEdit);
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
			this.mainPanel.Location = new System.Drawing.Point(12, 12);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(469, 329);
			this.mainPanel.TabIndex = 0;
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(198, 286);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 42;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// nudStreetNo
			// 
			this.nudStreetNo.Location = new System.Drawing.Point(344, 227);
			this.nudStreetNo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nudStreetNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudStreetNo.Name = "nudStreetNo";
			this.nudStreetNo.Size = new System.Drawing.Size(100, 20);
			this.nudStreetNo.TabIndex = 41;
			this.nudStreetNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// txtBoxStreet
			// 
			this.txtBoxStreet.Location = new System.Drawing.Point(344, 202);
			this.txtBoxStreet.Name = "txtBoxStreet";
			this.txtBoxStreet.Size = new System.Drawing.Size(100, 20);
			this.txtBoxStreet.TabIndex = 40;
			// 
			// txtBoxLocality
			// 
			this.txtBoxLocality.Location = new System.Drawing.Point(344, 176);
			this.txtBoxLocality.Name = "txtBoxLocality";
			this.txtBoxLocality.Size = new System.Drawing.Size(100, 20);
			this.txtBoxLocality.TabIndex = 39;
			// 
			// txtBoxCity
			// 
			this.txtBoxCity.Location = new System.Drawing.Point(344, 150);
			this.txtBoxCity.Name = "txtBoxCity";
			this.txtBoxCity.Size = new System.Drawing.Size(100, 20);
			this.txtBoxCity.TabIndex = 38;
			// 
			// txtBoxCounty
			// 
			this.txtBoxCounty.Location = new System.Drawing.Point(109, 228);
			this.txtBoxCounty.Name = "txtBoxCounty";
			this.txtBoxCounty.Size = new System.Drawing.Size(100, 20);
			this.txtBoxCounty.TabIndex = 37;
			// 
			// txtBoxCountry
			// 
			this.txtBoxCountry.Location = new System.Drawing.Point(109, 202);
			this.txtBoxCountry.Name = "txtBoxCountry";
			this.txtBoxCountry.Size = new System.Drawing.Size(100, 20);
			this.txtBoxCountry.TabIndex = 36;
			// 
			// txtBoxEmail
			// 
			this.txtBoxEmail.Location = new System.Drawing.Point(109, 176);
			this.txtBoxEmail.Name = "txtBoxEmail";
			this.txtBoxEmail.Size = new System.Drawing.Size(100, 20);
			this.txtBoxEmail.TabIndex = 35;
			// 
			// txtBoxPhone
			// 
			this.txtBoxPhone.Location = new System.Drawing.Point(109, 150);
			this.txtBoxPhone.Name = "txtBoxPhone";
			this.txtBoxPhone.Size = new System.Drawing.Size(100, 20);
			this.txtBoxPhone.TabIndex = 34;
			// 
			// lblStreetNo
			// 
			this.lblStreetNo.AutoSize = true;
			this.lblStreetNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStreetNo.Location = new System.Drawing.Point(268, 226);
			this.lblStreetNo.Name = "lblStreetNo";
			this.lblStreetNo.Size = new System.Drawing.Size(67, 16);
			this.lblStreetNo.TabIndex = 33;
			this.lblStreetNo.Text = "Street No.";
			// 
			// lblStreet
			// 
			this.lblStreet.AutoSize = true;
			this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStreet.Location = new System.Drawing.Point(268, 201);
			this.lblStreet.Name = "lblStreet";
			this.lblStreet.Size = new System.Drawing.Size(43, 16);
			this.lblStreet.TabIndex = 32;
			this.lblStreet.Text = "Street";
			// 
			// lblLocality
			// 
			this.lblLocality.AutoSize = true;
			this.lblLocality.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLocality.Location = new System.Drawing.Point(268, 175);
			this.lblLocality.Name = "lblLocality";
			this.lblLocality.Size = new System.Drawing.Size(54, 16);
			this.lblLocality.TabIndex = 31;
			this.lblLocality.Text = "Locality";
			// 
			// lblCity
			// 
			this.lblCity.AutoSize = true;
			this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCity.Location = new System.Drawing.Point(268, 150);
			this.lblCity.Name = "lblCity";
			this.lblCity.Size = new System.Drawing.Size(30, 16);
			this.lblCity.TabIndex = 30;
			this.lblCity.Text = "City";
			// 
			// lblCounty
			// 
			this.lblCounty.AutoSize = true;
			this.lblCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCounty.Location = new System.Drawing.Point(13, 226);
			this.lblCounty.Name = "lblCounty";
			this.lblCounty.Size = new System.Drawing.Size(49, 16);
			this.lblCounty.TabIndex = 29;
			this.lblCounty.Text = "County";
			// 
			// lblCountry
			// 
			this.lblCountry.AutoSize = true;
			this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCountry.Location = new System.Drawing.Point(13, 201);
			this.lblCountry.Name = "lblCountry";
			this.lblCountry.Size = new System.Drawing.Size(53, 16);
			this.lblCountry.TabIndex = 28;
			this.lblCountry.Text = "Country";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmail.Location = new System.Drawing.Point(13, 175);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(42, 16);
			this.lblEmail.TabIndex = 27;
			this.lblEmail.Text = "Email";
			// 
			// lblPhone
			// 
			this.lblPhone.AutoSize = true;
			this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPhone.Location = new System.Drawing.Point(13, 150);
			this.lblPhone.Name = "lblPhone";
			this.lblPhone.Size = new System.Drawing.Size(47, 16);
			this.lblPhone.TabIndex = 26;
			this.lblPhone.Text = "Phone";
			// 
			// lblCustomerDetails
			// 
			this.lblCustomerDetails.AutoSize = true;
			this.lblCustomerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCustomerDetails.Location = new System.Drawing.Point(12, 116);
			this.lblCustomerDetails.Name = "lblCustomerDetails";
			this.lblCustomerDetails.Size = new System.Drawing.Size(149, 24);
			this.lblCustomerDetails.TabIndex = 17;
			this.lblCustomerDetails.Text = "Customer details";
			// 
			// dpBirthdate
			// 
			this.dpBirthdate.Location = new System.Drawing.Point(343, 72);
			this.dpBirthdate.Name = "dpBirthdate";
			this.dpBirthdate.Size = new System.Drawing.Size(100, 20);
			this.dpBirthdate.TabIndex = 16;
			// 
			// txtBoxCnp
			// 
			this.txtBoxCnp.Location = new System.Drawing.Point(343, 49);
			this.txtBoxCnp.Name = "txtBoxCnp";
			this.txtBoxCnp.Size = new System.Drawing.Size(100, 20);
			this.txtBoxCnp.TabIndex = 15;
			// 
			// lblBirthdate
			// 
			this.lblBirthdate.AutoSize = true;
			this.lblBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBirthdate.Location = new System.Drawing.Point(267, 73);
			this.lblBirthdate.Name = "lblBirthdate";
			this.lblBirthdate.Size = new System.Drawing.Size(61, 16);
			this.lblBirthdate.TabIndex = 14;
			this.lblBirthdate.Text = "Birthdate";
			// 
			// lblCnp
			// 
			this.lblCnp.AutoSize = true;
			this.lblCnp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCnp.Location = new System.Drawing.Point(267, 49);
			this.lblCnp.Name = "lblCnp";
			this.lblCnp.Size = new System.Drawing.Size(36, 16);
			this.lblCnp.TabIndex = 13;
			this.lblCnp.Text = "CNP";
			// 
			// txtBoxFirstName
			// 
			this.txtBoxFirstName.Location = new System.Drawing.Point(108, 72);
			this.txtBoxFirstName.Name = "txtBoxFirstName";
			this.txtBoxFirstName.Size = new System.Drawing.Size(100, 20);
			this.txtBoxFirstName.TabIndex = 12;
			// 
			// txtBoxLastName
			// 
			this.txtBoxLastName.Location = new System.Drawing.Point(108, 48);
			this.txtBoxLastName.Name = "txtBoxLastName";
			this.txtBoxLastName.Size = new System.Drawing.Size(100, 20);
			this.txtBoxLastName.TabIndex = 11;
			// 
			// lblLastName
			// 
			this.lblLastName.AutoSize = true;
			this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLastName.Location = new System.Drawing.Point(13, 49);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size = new System.Drawing.Size(73, 16);
			this.lblLastName.TabIndex = 10;
			this.lblLastName.Text = "Last Name";
			// 
			// lblFirstName
			// 
			this.lblFirstName.AutoSize = true;
			this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFirstName.Location = new System.Drawing.Point(13, 72);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.Size = new System.Drawing.Size(73, 16);
			this.lblFirstName.TabIndex = 9;
			this.lblFirstName.Text = "First Name";
			// 
			// lblCustomerInfo
			// 
			this.lblCustomerInfo.AutoSize = true;
			this.lblCustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCustomerInfo.Location = new System.Drawing.Point(12, 11);
			this.lblCustomerInfo.Name = "lblCustomerInfo";
			this.lblCustomerInfo.Size = new System.Drawing.Size(197, 24);
			this.lblCustomerInfo.TabIndex = 1;
			this.lblCustomerInfo.Text = "Customer informations";
			// 
			// EditCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(494, 346);
			this.Controls.Add(this.mainPanel);
			this.Name = "EditCustomer";
			this.Text = "EditCustomer";
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudStreetNo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Panel mainPanel;
		public Panel MainPanel { get { return this.mainPanel; } }

		private Label lblCustomerInfo;

		private DateTimePicker dpBirthdate;
		public DateTimePicker DpBirthdate { get { return this.dpBirthdate; } }

		private TextBox txtBoxCnp;
		public TextBox TxtBoxCnp { get { return this.txtBoxCnp; } }

		private Label lblBirthdate;

		private Label lblCnp;

		private TextBox txtBoxFirstName;
		public TextBox TxtBoxFirstName { get { return this.txtBoxFirstName; } }

		private TextBox txtBoxLastName;
		public TextBox TxtBoxLastName { get { return this.txtBoxLastName; } }

		private Label lblLastName;

		private Label lblFirstName;

		private Label lblCustomerDetails;

		private Button btnEdit;

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

		private Label lblStreetNo;
		private Label lblStreet;
		private Label lblLocality;
		private Label lblCity;
		private Label lblCounty;
		private Label lblCountry;
		private Label lblEmail;
		private Label lblPhone;
	}
}