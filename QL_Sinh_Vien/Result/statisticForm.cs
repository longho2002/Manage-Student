using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using LiveCharts;
using LiveCharts.Wpf;

namespace QL_Sinh_Vien.Result
{
    public partial class statisticForm : Form
    {
        public statisticForm()
        {
            InitializeComponent();
        }

        Label createlb(string title, int x, int y)
        {
            Label lb_score = new Label();

            lb_score.AutoSize = true;
            lb_score.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            lb_score.Location = new Point(x, y);
            lb_score.Size = new Size(72, 25);
            lb_score.ForeColor = Color.AliceBlue;
            lb_score.Text = title;
            return lb_score;
        }

        private void statisticForm_Load(object sender, EventArgs e)
        {
            string s;
            MY_DB db = new MY_DB();
            SqlCommand command =
                new SqlCommand(
                    "select LABEL, avg(student_score)  from course left join score on id = course_id group by LABEL",
                    db.getConnection);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            int total = dt.Rows.Count;
            for (int i = 0; i < total; i++)
            {
                s = dt.Rows[i][0].ToString() + ": " + dt.Rows[i][1].ToString();
                pan_score.Controls.Add(createlb(s, 29, 34 + i * 30));
            }
            DataTable dtRes =new DataTable();
            command = new SqlCommand("select student_id, avg(student_score) as dtb from score group by student_id", db.getConnection);
            adapter.SelectCommand = command;
            adapter.Fill(dtRes);

            int a = dtRes.Rows.Count;
            int gioi = 0, kha = 0, tb = 0, rot = 0;
            for (int i = 0; i < a; i++)
            {
                double d = Math.Round(Convert.ToDouble(dt.Rows[i][1].ToString()), 2);
                if (d >= 8.5)
                    gioi++;
                else if (d < 8.5 && d >= 6.5)
                    kha++;
                else if (d < 6.5 && d >= 5)
                    tb++;
                else
                {
                    rot++;
                }
            }
            lb_gioi.Text = gioi.ToString();
            lb_kha.Text = kha.ToString();
            lb_tb.Text = tb.ToString();
            lb_fail.Text = rot.ToString();

            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Giỏi",
                    Values = new ChartValues<double> {Convert.ToDouble(lb_gioi.Text) },
                    DataLabels = true,
                },
                new PieSeries
                {
                    Title = "Khá",
                    Values = new ChartValues<double> {Convert.ToDouble(lb_kha.Text)},
                    DataLabels = true,
                },
                new PieSeries
                {
                    Title = "Trung bình",
                    Values = new ChartValues<double> {Convert.ToDouble(lb_tb.Text)},
                    DataLabels = true,
                },
                new PieSeries
                {
                    Title = "Rớt",
                    Values = new ChartValues<double> {Convert.ToDouble(lb_fail.Text)},
                    DataLabels = true,
                },
            };
            pieChart1.LegendLocation = LegendLocation.Right;
        }
    }
}
