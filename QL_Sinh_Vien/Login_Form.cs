using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Sinh_Vien
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
            progressBar1.Visible = false;
            backgroundWorker.WorkerReportsProgress = true;
            rBtn_std.Checked = true;
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            progressBar1.Value = 0;
            backgroundWorker.RunWorkerAsync();
        }


        private void Calculate(int i)
        {
            double pow = Math.Pow(i, i);
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var backgroundWorker = sender as BackgroundWorker;
            for (int j = 0; j < 100000; j++)
            {
                Calculate(j);
                backgroundWorker.ReportProgress((j * 100) / 100000);
            }
            MY_DB db = new MY_DB();
            if (rBtn_std.Checked == true)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command =
                    new SqlCommand("SELECT * FROM LOGIN WHERE username = @user AND password = @password ",
                        db.getConnection);

                command.Parameters.Add("@user", sqlDbType: SqlDbType.VarChar).Value = tb_Username.Text;
                command.Parameters.Add("@password", sqlDbType: SqlDbType.VarChar).Value =
                    Hash.HashPassword(tb_Password.Text);
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select * from users where uname = @name and pwd = @pwd",
                    db.getConnection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable dt = new DataTable();
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = tb_Username.Text;
                cmd.Parameters.Add("@pwd", SqlDbType.NVarChar).Value = tb_Password.Text;
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                if (tb_Username.Text.Trim() == "" || tb_Password.Text.Trim() == "")
                {
                    MessageBox.Show("Username or Password Empty", "Login Error");
                    progressBar1.Visible = false;
                    return;
                }
                if (dt.Rows.Count > 0)
                {
                    Globals.SetGlobalUserID(Convert.ToInt32(dt.Rows[0][0].ToString()));
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Error");
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Change the value of the ProgressBar to the BackgroundWorker progress.
            progressBar1.Value = e.ProgressPercentage;
            // Set the text.
            this.Text = e.ProgressPercentage.ToString();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // TODO: do something with final calculation.
      
            progressBar1.Visible = false;
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            picBox_Login.Image = Image.FromFile("../../Picture/download.png");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (rBtn_std.Checked == true)
            {
                signup newUser = new signup();
                newUser.ShowDialog(this);
                return;
            }

            Register a = new Register();
            a.ShowDialog(this);
        }

        private void lb_forgotpass_Click(object sender, EventArgs e)
        {
            forgotpass a = new forgotpass();
            a.ShowDialog(this);
        }
    }
}
