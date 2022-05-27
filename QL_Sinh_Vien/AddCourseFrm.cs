using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Forms;
using QL_Sinh_Vien.score;
using MessageBox = System.Windows.Forms.MessageBox;

namespace QL_Sinh_Vien
{
    public partial class AddCourseFrm : Form
    {
        private List<string> idCourse = new List<string>();
        private List<string> choose = new List<string>();
        private STUDENT std = new STUDENT();
        private MY_DB db = new MY_DB();
        private Score score = new Score();
        public AddCourseFrm()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            object a = ListtBoxCourses.SelectedItem;
            if (a != null)
            {
                choose.Add(idCourse[ListtBoxCourses.Items.IndexOf(a)]);
                listBox1.Items.Add(a);
                ListtBoxCourses.Items.Remove(a);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            foreach (string item in choose)
            {
                score.insertScore(Convert.ToInt32(tb_id.Text), Convert.ToInt32(item), 0, "null");
            }

            MessageBox.Show("Add success full");
        }

        private void AddCourseFrm_Load(object sender, EventArgs e)
        {
            //SqlCommand cmd = new SqlCommand("SELECT * FROM STD WHERE ID = @id");
            //cmd.Parameters.Add("@ID", SqlDbType.Int).Value = tb_id.Text;
            //DataTable dt = std.getStudents(cmd);

            SqlCommand cmd = new SqlCommand("SELECT distinct semester FROM COURSE", db.getConnection);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            foreach (DataRow v in dt.Rows)
            {
                cb_semester.Items.Add(v["semester"]);
            }
            cmd = new SqlCommand(
                "select * from course where id not  in (select course_id from course left join score on ID = score.course_id where score.student_id = @id) and semester = @se",
                db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = tb_id.Text;
            cmd.Parameters.Add("@se", SqlDbType.VarChar).Value = cb_semester.SelectedText;
            DataTable tmp = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(tmp);
            foreach (DataRow v in tmp.Rows)
            {
                idCourse.Add(v["label"].ToString());
                ListtBoxCourses.Items.Add(v["id"]);
            }
        }

        private void cb_semester_SelectedValueChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(
                "select * from course where id not  in (select course_id from course left join score on ID = score.course_id where score.student_id = @id) and semester = @se",
                db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = tb_id.Text;
            
            cmd.Parameters.Add("@se", SqlDbType.VarChar).Value = cb_semester.SelectedItem;
            DataTable tmp = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(tmp);
            idCourse.Clear();
            choose.Clear();
            listBox1.Items.Clear();
            ListtBoxCourses.Items.Clear();
            foreach (DataRow v in tmp.Rows)
            {
                idCourse.Add(v["id"].ToString());
                ListtBoxCourses.Items.Add(v["label"]);
            }
        }
    }
}
