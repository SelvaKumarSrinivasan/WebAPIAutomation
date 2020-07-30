using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using WebAPIAutomation.Base;

namespace WebAPIAutomation.Helpers
{
    /// <summary>
    /// Excel operation methods.
    /// </summary>
    public static class ExcelHelper
    {
        /// <summary>
        /// Get test data from excel sheet.
        /// </summary>
        public static Dictionary<string, string> GetTestData()
        {
            bool dataFound = false;
            var columnData = new Dictionary<string, string>();
            string filePath = TestSettings.TestDataSheetPath;
            try
            {
                FileInfo file = new FileInfo(filePath);
                using (ExcelPackage excelPackage = new ExcelPackage(file))
                {
                    ExcelWorksheet Dataworksheet = excelPackage.Workbook.Worksheets["DataSheet"];
                    int rowCount = Dataworksheet.Dimension.End.Row;
                    int colCount = Dataworksheet.Dimension.End.Column;
                    for (int row = 1; row <= rowCount; row++)
                    {
                        if (Dataworksheet.Cells[row, 1].Value.ToString().Equals(TestBase.TestName))
                        {
                            for (int col = 1; col <= colCount; col++)
                            {
                                if (Dataworksheet.Cells[row, col].Value != null)
                                {
                                    columnData.Add(Dataworksheet.Cells[1, col].Value.ToString(), Dataworksheet.Cells[row, col].Value.ToString());
                                }
                            }
                            dataFound = true;
                        }
                        if (dataFound)
                            break;
                    }
                }
            }
            catch(Exception ex)
            {
                LogHelper.Write("Error extacting data from test data sheet: " +ex.Message);
            }
            LogHelper.Write("Test Data extracted from file: "+ filePath);
            return columnData;
        }

    }
}
