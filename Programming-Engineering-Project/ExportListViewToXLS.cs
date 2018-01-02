using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;

namespace Programming_Engineering_Project
{
	class ExportListViewToXLS
	{
		public static void exportCustomers(List<Customer> customers, Action<Customer, Excel.Range> DisplayFunction)
		{
			var excelApp = new Excel.Application();
			excelApp.Workbooks.Add();
			excelApp.Visible = true;

			excelApp.Range["A1"].Value = "FIRST NAME";
			excelApp.Range["B1"].Value = "LAST NAME";
			excelApp.Range["C1"].Value = "CNP";
			excelApp.Range["D1"].Value = "BIRTHDATE";
			excelApp.Range["E1"].Value = "PHONE";
			excelApp.Range["F1"].Value = "EMAIL";
			excelApp.Range["G1"].Value = "COUNTRY";
			excelApp.Range["H1"].Value = "COUNTY";
			excelApp.Range["I1"].Value = "CITY";
			excelApp.Range["J1"].Value = "LOCALITY";
			excelApp.Range["K1"].Value = "STREET";
			excelApp.Range["L1"].Value = "STREET NO.";

		}
	}
}
