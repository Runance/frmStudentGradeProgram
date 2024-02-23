using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Student_name = Convert.ToString(Name.Text);
            double EnglishGrade = Convert.ToDouble(EnglishG.Text);
            double MathGrade = Convert.ToDouble(MathG.Text);
            double ScienceGrade = Convert.ToDouble(ScienceG.Text);
            double FilipinoGrade = Convert.ToDouble(FilipinoG.Text);
            double HistoryGrade = Convert.ToDouble(HistoryG.Text);

            double AverageGrade = ( EnglishGrade + MathGrade + ScienceGrade + FilipinoGrade + HistoryGrade) / 5;
            View.Visible = true;
            View.Text = AverageGrade >= 75.00 ? "The Student Passed The General Average " + Student_name + " Is " + AverageGrade : "The Student failed " + AverageGrade;
            
            
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
