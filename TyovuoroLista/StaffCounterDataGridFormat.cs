using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TyovuoroLista
{
    public static class StaffCounterDataGridFormat
    {
        public static void SetCellColors(DataGridView dgv)
        {
            SetStaffCountColors(dgv);
            SetColumnWidths(dgv);
        }


        private static void SetStaffCountColors(DataGridView dgv)
        {
            for (int solu = 1; solu < dgv.ColumnCount; solu++)
            {
                int henkilomaara = int.Parse(dgv?.Rows[0]?.Cells[solu]?.Value.ToString());

                if (henkilomaara == 0)
                    dgv.Rows[0].Cells[solu].Style.BackColor = Color.Black;
                else if (henkilomaara < 2)
                    dgv.Rows[0].Cells[solu].Style.BackColor = Color.Red;
                else if (henkilomaara == 2)
                    dgv.Rows[0].Cells[solu].Style.BackColor = Color.BlanchedAlmond;
                else if (henkilomaara < 5)
                    dgv.Rows[0].Cells[solu].Style.BackColor = Color.LightGreen;
                else
                    dgv.Rows[0].Cells[solu].Style.BackColor = Color.YellowGreen;
            }
        }        
        private static void SetColumnWidths(DataGridView dgv)
        {
            for(int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].Width = 44;
            }
        }
    }
}
