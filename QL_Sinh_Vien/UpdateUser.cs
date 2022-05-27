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
    public partial class UpdateUser : Form
    {
        private MY_DB mydb = new MY_DB();
        private User user = new User();
        public UpdateUser()
        {
            InitializeComponent();
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM USERS WHERE ID = @ID", mydb.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Globals.GlobalUserID;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            DataRow[] dr = dt.Select();
            tb_ID.Text = Globals.GlobalUserID.ToString();
            tb_FName.Text = dr[0]["f_name"].ToString();
            tb_LName.Text = dr[0]["l_name"].ToString();
            tb_password.Text = dr[0]["pwd"].ToString();
            tb_username.Text = dr[0]["uname"].ToString();
            byte[] pic;
            pic = (byte[])dr[0]["fig"];
            MemoryStream picture = new MemoryStream(pic);
            pictureBox1.Image = Image.FromStream(picture);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            string fname = tb_FName.Text;
            string lname = tb_LName.Text;
            string pwd = tb_password.Text;
            string uname = tb_username.Text;
            if (verif())
                try
                {
                    MemoryStream pic = new MemoryStream();
                    id = Convert.ToInt32(tb_ID.Text);
                    pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                    if (user.updateUser(id, fname, lname, uname, pwd, pic))
                    {
                        MessageBox.Show("User Information Updated", "Edit User", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Error", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            else
            {
                MessageBox.Show("Empty Fields", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                pictureBox1.Text = opf.FileName.Split('\\').Last();
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
