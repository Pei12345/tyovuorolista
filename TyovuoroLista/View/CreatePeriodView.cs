using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TyovuoroLista.Controller;

namespace TyovuoroLista.View
{
    public partial class CreatePeriodView : Form
    {
        CreatePeriodViewController cretePeriodController = new CreatePeriodViewController();
        DateTime dtNow = DateTime.Now;

        public CreatePeriodView()
        {
            InitializeComponent();
        }

        private void CreatePeriodView_Load(object sender, EventArgs e)
        {
            DataGridViewUtility.DataGridViewDoubleBuffer(dataGridView_period);
            dateTimePicker_periodStartDate.Value = new DateTime(dtNow.Year, 1, 1);
            dateTimePicker_periodEndDate.Value = new DateTime(dtNow.Year, 12, 31);
        }

        private void button_createPeriod_Click(object sender, EventArgs e)
        {
            dataGridView_period.ColumnCount = int.Parse(textBox_columnCount.Text);
            dataGridView_period.RowCount = int.Parse(textBox_rowCount.Text);
            cretePeriodController.CreatePeriodSkeleton(dataGridView_period, dateTimePicker_periodStartDate.Value);
        }

        private void button_savePeriod_Click(object sender, EventArgs e)
        {
            cretePeriodController.SaveNewPeriod(dataGridView_period, textBox_periodName.Text);
        }

        private void dateTimePicker_periodEndDate_ValueChanged(object sender, EventArgs e)
        {
            int columns = cretePeriodController.ReturnDaysBetweenDaytimes(dateTimePicker_periodStartDate.Value, dateTimePicker_periodEndDate.Value) + 4;
            textBox_columnCount.Text = columns.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int columns = cretePeriodController.ReturnDaysBetweenDaytimes(dateTimePicker_periodStartDate.Value, dateTimePicker_periodEndDate.Value) + 4;
            textBox_columnCount.Text = columns.ToString();
        }
    }
}
