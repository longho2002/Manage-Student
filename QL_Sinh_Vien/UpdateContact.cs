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
    public partial class UpdateContact : Form
    {
        MY_DB db = new MY_DB();
        public UpdateContact()
        {
            InitializeComponent();
        }
        Contact contact = new Contact();
        private void btn_remove_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int id;
            string fname = tb_FName.Text;
            string lname = tb_LName.Text;
            int group;
            string phone = tb_phone.Text;
            string adrs = tb_adrs.Text;
            string mail = tb_mail.Text;
            MemoryStream pic = new MemoryStream();
            pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
            if (verif())
                try
                {
                    id = Convert.ToInt32(tb_idUser.Text);
                    group = (Int32)cb_group.SelectedValue;
                    if (contact.updateContact(id, fname, lname, phone, adrs, mail, group, pic))
                        MessageBox.Show("User Information Updated", "Edit User", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
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

        public bool verif()
        {
            string fname = tb_FName.Text;
            string lname = tb_LName.Text;
            string group = cb_group.SelectedValue.ToString();
            string phone = tb_phone.Text;
            string adrs = tb_adrs.Text;
            string mail = tb_mail.Text;
            if (fname.Trim() == "" || lname.Trim() == "" || group.Trim() == "" ||
                phone.Trim() == "" || pictureBox1.Image == null || adrs.Trim() == "" || mail.Trim() == "" || tb_idUser.Text.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_selectContact_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            SelectContact a = new SelectContact();
            SqlCommand command = new SqlCommand("SELECT ID, FNAME, LNAME, GROUP_ID FROM CONTACT where userid = @id", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Globals.GlobalUserID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            a.dataGridView1.DataSource = dt;
            a.ShowDialog(this);

            command = new SqlCommand("SELECT * FROM CONTACT where id = @id", db.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Globals.GlobalContactID;
            DataTable dt1 = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt1);
            if (dt1.Rows.Count == 0)
                return;
            
            tb_idUser.Text = Globals.GlobalContactID.ToString();
            tb_FName.Text = dt1.Rows[0]["fname"].ToString();
            tb_LName.Text = dt1.Rows[0]["lname"].ToString();
            int c = 0;
            foreach (DataRowView item in cb_group.Items)
            {
                if (item.Row.ItemArray[0].ToString().Equals(dt1.Rows[0]["group_id"].ToString()))
                {
                    cb_group.SelectedIndex = c;
                    break;
                }
                c++;
            }
            tb_phone.Text = dt1.Rows[0]["phone"].ToString();
            tb_adrs.Text = dt1.Rows[0]["address"].ToString();
            tb_mail.Text = dt1.Rows[0]["email"].ToString();
            byte[] pic;
            pic = (byte[])dt1.Rows[0]["pic"];
            MemoryStream picture = new MemoryStream(pic);
            pictureBox1.Image = Image.FromStream(picture);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void UpdateContact_Load(object sender, EventArgs e)
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
