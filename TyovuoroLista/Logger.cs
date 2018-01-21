using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TyovuoroLista
{
    public static class Logger
    {
        static string cellChangeLogFile = ".\\cellchangelog.log";

        public static void LogCellChanges(List<string[]> changedCellValues)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(File.Open(cellChangeLogFile, FileMode.Append)))
                {
                    foreach (string[] changedCell in changedCellValues)
                    {
                        StringBuilder sb = new StringBuilder();

                        int row = int.Parse(changedCell[0]);
                        int column = int.Parse(changedCell[1]);
                        string newValue = changedCell[2];
                        string nameColumnValue = changedCell[3];
                        string dayCellValue = changedCell[4];

                        sb.Append(DateTime.Now);
                        sb.Append('\t');
                        sb.Append(nameColumnValue);
                        sb.Append('\t');
                        sb.Append(row.ToString());
                        sb.Append('\t');
                        sb.Append(column.ToString());
                        sb.Append('\t');
                        sb.Append(dayCellValue);
                        sb.Append('\t');
                        sb.Append(newValue);
                        sb.Append('\t');
                        sb.Append(Environment.MachineName);
                        sb.Append('\t');
                        sb.Append(Environment.UserName);

                        sb.Replace("\n", string.Empty);

                        sw.WriteLine(sb.ToString());
                    }
                }
            }
            catch { }

        }
    }
}
