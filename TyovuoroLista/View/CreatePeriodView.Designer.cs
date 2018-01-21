namespace TyovuoroLista.View
{
    partial class CreatePeriodView
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button_savePeriod = new System.Windows.Forms.Button();
            this.button_createPeriod = new System.Windows.Forms.Button();
            this.label_periodStartingDay = new System.Windows.Forms.Label();
            this.dateTimePicker_periodStartDate = new System.Windows.Forms.DateTimePicker();
            this.label_columnCount = new System.Windows.Forms.Label();
            this.label_RowCount = new System.Windows.Forms.Label();
            this.textBox_columnCount = new System.Windows.Forms.TextBox();
            this.textBox_rowCount = new System.Windows.Forms.TextBox();
            this.label_periodName = new System.Windows.Forms.Label();
            this.textBox_periodName = new System.Windows.Forms.TextBox();
            this.dataGridView_period = new System.Windows.Forms.DataGridView();
            this.label_periodEndDate = new System.Windows.Forms.Label();
            this.dateTimePicker_periodEndDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_period)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label_periodEndDate);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker_periodEndDate);
            this.splitContainer1.Panel1.Controls.Add(this.button_savePeriod);
            this.splitContainer1.Panel1.Controls.Add(this.button_createPeriod);
            this.splitContainer1.Panel1.Controls.Add(this.label_periodStartingDay);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker_periodStartDate);
            this.splitContainer1.Panel1.Controls.Add(this.label_columnCount);
            this.splitContainer1.Panel1.Controls.Add(this.label_RowCount);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_columnCount);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_rowCount);
            this.splitContainer1.Panel1.Controls.Add(this.label_periodName);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_periodName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView_period);
            this.splitContainer1.Size = new System.Drawing.Size(964, 657);
            this.splitContainer1.SplitterDistance = 197;
            this.splitContainer1.TabIndex = 0;
            // 
            // button_savePeriod
            // 
            this.button_savePeriod.Location = new System.Drawing.Point(42, 292);
            this.button_savePeriod.Name = "button_savePeriod";
            this.button_savePeriod.Size = new System.Drawing.Size(113, 25);
            this.button_savePeriod.TabIndex = 8;
            this.button_savePeriod.Text = "Tallenna periodi";
            this.button_savePeriod.UseVisualStyleBackColor = true;
            this.button_savePeriod.Click += new System.EventHandler(this.button_savePeriod_Click);
            // 
            // button_createPeriod
            // 
            this.button_createPeriod.Location = new System.Drawing.Point(42, 259);
            this.button_createPeriod.Name = "button_createPeriod";
            this.button_createPeriod.Size = new System.Drawing.Size(113, 25);
            this.button_createPeriod.TabIndex = 0;
            this.button_createPeriod.Text = "Luo periodin runko";
            this.button_createPeriod.UseVisualStyleBackColor = true;
            this.button_createPeriod.Click += new System.EventHandler(this.button_createPeriod_Click);
            // 
            // label_periodStartingDay
            // 
            this.label_periodStartingDay.AutoSize = true;
            this.label_periodStartingDay.Location = new System.Drawing.Point(13, 157);
            this.label_periodStartingDay.Name = "label_periodStartingDay";
            this.label_periodStartingDay.Size = new System.Drawing.Size(104, 13);
            this.label_periodStartingDay.TabIndex = 7;
            this.label_periodStartingDay.Text = "Periodin aloituspäivä";
            // 
            // dateTimePicker_periodStartDate
            // 
            this.dateTimePicker_periodStartDate.Location = new System.Drawing.Point(16, 175);
            this.dateTimePicker_periodStartDate.Name = "dateTimePicker_periodStartDate";
            this.dateTimePicker_periodStartDate.Size = new System.Drawing.Size(168, 20);
            this.dateTimePicker_periodStartDate.TabIndex = 6;
            this.dateTimePicker_periodStartDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label_columnCount
            // 
            this.label_columnCount.AutoSize = true;
            this.label_columnCount.Location = new System.Drawing.Point(13, 119);
            this.label_columnCount.Name = "label_columnCount";
            this.label_columnCount.Size = new System.Drawing.Size(73, 13);
            this.label_columnCount.TabIndex = 5;
            this.label_columnCount.Text = "Kolumnimäärä";
            // 
            // label_RowCount
            // 
            this.label_RowCount.AutoSize = true;
            this.label_RowCount.Location = new System.Drawing.Point(13, 93);
            this.label_RowCount.Name = "label_RowCount";
            this.label_RowCount.Size = new System.Drawing.Size(54, 13);
            this.label_RowCount.TabIndex = 4;
            this.label_RowCount.Text = "Rivimäärä";
            // 
            // textBox_columnCount
            // 
            this.textBox_columnCount.Location = new System.Drawing.Point(91, 116);
            this.textBox_columnCount.Name = "textBox_columnCount";
            this.textBox_columnCount.ReadOnly = true;
            this.textBox_columnCount.Size = new System.Drawing.Size(93, 20);
            this.textBox_columnCount.TabIndex = 3;
            this.textBox_columnCount.Text = "369";
            // 
            // textBox_rowCount
            // 
            this.textBox_rowCount.Location = new System.Drawing.Point(91, 90);
            this.textBox_rowCount.Name = "textBox_rowCount";
            this.textBox_rowCount.Size = new System.Drawing.Size(93, 20);
            this.textBox_rowCount.TabIndex = 2;
            this.textBox_rowCount.Text = "35";
            // 
            // label_periodName
            // 
            this.label_periodName.AutoSize = true;
            this.label_periodName.Location = new System.Drawing.Point(13, 41);
            this.label_periodName.Name = "label_periodName";
            this.label_periodName.Size = new System.Drawing.Size(66, 13);
            this.label_periodName.TabIndex = 1;
            this.label_periodName.Text = "Periodin nimi";
            // 
            // textBox_periodName
            // 
            this.textBox_periodName.Location = new System.Drawing.Point(13, 60);
            this.textBox_periodName.Name = "textBox_periodName";
            this.textBox_periodName.Size = new System.Drawing.Size(171, 20);
            this.textBox_periodName.TabIndex = 0;
            // 
            // dataGridView_period
            // 
            this.dataGridView_period.AllowUserToAddRows = false;
            this.dataGridView_period.AllowUserToDeleteRows = false;
            this.dataGridView_period.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_period.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_period.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_period.Name = "dataGridView_period";
            this.dataGridView_period.ReadOnly = true;
            this.dataGridView_period.Size = new System.Drawing.Size(763, 657);
            this.dataGridView_period.TabIndex = 0;
            // 
            // label_periodEndDate
            // 
            this.label_periodEndDate.AutoSize = true;
            this.label_periodEndDate.Location = new System.Drawing.Point(13, 208);
            this.label_periodEndDate.Name = "label_periodEndDate";
            this.label_periodEndDate.Size = new System.Drawing.Size(104, 13);
            this.label_periodEndDate.TabIndex = 10;
            this.label_periodEndDate.Text = "Periodin aloituspäivä";
            // 
            // dateTimePicker_periodEndDate
            // 
            this.dateTimePicker_periodEndDate.Location = new System.Drawing.Point(16, 226);
            this.dateTimePicker_periodEndDate.Name = "dateTimePicker_periodEndDate";
            this.dateTimePicker_periodEndDate.Size = new System.Drawing.Size(168, 20);
            this.dateTimePicker_periodEndDate.TabIndex = 9;
            this.dateTimePicker_periodEndDate.ValueChanged += new System.EventHandler(this.dateTimePicker_periodEndDate_ValueChanged);
            // 
            // CreatePeriodView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(964, 657);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CreatePeriodView";
            this.Text = "CreatePeriodView";
            this.Load += new System.EventHandler(this.CreatePeriodView_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_period)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView_period;
        private System.Windows.Forms.TextBox textBox_periodName;
        private System.Windows.Forms.Label label_columnCount;
        private System.Windows.Forms.Label label_RowCount;
        private System.Windows.Forms.TextBox textBox_columnCount;
        private System.Windows.Forms.TextBox textBox_rowCount;
        private System.Windows.Forms.Label label_periodName;
        private System.Windows.Forms.Label label_periodStartingDay;
        private System.Windows.Forms.DateTimePicker dateTimePicker_periodStartDate;
        private System.Windows.Forms.Button button_savePeriod;
        private System.Windows.Forms.Button button_createPeriod;
        private System.Windows.Forms.Label label_periodEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_periodEndDate;
    }
}