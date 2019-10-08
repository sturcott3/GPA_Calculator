using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPA_Calculator_UI_2
{
    public partial class frmOutput : Form
    {
        public frmOutput(string minGPA, string maxGPA, string CurrentCumuGPA, string outPutDirectory)
        {
            InitializeComponent();
            lblMinimum.Text = "Lowest passing GPA: " + minGPA;
            lblMaximum.Text = "Highest achievable GPA: " + maxGPA;
            lblCurrentGPA.Text = "Current Cumulative GPA: " + CurrentCumuGPA;
            lblOutputDirectory.Text = outPutDirectory;
        }
    }
}
