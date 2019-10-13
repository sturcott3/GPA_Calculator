namespace GPA_Calculator_UI_2
{
    partial class OutputForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabOutputParent = new System.Windows.Forms.TabControl();
            this.tabOriginal = new System.Windows.Forms.TabPage();
            this.tabMinimum = new System.Windows.Forms.TabPage();
            this.tabTarget = new System.Windows.Forms.TabPage();
            this.tabMaximum = new System.Windows.Forms.TabPage();
            this.lblSummaryOriginal = new System.Windows.Forms.Label();
            this.grdDisplay_Original = new System.Windows.Forms.DataGridView();
            this.colCourseCode_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditHours_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPercentGrade_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLetterGrade_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComplete_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConsidered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdDisplayMinimum = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSummaryMinimum = new System.Windows.Forms.Label();
            this.grdDisplayTarget = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSummaryTarget = new System.Windows.Forms.Label();
            this.grdDisplayMaximum = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSummaryMaximum = new System.Windows.Forms.Label();
            this.tabOutputParent.SuspendLayout();
            this.tabOriginal.SuspendLayout();
            this.tabMinimum.SuspendLayout();
            this.tabTarget.SuspendLayout();
            this.tabMaximum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplay_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplayMinimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplayTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplayMaximum)).BeginInit();
            this.SuspendLayout();
            // 
            // tabOutputParent
            // 
            this.tabOutputParent.Controls.Add(this.tabOriginal);
            this.tabOutputParent.Controls.Add(this.tabMinimum);
            this.tabOutputParent.Controls.Add(this.tabTarget);
            this.tabOutputParent.Controls.Add(this.tabMaximum);
            this.tabOutputParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOutputParent.Location = new System.Drawing.Point(0, 0);
            this.tabOutputParent.Name = "tabOutputParent";
            this.tabOutputParent.SelectedIndex = 0;
            this.tabOutputParent.Size = new System.Drawing.Size(585, 524);
            this.tabOutputParent.TabIndex = 0;
            // 
            // tabOriginal
            // 
            this.tabOriginal.Controls.Add(this.grdDisplay_Original);
            this.tabOriginal.Controls.Add(this.lblSummaryOriginal);
            this.tabOriginal.Location = new System.Drawing.Point(4, 22);
            this.tabOriginal.Name = "tabOriginal";
            this.tabOriginal.Padding = new System.Windows.Forms.Padding(3);
            this.tabOriginal.Size = new System.Drawing.Size(577, 498);
            this.tabOriginal.TabIndex = 0;
            this.tabOriginal.Text = "Original";
            this.tabOriginal.UseVisualStyleBackColor = true;
            // 
            // tabMinimum
            // 
            this.tabMinimum.Controls.Add(this.grdDisplayMinimum);
            this.tabMinimum.Controls.Add(this.lblSummaryMinimum);
            this.tabMinimum.Location = new System.Drawing.Point(4, 22);
            this.tabMinimum.Name = "tabMinimum";
            this.tabMinimum.Size = new System.Drawing.Size(577, 498);
            this.tabMinimum.TabIndex = 1;
            this.tabMinimum.Text = "Minimum Graduating";
            this.tabMinimum.UseVisualStyleBackColor = true;
            // 
            // tabTarget
            // 
            this.tabTarget.Controls.Add(this.grdDisplayTarget);
            this.tabTarget.Controls.Add(this.lblSummaryTarget);
            this.tabTarget.Location = new System.Drawing.Point(4, 22);
            this.tabTarget.Name = "tabTarget";
            this.tabTarget.Size = new System.Drawing.Size(577, 498);
            this.tabTarget.TabIndex = 2;
            this.tabTarget.Text = "Target (Or Closest)";
            this.tabTarget.UseVisualStyleBackColor = true;
            // 
            // tabMaximum
            // 
            this.tabMaximum.Controls.Add(this.grdDisplayMaximum);
            this.tabMaximum.Controls.Add(this.lblSummaryMaximum);
            this.tabMaximum.Location = new System.Drawing.Point(4, 22);
            this.tabMaximum.Name = "tabMaximum";
            this.tabMaximum.Size = new System.Drawing.Size(577, 498);
            this.tabMaximum.TabIndex = 3;
            this.tabMaximum.Text = "Highest Possible";
            this.tabMaximum.UseVisualStyleBackColor = true;
            // 
            // lblSummaryOriginal
            // 
            this.lblSummaryOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummaryOriginal.Location = new System.Drawing.Point(3, 3);
            this.lblSummaryOriginal.Name = "lblSummaryOriginal";
            this.lblSummaryOriginal.Size = new System.Drawing.Size(571, 111);
            this.lblSummaryOriginal.TabIndex = 0;
            this.lblSummaryOriginal.Text = "\r\n";
            // 
            // grdDisplay_Original
            // 
            this.grdDisplay_Original.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDisplay_Original.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDisplay_Original.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDisplay_Original.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCourseCode_1,
            this.colCreditHours_1,
            this.colPercentGrade_1,
            this.colLetterGrade_1,
            this.colComplete_1,
            this.colConsidered});
            this.grdDisplay_Original.Location = new System.Drawing.Point(3, 117);
            this.grdDisplay_Original.Name = "grdDisplay_Original";
            this.grdDisplay_Original.Size = new System.Drawing.Size(571, 378);
            this.grdDisplay_Original.TabIndex = 1;
            // 
            // colCourseCode_1
            // 
            this.colCourseCode_1.HeaderText = "Course Code";
            this.colCourseCode_1.Name = "colCourseCode_1";
            this.colCourseCode_1.ReadOnly = true;
            this.colCourseCode_1.Width = 85;
            // 
            // colCreditHours_1
            // 
            this.colCreditHours_1.HeaderText = "Credit Hours";
            this.colCreditHours_1.Name = "colCreditHours_1";
            this.colCreditHours_1.ReadOnly = true;
            this.colCreditHours_1.Width = 85;
            // 
            // colPercentGrade_1
            // 
            this.colPercentGrade_1.HeaderText = "Grade ( % )";
            this.colPercentGrade_1.Name = "colPercentGrade_1";
            this.colPercentGrade_1.ReadOnly = true;
            this.colPercentGrade_1.Width = 85;
            // 
            // colLetterGrade_1
            // 
            this.colLetterGrade_1.HeaderText = "Grade (Letter)";
            this.colLetterGrade_1.Name = "colLetterGrade_1";
            this.colLetterGrade_1.ReadOnly = true;
            this.colLetterGrade_1.Width = 85;
            // 
            // colComplete_1
            // 
            this.colComplete_1.HeaderText = "Completed";
            this.colComplete_1.Name = "colComplete_1";
            this.colComplete_1.ReadOnly = true;
            this.colComplete_1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colComplete_1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colComplete_1.Width = 85;
            // 
            // colConsidered
            // 
            this.colConsidered.FillWeight = 90F;
            this.colConsidered.HeaderText = "Consideration";
            this.colConsidered.Name = "colConsidered";
            this.colConsidered.ReadOnly = true;
            // 
            // grdDisplayMinimum
            // 
            this.grdDisplayMinimum.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDisplayMinimum.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdDisplayMinimum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDisplayMinimum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.grdDisplayMinimum.Location = new System.Drawing.Point(3, 117);
            this.grdDisplayMinimum.Name = "grdDisplayMinimum";
            this.grdDisplayMinimum.Size = new System.Drawing.Size(571, 378);
            this.grdDisplayMinimum.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Course Code";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 85;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Credit Hours";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 85;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Grade ( % )";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 85;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Grade (Letter)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 85;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Completed";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 85;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 90F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Consideration";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // lblSummaryMinimum
            // 
            this.lblSummaryMinimum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummaryMinimum.Location = new System.Drawing.Point(3, 3);
            this.lblSummaryMinimum.Name = "lblSummaryMinimum";
            this.lblSummaryMinimum.Size = new System.Drawing.Size(571, 111);
            this.lblSummaryMinimum.TabIndex = 2;
            this.lblSummaryMinimum.Text = "\r\n";
            // 
            // grdDisplayTarget
            // 
            this.grdDisplayTarget.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDisplayTarget.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdDisplayTarget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDisplayTarget.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.grdDisplayTarget.Location = new System.Drawing.Point(3, 117);
            this.grdDisplayTarget.Name = "grdDisplayTarget";
            this.grdDisplayTarget.Size = new System.Drawing.Size(571, 378);
            this.grdDisplayTarget.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Course Code";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 85;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Credit Hours";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 85;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Grade ( % )";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 85;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Grade (Letter)";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 85;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Completed";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn11.Width = 85;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.FillWeight = 90F;
            this.dataGridViewTextBoxColumn12.HeaderText = "Consideration";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // lblSummaryTarget
            // 
            this.lblSummaryTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummaryTarget.Location = new System.Drawing.Point(3, 3);
            this.lblSummaryTarget.Name = "lblSummaryTarget";
            this.lblSummaryTarget.Size = new System.Drawing.Size(571, 111);
            this.lblSummaryTarget.TabIndex = 2;
            this.lblSummaryTarget.Text = "\r\n";
            // 
            // grdDisplayMaximum
            // 
            this.grdDisplayMaximum.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDisplayMaximum.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdDisplayMaximum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDisplayMaximum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.grdDisplayMaximum.Location = new System.Drawing.Point(3, 117);
            this.grdDisplayMaximum.Name = "grdDisplayMaximum";
            this.grdDisplayMaximum.Size = new System.Drawing.Size(571, 378);
            this.grdDisplayMaximum.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Course Code";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 85;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Credit Hours";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 85;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "Grade ( % )";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 85;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "Grade (Letter)";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 85;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "Completed";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn17.Width = 85;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.FillWeight = 90F;
            this.dataGridViewTextBoxColumn18.HeaderText = "Consideration";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // lblSummaryMaximum
            // 
            this.lblSummaryMaximum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummaryMaximum.Location = new System.Drawing.Point(3, 3);
            this.lblSummaryMaximum.Name = "lblSummaryMaximum";
            this.lblSummaryMaximum.Size = new System.Drawing.Size(571, 111);
            this.lblSummaryMaximum.TabIndex = 2;
            this.lblSummaryMaximum.Text = "\r\n";
            // 
            // frmOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 524);
            this.Controls.Add(this.tabOutputParent);
            this.Name = "frmOutput";
            this.Text = "OutputForm";
            this.tabOutputParent.ResumeLayout(false);
            this.tabOriginal.ResumeLayout(false);
            this.tabMinimum.ResumeLayout(false);
            this.tabTarget.ResumeLayout(false);
            this.tabMaximum.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplay_Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplayMinimum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplayTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplayMaximum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabOutputParent;
        private System.Windows.Forms.TabPage tabOriginal;
        private System.Windows.Forms.Label lblSummaryOriginal;
        private System.Windows.Forms.TabPage tabMinimum;
        private System.Windows.Forms.TabPage tabTarget;
        private System.Windows.Forms.TabPage tabMaximum;
        private System.Windows.Forms.DataGridView grdDisplay_Original;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourseCode_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditHours_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPercentGrade_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLetterGrade_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComplete_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConsidered;
        private System.Windows.Forms.DataGridView grdDisplayMinimum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label lblSummaryMinimum;
        private System.Windows.Forms.DataGridView grdDisplayTarget;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Label lblSummaryTarget;
        private System.Windows.Forms.DataGridView grdDisplayMaximum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.Label lblSummaryMaximum;
    }
}