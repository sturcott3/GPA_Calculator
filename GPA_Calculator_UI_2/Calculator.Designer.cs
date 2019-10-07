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
            this.grdCourseDisplay = new System.Windows.Forms.DataGridView();
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
            this.lbxSemesters = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddSemester = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.radNotPrintToFile = new System.Windows.Forms.RadioButton();
            this.radPrintToFile = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdCourseDisplay)).BeginInit();
            this.mnuMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdCourseDisplay
            // 
            this.grdCourseDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCourseDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCourseCode,
            this.colCreditHours,
            this.colPercentGrade,
            this.colLetterGrade,
            this.colComplete});
            this.grdCourseDisplay.Location = new System.Drawing.Point(12, 44);
            this.grdCourseDisplay.Name = "grdCourseDisplay";
            this.grdCourseDisplay.Size = new System.Drawing.Size(542, 278);
            this.grdCourseDisplay.TabIndex = 0;
            this.grdCourseDisplay.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCourseDisplay_CellValueChanged);
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
            this.mnuMainFile.Name = "mnuMainFile";
            this.mnuMainFile.Size = new System.Drawing.Size(37, 20);
            this.mnuMainFile.Text = "File";
            // 
            // mnuMainHelp
            // 
            this.mnuMainHelp.Name = "mnuMainHelp";
            this.mnuMainHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuMainHelp.Text = "Help";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Target GPA: ";
            // 
            // txtTargetGPA
            // 
            this.txtTargetGPA.Location = new System.Drawing.Point(270, 328);
            this.txtTargetGPA.Name = "txtTargetGPA";
            this.txtTargetGPA.Size = new System.Drawing.Size(100, 20);
            this.txtTargetGPA.TabIndex = 3;
            // 
            // txtIncrement
            // 
            this.txtIncrement.Location = new System.Drawing.Point(459, 328);
            this.txtIncrement.Name = "txtIncrement";
            this.txtIncrement.Size = new System.Drawing.Size(100, 20);
            this.txtIncrement.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Increment:";
            // 
            // lbxSemesters
            // 
            this.lbxSemesters.FormattingEnabled = true;
            this.lbxSemesters.Items.AddRange(new object[] {
            "Semester 1"});
            this.lbxSemesters.Location = new System.Drawing.Point(69, 331);
            this.lbxSemesters.Name = "lbxSemesters";
            this.lbxSemesters.Size = new System.Drawing.Size(120, 82);
            this.lbxSemesters.TabIndex = 6;
            this.lbxSemesters.SelectedIndexChanged += new System.EventHandler(this.lbxSemesters_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Semester: ";
            // 
            // btnAddSemester
            // 
            this.btnAddSemester.Location = new System.Drawing.Point(15, 352);
            this.btnAddSemester.Name = "btnAddSemester";
            this.btnAddSemester.Size = new System.Drawing.Size(43, 23);
            this.btnAddSemester.TabIndex = 8;
            this.btnAddSemester.Text = "+ Semester";
            this.btnAddSemester.UseVisualStyleBackColor = true;
            this.btnAddSemester.Click += new System.EventHandler(this.btnAddSemester_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Del";
            this.button2.UseVisualStyleBackColor = true;
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
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 418);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddSemester);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbxSemesters);
            this.Controls.Add(this.txtIncrement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTargetGPA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdCourseDisplay);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "Calculator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Calculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCourseDisplay)).EndInit();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCourseDisplay;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuMainFile;
        private System.Windows.Forms.ToolStripMenuItem mnuMainHelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTargetGPA;
        private System.Windows.Forms.TextBox txtIncrement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxSemesters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddSemester;
        private System.Windows.Forms.Button button2;
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
    }
}

