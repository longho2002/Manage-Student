using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Sinh_Vien
{
    internal class User
    {
        private MY_DB mydb = new MY_DB();
        public bool insertUser(int Id, string fname, string lname, string username, string pwd, MemoryStream picture)
        {
            SqlCommand command =
                new SqlCommand(
                    "INSERT INTO users (id, f_name, l_name, uname, pwd, fig)" +
                    "VALUES(@id, @fname, @lname, @uname, @pwd, @fig)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@uname", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("@pwd", SqlDbType.NVarChar).Value = pwd;
            command.Parameters.Add("@fig", SqlDbType.Image).Value = picture.ToArray();
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();

                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool updateUser(int Id, string fname, string lname, string username, string pwd, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE users SET f_name = @fname, l_name = @lname, uname=@uname, pwd=@pwd, fig= @fig where id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@uname", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("@pwd", SqlDbType.NVarChar).Value = pwd;
            command.Parameters.Add("@fig", SqlDbType.Image).Value = picture.ToArray();
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool usernameExist(int id, string username)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM USERS WHERE ID = @ID OR uname = @NAME", mydb.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@NAME", SqlDbType.NVarChar).Value = username;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }


        //public bool verified(string username, string pwd)
        //{
        //    SqlCommand cmd = new SqlCommand("select * from user where uname = @name and pwd = @pwd",
        //        mydb.getConnection);
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable dt = new DataTable();
        //    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = username;
        //    cmd.Parameters.Add("@pwd", SqlDbType.NVarChar).Value = pwd;
        //    adapter.SelectCommand = cmd;
        //    adapter.Fill(dt);
        //    if (username.Trim() == "" || pwd.Trim() == "")
        //    {
        //        MessageBox.Show("Username or Password Empty", "Login Error");
        //        return false;
        //    }
        //    if (dt.Rows.Count > 0)
        //    {
        //        Globals.SetGlobalUserID(Convert.ToInt32(dt.Rows[0][0].ToString()));
        //    }
        //    else
        //    {
        //        MessageBox.Show("Invalid Username or Password", "Login Error");
        //    }
        //}
    }
}
