namespace GPA_Calculator_UI_2
{
    partial class Calculator
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
            this.grdDisplay_Sem_1 = new System.Windows.Forms.DataGridView();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuMainFile = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTargetGPA = new System.Windows.Forms.TextBox();
            this.txtIncrement = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddSemester = new System.Windows.Forms.Button();
            this.btnDelSemester = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.radNotPrintToFile = new System.Windows.Forms.RadioButton();
            this.radPrintToFile = new System.Windows.Forms.RadioButton();
            this.tbConSemesters = new System.Windows.Forms.TabControl();
            this.tabSemester1 = new System.Windows.Forms.TabPage();
            this.tabSemester2 = new System.Windows.Forms.TabPage();
            this.grd_Display_Sem2 = new System.Windows.Forms.DataGridView();
            this.tabSemester3 = new System.Windows.Forms.TabPage();
            this.grd_Display_Sem3 = new System.Windows.Forms.DataGridView();
            this.tabSemester4 = new System.Windows.Forms.TabPage();
            this.grd_Display_Sem4 = new System.Windows.Forms.DataGridView();
            this.btnTestInput = new System.Windows.Forms.Button();
            this.colCourseCode_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditHours_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPercentGrade_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLetterGrade_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComplete_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourseCode_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditHours_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPercentGrade_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLetterGrade_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompleted_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourseCode_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditHours_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPercentGrade_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLetterGrade_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComplete_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourseCode_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditHours_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPercentGrade_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLetterGrade_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompleted_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplay_Sem_1)).BeginInit();
            this.mnuMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tbConSemesters.SuspendLayout();
            this.tabSemester1.SuspendLayout();
            this.tabSemester2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Display_Sem2)).BeginInit();
            this.tabSemester3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Display_Sem3)).BeginInit();
            this.tabSemester4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Display_Sem4)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDisplay_Sem_1
            // 
            this.grdDisplay_Sem_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDisplay_Sem_1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCourseCode_1,
            this.colCreditHours_1,
            this.colPercentGrade_1,
            this.colLetterGrade_1,
            this.colComplete_1});
            this.grdDisplay_Sem_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDisplay_Sem_1.Location = new System.Drawing.Point(4, 4);
            this.grdDisplay_Sem_1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdDisplay_Sem_1.Name = "grdDisplay_Sem_1";
            this.grdDisplay_Sem_1.Size = new System.Drawing.Size(713, 309);
            this.grdDisplay_Sem_1.TabIndex = 0;
            this.grdDisplay_Sem_1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Display_Sem1_CellValueChanged);
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainFile,
            this.mnuMainHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnuMain.Size = new System.Drawing.Size(756, 28);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuMainFile
            // 
            this.mnuMainFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.mnuMainFile.Name = "mnuMainFile";
            this.mnuMainFile.Size = new System.Drawing.Size(44, 24);
            this.mnuMainFile.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // mnuMainHelp
            // 
            this.mnuMainHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem});
            this.mnuMainHelp.Name = "mnuMainHelp";
            this.mnuMainHelp.Size = new System.Drawing.Size(53, 24);
            this.mnuMainHelp.Text = "Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.instructionsToolStripMenuItem.Text = "&Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 400);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Target GPA: ";
            // 
            // txtTargetGPA
            // 
            this.txtTargetGPA.Location = new System.Drawing.Point(360, 396);
            this.txtTargetGPA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTargetGPA.Name = "txtTargetGPA";
            this.txtTargetGPA.Size = new System.Drawing.Size(132, 22);
            this.txtTargetGPA.TabIndex = 3;
            // 
            // txtIncrement
            // 
            this.txtIncrement.Location = new System.Drawing.Point(612, 396);
            this.txtIncrement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIncrement.Name = "txtIncrement";
            this.txtIncrement.Size = new System.Drawing.Size(132, 22);
            this.txtIncrement.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 400);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Increment:";
            // 
            // btnAddSemester
            // 
            this.btnAddSemester.Location = new System.Drawing.Point(16, 388);
            this.btnAddSemester.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddSemester.Name = "btnAddSemester";
            this.btnAddSemester.Size = new System.Drawing.Size(129, 54);
            this.btnAddSemester.TabIndex = 8;
            this.btnAddSemester.Text = "Add Another Semester";
            this.btnAddSemester.UseVisualStyleBackColor = true;
            this.btnAddSemester.Click += new System.EventHandler(this.btnAddSemester_Click);
            // 
            // btnDelSemester
            // 
            this.btnDelSemester.Location = new System.Drawing.Point(16, 449);
            this.btnDelSemester.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelSemester.Name = "btnDelSemester";
            this.btnDelSemester.Size = new System.Drawing.Size(129, 50);
            this.btnDelSemester.TabIndex = 9;
            this.btnDelSemester.Text = "Delete Current Semester";
            this.btnDelSemester.UseVisualStyleBackColor = true;
            this.btnDelSemester.Click += new System.EventHandler(this.btnDelSemester_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(532, 436);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(213, 64);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Get Results";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.radNotPrintToFile);
            this.panel1.Controls.Add(this.radPrintToFile);
            this.panel1.Location = new System.Drawing.Point(264, 436);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 64);
            this.panel1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Print Results to file?";
            // 
            // radNotPrintToFile
            // 
            this.radNotPrintToFile.AutoSize = true;
            this.radNotPrintToFile.Location = new System.Drawing.Point(172, 34);
            this.radNotPrintToFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radNotPrintToFile.Name = "radNotPrintToFile";
            this.radNotPrintToFile.Size = new System.Drawing.Size(47, 21);
            this.radNotPrintToFile.TabIndex = 1;
            this.radNotPrintToFile.TabStop = true;
            this.radNotPrintToFile.Text = "No";
            this.radNotPrintToFile.UseVisualStyleBackColor = true;
            // 
            // radPrintToFile
            // 
            this.radPrintToFile.AutoSize = true;
            this.radPrintToFile.Location = new System.Drawing.Point(172, 11);
            this.radPrintToFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radPrintToFile.Name = "radPrintToFile";
            this.radPrintToFile.Size = new System.Drawing.Size(53, 21);
            this.radPrintToFile.TabIndex = 0;
            this.radPrintToFile.TabStop = true;
            this.radPrintToFile.Text = "Yes";
            this.radPrintToFile.UseVisualStyleBackColor = true;
            // 
            // tbConSemesters
            // 
            this.tbConSemesters.Controls.Add(this.tabSemester1);
            this.tbConSemesters.Controls.Add(this.tabSemester2);
            this.tbConSemesters.Controls.Add(this.tabSemester3);
            this.tbConSemesters.Controls.Add(this.tabSemester4);
            this.tbConSemesters.Location = new System.Drawing.Point(16, 33);
            this.tbConSemesters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbConSemesters.Name = "tbConSemesters";
            this.tbConSemesters.SelectedIndex = 0;
            this.tbConSemesters.Size = new System.Drawing.Size(729, 346);
            this.tbConSemesters.TabIndex = 12;
            // 
            // tabSemester1
            // 
            this.tabSemester1.Controls.Add(this.grdDisplay_Sem_1);
            this.tabSemester1.Location = new System.Drawing.Point(4, 25);
            this.tabSemester1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabSemester1.Name = "tabSemester1";
            this.tabSemester1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabSemester1.Size = new System.Drawing.Size(721, 317);
            this.tabSemester1.TabIndex = 0;
            this.tabSemester1.Text = "Semester 1";
            this.tabSemester1.UseVisualStyleBackColor = true;
            // 
            // tabSemester2
            // 
            this.tabSemester2.Controls.Add(this.grd_Display_Sem2);
            this.tabSemester2.Location = new System.Drawing.Point(4, 25);
            this.tabSemester2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabSemester2.Name = "tabSemester2";
            this.tabSemester2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabSemester2.Size = new System.Drawing.Size(721, 317);
            this.tabSemester2.TabIndex = 1;
            this.tabSemester2.Text = "Semester 2";
            this.tabSemester2.UseVisualStyleBackColor = true;
            // 
            // grd_Display_Sem2
            // 
            this.grd_Display_Sem2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Display_Sem2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCourseCode_2,
            this.colCreditHours_2,
            this.colPercentGrade_2,
            this.colLetterGrade_2,
            this.colCompleted_2});
            this.grd_Display_Sem2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Display_Sem2.Location = new System.Drawing.Point(4, 4);
            this.grd_Display_Sem2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grd_Display_Sem2.Name = "grd_Display_Sem2";
            this.grd_Display_Sem2.Size = new System.Drawing.Size(713, 309);
            this.grd_Display_Sem2.TabIndex = 1;
            this.grd_Display_Sem2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Display_Sem2_CellValueChanged);
            // 
            // tabSemester3
            // 
            this.tabSemester3.Controls.Add(this.grd_Display_Sem3);
            this.tabSemester3.Location = new System.Drawing.Point(4, 25);
            this.tabSemester3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabSemester3.Name = "tabSemester3";
            this.tabSemester3.Size = new System.Drawing.Size(721, 317);
            this.tabSemester3.TabIndex = 2;
            this.tabSemester3.Text = "Semester 3";
            this.tabSemester3.UseVisualStyleBackColor = true;
            // 
            // grd_Display_Sem3
            // 
            this.grd_Display_Sem3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Display_Sem3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCourseCode_3,
            this.colCreditHours_3,
            this.colPercentGrade_3,
            this.colLetterGrade_3,
            this.colComplete_3});
            this.grd_Display_Sem3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Display_Sem3.Location = new System.Drawing.Point(0, 0);
            this.grd_Display_Sem3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grd_Display_Sem3.Name = "grd_Display_Sem3";
            this.grd_Display_Sem3.Size = new System.Drawing.Size(721, 317);
            this.grd_Display_Sem3.TabIndex = 1;
            this.grd_Display_Sem3.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Display_Sem3_CellValueChanged);
            // 
            // tabSemester4
            // 
            this.tabSemester4.Controls.Add(this.grd_Display_Sem4);
            this.tabSemester4.Location = new System.Drawing.Point(4, 25);
            this.tabSemester4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabSemester4.Name = "tabSemester4";
            this.tabSemester4.Size = new System.Drawing.Size(721, 317);
            this.tabSemester4.TabIndex = 3;
            this.tabSemester4.Text = "Semester 4";
            this.tabSemester4.UseVisualStyleBackColor = true;
            // 
            // grd_Display_Sem4
            // 
            this.grd_Display_Sem4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Display_Sem4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCourseCode_4,
            this.colCreditHours_4,
            this.colPercentGrade_4,
            this.colLetterGrade_4,
            this.colCompleted_4});
            this.grd_Display_Sem4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Display_Sem4.Location = new System.Drawing.Point(0, 0);
            this.grd_Display_Sem4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grd_Display_Sem4.Name = "grd_Display_Sem4";
            this.grd_Display_Sem4.Size = new System.Drawing.Size(721, 317);
            this.grd_Display_Sem4.TabIndex = 1;
            this.grd_Display_Sem4.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Display_Sem4_CellValueChanged);
            // 
            // btnTestInput
            // 
            this.btnTestInput.Location = new System.Drawing.Point(155, 388);
            this.btnTestInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTestInput.Name = "btnTestInput";
            this.btnTestInput.Size = new System.Drawing.Size(97, 112);
            this.btnTestInput.TabIndex = 13;
            this.btnTestInput.Text = "Validate Input";
            this.btnTestInput.UseVisualStyleBackColor = true;
            this.btnTestInput.Click += new System.EventHandler(this.btnTestInput_Click);
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
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 511);
            this.Controls.Add(this.btnTestInput);
            this.Controls.Add(this.tbConSemesters);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnDelSemester);
            this.Controls.Add(this.btnAddSemester);
            this.Controls.Add(this.txtIncrement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTargetGPA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Calculator";
            this.Text = "EZ-GPA Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplay_Sem_1)).EndInit();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbConSemesters.ResumeLayout(false);
            this.tabSemester1.ResumeLayout(false);
            this.tabSemester2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Display_Sem2)).EndInit();
            this.tabSemester3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Display_Sem3)).EndInit();
            this.tabSemester4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Display_Sem4)).EndInit();
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
        private System.Windows.Forms.TextBox txtIncrement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddSemester;
        private System.Windows.Forms.Button btnDelSemester;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radNotPrintToFile;
        private System.Windows.Forms.RadioButton radPrintToFile;
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
    }
}

