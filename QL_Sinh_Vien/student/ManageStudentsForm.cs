using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Sinh_Vien
{
    public partial class ManageStudentsForm : Form
    {
        private STUDENT student = new STUDENT();
        public ManageStudentsForm()
        {
            InitializeComponent();
        }

        public void fillGrid(SqlCommand command)
        {
            DataGridView1.DataSource = null;
            DataGridView1.Rows.Clear();
            DataGridView1.ReadOnly = true;
            DataGridViewImageColumn piccol = new DataGridViewImageColumn();
            DataGridView1.RowTemplate.Height = 80;
            DataGridView1.DataSource = student.getStudents(command);
            piccol = (DataGridViewImageColumn)DataGridView1.Columns[7];
            piccol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView1.AllowUserToAddRows = false;
            lb_Total.Text = ("Total Students: " + DataGridView1.Rows.Count);
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            tb_ID.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            tb_FName.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            tb_LName.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Value = (DateTime)DataGridView1.CurrentRow.Cells[4].Value;
            if ((DataGridView1.CurrentRow.Cells[3].Value.ToString() == "Female"))
                radioButtonFemale.Checked = true;
            else
                radioButtonMale.Checked = true;
            tb_Phone.Text = DataGridView1.CurrentRow.Cells[5].Value.ToString();
            tb_Address.Text = DataGridView1.CurrentRow.Cells[6].Value.ToString();
            byte[] pic;
            pic = (byte[])DataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            PictureBoxStudentImage1.Image = Image.FromStream(picture);
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std WHERE Trim(LOWER(CONCAT(id, fname, lname, address))) LIKE N'%" + tb_find.Text.ToLower() + "%'");
            //command.Parameters.Add("@tbfind", SqlDbType.NVarChar).Value = tb_find.Text.ToLower();
            //MessageBox.Show(command.CommandText);
            fillGrid(command);
        }

        private void ButtonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = " Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
                PictureBoxStudentImage1.Image = Image.FromFile(opf.FileName);
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            tb_ID.Text = "";
            tb_FName.Text = "";
            tb_LName.Text = "";
            tb_Address.Text = "";
            tb_Phone.Text = "";
            PictureBoxStudentImage1.Image = null;
            radioButtonMale.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            fillGrid(new SqlCommand("select * from std"));
        }
        private void ButtonDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("student_" + tb_ID.Text);
            if ((PictureBoxStudentImage1.Image == null))
                MessageBox.Show("No Image In The PictureBox");
            else if ((svf.ShowDialog() == DialogResult.OK))
                PictureBoxStudentImage1.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));

        }

        bool verif()
        {
            if ((tb_FName.Text.Trim() == "")
                || (tb_LName.Text.Trim() == "")
                || (tb_Address.Text.Trim() == "")
                || (tb_Phone.Text.Trim() == "")
                || (PictureBoxStudentImage1.Image == null))
                return false;
            return true;
        }

        private void ButtonAddStudent_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            try
            {
                if (!tb_ID.Text.All(char.IsDigit))
                {
                    throw new  Exception("ID mustn't have char");
                }
                bool containsInt = tb_LName.Text.Any(char.IsDigit);
                containsInt = tb_FName.Text.Any(char.IsDigit);
                if (containsInt == true)
                {
                    throw new Exception("Fname and Lname not contain digit");
                }
                if (Regex.IsMatch(tb_Address.Text, @"^\d+$"))
                {
                    throw new Exception("Address must be have char");
                }
                if (!Regex.IsMatch(tb_Phone.Text, @"^\d+$"))
                {
                    throw new Exception("Phone must be have number");
                }
                int id = Convert.ToInt32(tb_ID.Text);
                string fname = tb_FName.Text;
                string lname = tb_LName.Text;
                DateTime bdate = dateTimePicker1.Value;
                string phone = tb_Phone.Text;
                string adrs = tb_Address.Text;
                string gender = "Male";
                if (radioButtonFemale.Checked)
                    gender = "Female";
                MemoryStream pic = new MemoryStream();
                int born_year = dateTimePicker1.Value.Year;
                int this_year = DateTime.Now.Year;
                // allow only students age between 10 - 100
                if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
                    MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (verif())
                {
                    PictureBoxStudentImage1.Image.Save(pic, PictureBoxStudentImage1.Image.RawFormat);
                    if (student.insertStudent(id, fname, lname, bdate, gender, phone, adrs, pic))
                    {
                        MessageBox.Show("New Student Added",
                            "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid(new SqlCommand("SELECT *FROM std"));
                    }
                    else
                        MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
           
        }

        private void ManageStudentsForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from std");
            fillGrid(command);
        }
        private void btn_Remove_Click(object sender, EventArgs e)
        {

            try
            {
                int studentId = Convert.ToInt32(tb_ID.Text); // display a confirmation message before the delete if ((MessageBox.Show("Are You Sure You Want To Delete This Student", "Delete Student", MessageBoxButtons. Yeslo, MessageBoxicon. Question) - DialogResult.Yes))
                if ((MessageBox.Show("Are You Sure You Want To Delete This Student", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    if (student.deleteStudent(studentId))
                    {
                        MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK,
                            MessageBoxIcon
                                .Information);
                        tb_ID.Text = "";
                        tb_Address.Text = "";
                        tb_FName.Text = "";
                        tb_LName.Text = "";
                        tb_Phone.Text = "";
                        PictureBoxStudentImage1.Image = null;
                        dateTimePicker1.Value = DateTime.Now;
                        fillGrid(new SqlCommand("select * from std"));
                    }
                    else
                        MessageBox.Show("Student Not Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btn_Update_Click(object sender, EventArgs e)
        {
            int id;
            string fname = tb_FName.Text;
            string lname = tb_LName.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = tb_Phone.Text;
            string adrs = tb_Address.Text;
            string gender = "Male";
            if (radioButtonFemale.Checked)
                gender = "Female";
            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            if (((this_year - born_year) < 10) && ((this_year - born_year) > 100))
                MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Birth Date Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (verif())
                try
                {
                    id = Convert.ToInt32(tb_ID.Text);
                    PictureBoxStudentImage1.Image.Save(pic, PictureBoxStudentImage1.Image.RawFormat);
                    if (student.updateStudent(id, fname, lname, bdate, gender, phone, adrs, pic))
                    {
                        MessageBox.Show("Student Information Updated", "Edit Student", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        fillGrid(new SqlCommand("select * from std"));
                    }
                    else
                        MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MessageBox.Show("Empty Fields", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


        }

        private void btn_addcourse_Click(object sender, EventArgs e)
        {
            AddCourseFrm a = new AddCourseFrm();
            a.tb_id.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            a.Show(this);
        }
    }
}
