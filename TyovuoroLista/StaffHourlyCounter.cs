using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace TyovuoroLista
{
    public class StaffHourlyCounter
    {    
        public void SetStaffHourlyCounts(DataGridView period, DataGridView staffHourlyCount)
        {
            DataTable staffHourly = AddHourlyCountValuesToDT(period);
            staffHourlyCount.RowCount = 1;
            staffHourlyCount.ColumnCount = 25;
                        
            for(int i = 0; i < staffHourly.Columns.Count; i++)
            {
                staffHourlyCount.Columns[i].HeaderText = staffHourly.Columns[i].ColumnName;
                staffHourlyCount.Rows[0].Cells[i].Value = staffHourly.Rows[0][i].ToString();
            }
        }

        private DataTable AddHourlyCountValuesToDT(DataGridView dgv)
        {
            DataTable dtWithHourColumns = CreateDtWithHourColumns();
            Dictionary<string, int> staffHourly = CountStaffHourly(dgv);

            DataRow row = dtWithHourColumns.Rows.Add();
            row["Tunnit"] = "Töissä";
            foreach(DataColumn column in dtWithHourColumns.Columns)
            {
                if (staffHourly.ContainsKey(column.ColumnName))
                    row[column] = staffHourly[column.ColumnName].ToString();
            }

            return dtWithHourColumns;
        }

        //working day 24h from 6:00 to 6:00
        private DataTable CreateDtWithHourColumns()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Tunnit");

            for (int i = 6; i <= 24; i++)
                dt.Columns.Add(i.ToString());

            for (int i = 1; i <= 5; i++)
                dt.Columns.Add(i.ToString());

            return dt;
        }

        private Dictionary<string, int> CountStaffHourly(DataGridView dgv)
        {
            Dictionary<string, int> staffHourly = new Dictionary<string, int>();

            for (int i = 1; i < 25; i++)
                staffHourly.Add(i.ToString(), 0);

            int column = dgv.CurrentCell.ColumnIndex;

            for (int rivi = 1; rivi < dgv.RowCount; rivi++)
            {
                string cellValue = dgv?.Rows[rivi]?.Cells[column]?.Value?.ToString();

                List<int> shiftHours = GetHoursOfShift(cellValue);

                if (shiftHours != null)
                {
                    foreach (int i in shiftHours)
                    {
                        int hour = i;
                        if (i == 0)
                            hour = 24;

                        staffHourly[hour.ToString()]++;
                    }
                }
            }
            return staffHourly;
        }


        public List<int> GetHoursOfShift(string shiftToCheck)
        {
            List<int> returnValue = null;

            if (!string.IsNullOrWhiteSpace(shiftToCheck) && shiftToCheck.Contains(":"))
            {
                try
                {
                    string shift = shiftToCheck.Replace(" ", string.Empty);

                    string startTime = shift.Split('-')[0];
                    string endTime = shift.Split('-')[1];

                    DateTime shiftStartTime = DateTime.ParseExact(startTime, "HH:mm", CultureInfo.InvariantCulture);
                    DateTime shiftEndTime = DateTime.ParseExact(endTime, "HH:mm", CultureInfo.InvariantCulture);

                    if (shiftStartTime.Minute >= 30)
                        shiftStartTime = shiftStartTime.AddHours(0.5);

                    //if day changes during the shift (example: 22:00 - 06:00)
                    if (shiftEndTime < shiftStartTime)
                        shiftEndTime = shiftEndTime.AddDays(1);

                    returnValue = new List<int>();
                                        
                    for (DateTime date = shiftStartTime; shiftEndTime.CompareTo(date) > 0; date = date.AddHours(1.0))
                    {
                        returnValue.Add(date.Hour);
                    }
                }
                catch { }
            }

            return returnValue;
        }
                
        public double GetShiftDuration(string shiftToCheck)
        {
            double duration = 0;

            if (!string.IsNullOrWhiteSpace(shiftToCheck) && shiftToCheck.Contains(":"))
            {
                try
                {
                    string shift = shiftToCheck.Replace(" ", string.Empty);

                    string shiftStart = shift.Split('-')[0];
                    string ShiftEnd = shift.Split('-')[1];

                    DateTime shiftStartTime = DateTime.ParseExact(shiftStart, "HH:mm", CultureInfo.InvariantCulture);
                    DateTime ShiftEndTime = DateTime.ParseExact(ShiftEnd, "HH:mm", CultureInfo.InvariantCulture);

                    if (ShiftEndTime < shiftStartTime)
                        ShiftEndTime = ShiftEndTime.AddDays(1);

                    duration = (ShiftEndTime - shiftStartTime).TotalHours;

                    // if shift is 7,5 hours the pay is for 8 hours so duration will be counted as 8 hours
                    if (duration == 7.5)
                        duration = 8;
                }
                catch { }
            }
            return duration;
        }


        public double CountSelectedCellsHours(DataGridView dgv)
        {
            double duration = 0;

            try
            {
                foreach (DataGridViewCell cell in dgv.SelectedCells)
                    duration += GetShiftDuration(cell.Value.ToString());
            }
            catch { }
            return duration;
        }


    }
}
