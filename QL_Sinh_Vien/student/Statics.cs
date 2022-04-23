using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Sinh_Vien
{
    public partial class Statics : Form
    {
        public Statics()
        {
            InitializeComponent();
        }

        private void Statics_Load(object sender, EventArgs e)
        {
            STUDENT std = new STUDENT();
            double total = Convert.ToDouble(std.totalStudents());
            double totalMale = Convert.ToDouble(std.totalMale());
            double totalFeMale = Convert.ToDouble(std.totalFemale());
            double malePer = (totalMale / total * 100);
            double femalePer = (totalFeMale / total * 100);
            lb_Female.Text = ("Female: " + femalePer.ToString("0.00") + "%");
            lb_Male.Text = ("Male: " + malePer.ToString("0.00") + "%");
            lb_student.Text = ("Total Students: " + total.ToString());
        }

        private void btn_Chart_Click(object sender, EventArgs e)
        {
            STUDENT std = new STUDENT();
            double total = Convert.ToDouble(std.totalStudents());
            double totalMale = Convert.ToDouble(std.totalMale());
            double totalFeMale = Convert.ToDouble(std.totalFemale());
            double malePer = (totalMale / total * 100);
            double femalePer = (totalFeMale / total * 100);
            Chart t = new Chart();
            t.f = 2;
            t.m = 2;
            t.ShowDialog();
        }

    }
}
