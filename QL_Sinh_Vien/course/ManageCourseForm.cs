using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Sinh_Vien
{
    public partial class ManageCourseForm : Form
    {
        private COURSE course = new COURSE();
        private int pos;
        public ManageCourseForm()
        {
            InitializeComponent();
        }

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            reloadListBoxData();
        }

        void reloadListBoxData()
        {
            ListtBoxCourses.DataSource = course.getAllCourse();
            ListtBoxCourses.ValueMember = "id";
            ListtBoxCourses.DisplayMember = "label";
            ListtBoxCourses.SelectedItem = null;
            lb_total.Text = ("Total Courses: " + course.totalCourses());
        }

        void showData(int index)
        {
            DataRow dr = course.getAllCourse().Rows[index];
            ListtBoxCourses.SelectedItem = index;
            tb_id.Text = dr.ItemArray[0].ToString();
            tb_Label.Text = dr.ItemArray[1].ToString();
            numericUpDown1.Value = int.Parse(dr.ItemArray[2].ToString());
            tb_Des.Text = dr.ItemArray[3].ToString();
        }

        private void ListtBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListtBoxCourses_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)ListtBoxCourses.SelectedItem;
            pos = ListtBoxCourses.SelectedIndex;
            showData(pos);
        }

        private void ButtonAddCourse_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tb_id.Text);
            string name = tb_Label.Text;
            int hrs = (int)numericUpDown1.Value;
            string descr = tb_Des.Text;

            if (name.Trim() == "")
            {
                MessageBox.Show("Add A Course Name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (course.checkCourseName(name))
            {
                if (course.insertCourse(id, name, hrs, descr))
                {
                    MessageBox.Show("New Course Inserted",
                        "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reloadListBoxData();
                }
                else
                    MessageBox.Show("Course Not Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("This Course Name Already exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tb_id.Text);
            string name = tb_Label.Text;
            int hrs = (int)numericUpDown1.Value;
            string descr = tb_Des.Text;
            if (!course.checkCourseName(name, Convert.ToInt32(tb_id.Text)))
                MessageBox.Show("This Course Name Already Exist", "Edit Course", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            else if (course.updateCourse(id, name, hrs, descr))
            {
                MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reloadListBoxData();
            }
            else
                MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            pos = 0;
        }
        private void Button_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(tb_id.Text);
                if ((MessageBox.Show("Are Yousure You Want To Delete This Course", "Remove Course",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes))
                    if (course.deleteCourse(id))
                    {
                        MessageBox.Show("Course Deleted", "Remove Course", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        tb_id.Text = "";
                        tb_Label.Text = "";
                        numericUpDown1.Value = 10;
                        tb_Des.Text = "";
                        reloadListBoxData();
                    }
                    else
                        MessageBox.Show("Course Not Deleted", "Remove Course", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
            }
            catch
            {
                MessageBox.Show("Enter A Valid Numeric ID", "Remove Course", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            pos = 0;
        }

        private void ButtonFirst_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(pos);
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if (pos < (course.getAllCourse().Rows.Count - 1))
                pos = pos + 1;
            showData(pos);
        }

        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            if (pos > 0)
                pos = pos - 1;
            showData(pos);
        }

        private void ButtonLast_Click(object sender, EventArgs e)
        {
            pos = course.getAllCourse().Rows.Count - 1;
            showData(pos);
        }

    }
}
