using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Sinh_Vien.score
{
    public partial class AddScoreForm : Form
    {
        public AddScoreForm()
        {
            InitializeComponent();
        }
        private Score score = new Score();
        private COURSE course = new COURSE();
        private STUDENT student = new STUDENT();

        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            cb_course.DataSource = course.getAllCourse();
            cb_course.DisplayMember = "label";
            cb_course.ValueMember = "id";

            SqlCommand command = new SqlCommand("SELECT id, fname, lname FROM std");
            dataGridView1.DataSource = student.getStudents(command);
            dataGridView1.Click += DataGridViewStudents_Click;
        }

        private void DataGridViewStudents_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value == null)
                return;
            tb_stdID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void ButtonAddScore_Click(object sender, EventArgs e)
        {
            try
            {
                if (!tb_score.Text.All(char.IsDigit))
                {
                    throw new Exception("Score must digit");
                }
                int student_ID = Convert.ToInt32(tb_stdID.Text);
                int courseID = Convert.ToInt32(cb_course.SelectedValue);
                float score_Value = Convert.ToInt32(tb_score.Text);
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

        private void DataGridViewStudents_Click(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
