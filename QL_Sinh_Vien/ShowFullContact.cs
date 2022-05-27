using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using DataTable = System.Data.DataTable;

namespace QL_Sinh_Vien
{
    public partial class ShowFullContact : Form
    {
        public ShowFullContact()
        {
            InitializeComponent();
        }

        void fillgrid(string cmd)
        {
            MY_DB db = new MY_DB();
            SqlCommand command = new SqlCommand(cmd, db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataGridViewImageColumn picol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = dt;
            picol = (DataGridViewImageColumn)dataGridView1.Columns[6];
            picol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }
        private void ShowFullContact_Load(object sender, EventArgs e)
        {
            //fillgrid("SELECT  FNAME as [First Name], LNAME as [Last Name], GROUP_ID as [Group],phone, email, address, pic FROM CONTACT");
            try
            {
                DataGridViewImageColumn piccol = new DataGridViewImageColumn();
                dataGridView1.RowTemplate.Height = 80; // Chụ thuc tu gợi ý của sự
                Contact contact = new Contact();
                SqlCommand command = new SqlCommand("SELECT fname as 'First Name', name as 'Last Name', groups.name as 'Group', phone, email, address, pic"
                                                    + " FROM contact INNER JOIN groups on contact.group_id =  groups.id WHERE contact.userid = @userid");
                command.Parameters.Add("@userid", SqlDbType.Int).Value = Globals.GlobalUserID;
                dataGridView1.DataSource = contact.SelectContactlist(command);
                piccol = (DataGridViewImageColumn)dataGridView1.Columns[6];
                piccol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    if (IsOdd(1))
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    }
                Group group = new Group();
                listBox1.DataSource = group.getGroups(Globals.GlobalUserID);
                listBox1.DisplayMember = "name";
                listBox1.ValueMember = "id";
                listBox1.SelectedItem = null;
                dataGridView1.ClearSelection();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            ShowFullContact_Load(null, null);
            // fillgrid("SELECT  FNAME as [First Name], LNAME as [Last Name], GROUP_ID as [Group],phone, email, address, pic FROM CONTACT");
        }


        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                if (IsOdd(1))
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                tb_addrs.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            }
            catch (Exception exception)
            {
           
            }
        }

      

        private void listBox1_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedValue == null)
                    return;
                Contact contact = new Contact();
                int group_id = (Int32)listBox1.SelectedValue;

                SqlCommand command = new SqlCommand("SELECT fname as 'First Name', name as 'Last Name', groups.name as 'Group', phone, email, address, pic"
                                                    + " FROM contact INNER JOIN groups on contact.group_id =  groups.id WHERE contact.userid = @userid and contact.group_id =  @groupid");
                command.Parameters.Add("@userid", SqlDbType.Int).Value = Globals.GlobalUserID;
                command.Parameters.Add("@groupid", SqlDbType.Int).Value = group_id;
                dataGridView1.DataSource = contact.SelectContactlist(command);
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    if (IsOdd(1))
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
