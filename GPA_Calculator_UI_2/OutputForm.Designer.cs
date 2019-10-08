namespace GPA_Calculator_UI_2
{
    partial class frmOutput
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
            this.lblMinimum = new System.Windows.Forms.Label();
            this.lblMaximum = new System.Windows.Forms.Label();
            this.lblCurrentGPA = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblOutputDirectory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.Location = new System.Drawing.Point(16, 31);
            this.lblMinimum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(150, 17);
            this.lblMinimum.TabIndex = 0;
            this.lblMinimum.Text = "Lowest passing GPA : ";
            // 
            // lblMaximum
            // 
            this.lblMaximum.AutoSize = true;
            this.lblMaximum.Location = new System.Drawing.Point(9, 149);
            this.lblMaximum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaximum.Name = "lblMaximum";
            this.lblMaximum.Size = new System.Drawing.Size(173, 17);
            this.lblMaximum.TabIndex = 1;
            this.lblMaximum.Text = "Highest achievable GPA:  ";
            // 
            // lblCurrentGPA
            // 
            this.lblCurrentGPA.AutoSize = true;
            this.lblCurrentGPA.Location = new System.Drawing.Point(11, 256);
            this.lblCurrentGPA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentGPA.Name = "lblCurrentGPA";
            this.lblCurrentGPA.Size = new System.Drawing.Size(165, 17);
            this.lblCurrentGPA.TabIndex = 2;
            this.lblCurrentGPA.Text = "Current Cumulative GPA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 369);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Location of Output Files:";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(52, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(570, 48);
            this.label5.TabIndex = 4;
            this.label5.Text = "In the output directory, the file called minimum.txt shows the minimum grade in e" +
    "ach course that is  needed to graduate. \r\n\r\n";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(52, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "In the output directory, the file called maximum.txt shows what the cumulative GP" +
    "A would be with \'A\' grades in all outstanding courses. \r\n";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(52, 278);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(570, 48);
            this.label6.TabIndex = 6;
            this.label6.Text = "In the output directory, the file named original.txt shows the current state of t" +
    "he transcript, and current GPA. \r\nThis does not include incomplete courses.\r\n";
            // 
            // lblOutputDirectory
            // 
            this.lblOutputDirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutputDirectory.Location = new System.Drawing.Point(52, 399);
            this.lblOutputDirectory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutputDirectory.Name = "lblOutputDirectory";
            this.lblOutputDirectory.Size = new System.Drawing.Size(570, 48);
            this.lblOutputDirectory.TabIndex = 7;
            // 
            // frmOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 513);
            this.Controls.Add(this.lblOutputDirectory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCurrentGPA);
            this.Controls.Add(this.lblMaximum);
            this.Controls.Add(this.lblMinimum);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmOutput";
            this.Text = "OutputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMinimum;
        private System.Windows.Forms.Label lblMaximum;
        private System.Windows.Forms.Label lblCurrentGPA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblOutputDirectory;
    }
}