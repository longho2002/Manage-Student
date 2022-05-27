using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace QL_Sinh_Vien
{
    public partial class forgotpass : Form
    {
        private string mail;
        private int rNum;
        private MY_DB db = new MY_DB();
        DateTime presDateTime = DateTime.Now;
        public forgotpass()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
            {
            tb_repass.Enabled = false;
            tb_pass.Enabled = false;
            btn_repass.Enabled = false;
            lb_checkPassword.Visible = false;
            lb_CheckPassConfirm.Visible = false;

            mail = tb_mail.Text.Trim();
            if (tb_mail.Text.Trim() == "")
            {
                MessageBox.Show("Please input Email!");
                return;
            }
            SqlCommand cmd = new SqlCommand("SELECT *  FROM login where email = @mail", db.getConnection);
            cmd.Parameters.Add("@mail", SqlDbType.VarChar).Value = mail;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("Invalid Email!");
                return;
            }
            try
            {
                Random rnd = new Random();
                rNum = rnd.Next(100000, 999999);
                string content = "Your code is: " + rNum.ToString() + "\n Expire time: 1 mins";
                MessageBox.Show(Mail.Send(mail, "Reset Password", content));
             
                presDateTime = DateTime.Now;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btn_repass_Click(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now - presDateTime;
            if (ts.TotalSeconds > 60)
            {
                MessageBox.Show("Code is Expired");
                tb_repass.Enabled = false;
                tb_pass.Enabled = false;
                btn_repass.Enabled = false;
                return;
            }

            if (lb_checkPassword.Visible == false && lb_CheckPassConfirm.Visible == false)
            {
                SqlCommand command = new SqlCommand("update  LOGIN set password = @pass where email = @mail", db.getConnection);
                command.Parameters.Add("@mail", sqlDbType: SqlDbType.VarChar).Value =mail;
                command.Parameters.Add("@pass", sqlDbType: SqlDbType.VarChar).Value = Hash.HashPassword(tb_pass.Text);
                try
                {
                    db.openConnection();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Update account successfully, Please login!", "Update Success", MessageBoxButtons.OK);
                    this.Close();
                }
                catch (SqlException exception)
                {
                    MessageBox.Show("Error Generated. Details: " + exception.ToString());
                }
                finally
                {
                    db.closeConnection();
                }
            }
         
        }

        private void tb_pass_Leave(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$");
            bool validInput;
            validInput = rgx.IsMatch(tb_pass.Text);
            if (!validInput)
            {
                lb_checkPassword.Text = "Password must be between 8 and 15 characters long,\n 1 digit, 1 char, 1 special char";
                lb_checkPassword.Visible = true;
                return;
            }
            lb_checkPassword.Visible = false;
        }

        private void tb_repass_Leave(object sender, EventArgs e)
        {
            if (tb_pass.Text != tb_repass.Text)
            {
                lb_CheckPassConfirm.Text = "Password is not same Password Confirm";
                lb_CheckPassConfirm.Visible = true;
                return;
            }
            lb_CheckPassConfirm.Visible = false;
        }

        private void btn_valid_Click(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now - presDateTime;
            if (ts.TotalSeconds > 60)
            {
                MessageBox.Show("Code is Expired");
                tb_repass.Enabled = false;
                tb_pass.Enabled = false;
                btn_repass.Enabled = false;
                return;
            }
            if (Convert.ToInt32(tb_id.Text) == rNum)
            {
                tb_repass.Enabled = true;
                tb_pass.Enabled = true;
                btn_repass.Enabled = true;
            }
            else
            {
                MessageBox.Show("wrong code!");
            }
        }
    }
}
