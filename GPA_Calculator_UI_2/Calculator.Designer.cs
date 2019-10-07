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
            this.colCourseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPercentGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLetterGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComplete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuMainFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainHelp = new System.Windows.Forms.ToolStripMenuItem();
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabSemester3 = new System.Windows.Forms.TabPage();
            this.grd_Display_Sem3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabSemester4 = new System.Windows.Forms.TabPage();
            this.grd_Display_Sem4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnTestInput = new System.Windows.Forms.Button();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.colCourseCode,
            this.colCreditHours,
            this.colPercentGrade,
            this.colLetterGrade,
            this.colComplete});
            this.grdDisplay_Sem_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDisplay_Sem_1.Location = new System.Drawing.Point(3, 3);
            this.grdDisplay_Sem_1.Name = "grdDisplay_Sem_1";
            this.grdDisplay_Sem_1.Size = new System.Drawing.Size(533, 249);
            this.grdDisplay_Sem_1.TabIndex = 0;
            this.grdDisplay_Sem_1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Display_Sem1_CellValueChanged);
            // 
            // colCourseCode
            // 
            this.colCourseCode.HeaderText = "Course Code";
            this.colCourseCode.Name = "colCourseCode";
            // 
            // colCreditHours
            // 
            this.colCreditHours.HeaderText = "Credit Hours";
            this.colCreditHours.Name = "colCreditHours";
            // 
            // colPercentGrade
            // 
            this.colPercentGrade.HeaderText = "Grade ( % )";
            this.colPercentGrade.Name = "colPercentGrade";
            // 
            // colLetterGrade
            // 
            this.colLetterGrade.HeaderText = "Grade (Letter)";
            this.colLetterGrade.Name = "colLetterGrade";
            // 
            // colComplete
            // 
            this.colComplete.HeaderText = "Completed";
            this.colComplete.Name = "colComplete";
            this.colComplete.ReadOnly = true;
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainFile,
            this.mnuMainHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(571, 24);
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
            // mnuMainHelp
            // 
            this.mnuMainHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem});
            this.mnuMainHelp.Name = "mnuMainHelp";
            this.mnuMainHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuMainHelp.Text = "Help";
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
            // 
            // txtIncrement
            // 
            this.txtIncrement.Location = new System.Drawing.Point(459, 322);
            this.txtIncrement.Name = "txtIncrement";
            this.txtIncrement.Size = new System.Drawing.Size(100, 20);
            this.txtIncrement.TabIndex = 5;
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
            this.btnAddSemester.Location = new System.Drawing.Point(12, 315);
            this.btnAddSemester.Name = "btnAddSemester";
            this.btnAddSemester.Size = new System.Drawing.Size(97, 44);
            this.btnAddSemester.TabIndex = 8;
            this.btnAddSemester.Text = "Add Another Semester";
            this.btnAddSemester.UseVisualStyleBackColor = true;
            this.btnAddSemester.Click += new System.EventHandler(this.btnAddSemester_Click);
            // 
            // btnDelSemester
            // 
            this.btnDelSemester.Location = new System.Drawing.Point(12, 365);
            this.btnDelSemester.Name = "btnDelSemester";
            this.btnDelSemester.Size = new System.Drawing.Size(97, 41);
            this.btnDelSemester.TabIndex = 9;
            this.btnDelSemester.Text = "Delete Current Semester";
            this.btnDelSemester.UseVisualStyleBackColor = true;
            this.btnDelSemester.Click += new System.EventHandler(this.btnDelSemester_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(399, 354);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(160, 52);
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
            this.panel1.Location = new System.Drawing.Point(198, 354);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 52);
            this.panel1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(13, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Print Results to file?";
            // 
            // radNotPrintToFile
            // 
            this.radNotPrintToFile.AutoSize = true;
            this.radNotPrintToFile.Location = new System.Drawing.Point(129, 28);
            this.radNotPrintToFile.Name = "radNotPrintToFile";
            this.radNotPrintToFile.Size = new System.Drawing.Size(39, 17);
            this.radNotPrintToFile.TabIndex = 1;
            this.radNotPrintToFile.TabStop = true;
            this.radNotPrintToFile.Text = "No";
            this.radNotPrintToFile.UseVisualStyleBackColor = true;
            // 
            // radPrintToFile
            // 
            this.radPrintToFile.AutoSize = true;
            this.radPrintToFile.Location = new System.Drawing.Point(129, 9);
            this.radPrintToFile.Name = "radPrintToFile";
            this.radPrintToFile.Size = new System.Drawing.Size(43, 17);
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
            this.tbConSemesters.Location = new System.Drawing.Point(12, 27);
            this.tbConSemesters.Name = "tbConSemesters";
            this.tbConSemesters.SelectedIndex = 0;
            this.tbConSemesters.Size = new System.Drawing.Size(547, 281);
            this.tbConSemesters.TabIndex = 12;
            // 
            // tabSemester1
            // 
            this.tabSemester1.Controls.Add(this.grdDisplay_Sem_1);
            this.tabSemester1.Location = new System.Drawing.Point(4, 22);
            this.tabSemester1.Name = "tabSemester1";
            this.tabSemester1.Padding = new System.Windows.Forms.Padding(3);
            this.tabSemester1.Size = new System.Drawing.Size(539, 255);
            this.tabSemester1.TabIndex = 0;
            this.tabSemester1.Text = "Semester 1";
            this.tabSemester1.UseVisualStyleBackColor = true;
            // 
            // tabSemester2
            // 
            this.tabSemester2.Controls.Add(this.grd_Display_Sem2);
            this.tabSemester2.Location = new System.Drawing.Point(4, 22);
            this.tabSemester2.Name = "tabSemester2";
            this.tabSemester2.Padding = new System.Windows.Forms.Padding(3);
            this.tabSemester2.Size = new System.Drawing.Size(539, 255);
            this.tabSemester2.TabIndex = 1;
            this.tabSemester2.Text = "Semester 2";
            this.tabSemester2.UseVisualStyleBackColor = true;
            // 
            // grd_Display_Sem2
            // 
            this.grd_Display_Sem2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Display_Sem2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.grd_Display_Sem2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Display_Sem2.Location = new System.Drawing.Point(3, 3);
            this.grd_Display_Sem2.Name = "grd_Display_Sem2";
            this.grd_Display_Sem2.Size = new System.Drawing.Size(533, 249);
            this.grd_Display_Sem2.TabIndex = 1;
            this.grd_Display_Sem2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Display_Sem2_CellValueChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Course Code";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Credit Hours";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Grade ( % )";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Grade (Letter)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Completed";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // tabSemester3
            // 
            this.tabSemester3.Controls.Add(this.grd_Display_Sem3);
            this.tabSemester3.Location = new System.Drawing.Point(4, 22);
            this.tabSemester3.Name = "tabSemester3";
            this.tabSemester3.Size = new System.Drawing.Size(539, 255);
            this.tabSemester3.TabIndex = 2;
            this.tabSemester3.Text = "Semester 3";
            this.tabSemester3.UseVisualStyleBackColor = true;
            // 
            // grd_Display_Sem3
            // 
            this.grd_Display_Sem3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Display_Sem3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn2});
            this.grd_Display_Sem3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Display_Sem3.Location = new System.Drawing.Point(0, 0);
            this.grd_Display_Sem3.Name = "grd_Display_Sem3";
            this.grd_Display_Sem3.Size = new System.Drawing.Size(539, 255);
            this.grd_Display_Sem3.TabIndex = 1;
            this.grd_Display_Sem3.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Display_Sem3_CellValueChanged);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Course Code";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Credit Hours";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Grade ( % )";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Grade (Letter)";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.HeaderText = "Completed";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            // 
            // tabSemester4
            // 
            this.tabSemester4.Controls.Add(this.grd_Display_Sem4);
            this.tabSemester4.Location = new System.Drawing.Point(4, 22);
            this.tabSemester4.Name = "tabSemester4";
            this.tabSemester4.Size = new System.Drawing.Size(539, 255);
            this.tabSemester4.TabIndex = 3;
            this.tabSemester4.Text = "Semester 4";
            this.tabSemester4.UseVisualStyleBackColor = true;
            // 
            // grd_Display_Sem4
            // 
            this.grd_Display_Sem4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Display_Sem4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewCheckBoxColumn3});
            this.grd_Display_Sem4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Display_Sem4.Location = new System.Drawing.Point(0, 0);
            this.grd_Display_Sem4.Name = "grd_Display_Sem4";
            this.grd_Display_Sem4.Size = new System.Drawing.Size(539, 255);
            this.grd_Display_Sem4.TabIndex = 1;
            this.grd_Display_Sem4.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Display_Sem4_CellValueChanged);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Course Code";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Credit Hours";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Grade ( % )";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Grade (Letter)";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.HeaderText = "Completed";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.ReadOnly = true;
            // 
            // btnTestInput
            // 
            this.btnTestInput.Location = new System.Drawing.Point(116, 315);
            this.btnTestInput.Name = "btnTestInput";
            this.btnTestInput.Size = new System.Drawing.Size(73, 91);
            this.btnTestInput.TabIndex = 13;
            this.btnTestInput.Text = "Validate Input";
            this.btnTestInput.UseVisualStyleBackColor = true;
            this.btnTestInput.Click += new System.EventHandler(this.btnTestInput_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.instructionsToolStripMenuItem.Text = "&Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 418);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPercentGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLetterGrade;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colComplete;
        private System.Windows.Forms.TabControl tbConSemesters;
        private System.Windows.Forms.TabPage tabSemester1;
        private System.Windows.Forms.TabPage tabSemester2;
        private System.Windows.Forms.DataGridView grd_Display_Sem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TabPage tabSemester3;
        private System.Windows.Forms.DataGridView grd_Display_Sem3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.TabPage tabSemester4;
        private System.Windows.Forms.DataGridView grd_Display_Sem4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.Button btnTestInput;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
    }
}

