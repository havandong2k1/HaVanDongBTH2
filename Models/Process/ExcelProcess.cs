using System.Data;
using OfficeOpenXml;
namespace HaVanDongBTH2.Models.Process
{
public class Excelprocess
    {
    public DataTable ExcelToDataTable(string strPath)
        {
            FileInfo fi = new ExcelPackage(strPath);
            ExcelPackage excelPackage = new ExcelPackage(fi);
            DataTable dt = new DateTable();
            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[0];
            if(worksheet.Dimension == null)
            {
                return dt;
            }

            List<String> columnNames = new List<string>();
            int currentColumns = 1;
            foreach (var cell in worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column]
            {
                string columnName = cell.Text.Trim();
                if (cell.Start.Column != currentColumns)
                {
                    columnNames.Add("Header_"+ currentColumn);
                    dt.Columns.add(("Header_"+ currentColumn);
                    currentColumns++;
                }
                columnNames.Add(columnName);
                int occurrences = columnNames.Count(x => x.Equals(columnName));
                if (occurrences >1)
                {
                    columnName= columnName + "_" + occurrences; 
                }
                dt.Columns.Add(columnName);
                currentColumns++;
            }
            for (int i = 2 ;i <= worksheet.Dimension.End.Row; i++ )
            {
               var row = worksheet.Cells[i,1,i, worksheet.Dimension.End.Column];
                foreach (var cell in row)
                {
                    newRow[cell.Start.Column - 1] = cell.Text;
                }
                dt.Rows.Add(newRow);
            }
            return dt;
         }
      }
}