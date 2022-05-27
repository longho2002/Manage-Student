using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Sinh_Vien
{
    public partial class EditCourseForm : Form
    {
        private MY_DB myDb = new MY_DB();
        private COURSE course = new COURSE();
        public EditCourseForm()
        {
            InitializeComponent();
        }

        private void EditCourseForm_Load(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = 1000;
            numericUpDown1.Minimum = 0;
            comboBox1.DataSource = course.getAllCourse();
            comboBox1.DisplayMember = "label";
            comboBox1.ValueMember = "id";
            comboBox1.SelectedItem = null;
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_Label.Text.All(char.IsDigit) == true)
                {
                    throw new Exception("Label must have character");
                }
                string name = tb_Label.Text;
                int hrs = (int)numericUpDown1.Value;
                string descr = tb_Des.Text;
                int id = Convert.ToInt32(comboBox1.SelectedValue);
                if (!course.checkCourseName(name, Convert.ToInt32(comboBox1.SelectedValue)))
                {
                    MessageBox.Show("This Course Name Already Exist", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (course.updateCourse(id, name, hrs, descr))
                {
                    MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information); fillCombo(comboBox1.SelectedIndex);
                }
                else
                {
                    MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

           
            //try
            //{
            //    int id = Convert.ToInt32(comboBox1.SelectedValue);
            //    String label = tb_Label.Text;
            //    int period = Convert.ToInt32(numericUpDown1.Text);
            //    String description = tb_Des.Text;
            //    if (id.ToString().Trim() == "" || label.Trim() == "" || period.ToString().Trim() == "" || description.Trim() == "")
            //        MessageBox.Show("All field not accept null value", "Value Error",
            //            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    else
            //        try
            //        {
            //            if (course.updateCourse(id, label, period, description))
            //                MessageBox.Show("Course Information Updated", "Edit Student", MessageBoxButtons.OK,
            //                    MessageBoxIcon.Information);
            //            else
            //                MessageBox.Show("Error", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.Message, "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //            MessageBox.Show("Empty Fields", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        }
            //}
            //catch (Exception exception)
            //{
            //    Console.WriteLine(exception);
            //    throw;
            //}
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
          
        }
        public void fillCombo(int index)
        {
            comboBox1.DataSource = course.getAllCourse();
            comboBox1.DisplayMember = "label";
            comboBox1.ValueMember = "id";
            comboBox1.SelectedIndex = index;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(comboBox1.SelectedValue);
                DataTable dt = course.getCourseById(id);
                tb_Des.Text = dt.Rows[0][3].ToString();
                tb_Label.Text = dt.Rows[0][1].ToString();
                numericUpDown1.Value = Convert.ToInt32(dt.Rows[0][2].ToString());
            }
            catch
            {

            }

        }
    }
}
