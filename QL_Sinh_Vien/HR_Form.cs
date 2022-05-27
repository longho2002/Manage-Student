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
    public partial class HR_Form : Form
    {
        private MY_DB mydb = new MY_DB();
        private Contact contact = new Contact();
        Group mygroup = new Group();
        User user = new User();
        public HR_Form()
        {
            InitializeComponent();
        }

        private void HR_Form_Load(object sender, EventArgs e)
        {
            getImageAndUsername();
            LoadAllGroup();
        }

        private void LoadAllGroup()
        {
            cb_groupedit.DataSource = mygroup.getGroups(Convert.ToInt32(Globals.GlobalUserID));
            cb_groupedit.ValueMember = "id";
            cb_groupedit.DisplayMember = "name";
            cb_groupedit.SelectedItem = null;
            cb_removeGroup.DataSource = mygroup.getGroups(Convert.ToInt32(Globals.GlobalUserID));
            cb_removeGroup.ValueMember = "id";
            cb_removeGroup.DisplayMember = "name";
            cb_removeGroup.SelectedItem = null;
        }
        public void getImageAndUsername()
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM users WHERE Id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Globals.GlobalUserID; // lãy id de up thông tin
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
            {
                byte[] pic = (byte[])table.Rows[0]["fig"];
                MemoryStream picture = new MemoryStream(pic);
                pic_user.Image = Image.FromStream(picture);
                lb_userID.Text = "Welcome Back (" + table.Rows[0]["f_name"].ToString() + ")";
            }
        }

        private void lb_edit_Click(object sender, EventArgs e)
        {
            UpdateUser a = new UpdateUser();
            a.ShowDialog(this);
            getImageAndUsername();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddC_Click(object sender, EventArgs e)
        {
            AddContactForm a = new AddContactForm();
            a.ShowDialog(this);
        }

        private void btn_editC_Click(object sender, EventArgs e)
        {
            UpdateContact a = new UpdateContact();
            a.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                contact.deleteContact(Convert.ToInt32(tb_delContact.Text));
                MessageBox.Show("Delete successfully!");
            }
            catch (Exception exception)
            {
               MessageBox.Show(exception.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
            tb_delContact.Text = Globals.GlobalContactID.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowFullContact a = new ShowFullContact();
            a.ShowDialog();
        }

        private void btn_addGroup_Click(object sender, EventArgs e)
        {
            try
            {
                if (verif())
                {
                    if (mygroup.insertGroup(Convert.ToInt32(tb_idGroup.Text), tb_GroupName.Text, Globals.GlobalUserID))
                    {
                        MessageBox.Show("New Group Added", "Add Group", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Error", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
          
        }

        bool verif()
        {
            if (tb_GroupName.Text.Trim() == "" || tb_idGroup.Text.Trim() == "")
                return false;
            return true;
        }

        private void btn_editGroupName_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_groupedit.SelectedValue != null && tb_NameGroup.Text.Trim() != "")
                    try
                    {
                        if (mygroup.updateGroup(Convert.ToInt32(cb_groupedit.SelectedValue.ToString()),
                                tb_NameGroup.Text.Trim()))
                        {
                            MessageBox.Show("Group Information Updated", "Edit Group", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            LoadAllGroup();
                            tb_NameGroup.Text = "";
                        }
                        else
                            MessageBox.Show("Error", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                else
                {
                    MessageBox.Show("Empty Fields", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
          
        }

        private void btn_removeGroup_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_removeGroup.SelectedValue == null)
                {
                    throw new Exception("Invalid Id");
                }
                mygroup.deleteGroup((Int32)cb_removeGroup.SelectedValue);
                MessageBox.Show("Delete successfully!");
                LoadAllGroup();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
