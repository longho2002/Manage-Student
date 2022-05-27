using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace QL_Sinh_Vien
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                STUDENT student = new STUDENT();
                if (!tb_ID.Text.All(char.IsDigit))
                {
                    throw new Exception("ID mustn't have char");
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
                string frame = tb_FName.Text;
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
                //check
                if (((this_year - born_year) < 10) && ((this_year - born_year) > 100))
                {
                    MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verif())
                {
                    PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
                    if (student.insertStudent(id, frame, lname, bdate, gender, phone, adrs, pic))
                    {
                        MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool verif()
        {
            if (tb_FName.Text.Trim() == "" || tb_LName.Text.Trim() == "" || tb_Address.Text.Trim() == "" ||
                tb_Phone.Text.Trim() == "" || PictureBoxStudentImage.Image == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                PictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
                tb_Picture.Text = opf.FileName.Split('\\').Last();
                PictureBoxStudentImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void btn_Can_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
