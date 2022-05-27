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
    public partial class AddContactForm : Form
    {
        private MY_DB db = new MY_DB();
        public AddContactForm()
        {
            InitializeComponent();
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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            Contact contact = new Contact();
            try
            {
                bool containsInt = tb_LName.Text.Any(char.IsDigit);
                containsInt = tb_FName.Text.Any(char.IsDigit);
                if (containsInt == false)
                {
                    throw new Exception("Fname and Lname not contain digit");
                }

                if (tb_mail.Text.Contains("@"))
                {
                    throw new Exception("Email must contain @");
                }

                if (Regex.IsMatch(tb_adrs.Text, @"^\d+$"))
                {
                    throw new Exception("Address must be have char");
                }

                if (!Regex.IsMatch(tb_phone.Text, @"^\d+$"))
                {
                    throw new Exception("Phone must be have number");
                }
                int id;
                string fname = tb_FName.Text;
                string lname = tb_LName.Text;
                int group;
                string phone = tb_adrs.Text;
                string adrs = tb_adrs.Text;
                string mail = tb_mail.Text;
                MemoryStream pic = new MemoryStream();
                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                //check
                if (verif())
                {
                    // id = Convert.ToInt32(tb_idUser.Text);
                    id = Globals.GlobalUserID;
                    group = Convert.ToInt32(cb_group.SelectedValue);
                    pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                    if (contact.insertContact(fname, lname, phone, adrs, mail, id, group, pic))
                    {
                        MessageBox.Show("New User Added", "Add User", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Error", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public bool verif()
        {
            string fname = tb_FName.Text;
            string lname = tb_LName.Text;
            string group = cb_group.SelectedValue.ToString();
            string phone = tb_phone.Text;
            string adrs = tb_adrs.Text;
            string mail = tb_mail.Text;
            if (fname.Trim() == "" || lname.Trim() == "" || group.Trim() == "" ||
                phone.Trim() == "" || pictureBox1.Image == null || adrs.Trim() == "" || mail.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void AddContactForm_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from groups where userid = @groupid", db.getConnection);
            cmd.Parameters.Add("@groupid", SqlDbType.Int).Value = Globals.GlobalUserID;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cb_group.DataSource = dt;
            cb_group.DisplayMember = "name";
            cb_group.ValueMember = "id";
            cb_group.SelectedItem = null;
        }
    }
}
