namespace GPA_Calculator_UI_2
{
    partial class Editor
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
            this.grdDisplay_Sem_1 = new System.Windows.Forms.DataGridView();
            this.colCourseCode_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditHours_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPercentGrade_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLetterGrade_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComplete_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuMainFile = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTargetGPA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddSemester = new System.Windows.Forms.Button();
            this.btnDelSemester = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tbConSemesters = new System.Windows.Forms.TabControl();
            this.tabSemester1 = new System.Windows.Forms.TabPage();
            this.tabSemester2 = new System.Windows.Forms.TabPage();
            this.grd_Display_Sem2 = new System.Windows.Forms.DataGridView();
            this.colCourseCode_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditHours_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPercentGrade_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLetterGrade_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompleted_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSemester3 = new System.Windows.Forms.TabPage();
            this.grd_Display_Sem3 = new System.Windows.Forms.DataGridView();
            this.colCourseCode_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditHours_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPercentGrade_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLetterGrade_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComplete_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSemester4 = new System.Windows.Forms.TabPage();
            this.grd_Display_Sem4 = new System.Windows.Forms.DataGridView();
            this.colCourseCode_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditHours_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPercentGrade_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLetterGrade_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompleted_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTestInput = new System.Windows.Forms.Button();
            this.cbxIncrement = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblWarning = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplay_Sem_1)).BeginInit();
            this.mnuMain.SuspendLayout();
            this.tbConSemesters.SuspendLayout();
            this.tabSemester1.SuspendLayout();
            this.tabSemester2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Display_Sem2)).BeginInit();
            this.tabSemester3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Display_Sem3)).BeginInit();
            this.tabSemester4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Display_Sem4)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdDisplay_Sem_1
            // 
            this.grdDisplay_Sem_1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDisplay_Sem_1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDisplay_Sem_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDisplay_Sem_1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCourseCode_1,
            this.colCreditHours_1,
            this.colPercentGrade_1,
            this.colLetterGrade_1,
            this.colComplete_1});
            this.grdDisplay_Sem_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDisplay_Sem_1.Location = new System.Drawing.Point(3, 3);
            this.grdDisplay_Sem_1.Name = "grdDisplay_Sem_1";
            this.grdDisplay_Sem_1.Size = new System.Drawing.Size(533, 249);
            this.grdDisplay_Sem_1.TabIndex = 0;
            this.grdDisplay_Sem_1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Display_Sem1_CellValueChanged);
            // 
            // colCourseCode_1
            // 
            this.colCourseCode_1.HeaderText = "Course Code";
            this.colCourseCode_1.Name = "colCourseCode_1";
            // 
            // colCreditHours_1
            // 
            this.colCreditHours_1.HeaderText = "Credit Hours";
            this.colCreditHours_1.Name = "colCreditHours_1";
            // 
            // colPercentGrade_1
            // 
            this.colPercentGrade_1.HeaderText = "Grade ( % )";
            this.colPercentGrade_1.Name = "colPercentGrade_1";
            // 
            // colLetterGrade_1
            // 
            this.colLetterGrade_1.HeaderText = "Grade (Letter)";
            this.colLetterGrade_1.Name = "colLetterGrade_1";
            // 
            // colComplete_1
            // 
            this.colComplete_1.HeaderText = "Completed";
            this.colComplete_1.Name = "colComplete_1";
            this.colComplete_1.ReadOnly = true;
            this.colComplete_1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colComplete_1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.Color.White;
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainFile,
            this.mnuMainHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(567, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuMainFile
            // 
            this.mnuMainFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.mnuMainFile.Name = "mnuMainFile";
            this.mnuMainFile.Size = new System.Drawing.Size(37, 20);
            this.mnuMainFile.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // mnuMainHelp
            // 
            this.mnuMainHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem});
            this.mnuMainHelp.Name = "mnuMainHelp";
            this.mnuMainHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuMainHelp.Text = "Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.instructionsToolStripMenuItem.Text = "&Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Target GPA: ";
            // 
            // txtTargetGPA
            // 
            this.txtTargetGPA.Location = new System.Drawing.Point(270, 322);
            this.txtTargetGPA.Name = "txtTargetGPA";
            this.txtTargetGPA.Size = new System.Drawing.Size(100, 20);
            this.txtTargetGPA.TabIndex = 3;
            this.txtTargetGPA.TextChanged += new System.EventHandler(this.txtTargetGPA_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Increment:";
            // 
            // btnAddSemester
            // 
            this.btnAddSemester.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddSemester.Location = new System.Drawing.Point(12, 315);
            this.btnAddSemester.Name = "btnAddSemester";
            this.btnAddSemester.Size = new System.Drawing.Size(97, 44);
            this.btnAddSemester.TabIndex = 8;
            this.btnAddSemester.Text = "Add Another Semester";
            this.btnAddSemester.UseVisualStyleBackColor = false;
            this.btnAddSemester.Click += new System.EventHandler(this.btnAddSemester_Click);
            // 
            // btnDelSemester
            // 
            this.btnDelSemester.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelSemester.Location = new System.Drawing.Point(12, 365);
            this.btnDelSemester.Name = "btnDelSemester";
            this.btnDelSemester.Size = new System.Drawing.Size(97, 41);
            this.btnDelSemester.TabIndex = 9;
            this.btnDelSemester.Text = "Delete Current Semester";
            this.btnDelSemester.UseVisualStyleBackColor = false;
            this.btnDelSemester.Click += new System.EventHandler(this.btnDelSemester_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.Control;
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalculate.Location = new System.Drawing.Point(399, 354);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(160, 52);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate Outcomes";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tbConSemesters
            // 
            this.tbConSemesters.Controls.Add(this.tabSemester1);
            this.tbConSemesters.Controls.Add(this.tabSemester2);
            this.tbConSemesters.Controls.Add(this.tabSemester3);
            this.tbConSemesters.Controls.Add(this.tabSemester4);
            this.tbConSemesters.Location = new System.Drawing.Point(12, 27);
            this.tbConSemesters.Name = "tbConSemesters";
            this.tbConSemesters.SelectedIndex = 0;
            this.tbConSemesters.Size = new System.Drawing.Size(547, 281);
            this.tbConSemesters.TabIndex = 12;
            // 
            // tabSemester1
            // 
            this.tabSemester1.BackColor = System.Drawing.Color.White;
            this.tabSemester1.Controls.Add(this.grdDisplay_Sem_1);
            this.tabSemester1.Location = new System.Drawing.Point(4, 22);
            this.tabSemester1.Name = "tabSemester1";
            this.tabSemester1.Padding = new System.Windows.Forms.Padding(3);
            this.tabSemester1.Size = new System.Drawing.Size(539, 255);
            this.tabSemester1.TabIndex = 0;
            this.tabSemester1.Text = "Semester 1";
            // 
            // tabSemester2
            // 
            this.tabSemester2.BackColor = System.Drawing.Color.White;
            this.tabSemester2.Controls.Add(this.grd_Display_Sem2);
            this.tabSemester2.Location = new System.Drawing.Point(4, 22);
            this.tabSemester2.Name = "tabSemester2";
            this.tabSemester2.Padding = new System.Windows.Forms.Padding(3);
            this.tabSemester2.Size = new System.Drawing.Size(539, 255);
            this.tabSemester2.TabIndex = 1;
            this.tabSemester2.Text = "Semester 2";
            // 
            // grd_Display_Sem2
            // 
            this.grd_Display_Sem2.BackgroundColor = System.Drawing.Color.White;
            this.grd_Display_Sem2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Display_Sem2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCourseCode_2,
            this.colCreditHours_2,
            this.colPercentGrade_2,
            this.colLetterGrade_2,
            this.colCompleted_2});
            this.grd_Display_Sem2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Display_Sem2.Location = new System.Drawing.Point(3, 3);
            this.grd_Display_Sem2.Name = "grd_Display_Sem2";
            this.grd_Display_Sem2.Size = new System.Drawing.Size(533, 249);
            this.grd_Display_Sem2.TabIndex = 1;
            this.grd_Display_Sem2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Display_Sem2_CellValueChanged);
            // 
            // colCourseCode_2
            // 
            this.colCourseCode_2.HeaderText = "Course Code";
            this.colCourseCode_2.Name = "colCourseCode_2";
            // 
            // colCreditHours_2
            // 
            this.colCreditHours_2.HeaderText = "Credit Hours";
            this.colCreditHours_2.Name = "colCreditHours_2";
            // 
            // colPercentGrade_2
            // 
            this.colPercentGrade_2.HeaderText = "Grade ( % )";
            this.colPercentGrade_2.Name = "colPercentGrade_2";
            // 
            // colLetterGrade_2
            // 
            this.colLetterGrade_2.HeaderText = "Grade (Letter)";
            this.colLetterGrade_2.Name = "colLetterGrade_2";
            // 
            // colCompleted_2
            // 
            this.colCompleted_2.HeaderText = "Completed";
            this.colCompleted_2.Name = "colCompleted_2";
            this.colCompleted_2.ReadOnly = true;
            this.colCompleted_2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCompleted_2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tabSemester3
            // 
            this.tabSemester3.BackColor = System.Drawing.Color.White;
            this.tabSemester3.Controls.Add(this.grd_Display_Sem3);
            this.tabSemester3.Location = new System.Drawing.Point(4, 22);
            this.tabSemester3.Name = "tabSemester3";
            this.tabSemester3.Size = new System.Drawing.Size(539, 255);
            this.tabSemester3.TabIndex = 2;
            this.tabSemester3.Text = "Semester 3";
            // 
            // grd_Display_Sem3
            // 
            this.grd_Display_Sem3.BackgroundColor = System.Drawing.Color.White;
            this.grd_Display_Sem3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Display_Sem3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCourseCode_3,
            this.colCreditHours_3,
            this.colPercentGrade_3,
            this.colLetterGrade_3,
            this.colComplete_3});
            this.grd_Display_Sem3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Display_Sem3.Location = new System.Drawing.Point(0, 0);
            this.grd_Display_Sem3.Name = "grd_Display_Sem3";
            this.grd_Display_Sem3.Size = new System.Drawing.Size(539, 255);
            this.grd_Display_Sem3.TabIndex = 1;
            this.grd_Display_Sem3.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Display_Sem3_CellValueChanged);
            // 
            // colCourseCode_3
            // 
            this.colCourseCode_3.HeaderText = "Course Code";
            this.colCourseCode_3.Name = "colCourseCode_3";
            // 
            // colCreditHours_3
            // 
            this.colCreditHours_3.HeaderText = "Credit Hours";
            this.colCreditHours_3.Name = "colCreditHours_3";
            // 
            // colPercentGrade_3
            // 
            this.colPercentGrade_3.HeaderText = "Grade ( % )";
            this.colPercentGrade_3.Name = "colPercentGrade_3";
            // 
            // colLetterGrade_3
            // 
            this.colLetterGrade_3.HeaderText = "Grade (Letter)";
            this.colLetterGrade_3.Name = "colLetterGrade_3";
            // 
            // colComplete_3
            // 
            this.colComplete_3.HeaderText = "Completed";
            this.colComplete_3.Name = "colComplete_3";
            this.colComplete_3.ReadOnly = true;
            this.colComplete_3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colComplete_3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tabSemester4
            // 
            this.tabSemester4.BackColor = System.Drawing.Color.White;
            this.tabSemester4.Controls.Add(this.grd_Display_Sem4);
            this.tabSemester4.Location = new System.Drawing.Point(4, 22);
            this.tabSemester4.Name = "tabSemester4";
            this.tabSemester4.Size = new System.Drawing.Size(539, 255);
            this.tabSemester4.TabIndex = 3;
            this.tabSemester4.Text = "Semester 4";
            // 
            // grd_Display_Sem4
            // 
            this.grd_Display_Sem4.BackgroundColor = System.Drawing.Color.White;
            this.grd_Display_Sem4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Display_Sem4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCourseCode_4,
            this.colCreditHours_4,
            this.colPercentGrade_4,
            this.colLetterGrade_4,
            this.colCompleted_4});
            this.grd_Display_Sem4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Display_Sem4.Location = new System.Drawing.Point(0, 0);
            this.grd_Display_Sem4.Name = "grd_Display_Sem4";
            this.grd_Display_Sem4.Size = new System.Drawing.Size(539, 255);
            this.grd_Display_Sem4.TabIndex = 1;
            this.grd_Display_Sem4.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Display_Sem4_CellValueChanged);
            // 
            // colCourseCode_4
            // 
            this.colCourseCode_4.HeaderText = "Course Code";
            this.colCourseCode_4.Name = "colCourseCode_4";
            // 
            // colCreditHours_4
            // 
            this.colCreditHours_4.HeaderText = "Credit Hours";
            this.colCreditHours_4.Name = "colCreditHours_4";
            // 
            // colPercentGrade_4
            // 
            this.colPercentGrade_4.HeaderText = "Grade ( % )";
            this.colPercentGrade_4.Name = "colPercentGrade_4";
            // 
            // colLetterGrade_4
            // 
            this.colLetterGrade_4.HeaderText = "Grade (Letter)";
            this.colLetterGrade_4.Name = "colLetterGrade_4";
            // 
            // colCompleted_4
            // 
            this.colCompleted_4.HeaderText = "Completed";
            this.colCompleted_4.Name = "colCompleted_4";
            this.colCompleted_4.ReadOnly = true;
            this.colCompleted_4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCompleted_4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnTestInput
            // 
            this.btnTestInput.BackColor = System.Drawing.SystemColors.Control;
            this.btnTestInput.Location = new System.Drawing.Point(116, 315);
            this.btnTestInput.Name = "btnTestInput";
            this.btnTestInput.Size = new System.Drawing.Size(73, 91);
            this.btnTestInput.TabIndex = 13;
            this.btnTestInput.Text = "Auto Fill";
            this.btnTestInput.UseVisualStyleBackColor = false;
            this.btnTestInput.Click += new System.EventHandler(this.btnTestInput_Click);
            // 
            // cbxIncrement
            // 
            this.cbxIncrement.FormattingEnabled = true;
            this.cbxIncrement.Items.AddRange(new object[] {
            "0.10",
            "0.25",
            "0.5",
            "1.0"});
            this.cbxIncrement.Location = new System.Drawing.Point(455, 322);
            this.cbxIncrement.Name = "cbxIncrement";
            this.cbxIncrement.Size = new System.Drawing.Size(97, 21);
            this.cbxIncrement.TabIndex = 14;
            this.cbxIncrement.Text = "0.25";
            this.cbxIncrement.SelectedIndexChanged += new System.EventHandler(this.cbxIncrement_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblWarning});
            this.statusStrip1.Location = new System.Drawing.Point(0, 423);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(567, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblWarning
            // 
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(22, 17);
            this.lblWarning.Text = ". . .";
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(567, 445);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cbxIncrement);
            this.Controls.Add(this.btnTestInput);
            this.Controls.Add(this.tbConSemesters);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnDelSemester);
            this.Controls.Add(this.btnAddSemester);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTargetGPA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuMain;
            this.Name = "Editor";
            this.Text = "EZ-GPA Calculator - Editor";
            this.Load += new System.EventHandler(this.Calculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplay_Sem_1)).EndInit();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.tbConSemesters.ResumeLayout(false);
            this.tabSemester1.ResumeLayout(false);
            this.tabSemester2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Display_Sem2)).EndInit();
            this.tabSemester3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Display_Sem3)).EndInit();
            this.tabSemester4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Display_Sem4)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDisplay_Sem_1;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuMainFile;
        private System.Windows.Forms.ToolStripMenuItem mnuMainHelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTargetGPA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddSemester;
        private System.Windows.Forms.Button btnDelSemester;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TabControl tbConSemesters;
        private System.Windows.Forms.TabPage tabSemester1;
        private System.Windows.Forms.TabPage tabSemester2;
        private System.Windows.Forms.DataGridView grd_Display_Sem2;
        private System.Windows.Forms.TabPage tabSemester3;
        private System.Windows.Forms.DataGridView grd_Display_Sem3;
        private System.Windows.Forms.TabPage tabSemester4;
        private System.Windows.Forms.DataGridView grd_Display_Sem4;
        private System.Windows.Forms.Button btnTestInput;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourseCode_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditHours_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPercentGrade_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLetterGrade_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComplete_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourseCode_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditHours_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPercentGrade_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLetterGrade_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompleted_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourseCode_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditHours_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPercentGrade_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLetterGrade_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComplete_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourseCode_4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditHours_4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPercentGrade_4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLetterGrade_4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompleted_4;
        private System.Windows.Forms.ComboBox cbxIncrement;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblWarning;
    }
}

