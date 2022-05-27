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

namespace QL_Sinh_Vien.score
{
    public partial class ManageScoreForm : Form
    {
        public ManageScoreForm()
        {
            InitializeComponent();
        }

        private Score score = new Score();
        STUDENT student = new STUDENT();
        MY_DB myDb = new MY_DB();
        private COURSE course = new COURSE();
        private string data = "score";
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                int student_ID = Convert.ToInt32(tb_stdID.Text);
                int courseID = Convert.ToInt32(cb_course.SelectedValue);
                double score_Value = Convert.ToDouble(tb_score.Text);
                string description = tb_des.Text;
                // check if the score is already set for this student on this score
                if (!score.studentScoreExist(student_ID, courseID))
                    if (score.insertScore(student_ID, courseID, score_Value, description))
                        MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Student Score Not Inserted", "Add Score", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                else
                {
                    MessageBox.Show("The Score For This Course Are Already set", "Add Score", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                int id_std = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                int id_course = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                score.deleteScore(id_std, id_course);
                MessageBox.Show("Delete success full!");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

        }

        private void btn_showAVG_Click(object sender, EventArgs e)
        {
            avgScoreByCourseForm t = new avgScoreByCourseForm();
            t.Show(this);
        }

        private void btn_showSTD_Click(object sender, EventArgs e)
        {
            data = "std";
            dataGridView1.DataSource = student.getStudents(new SqlCommand("SELECT ID, FNAME, LNAME, BDATE FROM STD"));
        }

        private void btn_showscore_Click(object sender, EventArgs e)
        {
            data = "score";
            dataGridView1.DataSource = score.getStudentScore();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataGridView();
        }

        private void ManageScoreForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.getStudentScore();
            cb_course.DataSource = course.getAllCourse();
            cb_course.DisplayMember = "label";
            cb_course.ValueMember = "id";
        }

        private void getDataGridView()
        {
            if (data == "std")
            {
                tb_stdID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
            else if (data == "score")
            {
                tb_stdID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                cb_course.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
        }
    }
}
