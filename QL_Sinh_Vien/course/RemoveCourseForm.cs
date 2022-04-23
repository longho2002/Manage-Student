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
    public partial class RemoveCourseForm : Form
    {
        public RemoveCourseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            COURSE course = new COURSE();
            try
            {
                int id = Convert.ToInt32(tb_id.Text); // display a confirmation message before the delete if ((MessageBox.Show("Are You Sure You Want To Delete This Student", "Delete Student", MessageBoxButtons. Yeslo, MessageBoxicon. Question) - DialogResult.Yes))
                if ((MessageBox.Show("Are You Sure You Want To Delete This Course", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    if (course.deleteCourse(id))
                    {
                        MessageBox.Show("Course Deleted", "Delete Course", MessageBoxButtons.OK,
                            MessageBoxIcon
                                .Information);
                        tb_id.Text = "";
                    }
                    else
                        MessageBox.Show("Course Not Deleted", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
