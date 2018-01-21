using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using TyovuoroLista.DAL;

namespace TyovuoroLista.Controller
{
    public class CreatePeriodViewController
    {
        private readonly string periodFolder = ".\\Periodit\\";

        public void CreatePeriodSkeleton(DataGridView dgv, DateTime dt)
        {
            LisaaPaivat(dgv, dt);
        }

        private void LisaaPaivat(DataGridView dgv, DateTime dt)
        {
            dgv.Rows[2].Cells[0].Value = "Nimi";
            dgv.Rows[2].Cells[1].Value = "Puhelin";
            dgv.Rows[2].Cells[2].Value = "Sähköposti";

            for (int i = 3; i < dgv.ColumnCount; i++)
            {
                DateTime startDate = dt;
                var cultureInfo = new CultureInfo("fi-FI");
                var dateTimeInfo = cultureInfo.DateTimeFormat.GetDayName(dt.AddDays(i - 3).DayOfWeek).Substring(0, 2);

                if (dateTimeInfo == "ma")
                {
                    var weekNumber = GetIso8601WeekOfYear(dt.AddDays(i - 3));
                    dgv.Rows[0].Cells[i].Value = "Vk " + weekNumber;
                }
                dgv.Rows[1].Cells[i].Value = dateTimeInfo;
                dgv.Rows[2].Cells[i].Value = dt.AddDays(i - 3).ToString("d.M.");
            }
        }

        // https://blogs.msdn.microsoft.com/shawnste/2006/01/24/iso-8601-week-of-year-format-in-microsoft-net/
        // This presumes that weeks start with Monday.
        // Week 1 is the 1st week of the year with a Thursday in it.
        public static int GetIso8601WeekOfYear(DateTime time)
        {
            // Seriously cheat.  If its Monday, Tuesday or Wednesday, then it'll 
            // be the same week# as whatever Thursday, Friday or Saturday are,
            // and we always get those right
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            // Return the week of our adjusted day
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }

        public void SaveNewPeriod(DataGridView dgv, string fileName)
        {
            string fileToSave = periodFolder + fileName + ".bin";

            try
            {
                if (!File.Exists(fileToSave))
                {
                    dgv.Rows[0].Cells[0].Value = fileName;
                    DataTable dt = DataGridViewUtility.DataGridViewToDataTable(dgv);
                    PeriodiDAL.SaveDataTableToBinaryFile(dt, fileToSave);
                }
                else
                    throw new IOException("Saman niminen tiedosto on jo olemassa: " + fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public int ReturnDaysBetweenDaytimes(DateTime dtStart, DateTime dtEnd)
        {
            TimeSpan difference = dtEnd - dtStart;
            int daysBetween = (int)difference.TotalDays;
            return daysBetween;
        }
    }
}
