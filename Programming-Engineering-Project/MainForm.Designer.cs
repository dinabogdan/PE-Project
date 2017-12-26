using System.Windows.Forms;

namespace Programming_Engineering_Project
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.mainPanel = new System.Windows.Forms.Panel();
			this.lvMain = new System.Windows.Forms.ListView();
			this.lblWelcome = new System.Windows.Forms.Label();
			this.btnAllCustomers = new System.Windows.Forms.Button();
			this.btnAllAccounts = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.mainPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.lvMain);
			this.mainPanel.Location = new System.Drawing.Point(12, 89);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(652, 254);
			this.mainPanel.TabIndex = 0;
			// 
			// lvMain
			// 
			this.lvMain.Location = new System.Drawing.Point(12, 12);
			this.lvMain.Name = "lvMain";
			this.lvMain.Size = new System.Drawing.Size(628, 229);
			this.lvMain.TabIndex = 0;
			this.lvMain.UseCompatibleStateImageBehavior = false;
			// 
			// lblWelcome
			// 
			this.lblWelcome.AutoSize = true;
			this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWelcome.Location = new System.Drawing.Point(12, 13);
			this.lblWelcome.Name = "lblWelcome";
			this.lblWelcome.Size = new System.Drawing.Size(96, 24);
			this.lblWelcome.TabIndex = 1;
			this.lblWelcome.Text = "Welcome ";
			// 
			// btnAllCustomers
			// 
			this.btnAllCustomers.Location = new System.Drawing.Point(24, 60);
			this.btnAllCustomers.Name = "btnAllCustomers";
			this.btnAllCustomers.Size = new System.Drawing.Size(84, 23);
			this.btnAllCustomers.TabIndex = 2;
			this.btnAllCustomers.Text = "All customers";
			this.btnAllCustomers.UseVisualStyleBackColor = true;
			this.btnAllCustomers.Click += new System.EventHandler(this.btnAllCustomers_Click);
			// 
			// btnAllAccounts
			// 
			this.btnAllAccounts.Location = new System.Drawing.Point(115, 60);
			this.btnAllAccounts.Name = "btnAllAccounts";
			this.btnAllAccounts.Size = new System.Drawing.Size(75, 23);
			this.btnAllAccounts.TabIndex = 3;
			this.btnAllAccounts.Text = "All accounts";
			this.btnAllAccounts.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdd.Location = new System.Drawing.Point(535, 44);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(129, 39);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(676, 355);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnAllAccounts);
			this.Controls.Add(this.btnAllCustomers);
			this.Controls.Add(this.lblWelcome);
			this.Controls.Add(this.mainPanel);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.mainPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Panel mainPanel;
		private ListView lvMain;
		private Label lblWelcome;
		private Button btnAllCustomers;
		private Button btnAllAccounts;
		private Button btnAdd;

		public Panel MainPanel
		{
			get
			{
				return this.mainPanel;
			}
		}

		public ListView LvMain
		{
			get
			{
				return this.lvMain;
			}
		}

		public Label LblWelcome
		{
			get
			{
				return this.lblWelcome;
			}
		}

		public Button BtnAllCustomers
		{
			get
			{
				return this.btnAllCustomers;
			}
		}

		public Button BtnAllAccounts
		{
			get
			{
				return this.btnAllAccounts;
			}
		}
	}
}