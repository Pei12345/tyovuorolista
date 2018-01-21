using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TyovuoroLista
{
    public class ShiftRotation
    {
        // holidays, free days etc.
        string[] notToOverride = new string[] {"k", "tyl/yt", "t", "muu" };

        public void GenerateSelectedShiftRotation(DataGridView dgv, string selectedRotation)
        {
            if (!string.IsNullOrEmpty(selectedRotation))
            {
                DataGridViewCell cell = dgv.CurrentCell;

                char[] kierto = selectedRotation.ToCharArray();
                int vuoro = 0;

                for (int i = cell.ColumnIndex; i < dgv.ColumnCount; i++)
                {
                    if (!notToOverride.Contains(dgv.Rows[cell.RowIndex].Cells[i].Value.ToString().ToLower()))
                        dgv.Rows[cell.RowIndex].Cells[i].Value = kierto[vuoro].ToString();

                    vuoro++;
                    if (vuoro == kierto.Length)
                        vuoro = 0;
                }
            }
        }

    }
}
