using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Sinh_Vien.course
{
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_Label.Text.All(char.IsDigit) == true)
                {
                    throw new Exception("Label must have character");
                }
                if (!Regex.IsMatch(tb_ID.Text, @"^\d+$"))
                {
                    throw new Exception("id is digit not char");
                }
                if (tb_ID.Text.Trim() == "" || tb_Label.Text.Trim() == "" || tb_Period.Text.Trim() == "" || tb_Des.Text.Trim() == "" || tb_semester.Text.Trim() == "")
                {
                    MessageBox.Show("Empty Fields", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    COURSE course = new COURSE();
                    int id = Convert.ToInt32(tb_ID.Text);
                    string label = tb_Label.Text;
                    int period = Convert.ToInt32(tb_Period.Text);
                    string des = tb_Des.Text;
                    if (course.insertCourse(id, label, period, des, tb_semester.Text))
                    {
                        MessageBox.Show("New Course Added", "Add Course", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Error", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
