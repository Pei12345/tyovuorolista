using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TyovuoroLista
{
    public static class PeriodDataGridFormat
    {
        public static void SetDataGridViewColors(DataGridView DGV, Dictionary<string,string> comments)
        {
            try
            {
                SetColorOfWeekendCells(DGV);
                SetCellColors(DGV);
                SetColorOfMonths(DGV.Rows[2]);
                SetColorOfCommentedCell(DGV, comments);
                MakeBorderRow(DGV);
            }
            catch { }
        }

        private static void SetColorOfWeekendCells(DataGridView DGV)
        {
            int rowOfDayName = 1;
            for (int i = 0; i < DGV.ColumnCount; i++)
            {
                if (DGV.Rows[rowOfDayName].Cells[i].Value?.ToString() == "su" || DGV.Rows[rowOfDayName].Cells[i].Value?.ToString() == "la")
                {
                    foreach (DataGridViewRow row in DGV.Rows)
                    {
                        row.Cells[i].Style.BackColor = Color.LightGray;
                    }
                }
                else
                    foreach (DataGridViewRow row in DGV.Rows)
                    {
                        row.Cells[i].Style.BackColor = Color.Empty;
                    }
            }
        }

        private static void SetCellColors(DataGridView DGV)
        {
            foreach (DataGridViewRow row in DGV.Rows)
            {
                for (int column = 0; column < DGV.ColumnCount; column++)
                {
                    if (column > 2 && !string.IsNullOrEmpty(row.Cells[column].Value?.ToString()))
                    {
                        SetColorOfSickLeave(row, column);
                        SetColorIfMorningShiftAfterNightShift(DGV, row, column);
                    }
                    SetColorOfFreeDays(row, column);                    
                }
            }
        }


        private static void SetColorOfSickLeave(DataGridViewRow row, int column)
        {
            if (row.Cells[column].Value.ToString().ToLower().Contains("s"))
            {
                row.Cells[column].Style.ForeColor = Color.Red;
            }
            else
                row.Cells[column].Style.ForeColor = Color.Empty;
        }

        private static void SetColorIfMorningShiftAfterNightShift(DataGridView DGV, DataGridViewRow row, int column)
        {
            string cellOnLeftSide = row.Cells?[column - 1].Value?.ToString().Replace(" ", string.Empty);

            if (!string.IsNullOrWhiteSpace(cellOnLeftSide) && cellOnLeftSide.Contains('-'))
            {
                string[] cellOnLeftSideSplitted = cellOnLeftSide.Split('-');
                string[] morningStartHours = { "06", "07", "08", "09", "10", "P", "A", "H" };
                string[] nightEndTime = { "01", "02", "03", "04", "05", "06", "Y", "Y1", "PY", "PY1" };

                if (nightEndTime.Contains(cellOnLeftSideSplitted[1].ToString().Substring(0, 2)))
                {
                    if (row.Cells[column].Value.ToString().Length > 1 && morningStartHours.Contains(row.Cells[column].Value.ToString().Substring(0, 2)))
                        row.Cells[column].Style.BackColor = Color.Red;
                }
                else
                {
                    if (DGV.Rows[1].Cells[column].Value?.ToString() == "su" || DGV.Rows[1].Cells[column].Value?.ToString() == "la")
                        row.Cells[column].Style.BackColor = Color.LightGray;
                    else
                        row.Cells[column].Style.BackColor = Color.Empty;
                }
            }
        }

        private static void SetColorOfFreeDays(DataGridViewRow row, int column)
        {
            if (row.Cells[column].Value?.ToString().ToLower() == "v")            
                row.Cells[column].Style.BackColor = Color.Yellow;            

            if (row.Cells[column].Value?.ToString().ToLower() == "k")            
                row.Cells[column].Style.BackColor = Color.LightGreen;            

            if (row.Cells[column].Value?.ToString().ToLower() == "tyl/yt")            
                row.Cells[column].Style.BackColor = Color.DarkOrange;
            
            if (row.Cells[column].Value?.ToString().ToLower() == "t")            
                row.Cells[column].Style.BackColor = Color.LightBlue;            

            if (row.Cells[column].Value?.ToString().ToLower() == "arkipyhä")            
                row.Cells[column].Style.BackColor = Color.DarkOrange;

            if (row.Cells[column].Value?.ToString().ToLower() == "muu")
                row.Cells[column].Style.BackColor = Color.DarkBlue;
        }

        private static void SetColorOfMonths(DataGridViewRow row)
        {
            for(int i = 3;i < row.Cells.Count; i++)
            {
                string[] cellValueSplitted = row.Cells[i]?.Value.ToString().Split('.');
                if (cellValueSplitted.Length > 1)
                {
                    int monthNumber = int.Parse(cellValueSplitted[1]);
                    row.Cells[i].Style.BackColor = GetMonthColor(monthNumber);
                }
            }
        }

        private static void SetColorOfCommentedCell(DataGridView DGV, Dictionary<string, string> comments)
        {
            foreach (DataGridViewRow row in DGV.Rows)
            {
                for (int i = 0; i < DGV.ColumnCount; i++)
                {
                    DataGridViewCell currenCell = row.Cells[i];

                    if (row.Cells[0].Value != null)
                    {

                        string name = DGV.Rows[currenCell.RowIndex]?.Cells[0]?.Value?.ToString();
                        string columnIndex = currenCell.ColumnIndex.ToString();
                        string commentKey = name + columnIndex;

                        if (comments.ContainsKey(commentKey))
                        {
                            row.Cells[i].Style.BackColor = Color.Bisque;
                        }
                    }
                }
            }
        }

        private static Color GetMonthColor(int monthNumber)
        {            
            switch (monthNumber)
            {
                case 1:
                    return Color.LightBlue;
                case 2:
                    return Color.LightSkyBlue;
                case 3:
                    return Color.LightSalmon;
                case 4:
                    return Color.LightCoral;
                case 5:
                    return Color.LightGoldenrodYellow;
                case 6:
                    return Color.YellowGreen;
                case 7:
                    return Color.OrangeRed;
                case 8:
                    return Color.RosyBrown;
                case 9:
                    return Color.SandyBrown;
                case 10:
                    return Color.BlanchedAlmond;
                case 11:
                    return Color.LightSlateGray;
                case 12:
                    return Color.PaleVioletRed;
            }
            return Color.Empty;
        }
                
        private static void MakeBorderRow(DataGridView dgv)
        {
            foreach(DataGridViewRow row in dgv.Rows) {
                if(row.Cells[0].Value.ToString() == "x")
                {
                    row.Height = 2;
                    for(int i = 0; i < dgv.ColumnCount; i++)
                    {
                        row.Cells[i].Style.BackColor = Color.SteelBlue;
                    }
                }

            }
        }


    }
}
