using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TyovuoroLista
{
    public class ShiftEmail
    {
        Emailer emailer = new Emailer();

        public void SendShiftEmail(DataGridView dgv)
        {
            List<string[]> addressAndMessages = ParseEmailAddressAndMessage(dgv);
            string subject = "Työvuorot LS JKL";

            foreach(string[] msg in addressAndMessages)
            {
                emailer.SendMail(msg[0], subject, msg[1], true);
            }
        }


        private List<string[]> ParseEmailAddressAndMessage(DataGridView dgv)
        {
            List<string[]> emailAddressAndMessage = new List<string[]>();
            StringBuilder sb = new StringBuilder();
            List<int> selectedRows = new List<int>();
            List<int> selectedColumns = new List<int>();

            int emailAddressColumNumber = 2;
            int dayColumn = 1;
            int dateColumn = 2;

            //parse email, date and shifts from datagridview
            foreach (DataGridViewCell cell in dgv.SelectedCells)
            {
                if (!string.IsNullOrWhiteSpace(dgv.Rows[cell.RowIndex].Cells[emailAddressColumNumber].Value.ToString()))
                {
                    if (!selectedRows.Contains(cell.RowIndex))
                        selectedRows.Add(cell.RowIndex);

                    selectedColumns.Add(cell.ColumnIndex);
                }
            }
            
            //create and send shifts email
            if (selectedColumns.Count > 0)
            {
                selectedColumns.Sort();

                int startColumn = selectedColumns[0];
                int endColumn = selectedColumns[selectedColumns.Count - 1];

                foreach (int rivi in selectedRows)
                {
                    sb.Append(dgv.Rows[rivi].Cells[0].Value.ToString());
                    sb.Append("<br />");
                    sb.Append("<br />");
                    sb.Append("<br />");

                    for (int column = startColumn; column <= endColumn; column++)
                    {
                        sb.Append(dgv.Rows[dayColumn].Cells[column].Value.ToString());
                        sb.Append(" ");
                        sb.Append(dgv.Rows[dateColumn].Cells[column].Value.ToString().PadRight(7));
                        sb.Append(": ");
                        sb.Append(dgv.Rows[rivi].Cells[column].Value.ToString());
                        sb.Append("<br />");
                    }
                    emailAddressAndMessage.Add(new string[] { dgv.Rows[rivi].Cells[emailAddressColumNumber].Value.ToString(), sb.ToString() });
                    sb.Clear();

                }
            }
            return emailAddressAndMessage;
        }

    }
}
