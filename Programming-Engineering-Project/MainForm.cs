using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;

namespace Programming_Engineering_Project
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (this.TextBoxUsername.Text.Length > 0 && this.TextBoxPassword.Text.Length > 0)
			{
				SQLiteConnection connection = DatabaseConnection.getConnection();
			}
			else
			{
				this.LabelError.Visible = true;
			}
		}
	}
}
