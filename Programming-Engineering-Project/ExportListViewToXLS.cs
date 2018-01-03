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
		public static void exportCustomers(List<Customer> customers)
		{
			var excelApp = new Excel.Application();
			excelApp.Workbooks.Add();
			excelApp.Visible = true;

			Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;

			workSheet.Cells[1, "A"] = "FIRST NAME";
			workSheet.Cells[1, "B"] = "LAST NAME";
			workSheet.Cells[1, "C"] = "CNP";
			workSheet.Cells[1, "D"] = "BIRTHDATE";
			workSheet.Cells[1, "E"] = "PHONE";
			workSheet.Cells[1, "F"] = "EMAIL";
			workSheet.Cells[1, "G"] = "COUNTRY";
			workSheet.Cells[1, "H"] = "COUNTY";
			workSheet.Cells[1, "I"] = "CITY";
			workSheet.Cells[1, "J"] = "LOCALITY";
			workSheet.Cells[1, "K"] = "STREET";
			workSheet.Cells[1, "L"] = "STREET NO.";
			
			var row = 1;
			foreach (var customer in customers)
			{
				row++;
				workSheet.Cells[row, "A"] = customer.FirstName;
				workSheet.Cells[row, "B"] = customer.LastName;
				workSheet.Cells[row, "C"] = customer.Cnp;
				workSheet.Cells[row, "D"] = customer.BirthDate;
				workSheet.Cells[row, "E"] = customer.Phone;
				workSheet.Cells[row, "F"] = customer.Email;
				workSheet.Cells[row, "G"] = customer.Country;
				workSheet.Cells[row, "H"] = customer.County;
				workSheet.Cells[row, "I"] = customer.City;
				workSheet.Cells[row, "J"] = customer.Locality;
				workSheet.Cells[row, "K"] = customer.Street;
				workSheet.Cells[row, "L"] = customer.StreetNo;
			}

			workSheet.Columns[1].AutoFit();
			workSheet.Columns[2].AutoFit();
			workSheet.Columns[3].AutoFit();
			workSheet.Columns[4].AutoFit();
			workSheet.Columns[5].AutoFit();
			workSheet.Columns[6].AutoFit();
			workSheet.Columns[7].AutoFit();
			workSheet.Columns[8].AutoFit();
			workSheet.Columns[9].AutoFit();
			workSheet.Columns[10].AutoFit();
			workSheet.Columns[11].AutoFit();
			workSheet.Columns[12].AutoFit();
		}
	}
}
