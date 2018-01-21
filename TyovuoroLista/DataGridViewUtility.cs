using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace TyovuoroLista
{
    public static class DataGridViewUtility
    {
        public static void DataGridViewDoubleBuffer(DataGridView dgv)
        {
            try
            {
                if (!SystemInformation.TerminalServerSession)
                {
                    Type dgvType = dgv.GetType();
                    PropertyInfo propInfo = dgvType.GetProperty("DoubleBuffered",
                      BindingFlags.Instance | BindingFlags.NonPublic);
                    propInfo.SetValue(dgv, true, null);
                }
            }
            catch { }
        }
        
        public static void KeyDown(object sender, KeyEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            
            if (!dgv.ReadOnly)
            {             
                if (e.KeyData == (Keys.Control | Keys.V))
                {
                    dgv.CurrentCell.Value = Clipboard.GetText();
                }

                if (e.KeyCode == Keys.Delete)
                    dgv.CurrentCell.Value = string.Empty;
            }
        }

        public static DataTable DataGridViewToDataTable(DataGridView dgv)
        {
            try {
                DataTable dt = new DataTable();

                for (int i = 0; i < dgv.ColumnCount; i++)
                {
                    dt.Columns.Add();
                }

                for (int rivi = 0; rivi < dgv.RowCount; rivi++)
                {
                    DataRow dataRow = dt.NewRow();

                    for (int column = 0; column < dgv.ColumnCount; column++)
                    {
                        dataRow[column] = dgv.Rows[rivi].Cells[column].Value?.ToString();
                    }
                    dt.Rows.Add(dataRow);
                }
                return dt;
            }
            catch { return null; }
        }

        public static DataTable moveDTRow(DataTable dt, int toIndex, int fromIndex)
        {
            DataRow oldRow = dt.Rows[fromIndex];
            DataRow newRow = dt.NewRow();
            newRow.ItemArray = oldRow.ItemArray;
            dt.Rows.InsertAt(newRow, toIndex);
            dt.Rows.Remove(oldRow);

            return dt;
        }

        public static DataTable AddRow(DataTable dt)
        {
            DataRow newRow = dt.NewRow();
            dt.Rows.Add(newRow);

            return dt;
        }

        public static DataTable DeleteRowAt(DataTable dt, int rowToDelete)
        {
            dt.Rows.RemoveAt(rowToDelete);
            return dt;
        }
    }
}
