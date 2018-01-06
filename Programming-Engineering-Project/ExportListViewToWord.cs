using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;


namespace Programming_Engineering_Project
{
	class ExportListViewToWord
	{
		public static void exportCustomers()
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
			document.Content.Text = "This is a test document " + Environment.NewLine;

			Word.Paragraph paragraph1 = document.Content.Paragraphs.Add(ref missingValue);
			object styleHeading1 = "Heading 1";
			paragraph1.Range.set_Style(ref styleHeading1);
			paragraph1.Range.Text = "Paragraph 1 text";
			paragraph1.Range.InsertParagraphAfter();

			Word.Paragraph paragraph2 = document.Content.Paragraphs.Add(ref missingValue);
			object styleHeading2 = "Heading 2";
			paragraph2.Range.set_Style(ref styleHeading2);
			paragraph2.Range.Text = "Paragraph 2 text";
			paragraph2.Range.InsertParagraphAfter();

			object filename = @"C:\temp1.docx";
			document.SaveAs2(ref filename);
			document.Close(ref missingValue, ref missingValue, ref missingValue);
			document = null;
			wordApp.Quit(ref missingValue, ref missingValue, ref missingValue);
			wordApp = null;
		}
	}
}
