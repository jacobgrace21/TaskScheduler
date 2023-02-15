namespace Ksu.Cis300.TaskScheduler
{
    partial class UserInterface
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uxGetInputFile = new System.Windows.Forms.Button();
            this.uxInputFileName = new System.Windows.Forms.TextBox();
            this.uxLengthLabel = new System.Windows.Forms.Label();
            this.uxLength = new System.Windows.Forms.NumericUpDown();
            this.uxComputeSchedule = new System.Windows.Forms.Button();
            this.uxOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.uxScheduleView = new System.Windows.Forms.TabControl();
            this.uxScheduleDataTab = new System.Windows.Forms.TabPage();
            this.uxScheduleDataGrid = new System.Windows.Forms.DataGridView();
            this.uxComputedScheduleTab = new System.Windows.Forms.TabPage();
            this.uxComputedScheduleDataGrid = new System.Windows.Forms.DataGridView();
            this.uxStatsTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uxLength)).BeginInit();
            this.uxScheduleView.SuspendLayout();
            this.uxScheduleDataTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxScheduleDataGrid)).BeginInit();
            this.uxComputedScheduleTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxComputedScheduleDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // uxGetInputFile
            // 
            this.uxGetInputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGetInputFile.Location = new System.Drawing.Point(12, 12);
            this.uxGetInputFile.Name = "uxGetInputFile";
            this.uxGetInputFile.Size = new System.Drawing.Size(123, 32);
            this.uxGetInputFile.TabIndex = 0;
            this.uxGetInputFile.Text = "Input File:";
            this.uxGetInputFile.UseVisualStyleBackColor = true;
            this.uxGetInputFile.Click += new System.EventHandler(this.uxGetInputFile_Click);
            // 
            // uxInputFileName
            // 
            this.uxInputFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInputFileName.Location = new System.Drawing.Point(141, 13);
            this.uxInputFileName.Name = "uxInputFileName";
            this.uxInputFileName.ReadOnly = true;
            this.uxInputFileName.Size = new System.Drawing.Size(867, 29);
            this.uxInputFileName.TabIndex = 1;
            this.uxInputFileName.TextChanged += new System.EventHandler(this.uxInputFileName_TextChanged);
            // 
            // uxLengthLabel
            // 
            this.uxLengthLabel.AutoSize = true;
            this.uxLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLengthLabel.Location = new System.Drawing.Point(15, 52);
            this.uxLengthLabel.Name = "uxLengthLabel";
            this.uxLengthLabel.Size = new System.Drawing.Size(159, 24);
            this.uxLengthLabel.TabIndex = 2;
            this.uxLengthLabel.Text = "Schedule Length:";
            // 
            // uxLength
            // 
            this.uxLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLength.Location = new System.Drawing.Point(180, 50);
            this.uxLength.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.uxLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxLength.Name = "uxLength";
            this.uxLength.Size = new System.Drawing.Size(88, 29);
            this.uxLength.TabIndex = 3;
            this.uxLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.uxLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // uxComputeSchedule
            // 
            this.uxComputeSchedule.Enabled = false;
            this.uxComputeSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxComputeSchedule.Location = new System.Drawing.Point(274, 48);
            this.uxComputeSchedule.Name = "uxComputeSchedule";
            this.uxComputeSchedule.Size = new System.Drawing.Size(206, 32);
            this.uxComputeSchedule.TabIndex = 4;
            this.uxComputeSchedule.Text = "Compute Schedule";
            this.uxComputeSchedule.UseVisualStyleBackColor = true;
            this.uxComputeSchedule.Click += new System.EventHandler(this.uxComputeSchedule_Click);
            // 
            // uxOpenDialog
            // 
            this.uxOpenDialog.Filter = "CSV files|*.csv|All files|*.*";
            this.uxOpenDialog.Title = "Select Input File";
            // 
            // uxSaveDialog
            // 
            this.uxSaveDialog.Filter = "CSV files|*.csv|All files|*.*";
            this.uxSaveDialog.Title = "Save Output File As";
            // 
            // uxScheduleView
            // 
            this.uxScheduleView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxScheduleView.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.uxScheduleView.Controls.Add(this.uxScheduleDataTab);
            this.uxScheduleView.Controls.Add(this.uxComputedScheduleTab);
            this.uxScheduleView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.uxScheduleView.Location = new System.Drawing.Point(12, 85);
            this.uxScheduleView.Name = "uxScheduleView";
            this.uxScheduleView.SelectedIndex = 0;
            this.uxScheduleView.Size = new System.Drawing.Size(1003, 468);
            this.uxScheduleView.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.uxScheduleView.TabIndex = 5;
            // 
            // uxScheduleDataTab
            // 
            this.uxScheduleDataTab.BackColor = System.Drawing.Color.Transparent;
            this.uxScheduleDataTab.Controls.Add(this.uxScheduleDataGrid);
            this.uxScheduleDataTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxScheduleDataTab.Location = new System.Drawing.Point(4, 25);
            this.uxScheduleDataTab.Name = "uxScheduleDataTab";
            this.uxScheduleDataTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.uxScheduleDataTab.Size = new System.Drawing.Size(995, 439);
            this.uxScheduleDataTab.TabIndex = 0;
            this.uxScheduleDataTab.Text = "Schedule Data";
            this.uxScheduleDataTab.UseVisualStyleBackColor = true;
            // 
            // uxScheduleDataGrid
            // 
            this.uxScheduleDataGrid.AllowUserToAddRows = false;
            this.uxScheduleDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uxScheduleDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.uxScheduleDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.uxScheduleDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.uxScheduleDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uxScheduleDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.uxScheduleDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxScheduleDataGrid.Location = new System.Drawing.Point(3, 3);
            this.uxScheduleDataGrid.Name = "uxScheduleDataGrid";
            this.uxScheduleDataGrid.ReadOnly = true;
            this.uxScheduleDataGrid.RowHeadersWidth = 51;
            this.uxScheduleDataGrid.Size = new System.Drawing.Size(989, 433);
            this.uxScheduleDataGrid.TabIndex = 0;
            // 
            // uxComputedScheduleTab
            // 
            this.uxComputedScheduleTab.Controls.Add(this.uxComputedScheduleDataGrid);
            this.uxComputedScheduleTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uxComputedScheduleTab.Location = new System.Drawing.Point(4, 25);
            this.uxComputedScheduleTab.Name = "uxComputedScheduleTab";
            this.uxComputedScheduleTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.uxComputedScheduleTab.Size = new System.Drawing.Size(995, 439);
            this.uxComputedScheduleTab.TabIndex = 1;
            this.uxComputedScheduleTab.Text = "Computed Schedule";
            this.uxComputedScheduleTab.UseVisualStyleBackColor = true;
            // 
            // uxComputedScheduleDataGrid
            // 
            this.uxComputedScheduleDataGrid.AllowUserToAddRows = false;
            this.uxComputedScheduleDataGrid.AllowUserToDeleteRows = false;
            this.uxComputedScheduleDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.uxComputedScheduleDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxComputedScheduleDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxComputedScheduleDataGrid.Location = new System.Drawing.Point(3, 3);
            this.uxComputedScheduleDataGrid.Name = "uxComputedScheduleDataGrid";
            this.uxComputedScheduleDataGrid.ReadOnly = true;
            this.uxComputedScheduleDataGrid.RowHeadersWidth = 51;
            this.uxComputedScheduleDataGrid.Size = new System.Drawing.Size(989, 433);
            this.uxComputedScheduleDataGrid.TabIndex = 0;
            // 
            // uxStatsTextBox
            // 
            this.uxStatsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStatsTextBox.Location = new System.Drawing.Point(486, 50);
            this.uxStatsTextBox.Multiline = true;
            this.uxStatsTextBox.Name = "uxStatsTextBox";
            this.uxStatsTextBox.ReadOnly = true;
            this.uxStatsTextBox.Size = new System.Drawing.Size(522, 54);
            this.uxStatsTextBox.TabIndex = 6;
            this.uxStatsTextBox.TextChanged += new System.EventHandler(this.uxStatsTextBox_TextChanged);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1027, 565);
            this.Controls.Add(this.uxStatsTextBox);
            this.Controls.Add(this.uxScheduleView);
            this.Controls.Add(this.uxComputeSchedule);
            this.Controls.Add(this.uxLength);
            this.Controls.Add(this.uxLengthLabel);
            this.Controls.Add(this.uxInputFileName);
            this.Controls.Add(this.uxGetInputFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1500, 1498);
            this.Name = "UserInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scheduler";
            ((System.ComponentModel.ISupportInitialize)(this.uxLength)).EndInit();
            this.uxScheduleView.ResumeLayout(false);
            this.uxScheduleDataTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uxScheduleDataGrid)).EndInit();
            this.uxComputedScheduleTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uxComputedScheduleDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxGetInputFile;
        private System.Windows.Forms.TextBox uxInputFileName;
        private System.Windows.Forms.Label uxLengthLabel;
        private System.Windows.Forms.NumericUpDown uxLength;
        private System.Windows.Forms.Button uxComputeSchedule;
        private System.Windows.Forms.OpenFileDialog uxOpenDialog;
        private System.Windows.Forms.SaveFileDialog uxSaveDialog;
        private System.Windows.Forms.TabControl uxScheduleView;
        private System.Windows.Forms.TabPage uxScheduleDataTab;
        private System.Windows.Forms.DataGridView uxScheduleDataGrid;
        private System.Windows.Forms.TabPage uxComputedScheduleTab;
        private System.Windows.Forms.DataGridView uxComputedScheduleDataGrid;
        private System.Windows.Forms.TextBox uxStatsTextBox;
    }
}

