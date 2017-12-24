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
			this.mainPanel = new System.Windows.Forms.Panel();
			this.lblError = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.txtBoxPassword = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txtBoxUsername = new System.Windows.Forms.TextBox();
			this.lblUsername = new System.Windows.Forms.Label();
			this.mainPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mainPanel.Controls.Add(this.lblError);
			this.mainPanel.Controls.Add(this.btnLogin);
			this.mainPanel.Controls.Add(this.txtBoxPassword);
			this.mainPanel.Controls.Add(this.lblPassword);
			this.mainPanel.Controls.Add(this.txtBoxUsername);
			this.mainPanel.Controls.Add(this.lblUsername);
			this.mainPanel.Location = new System.Drawing.Point(25, 25);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(200, 236);
			this.mainPanel.TabIndex = 0;
			// 
			// lblError
			// 
			this.lblError.AutoSize = true;
			this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblError.ForeColor = System.Drawing.Color.Red;
			this.lblError.Location = new System.Drawing.Point(21, 145);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(159, 20);
			this.lblError.TabIndex = 6;
			this.lblError.Text = "Wrong credentials!";
			this.lblError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblError.Visible = false;
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(59, 186);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(75, 23);
			this.btnLogin.TabIndex = 4;
			this.btnLogin.Text = "LOGIN";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// txtBoxPassword
			// 
			this.txtBoxPassword.Location = new System.Drawing.Point(25, 111);
			this.txtBoxPassword.Name = "txtBoxPassword";
			this.txtBoxPassword.PasswordChar = '#';
			this.txtBoxPassword.Size = new System.Drawing.Size(139, 20);
			this.txtBoxPassword.TabIndex = 3;
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPassword.Location = new System.Drawing.Point(55, 88);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(86, 20);
			this.lblPassword.TabIndex = 2;
			this.lblPassword.Text = "Password";
			// 
			// txtBoxUsername
			// 
			this.txtBoxUsername.Location = new System.Drawing.Point(25, 55);
			this.txtBoxUsername.Name = "txtBoxUsername";
			this.txtBoxUsername.Size = new System.Drawing.Size(139, 20);
			this.txtBoxUsername.TabIndex = 1;
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsername.Location = new System.Drawing.Point(55, 32);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(91, 20);
			this.lblUsername.TabIndex = 0;
			this.lblUsername.Text = "Username";
			this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// MainForm
			// 
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(259, 285);
			this.Controls.Add(this.mainPanel);
			this.Name = "MainForm";
			this.Text = "Login";
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Panel mainPanel;
		private Label lblUsername;
		private TextBox txtBoxUsername;
		private Label lblPassword;
		private TextBox txtBoxPassword;
		private Label lblError;
		private Button btnLogin;

		public Panel MainPanel
		{
			get
			{
				return mainPanel;
			}
		}

		public Label LabelUsername
		{
			get
			{
				return lblUsername;
			}
		}

		public Label LabelPassword
		{
			get
			{
				return lblPassword;
			}
		}

		public TextBox TextBoxUsername
		{
			get
			{
				return txtBoxUsername;
			}
		}

		public TextBox TextBoxPassword
		{
			get
			{
				return txtBoxPassword;
			}
		}

		public Label LabelError
		{
			get
			{
				return lblError;
			}
		}

		public Button BtnLogin
		{
			get
			{
				return btnLogin;
			}
		}
	}
}

