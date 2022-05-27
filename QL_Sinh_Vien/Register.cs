using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Sinh_Vien
{
    public partial class Register : Form
    {
        private User user = new User();
        public Register()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                MemoryStream pic = new MemoryStream();
                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                int id = tb_ID.Text == "" ? -1 : Convert.ToInt32(tb_ID.Text);
                string lname = tb_LName.Text;
                string fname = tb_FName.Text;
                string username = tb_username.Text;
                string password = tb_password.Text;
                if (user.usernameExist(Convert.ToInt32(tb_ID.Text), tb_username.Text))
                {
                    if (user.insertUser(id, fname, lname, username, password, pic))
                    {
                        MessageBox.Show("New User Added", "Add User", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Close();
                    }

                    else
                        MessageBox.Show("Add fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("ID and Username is exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields");
            }
        }

        private bool verif()
        {
            if (tb_FName.Text.Trim() == "" || tb_LName.Text.Trim() == "" || tb_username.Text.Trim() == "" ||
                tb_ID.Text.Trim() == "" || pictureBox1.Image == null || tb_password.Text.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
