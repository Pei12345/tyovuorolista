using System;
using System.Drawing.Printing;
using System.Windows.Forms;
using TyovuoroLista.Controller;

namespace TyovuoroLista.View
{
    public partial class PeriodiView : Form
    {
        PeriodiViewController periodiController = new PeriodiViewController();
                

        public PeriodiView()
        {
            InitializeComponent();
        }

        private void PeriodiView_Load(object sender, EventArgs e)
        {
            this.Hide();
            periodiController.LoginFalse(groupBox_editingControls, dataGridView_showSchedule);
            DataGridViewUtility.DataGridViewDoubleBuffer(dataGridView_showSchedule);
            DataGridViewUtility.DataGridViewDoubleBuffer(dataGridView_workerCountByHours);           
            comboBox_loadPeriod.DataSource = periodiController.LoadSavedPeriodFilePaths();
            comboBox_savedShiftSkeletons.DataSource = periodiController.LoadShiftSkeletons();
            dataGridView_showSchedule.DataSource = periodiController.LoadPeriod();
            periodiController.HideContactInfo(dataGridView_showSchedule);
            periodiController.LoadingReady();
            periodiController.SetFirstShownColumn(dataGridView_showSchedule);
            this.Show();
        }

        private void button_saveShifts_Click(object sender, EventArgs e)
        {
            periodiController.SavePeriod(dataGridView_showSchedule);
        }

        private void button_refreshPeriod_Click(object sender, EventArgs e)
        {
            periodiController.RefreshPeriod(dataGridView_showSchedule);
        }

        private void button_showContactInfo_Click(object sender, EventArgs e)
        {
            periodiController.ContactInfoVisible(dataGridView_showSchedule);
        }

        private void dataGridView_showSchedule_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            periodiController.SetStaffHourly(dataGridView_showSchedule, dataGridView_workerCountByHours);
            periodiController.SetStaffHourlyDataGridViewFormat(dataGridView_workerCountByHours);
            dataGridView_workerCountByHours.CurrentCell = null;
            periodiController.ShowComment(dataGridView_showSchedule, richTextBox_comment);
        }

        public void comboBox_loadPeriod_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string path = comboBox_loadPeriod.SelectedValue.ToString();
            dataGridView_showSchedule.DataSource = periodiController.LoadSelectedPeriod(path);
            periodiController.SetFirstShownColumn(dataGridView_showSchedule);
        }

        private void dataGridView_showSchedule_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            periodiController.SetPeriodDataGridViewColors(dataGridView_showSchedule);
            periodiController.FreezeContactAndDayCells(dataGridView_showSchedule);
        }

        private void dataGridView_showSchedule_KeyDown(object sender, KeyEventArgs e)
        {
            DataGridViewUtility.KeyDown(sender, e);
        }

        private void button_openCreateNewPeriod_Click(object sender, EventArgs e)
        {
            periodiController.OpenCreatePeriodForm();
        }

        private void comboBox_savedShiftSkeletons_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox_savedShiftSkeletons.SelectedIndex != -1)
                periodiController.SelectedShiftRotation = comboBox_savedShiftSkeletons?.SelectedItem.ToString();
        }

        private void button_addShiftsFromSkeleton_Click(object sender, EventArgs e)
        {
            periodiController.GenerateShiftRotationStartingFromSelectedCell(dataGridView_showSchedule);
        }

        private void dataGridView_showSchedule_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            periodiController.AddChangedCellValue(sender, e);

            if (!periodiController.Loading)
            {
                periodiController.SetShiftCounterValues(dataGridView_showSchedule, e);
                periodiController.SetPeriodDataGridViewColors(dataGridView_showSchedule);
            }
        }

        private void button_saveComment_Click(object sender, EventArgs e)
        {
            periodiController.SaveComments(dataGridView_showSchedule, richTextBox_comment);
            periodiController.SetPeriodDataGridViewColors(dataGridView_showSchedule);
        }

        private void button_removeComment_Click(object sender, EventArgs e)
        {
            richTextBox_comment.Clear();
            periodiController.SaveComments(dataGridView_showSchedule, richTextBox_comment);
            periodiController.SetPeriodDataGridViewColors(dataGridView_showSchedule);
        }

        private void checkBox_copyShift_CheckedChanged(object sender, EventArgs e)
        {
            periodiController.PasteshiftsChecked();
        }

        private void listBox_shifts_SelectedIndexChanged(object sender, EventArgs e)
        {
            periodiController.CopyShiftFromList(listBox_shifts);
        }

        private void dataGridView_showSchedule_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            periodiController.PasteFromClipboard(dataGridView_showSchedule);
            periodiController.SetStaffHourly(dataGridView_showSchedule, dataGridView_workerCountByHours);
            periodiController.SetStaffHourlyDataGridViewFormat(dataGridView_workerCountByHours);
        }

        private void button_moveRowUp_Click(object sender, EventArgs e)
        {
            periodiController.MoveRowUp(dataGridView_showSchedule);
        }

        private void button_moveRowDown_Click(object sender, EventArgs e)
        {
            periodiController.MoveRowDown(dataGridView_showSchedule);
        }

        private void button_emailShifts(object sender, EventArgs e)
        {
            periodiController.EmailShifts(dataGridView_showSchedule);
        }

        private void button_signIn_Click(object sender, EventArgs e)
        {
            periodiController.LogIn(textBox_password, groupBox_editingControls, dataGridView_showSchedule);
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            periodiController.LoginFalse(groupBox_editingControls, dataGridView_showSchedule);
        }

        private void textBox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                periodiController.LogIn(textBox_password, groupBox_editingControls, dataGridView_showSchedule);
        }

        private void button_addRow_Click(object sender, EventArgs e)
        {
            periodiController.AddRow(dataGridView_showSchedule);
        }

        private void button_removeSelectedRow_Click(object sender, EventArgs e)
        {
            periodiController.DeleteSelectedRow(dataGridView_showSchedule);
        }

        private void button_printShifts_Click(object sender, EventArgs e)
        {
            printDocument_shifts.DefaultPageSettings.Landscape = true;
            printDocument_shifts.Print();
        }

        private void printDocument_shifts_PrintPage(object sender, PrintPageEventArgs e)
        {            
            periodiController.PrintShifts(e, dataGridView_showSchedule);
            printDocument_shifts.Dispose();
        }

        private void dataGridView_showSchedule_SelectionChanged(object sender, EventArgs e)
        {
            periodiController.SetHourCounterValue(label_hourCount, dataGridView_showSchedule);
        }
    }
}
