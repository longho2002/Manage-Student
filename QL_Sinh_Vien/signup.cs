using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Sinh_Vien
{
    public partial class signup : Form
    {
        private bool validUsername = false;
        private bool validPass = false;
        private bool validPassConfirm = false;
        public signup()
        {
            InitializeComponent();

        }

        private void btn_Singup_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            if (!validUsername || !validPass || !validPassConfirm)
               MessageBox.Show("Some thing went wrongs!!!!!");
            SqlCommand command = new SqlCommand("INSERT INTO LOGIN (username, password) VALUES(@username, @password); ", db.getConnection);
            command.Parameters.Add("@username", sqlDbType: SqlDbType.VarChar).Value = tb_Username.Text;
            command.Parameters.Add("@password", sqlDbType: SqlDbType.VarChar).Value = Hash.HashPassword(tb_Password.Text);
            try
            {
                db.openConnection();
                command.ExecuteNonQuery();
                MessageBox.Show("Create account successfully, Please login!", "SignUp Success", MessageBoxButtons.OK);
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

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_Username_Leave(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM LOGIN WHERE username = @username ", db.getConnection);
            command.Parameters.Add("@username", sqlDbType: SqlDbType.VarChar).Value = tb_Username.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                validUsername = false;
                lb_checkUsername.Text = "Username is already exists";
                lb_checkUsername.Visible = true;
                return;
            }
            Regex rgx = new Regex(@"[^A-Za-z0-9]");
            string username = tb_Username.Text.Trim();
            bool validInput = rgx.IsMatch(username);
            //
            if (validInput || (username.Length <6 || username.Length > 17))
            {
                validUsername = false;
                lb_checkUsername.Text = "Username not include special character\n and must have 6-16 characters";
                lb_checkUsername.Visible = true;
                return;
            }
            validUsername = true;
            lb_checkUsername.Visible = false;
        }

        private void tb_Password_Leave(object sender, EventArgs e)
        {
            Regex rgx = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$");
            bool validInput;
            validInput = rgx.IsMatch(tb_Password.Text);
            if (!validInput)
            {
                lb_checkPassword.Text = "Password must be between 8 and 15 characters long,\n 1 digit, 1 char, 1 special char";
                lb_checkPassword.Visible = true;
                return;
            }
            lb_checkPassword.Visible = false;
            validPass = true;
        }

        private void tb_passwordConfirm_Leave(object sender, EventArgs e)
        {
            if (tb_Password.Text != tb_passwordConfirm.Text)
            {
                lb_CheckPassConfirm.Text = "Password is not same Password Confirm";
                lb_CheckPassConfirm.Visible = true;
                validPassConfirm = false;
                return;
            }

            lb_checkPassword.Visible = false;
            validPassConfirm = true;
        }
    }
}
