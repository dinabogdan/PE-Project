using System;
using System.Collections.Generic;
using Word = Microsoft.Office.Interop.Word;


namespace Programming_Engineering_Project
{
	class ExportListViewToWord
	{
		public static void exportCustomers(List<Customer> customers)
		{
			Word.Application wordApp = new Word.Application();
			wordApp.ShowAnimation = false;
			wordApp.Visible = false;
			object missingValue = System.Reflection.Missing.Value;
			Word.Document document = wordApp.Documents.Add(ref missingValue, ref missingValue, ref missingValue, ref missingValue);

			foreach (Word.Section section in document.Sections)
			{
				Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
				headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
				headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
				headerRange.Font.ColorIndex = Word.WdColorIndex.wdBlue;
				headerRange.Font.Size = 12;
				headerRange.Text = "List of customers";
			}

			foreach (Word.Section section in document.Sections)
			{
				Word.Range footerRange = section.Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
				footerRange.Font.ColorIndex = Word.WdColorIndex.wdDarkRed;
				footerRange.Font.Size = 12;
				footerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
				footerRange.Text = "Programming Engineering";
			}

			document.Content.SetRange(0, 0);
			foreach (Customer customer in customers)
			{
				document.Content.Text = "Customer informations" + Environment.NewLine;
				Word.Paragraph firstNameParagraph = document.Content.Paragraphs.Add(ref missingValue);
				object styleHeading = "Heading 2";
				firstNameParagraph.Range.set_Style(ref styleHeading);
				firstNameParagraph.Range.Text = "First Name: " + customer.FirstName;
				firstNameParagraph.Range.InsertParagraphAfter();

				Word.Paragraph lastNameParagraph = document.Content.Paragraphs.Add(ref missingValue);
				lastNameParagraph.Range.set_Style(ref styleHeading);
				lastNameParagraph.Range.Text = "Last Name: " + customer.LastName;
				lastNameParagraph.Range.InsertParagraphAfter();

				Word.Paragraph cnpParagraph = document.Content.Paragraphs.Add(ref missingValue);
				cnpParagraph.Range.set_Style(ref styleHeading);
				cnpParagraph.Range.Text = "CNP: " + customer.Cnp;
				cnpParagraph.Range.InsertParagraphAfter();

				Word.Paragraph birthDateParagraph = document.Content.Paragraphs.Add(ref missingValue);
				birthDateParagraph.Range.set_Style(ref styleHeading);
				birthDateParagraph.Range.Text = "Birthdate: " + customer.BirthDate;
				birthDateParagraph.Range.InsertParagraphAfter();

				document.Content.Text = "Customer Details" + Environment.NewLine;

				Word.Paragraph phoneParagraph = document.Content.Paragraphs.Add(ref missingValue);
				phoneParagraph.Range.set_Style(ref styleHeading);
				phoneParagraph.Range.Text = "Customer's phone: " + customer.Phone;
				phoneParagraph.Range.InsertParagraphAfter();

				Word.Paragraph emailParagraph = document.Content.Paragraphs.Add(ref missingValue);
				emailParagraph.Range.set_Style(ref styleHeading);
				emailParagraph.Range.Text = "Customer's email: " + customer.Email;
				emailParagraph.Range.InsertParagraphAfter();

				Word.Paragraph countryParagraph = document.Content.Paragraphs.Add(ref missingValue);
				countryParagraph.Range.set_Style(ref styleHeading);
				countryParagraph.Range.Text = "Customer's country: " + customer.Country;
				countryParagraph.Range.InsertParagraphAfter();

				Word.Paragraph countyParagraph = document.Content.Paragraphs.Add(ref missingValue);
				countyParagraph.Range.set_Style(ref styleHeading);
				countyParagraph.Range.Text = "Customer's county: " + customer.County;
				countyParagraph.Range.InsertParagraphAfter();

				Word.Paragraph cityParagraph = document.Content.Paragraphs.Add(ref missingValue);
				cityParagraph.Range.set_Style(ref styleHeading);
				cityParagraph.Range.Text = "Customer's city: " + customer.City;
				cityParagraph.Range.InsertParagraphAfter();

				Word.Paragraph localityParagraph = document.Content.Paragraphs.Add(ref missingValue);
				localityParagraph.Range.set_Style(ref styleHeading);
				localityParagraph.Range.Text = "Customer's locality: " + customer.Locality;
				localityParagraph.Range.InsertParagraphAfter();

				Word.Paragraph streetParagraph = document.Content.Paragraphs.Add(ref missingValue);
				streetParagraph.Range.set_Style(ref styleHeading);
				streetParagraph.Range.Text = "Customer's street: " + customer.Street;
				streetParagraph.Range.InsertParagraphAfter();

				Word.Paragraph streetNoParagraph = document.Content.Paragraphs.Add(ref missingValue);
				streetNoParagraph.Range.set_Style(ref styleHeading);
				streetNoParagraph.Range.Text = "Customer's street no.: " + customer.StreetNo;
				streetNoParagraph.Range.InsertParagraphAfter();
			}

			object filename = @"C:\Customers.docx";
			document.SaveAs2(ref filename);
			document.Close(ref missingValue, ref missingValue, ref missingValue);
			document = null;
			wordApp.Quit(ref missingValue, ref missingValue, ref missingValue);
			wordApp = null;
		}
	}
}
