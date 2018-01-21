namespace TyovuoroLista.View
{
    partial class PeriodiView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer_controlsAndDataGridViews = new System.Windows.Forms.SplitContainer();
            this.groupBox_DataGridViewOptions = new System.Windows.Forms.GroupBox();
            this.button_printShifts = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label_PeriodToShow = new System.Windows.Forms.Label();
            this.comboBox_loadPeriod = new System.Windows.Forms.ComboBox();
            this.button_refreshPeriod = new System.Windows.Forms.Button();
            this.button_showContactInfo = new System.Windows.Forms.Button();
            this.groupBox_comments = new System.Windows.Forms.GroupBox();
            this.button_removeComment = new System.Windows.Forms.Button();
            this.button_saveComment = new System.Windows.Forms.Button();
            this.richTextBox_comment = new System.Windows.Forms.RichTextBox();
            this.groupBox_kirjaudu = new System.Windows.Forms.GroupBox();
            this.button_signIn = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.groupBox_editingControls = new System.Windows.Forms.GroupBox();
            this.button_openCreateNewPeriod = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_addShiftsFromSkeleton = new System.Windows.Forms.Button();
            this.comboBox_savedShiftSkeletons = new System.Windows.Forms.ComboBox();
            this.button_saveShifts = new System.Windows.Forms.Button();
            this.button_addRow = new System.Windows.Forms.Button();
            this.button_removeSelectedRow = new System.Windows.Forms.Button();
            this.button_moveRowUp = new System.Windows.Forms.Button();
            this.button_moveRowDown = new System.Windows.Forms.Button();
            this.checkBox_copyShift = new System.Windows.Forms.CheckBox();
            this.listBox_shifts = new System.Windows.Forms.ListBox();
            this.splitContainer_dataGridViews = new System.Windows.Forms.SplitContainer();
            this.dataGridView_showSchedule = new System.Windows.Forms.DataGridView();
            this.splitContainer_hourlyWorkerCount = new System.Windows.Forms.SplitContainer();
            this.dataGridView_workerCountByHours = new System.Windows.Forms.DataGridView();
            this.label_hourCount = new System.Windows.Forms.Label();
            this.printDocument_shifts = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_controlsAndDataGridViews)).BeginInit();
            this.splitContainer_controlsAndDataGridViews.Panel1.SuspendLayout();
            this.splitContainer_controlsAndDataGridViews.Panel2.SuspendLayout();
            this.splitContainer_controlsAndDataGridViews.SuspendLayout();
            this.groupBox_DataGridViewOptions.SuspendLayout();
            this.groupBox_comments.SuspendLayout();
            this.groupBox_kirjaudu.SuspendLayout();
            this.groupBox_editingControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_dataGridViews)).BeginInit();
            this.splitContainer_dataGridViews.Panel1.SuspendLayout();
            this.splitContainer_dataGridViews.Panel2.SuspendLayout();
            this.splitContainer_dataGridViews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_showSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_hourlyWorkerCount)).BeginInit();
            this.splitContainer_hourlyWorkerCount.Panel1.SuspendLayout();
            this.splitContainer_hourlyWorkerCount.Panel2.SuspendLayout();
            this.splitContainer_hourlyWorkerCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_workerCountByHours)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer_controlsAndDataGridViews
            // 
            this.splitContainer_controlsAndDataGridViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_controlsAndDataGridViews.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer_controlsAndDataGridViews.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_controlsAndDataGridViews.Name = "splitContainer_controlsAndDataGridViews";
            // 
            // splitContainer_controlsAndDataGridViews.Panel1
            // 
            this.splitContainer_controlsAndDataGridViews.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitContainer_controlsAndDataGridViews.Panel1.Controls.Add(this.groupBox_DataGridViewOptions);
            this.splitContainer_controlsAndDataGridViews.Panel1.Controls.Add(this.groupBox_comments);
            this.splitContainer_controlsAndDataGridViews.Panel1.Controls.Add(this.groupBox_kirjaudu);
            this.splitContainer_controlsAndDataGridViews.Panel1.Controls.Add(this.groupBox_editingControls);
            // 
            // splitContainer_controlsAndDataGridViews.Panel2
            // 
            this.splitContainer_controlsAndDataGridViews.Panel2.Controls.Add(this.splitContainer_dataGridViews);
            this.splitContainer_controlsAndDataGridViews.Size = new System.Drawing.Size(1630, 1008);
            this.splitContainer_controlsAndDataGridViews.SplitterDistance = 251;
            this.splitContainer_controlsAndDataGridViews.TabIndex = 0;
            // 
            // groupBox_DataGridViewOptions
            // 
            this.groupBox_DataGridViewOptions.Controls.Add(this.button_printShifts);
            this.groupBox_DataGridViewOptions.Controls.Add(this.button1);
            this.groupBox_DataGridViewOptions.Controls.Add(this.label_PeriodToShow);
            this.groupBox_DataGridViewOptions.Controls.Add(this.comboBox_loadPeriod);
            this.groupBox_DataGridViewOptions.Controls.Add(this.button_refreshPeriod);
            this.groupBox_DataGridViewOptions.Controls.Add(this.button_showContactInfo);
            this.groupBox_DataGridViewOptions.Location = new System.Drawing.Point(13, 12);
            this.groupBox_DataGridViewOptions.Name = "groupBox_DataGridViewOptions";
            this.groupBox_DataGridViewOptions.Size = new System.Drawing.Size(225, 186);
            this.groupBox_DataGridViewOptions.TabIndex = 3;
            this.groupBox_DataGridViewOptions.TabStop = false;
            this.groupBox_DataGridViewOptions.Text = "Tiedot";
            // 
            // button_printShifts
            // 
            this.button_printShifts.Location = new System.Drawing.Point(13, 105);
            this.button_printShifts.Name = "button_printShifts";
            this.button_printShifts.Size = new System.Drawing.Size(198, 25);
            this.button_printShifts.TabIndex = 5;
            this.button_printShifts.Text = "Tulosta vuorot";
            this.button_printShifts.UseVisualStyleBackColor = true;
            this.button_printShifts.Click += new System.EventHandler(this.button_printShifts_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Lähetä valitut vuorot sähköpostilla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_emailShifts);
            // 
            // label_PeriodToShow
            // 
            this.label_PeriodToShow.AutoSize = true;
            this.label_PeriodToShow.Location = new System.Drawing.Point(14, 135);
            this.label_PeriodToShow.Name = "label_PeriodToShow";
            this.label_PeriodToShow.Size = new System.Drawing.Size(93, 13);
            this.label_PeriodToShow.TabIndex = 3;
            this.label_PeriodToShow.Text = "Näytettävä periodi";
            // 
            // comboBox_loadPeriod
            // 
            this.comboBox_loadPeriod.FormattingEnabled = true;
            this.comboBox_loadPeriod.Location = new System.Drawing.Point(14, 154);
            this.comboBox_loadPeriod.Name = "comboBox_loadPeriod";
            this.comboBox_loadPeriod.Size = new System.Drawing.Size(197, 21);
            this.comboBox_loadPeriod.TabIndex = 2;
            this.comboBox_loadPeriod.SelectionChangeCommitted += new System.EventHandler(this.comboBox_loadPeriod_SelectionChangeCommitted);
            // 
            // button_refreshPeriod
            // 
            this.button_refreshPeriod.Location = new System.Drawing.Point(14, 47);
            this.button_refreshPeriod.Name = "button_refreshPeriod";
            this.button_refreshPeriod.Size = new System.Drawing.Size(198, 25);
            this.button_refreshPeriod.TabIndex = 1;
            this.button_refreshPeriod.Text = "Päivitä vuorolista";
            this.button_refreshPeriod.UseVisualStyleBackColor = true;
            this.button_refreshPeriod.Click += new System.EventHandler(this.button_refreshPeriod_Click);
            // 
            // button_showContactInfo
            // 
            this.button_showContactInfo.Location = new System.Drawing.Point(14, 18);
            this.button_showContactInfo.Name = "button_showContactInfo";
            this.button_showContactInfo.Size = new System.Drawing.Size(197, 25);
            this.button_showContactInfo.TabIndex = 0;
            this.button_showContactInfo.Text = "Näytä / Piilota yhteystiedot";
            this.button_showContactInfo.UseVisualStyleBackColor = true;
            this.button_showContactInfo.Click += new System.EventHandler(this.button_showContactInfo_Click);
            // 
            // groupBox_comments
            // 
            this.groupBox_comments.Controls.Add(this.button_removeComment);
            this.groupBox_comments.Controls.Add(this.button_saveComment);
            this.groupBox_comments.Controls.Add(this.richTextBox_comment);
            this.groupBox_comments.Location = new System.Drawing.Point(13, 204);
            this.groupBox_comments.Name = "groupBox_comments";
            this.groupBox_comments.Size = new System.Drawing.Size(225, 208);
            this.groupBox_comments.TabIndex = 2;
            this.groupBox_comments.TabStop = false;
            this.groupBox_comments.Text = "Kommentti";
            // 
            // button_removeComment
            // 
            this.button_removeComment.Location = new System.Drawing.Point(116, 171);
            this.button_removeComment.Name = "button_removeComment";
            this.button_removeComment.Size = new System.Drawing.Size(95, 25);
            this.button_removeComment.TabIndex = 3;
            this.button_removeComment.Text = "Poista";
            this.button_removeComment.UseVisualStyleBackColor = true;
            this.button_removeComment.Click += new System.EventHandler(this.button_removeComment_Click);
            // 
            // button_saveComment
            // 
            this.button_saveComment.Location = new System.Drawing.Point(14, 171);
            this.button_saveComment.Name = "button_saveComment";
            this.button_saveComment.Size = new System.Drawing.Size(96, 25);
            this.button_saveComment.TabIndex = 2;
            this.button_saveComment.Text = "Tallenna";
            this.button_saveComment.UseVisualStyleBackColor = true;
            this.button_saveComment.Click += new System.EventHandler(this.button_saveComment_Click);
            // 
            // richTextBox_comment
            // 
            this.richTextBox_comment.Location = new System.Drawing.Point(14, 20);
            this.richTextBox_comment.Name = "richTextBox_comment";
            this.richTextBox_comment.Size = new System.Drawing.Size(198, 144);
            this.richTextBox_comment.TabIndex = 0;
            this.richTextBox_comment.Text = "";
            // 
            // groupBox_kirjaudu
            // 
            this.groupBox_kirjaudu.Controls.Add(this.button_signIn);
            this.groupBox_kirjaudu.Controls.Add(this.textBox_password);
            this.groupBox_kirjaudu.Location = new System.Drawing.Point(13, 418);
            this.groupBox_kirjaudu.Name = "groupBox_kirjaudu";
            this.groupBox_kirjaudu.Size = new System.Drawing.Size(225, 51);
            this.groupBox_kirjaudu.TabIndex = 1;
            this.groupBox_kirjaudu.TabStop = false;
            this.groupBox_kirjaudu.Text = "Kirjaudu";
            // 
            // button_signIn
            // 
            this.button_signIn.Location = new System.Drawing.Point(117, 17);
            this.button_signIn.Name = "button_signIn";
            this.button_signIn.Size = new System.Drawing.Size(94, 25);
            this.button_signIn.TabIndex = 1;
            this.button_signIn.Text = "Kirjaudu";
            this.button_signIn.UseVisualStyleBackColor = true;
            this.button_signIn.Click += new System.EventHandler(this.button_signIn_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(14, 20);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(96, 20);
            this.textBox_password.TabIndex = 0;
            this.textBox_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_password_KeyDown);
            // 
            // groupBox_editingControls
            // 
            this.groupBox_editingControls.Controls.Add(this.button_openCreateNewPeriod);
            this.groupBox_editingControls.Controls.Add(this.button_logout);
            this.groupBox_editingControls.Controls.Add(this.button_addShiftsFromSkeleton);
            this.groupBox_editingControls.Controls.Add(this.comboBox_savedShiftSkeletons);
            this.groupBox_editingControls.Controls.Add(this.button_saveShifts);
            this.groupBox_editingControls.Controls.Add(this.button_addRow);
            this.groupBox_editingControls.Controls.Add(this.button_removeSelectedRow);
            this.groupBox_editingControls.Controls.Add(this.button_moveRowUp);
            this.groupBox_editingControls.Controls.Add(this.button_moveRowDown);
            this.groupBox_editingControls.Controls.Add(this.checkBox_copyShift);
            this.groupBox_editingControls.Controls.Add(this.listBox_shifts);
            this.groupBox_editingControls.Location = new System.Drawing.Point(13, 475);
            this.groupBox_editingControls.Name = "groupBox_editingControls";
            this.groupBox_editingControls.Size = new System.Drawing.Size(225, 501);
            this.groupBox_editingControls.TabIndex = 0;
            this.groupBox_editingControls.TabStop = false;
            this.groupBox_editingControls.Text = "Muokkaus";
            // 
            // button_openCreateNewPeriod
            // 
            this.button_openCreateNewPeriod.Location = new System.Drawing.Point(49, 398);
            this.button_openCreateNewPeriod.Name = "button_openCreateNewPeriod";
            this.button_openCreateNewPeriod.Size = new System.Drawing.Size(112, 25);
            this.button_openCreateNewPeriod.TabIndex = 28;
            this.button_openCreateNewPeriod.Text = "Uusi periodi";
            this.button_openCreateNewPeriod.UseVisualStyleBackColor = true;
            this.button_openCreateNewPeriod.Click += new System.EventHandler(this.button_openCreateNewPeriod_Click);
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(54, 455);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(107, 25);
            this.button_logout.TabIndex = 27;
            this.button_logout.Text = "Kirjaudu ulos";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // button_addShiftsFromSkeleton
            // 
            this.button_addShiftsFromSkeleton.Location = new System.Drawing.Point(49, 367);
            this.button_addShiftsFromSkeleton.Name = "button_addShiftsFromSkeleton";
            this.button_addShiftsFromSkeleton.Size = new System.Drawing.Size(112, 25);
            this.button_addShiftsFromSkeleton.TabIndex = 26;
            this.button_addShiftsFromSkeleton.Text = "Lisaa rungon vuorot";
            this.button_addShiftsFromSkeleton.UseVisualStyleBackColor = true;
            this.button_addShiftsFromSkeleton.Click += new System.EventHandler(this.button_addShiftsFromSkeleton_Click);
            // 
            // comboBox_savedShiftSkeletons
            // 
            this.comboBox_savedShiftSkeletons.FormattingEnabled = true;
            this.comboBox_savedShiftSkeletons.Items.AddRange(new object[] {
            "AAAAAVV",
            "IIIIIVV"});
            this.comboBox_savedShiftSkeletons.Location = new System.Drawing.Point(14, 340);
            this.comboBox_savedShiftSkeletons.Name = "comboBox_savedShiftSkeletons";
            this.comboBox_savedShiftSkeletons.Size = new System.Drawing.Size(197, 21);
            this.comboBox_savedShiftSkeletons.TabIndex = 25;
            this.comboBox_savedShiftSkeletons.SelectionChangeCommitted += new System.EventHandler(this.comboBox_savedShiftSkeletons_SelectionChangeCommitted);
            // 
            // button_saveShifts
            // 
            this.button_saveShifts.Location = new System.Drawing.Point(117, 43);
            this.button_saveShifts.Name = "button_saveShifts";
            this.button_saveShifts.Size = new System.Drawing.Size(95, 36);
            this.button_saveShifts.TabIndex = 0;
            this.button_saveShifts.Text = "Tallenna periodi";
            this.button_saveShifts.UseVisualStyleBackColor = true;
            this.button_saveShifts.Click += new System.EventHandler(this.button_saveShifts_Click);
            // 
            // button_addRow
            // 
            this.button_addRow.Location = new System.Drawing.Point(14, 302);
            this.button_addRow.Name = "button_addRow";
            this.button_addRow.Size = new System.Drawing.Size(96, 25);
            this.button_addRow.TabIndex = 24;
            this.button_addRow.Text = "Lisää rivi";
            this.button_addRow.UseVisualStyleBackColor = true;
            this.button_addRow.Click += new System.EventHandler(this.button_addRow_Click);
            // 
            // button_removeSelectedRow
            // 
            this.button_removeSelectedRow.Location = new System.Drawing.Point(14, 274);
            this.button_removeSelectedRow.Name = "button_removeSelectedRow";
            this.button_removeSelectedRow.Size = new System.Drawing.Size(96, 25);
            this.button_removeSelectedRow.TabIndex = 23;
            this.button_removeSelectedRow.Text = "Poista valittu rivi";
            this.button_removeSelectedRow.UseVisualStyleBackColor = true;
            this.button_removeSelectedRow.Click += new System.EventHandler(this.button_removeSelectedRow_Click);
            // 
            // button_moveRowUp
            // 
            this.button_moveRowUp.Location = new System.Drawing.Point(116, 274);
            this.button_moveRowUp.Name = "button_moveRowUp";
            this.button_moveRowUp.Size = new System.Drawing.Size(95, 25);
            this.button_moveRowUp.TabIndex = 22;
            this.button_moveRowUp.Text = "Siirrä riviä ylös";
            this.button_moveRowUp.UseVisualStyleBackColor = true;
            this.button_moveRowUp.Click += new System.EventHandler(this.button_moveRowUp_Click);
            // 
            // button_moveRowDown
            // 
            this.button_moveRowDown.Location = new System.Drawing.Point(117, 302);
            this.button_moveRowDown.Name = "button_moveRowDown";
            this.button_moveRowDown.Size = new System.Drawing.Size(95, 25);
            this.button_moveRowDown.TabIndex = 21;
            this.button_moveRowDown.Text = "Siirrä riviä alas";
            this.button_moveRowDown.UseVisualStyleBackColor = true;
            this.button_moveRowDown.Click += new System.EventHandler(this.button_moveRowDown_Click);
            // 
            // checkBox_copyShift
            // 
            this.checkBox_copyShift.AutoSize = true;
            this.checkBox_copyShift.Location = new System.Drawing.Point(14, 20);
            this.checkBox_copyShift.Name = "checkBox_copyShift";
            this.checkBox_copyShift.Size = new System.Drawing.Size(154, 17);
            this.checkBox_copyShift.TabIndex = 20;
            this.checkBox_copyShift.Text = "Vuoron liittäminen käytössä";
            this.checkBox_copyShift.UseVisualStyleBackColor = true;
            this.checkBox_copyShift.CheckedChanged += new System.EventHandler(this.checkBox_copyShift_CheckedChanged);
            // 
            // listBox_shifts
            // 
            this.listBox_shifts.FormattingEnabled = true;
            this.listBox_shifts.Items.AddRange(new object[] {
            "06:00 - 14:00",
            "10:00 - 18:00",
            "14:00 - 22:00",
            "15:30 - 21:00",
            "15:30 - 06:00",
            "17:00 - 22:00",
            "18:00 - 01:30",
            "20:00 - 01:30",
            "20:00 - 02:00",
            "21:00 - 02:00",
            "22:00 - 06:00",
            "A",
            "H",
            "P",
            "P1",
            "Y",
            "Y1"});
            this.listBox_shifts.Location = new System.Drawing.Point(14, 43);
            this.listBox_shifts.Name = "listBox_shifts";
            this.listBox_shifts.Size = new System.Drawing.Size(96, 225);
            this.listBox_shifts.TabIndex = 19;
            this.listBox_shifts.SelectedIndexChanged += new System.EventHandler(this.listBox_shifts_SelectedIndexChanged);
            // 
            // splitContainer_dataGridViews
            // 
            this.splitContainer_dataGridViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_dataGridViews.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer_dataGridViews.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_dataGridViews.Name = "splitContainer_dataGridViews";
            this.splitContainer_dataGridViews.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_dataGridViews.Panel1
            // 
            this.splitContainer_dataGridViews.Panel1.Controls.Add(this.dataGridView_showSchedule);
            // 
            // splitContainer_dataGridViews.Panel2
            // 
            this.splitContainer_dataGridViews.Panel2.Controls.Add(this.splitContainer_hourlyWorkerCount);
            this.splitContainer_dataGridViews.Size = new System.Drawing.Size(1375, 1008);
            this.splitContainer_dataGridViews.SplitterDistance = 960;
            this.splitContainer_dataGridViews.TabIndex = 0;
            // 
            // dataGridView_showSchedule
            // 
            this.dataGridView_showSchedule.AllowUserToAddRows = false;
            this.dataGridView_showSchedule.AllowUserToDeleteRows = false;
            this.dataGridView_showSchedule.AllowUserToResizeColumns = false;
            this.dataGridView_showSchedule.AllowUserToResizeRows = false;
            this.dataGridView_showSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_showSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_showSchedule.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_showSchedule.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_showSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_showSchedule.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_showSchedule.Name = "dataGridView_showSchedule";
            this.dataGridView_showSchedule.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_showSchedule.Size = new System.Drawing.Size(1375, 960);
            this.dataGridView_showSchedule.TabIndex = 0;
            this.dataGridView_showSchedule.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_showSchedule_CellEnter);
            this.dataGridView_showSchedule.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_showSchedule_CellMouseClick);
            this.dataGridView_showSchedule.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_showSchedule_CellValueChanged);
            this.dataGridView_showSchedule.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_showSchedule_DataBindingComplete);
            this.dataGridView_showSchedule.SelectionChanged += new System.EventHandler(this.dataGridView_showSchedule_SelectionChanged);
            this.dataGridView_showSchedule.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_showSchedule_KeyDown);
            // 
            // splitContainer_hourlyWorkerCount
            // 
            this.splitContainer_hourlyWorkerCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_hourlyWorkerCount.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer_hourlyWorkerCount.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_hourlyWorkerCount.Name = "splitContainer_hourlyWorkerCount";
            // 
            // splitContainer_hourlyWorkerCount.Panel1
            // 
            this.splitContainer_hourlyWorkerCount.Panel1.Controls.Add(this.dataGridView_workerCountByHours);
            // 
            // splitContainer_hourlyWorkerCount.Panel2
            // 
            this.splitContainer_hourlyWorkerCount.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitContainer_hourlyWorkerCount.Panel2.Controls.Add(this.label_hourCount);
            this.splitContainer_hourlyWorkerCount.Size = new System.Drawing.Size(1375, 44);
            this.splitContainer_hourlyWorkerCount.SplitterDistance = 1100;
            this.splitContainer_hourlyWorkerCount.TabIndex = 0;
            // 
            // dataGridView_workerCountByHours
            // 
            this.dataGridView_workerCountByHours.AllowUserToAddRows = false;
            this.dataGridView_workerCountByHours.AllowUserToDeleteRows = false;
            this.dataGridView_workerCountByHours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_workerCountByHours.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_workerCountByHours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_workerCountByHours.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_workerCountByHours.Name = "dataGridView_workerCountByHours";
            this.dataGridView_workerCountByHours.ReadOnly = true;
            this.dataGridView_workerCountByHours.RowHeadersVisible = false;
            this.dataGridView_workerCountByHours.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView_workerCountByHours.Size = new System.Drawing.Size(1100, 44);
            this.dataGridView_workerCountByHours.TabIndex = 0;
            // 
            // label_hourCount
            // 
            this.label_hourCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_hourCount.AutoSize = true;
            this.label_hourCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hourCount.Location = new System.Drawing.Point(3, 24);
            this.label_hourCount.Name = "label_hourCount";
            this.label_hourCount.Size = new System.Drawing.Size(71, 16);
            this.label_hourCount.TabIndex = 0;
            this.label_hourCount.Text = "HourCount";
            // 
            // printDocument_shifts
            // 
            this.printDocument_shifts.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_shifts_PrintPage);
            // 
            // PeriodiView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1630, 1008);
            this.Controls.Add(this.splitContainer_controlsAndDataGridViews);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PeriodiView";
            this.Text = "Työvuorolista";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PeriodiView_Load);
            this.splitContainer_controlsAndDataGridViews.Panel1.ResumeLayout(false);
            this.splitContainer_controlsAndDataGridViews.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_controlsAndDataGridViews)).EndInit();
            this.splitContainer_controlsAndDataGridViews.ResumeLayout(false);
            this.groupBox_DataGridViewOptions.ResumeLayout(false);
            this.groupBox_DataGridViewOptions.PerformLayout();
            this.groupBox_comments.ResumeLayout(false);
            this.groupBox_kirjaudu.ResumeLayout(false);
            this.groupBox_kirjaudu.PerformLayout();
            this.groupBox_editingControls.ResumeLayout(false);
            this.groupBox_editingControls.PerformLayout();
            this.splitContainer_dataGridViews.Panel1.ResumeLayout(false);
            this.splitContainer_dataGridViews.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_dataGridViews)).EndInit();
            this.splitContainer_dataGridViews.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_showSchedule)).EndInit();
            this.splitContainer_hourlyWorkerCount.Panel1.ResumeLayout(false);
            this.splitContainer_hourlyWorkerCount.Panel2.ResumeLayout(false);
            this.splitContainer_hourlyWorkerCount.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_hourlyWorkerCount)).EndInit();
            this.splitContainer_hourlyWorkerCount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_workerCountByHours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer_controlsAndDataGridViews;
        private System.Windows.Forms.DataGridView dataGridView_showSchedule;
        private System.Windows.Forms.GroupBox groupBox_editingControls;
        private System.Windows.Forms.Button button_addRow;
        private System.Windows.Forms.Button button_removeSelectedRow;
        private System.Windows.Forms.Button button_moveRowUp;
        private System.Windows.Forms.Button button_moveRowDown;
        private System.Windows.Forms.CheckBox checkBox_copyShift;
        private System.Windows.Forms.ListBox listBox_shifts;
        private System.Windows.Forms.Button button_saveShifts;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_addShiftsFromSkeleton;
        private System.Windows.Forms.ComboBox comboBox_savedShiftSkeletons;
        private System.Windows.Forms.GroupBox groupBox_kirjaudu;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_signIn;
        private System.Windows.Forms.GroupBox groupBox_comments;
        private System.Windows.Forms.Button button_saveComment;
        private System.Windows.Forms.RichTextBox richTextBox_comment;
        private System.Windows.Forms.SplitContainer splitContainer_dataGridViews;
        private System.Windows.Forms.SplitContainer splitContainer_hourlyWorkerCount;
        private System.Windows.Forms.DataGridView dataGridView_workerCountByHours;
        private System.Windows.Forms.GroupBox groupBox_DataGridViewOptions;
        private System.Windows.Forms.Label label_PeriodToShow;
        private System.Windows.Forms.ComboBox comboBox_loadPeriod;
        private System.Windows.Forms.Button button_refreshPeriod;
        private System.Windows.Forms.Button button_showContactInfo;
        private System.Windows.Forms.Button button_openCreateNewPeriod;
        private System.Windows.Forms.Button button_removeComment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_printShifts;
        private System.Drawing.Printing.PrintDocument printDocument_shifts;
        private System.Windows.Forms.Label label_hourCount;
    }
}