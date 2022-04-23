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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_ID.Text.Trim() == "" || tb_Label.Text.Trim() == "" || tb_Period.Text.Trim() == "" || tb_Des.Text.Trim() == "")
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
                    if (course.insertCourse(id, label, period, des))
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
