using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TyovuoroLista
{
    public class PrintDgv
    {
        public void PrintDataGridView(PrintPageEventArgs e, DataGridView dgv)
        {
            try
            {
                int picWidth = 1350;
                int picHeight = 0; 

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    picHeight += row.Height;
                }

                float mmpi = 2.54f;
                int dpi = 140;
                
                using (Bitmap dgvPic = new Bitmap((int)(210 / mmpi * dpi), (int)(297 / mmpi * dpi), 0, System.Drawing.Imaging.PixelFormat.Format32bppPArgb,IntPtr.Zero))
                {
                    dgvPic.SetResolution(dpi, dpi);                    

                    dgv.DrawToBitmap(dgvPic, new Rectangle(30, 30, picWidth, picHeight));
                    e.Graphics.DrawImage(dgvPic, 0, 0);
                }      
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}
