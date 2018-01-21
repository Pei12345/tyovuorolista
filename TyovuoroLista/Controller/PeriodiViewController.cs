using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;
using TyovuoroLista.DAL;
using TyovuoroLista.View;

namespace TyovuoroLista.Controller
{
    public class PeriodiViewController
    {
        bool loggedIn = false;
        string pw = "index";

        string periodFilePath;
        string fileName;
        public string SelectedShiftRotation { get; set; }
        bool pasteShiftEnabled = false;
        bool showContactInfo = true;
        public bool Loading { get; private set; } = true;
        List<string[]> changedCellValues = new List<string[]>();
        Dictionary<string, string> comments = new Dictionary<string, string>();
        StaffHourlyCounter staffHourly = new StaffHourlyCounter();
        StaffShiftCounter staffShiftCounter = new StaffShiftCounter();

        public void LogIn(TextBox passwordTextBox, GroupBox editGroup, DataGridView dgv)
        {
            if(passwordTextBox.Text == pw)
                LoginTrue(editGroup, dgv);

            passwordTextBox.Text = string.Empty;
        }

        private void LoginTrue(GroupBox editGroup, DataGridView dgv)
        {
            editGroup.Enabled = true;
            dgv.ReadOnly = false;
            loggedIn = true;
        }

        public void LoginFalse(GroupBox editGroup, DataGridView dgv)
        {
            editGroup.Enabled = false;
            dgv.ReadOnly = true;
            loggedIn = false;
        }

        public DataTable LoadPeriod()
        {
            if(periodFilePath != null){
                string[] filePath = periodFilePath.Split('\\');
                fileName = filePath[filePath.Length - 1];
                LoadComments();
                return PeriodiDAL.LoadBinaryFileToDataTable(periodFilePath);
            }
            return null;
        }

        public List<string> LoadShiftSkeletons()
        {
            return PeriodiDAL.LoadPeriodSkeletonFile();
        }

        private void LoadComments()
        {            
            comments = PeriodiDAL.LoadDictionaryFromFile(fileName);
        }        

        public void SaveComments(DataGridView dgv, RichTextBox rTextBox)
        {
            DataGridViewCell currenCell = dgv.CurrentCell;

            string personName = dgv.Rows[currenCell.RowIndex].Cells[0].Value.ToString();
            string columnIndex = currenCell.ColumnIndex.ToString();
            string commentKey = personName + columnIndex;


            if (!comments.ContainsKey(commentKey) && !string.IsNullOrWhiteSpace(rTextBox.Text))
                comments.Add(commentKey, rTextBox.Text);

            else
            {
                comments.Remove(commentKey);

                if (!string.IsNullOrWhiteSpace(rTextBox.Text))
                    comments.Add(commentKey, rTextBox.Text);
            }
            PeriodiDAL.SaveDictionaryToFile(comments, fileName);
        }

        public void ShowComment(DataGridView dgv, RichTextBox rTextBox)
        {
            DataGridViewCell currentCell = dgv.CurrentCell;

            string name = dgv.Rows[currentCell.RowIndex]?.Cells[0]?.Value?.ToString();
            string columnIndex = currentCell.ColumnIndex.ToString();
            string commentKey = name + columnIndex;

            if (comments.ContainsKey(commentKey))
            {
                string kommentti = comments[commentKey];

                rTextBox.Text = kommentti;
            }
            else
                rTextBox.Text = null;
        }
        
        public void RefreshPeriod(DataGridView dgv)
        {
            int firstColumnToShow = 0;
            if (dgv.FirstDisplayedScrollingColumnIndex != -1)
                firstColumnToShow = dgv.FirstDisplayedScrollingColumnIndex;

            dgv.DataSource = LoadPeriod();
            SetPeriodDataGridViewColors(dgv);

            dgv.FirstDisplayedScrollingColumnIndex = firstColumnToShow;
        }

        public void SavePeriod(DataGridView dgv)
        {
            DataTable dt = LoadPeriod();
            AddChangesToDataTableToSave(dt);
            PeriodiDAL.SaveDataTableToBinaryFile(dt, periodFilePath);
            Logger.LogCellChanges(changedCellValues);
            changedCellValues.Clear();
            RefreshPeriod(dgv);
        }
                

        private void AddChangesToDataTableToSave(DataTable dt)
        {
            foreach (string[] changedCell in changedCellValues)
            {
                int row = int.Parse(changedCell[0]);
                int column = int.Parse(changedCell[1]);
                string newValue = changedCell[2];

                dt.Rows[row][column] = newValue;
            }
        }


        public void SetPeriodDataGridViewColors(DataGridView dgv)
        {            
            PeriodDataGridFormat.SetDataGridViewColors(dgv, comments);
        }

        public void ContactInfoVisible(DataGridView dgv)
        {
            if (dgv != null && dgv.Columns.Count > 2)
            {
                if (showContactInfo)
                    HideContactInfo(dgv);
                else
                    ShowContactInfo(dgv);
            }
        }
        
        private void ShowContactInfo(DataGridView dgv)
        {            
            dgv.Columns[1].Visible = true;
            dgv.Columns[2].Visible = true;
            showContactInfo = true;
        }

        public void HideContactInfo(DataGridView dgv)
        {
            if (dgv != null && dgv.Columns.Count > 2)
            {
                dgv.Columns[1].Visible = false;
                dgv.Columns[2].Visible = false;
                showContactInfo = false;
            }
        }        

        public void FreezeContactAndDayCells(DataGridView dgv)
        {
            if (dgv != null && dgv.Columns.Count > 2)
            {
                if (dgv.RowCount > 4 && dgv.ColumnCount > 3)
                {
                    dgv.Columns[2].Frozen = true;
                    dgv.Rows[3].Frozen = true;
                }
            }
        }

        public void SetStaffHourly(DataGridView period, DataGridView staffHourlyCount)
        {
            if (!Loading)                
                staffHourly.SetStaffHourlyCounts(period, staffHourlyCount);
        }
                
        public void SetStaffHourlyDataGridViewFormat(DataGridView dgv)
        {
            StaffCounterDataGridFormat.SetCellColors(dgv);
        }

        public void SetShiftCounterValues(DataGridView dgv, DataGridViewCellEventArgs e)
        {
            Loading = true;
            staffShiftCounter.CountShiftsDaily(dgv, e);
            Loading = false;
            
        }

        public void LoadingReady()
        {
            Loading = false;
        }

        public string[] LoadSavedPeriodFilePaths()
        {
            string[] periods = PeriodiDAL.GetSavedPeriodFilePaths();
            if(periods.Length != 0)
                periodFilePath = periods[0];
            return periods;
        }        

        public DataTable LoadSelectedPeriod(string path)
        {
            periodFilePath = path;   
            return LoadPeriod();
        }

        public void OpenCreatePeriodForm()
        {
            CreatePeriodView createPeriodView = new CreatePeriodView();
            createPeriodView.ShowDialog();
        }

        public void GenerateShiftRotationStartingFromSelectedCell(DataGridView dgv)
        {
            Loading = true;
            ShiftRotation sr = new ShiftRotation();
            sr.GenerateSelectedShiftRotation(dgv, SelectedShiftRotation);
            Loading = false;
        }

        public void AddChangedCellValue(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int row = e.RowIndex;
            int column = e.ColumnIndex;            
            string newValue = dgv.Rows[row].Cells[column].Value.ToString();
            string nameColumnValue = dgv.Rows[row].Cells[0].Value.ToString();
            string dayCellValue = dgv.Rows[2].Cells[column].Value.ToString();

            changedCellValues.Add(new string[] { row.ToString(), column.ToString(), newValue, nameColumnValue, dayCellValue });
        }

        public void PasteshiftsChecked()
        {
            if (!pasteShiftEnabled)
                pasteShiftEnabled = true;
            else
                pasteShiftEnabled = false;
        }

        public void CopyShiftFromList(ListBox lb)
        {
                Clipboard.SetText(lb.SelectedItem.ToString());
        }

        public void PasteFromClipboard(DataGridView dgv)
        {
            if (pasteShiftEnabled)
            {
                DataGridViewCell cell = dgv.CurrentCell;
                cell.Value = Clipboard.GetText(TextDataFormat.Text);
            }
        }

        public void AddRow(DataGridView dgv)
        {
            if (dgv != null)
            {
                DataTable dt = LoadSelectedPeriod(periodFilePath);
                dgv.DataSource = DataGridViewUtility.AddRow(dt);
                PeriodiDAL.SaveDataTableToBinaryFile(dt, periodFilePath);
            }
        }

        public void DeleteSelectedRow(DataGridView dgv)
        {
            int rowToDelete = dgv.CurrentRow.Index;

            if (rowToDelete > 3)
            {
                DialogResult dialogResult = MessageBox.Show("Haluatko varmasti poistaa rivin?", 
                    "Poista rivi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.OK)
                {
                DataTable dt = LoadSelectedPeriod(periodFilePath);
                dgv.DataSource = DataGridViewUtility.DeleteRowAt(dt, rowToDelete);
                PeriodiDAL.SaveDataTableToBinaryFile(dt, periodFilePath);                    
                }
            }
        }


        public void MoveRowUp(DataGridView dgv)
        {
            int dgvRowIndex = dgv.CurrentRow.Index;

            if (dgvRowIndex > 0)
            {
                DataTable dt = LoadSelectedPeriod(periodFilePath);
                dgv.DataSource = DataGridViewUtility.moveDTRow(dt, dgvRowIndex - 1, dgvRowIndex);
                PeriodiDAL.SaveDataTableToBinaryFile(dt, periodFilePath);
                dgv.CurrentCell = dgv.Rows[dgvRowIndex - 1].Cells[0];
                dgv.Rows[dgvRowIndex - 1].Selected = true;
            }
        }

        public void MoveRowDown(DataGridView dgv)
        {
            int dgvRowIndex = dgv.CurrentRow.Index;

            if (dgvRowIndex < dgv.Rows.Count -1)
            {
                DataTable dt = LoadSelectedPeriod(periodFilePath);
                dgv.DataSource = DataGridViewUtility.moveDTRow(dt, dgvRowIndex + 2, dgvRowIndex);
                PeriodiDAL.SaveDataTableToBinaryFile(dt, periodFilePath);
                dgv.CurrentCell = dgv.Rows[dgvRowIndex + 1].Cells[0];
                dgv.Rows[dgvRowIndex + 1].Selected = true;
            }
        }

        public void EmailShifts(DataGridView dgv)
        {
            ShiftEmail shiftEmail = new ShiftEmail();
            shiftEmail.SendShiftEmail(dgv);
        }

        public void PrintShifts(PrintPageEventArgs e, DataGridView dgv)
        {
            PrintDgv printDgv = new PrintDgv();
            printDgv.PrintDataGridView(e, dgv);
        }

        public void SetFirstShownColumn(DataGridView dgv)
        {
            int dayOfYearToday = DateTime.Now.DayOfYear;
            string yearToday = DateTime.Now.Year.ToString();

            if (dayOfYearToday < dgv.ColumnCount && periodFilePath.Contains(yearToday))
                if(dgv.Columns[dayOfYearToday].Visible)
                    dgv.FirstDisplayedScrollingColumnIndex = dayOfYearToday;
        }

        public void SetHourCounterValue(Label hourCountLabel, DataGridView dgv)
        {
            string hourCount = "Valittujen vuorojen tuntimäärä: " + staffHourly.CountSelectedCellsHours(dgv).ToString();
            hourCountLabel.Text = hourCount;
        }

    }
}
