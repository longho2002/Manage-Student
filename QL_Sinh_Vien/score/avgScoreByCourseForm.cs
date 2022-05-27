using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Sinh_Vien.score
{
    public partial class avgScoreByCourseForm : Form
    {
        private Score score = new Score();
        public avgScoreByCourseForm()
        {
            InitializeComponent();
        }

        private void avgScoreByCourseForm_Load(object sender, EventArgs e)
        {
            DataTable dtb = score.getAvgScoreByCourse();
            dataGridView1.DataSource = dtb;
            chart1.Series[0].Name = "Score";
            foreach (DataRow item in dtb.Rows)
            {
                chart1.Series["Score"].Points.AddXY(item["label"].ToString(), item["AverageGrade"].ToString());
            }
            chart1.Titles.Add("Average Score");

        }
    }
}
