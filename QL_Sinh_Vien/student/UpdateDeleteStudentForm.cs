using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Sinh_Vien
{
    public partial class UpdateDeleteStudentForm : Form
    {
        private STUDENT student = new STUDENT();
        private string id;
        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std WHERE CONCAT(fname,lname,address,phone) LIKE '%" + tb_Search.Text.Trim() + "%'");
            DataTable table = student.getStudents(command);
            if (table.Rows.Count > 0)
            {


                if (table.Rows[0]["fname"].ToString().ToLower().Contains(tb_Search.Text.ToLower()) ||
                    table.Rows[0]["lname"].ToString().ToLower().Contains(tb_Search.Text.ToLower()))
                {
                    StudentsListForm stdListForm = new StudentsListForm();
                    stdListForm.DataGridView.DataSource = table;
                    StudentsListForm.flag = false;
                    stdListForm.DataGridView.ReadOnly = true;
                    DataGridViewImageColumn picol = new DataGridViewImageColumn();
                    stdListForm.DataGridView.RowTemplate.Height = 80;
                    stdListForm.DataGridView.DataSource = student.getStudents(command);
                    picol = (DataGridViewImageColumn)stdListForm.DataGridView.Columns[7];
                    picol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                    stdListForm.DataGridView.AllowUserToAddRows = false;
                    stdListForm.ShowDialog(this);
                }
                else
                {
                    id = tb_ID.Text = table.Rows[0]["id"].ToString();
                    tb_FName.Text = table.Rows[0]["fname"].ToString();
                    tb_LName.Text = table.Rows[0]["lname"].ToString();
                    dateTimePicker1.Value = (DateTime)table.Rows[0]["bdate"];
                    if (table.Rows[0]["gender"].ToString() == "Female")
                    {
                        radioButtonFemale.Checked = true;
                    }
                    else
                    {
                        radioButtonMale.Checked = true;
                    }
                    tb_Phone.Text = table.Rows[0]["phone"].ToString();
                    tb_Address.Text = table.Rows[0]["address"].ToString();
                    byte[] pic;
                    pic = (byte[])table.Rows[0]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    PictureBoxStudentImage1.Image = Image.FromStream(picture);

                }
            }
            else
            {
                MessageBox.Show("Not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

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
            if (!tb_ID.Text.All(char.IsDigit))
            {
                throw new Exception("ID mustn't have char");
            }
            bool containsInt = tb_LName.Text.Any(char.IsDigit);
            containsInt = tb_FName.Text.Any(char.IsDigit);
            if (containsInt == false)
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
                        MessageBox.Show("Student Information Updated", "Edit Student", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MessageBox.Show("Empty Fields", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


        }

        private bool verif()
        {
            if (tb_FName.Text.Trim() == "" || tb_LName.Text.Trim() == "" || tb_Address.Text.Trim() == "" ||
                tb_Phone.Text.Trim() == "" || PictureBoxStudentImage1.Image == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void UpdateDeleteStudentForm_Load(object sender, EventArgs e)
        {
            id = tb_ID.Text;


        }

        private void btn_UploadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                PictureBoxStudentImage1.Image = Image.FromFile(opf.FileName);
                tb_Picture.Text = opf.FileName.Split('\\').Last();
                PictureBoxStudentImage1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

    }
}
