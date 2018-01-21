using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TyovuoroLista
{
    public class StaffShiftCounter
    {

        public void CountShiftsDaily(DataGridView dgv, DataGridViewCellEventArgs e)
        {            
            int col = e.ColumnIndex;
                int counterAmount = 4; // datagridview performance drops too much with over 4 counters if 1 year period

                if (col >= 3)
                {

                    Dictionary<string, string[]> valuesToCount = new Dictionary<string, string[]>();
                    Dictionary<string, int> counterValues = new Dictionary<string, int>();

                    //create counters with filters and amount
                    for (int i = 0; i < counterAmount; i++)
                    {
                        string counter = "counter" + i.ToString();
                        valuesToCount.Add(counter, GetShiftsToCount(dgv, counter));
                        counterValues.Add(counter, 0);
                    }

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Index >= 3)
                    {
                        for (int i = 0; i < counterAmount; i++)
                        {
                            string counter = "counter" + i.ToString();
                            string cellValue = null;

                            if (row.Cells[col].Value != null)
                                cellValue = row.Cells[col].Value.ToString();

                            if (cellValue != null && valuesToCount[counter] != null)
                                if (counterValues.ContainsKey(counter) && valuesToCount[counter].Contains(cellValue.ToLower()))
                                    counterValues[counter]++;
                        }

                        //if row has counter then add counter value to current row/column counterCell
                        var counterName = row.Cells[2].Value;

                        if (counterName != null && counterValues.ContainsKey(counterName.ToString()))
                        {
                            var count = counterValues[counterName.ToString()].ToString();
                            row.Cells[col].Value = count;
                        }
                    }
                }
            }            
        }

        private string[] GetShiftsToCount(DataGridView dgv, string key)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                var cellValue = row.Cells[2].Value;
                if (cellValue != null && cellValue.ToString().ToLower() == key)
                {
                    string toSplit = row.Cells[1].Value.ToString().ToLower();
                    string[] splitted = toSplit.Split(',');

                    return splitted;
                }
            }
            return null;
        }
    }
}
