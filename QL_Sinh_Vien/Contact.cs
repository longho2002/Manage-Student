using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Sinh_Vien
{
    internal class Contact
    {
        MY_DB mydb = new MY_DB();

        public bool insertContact(string fname, string lname, string phone, string address, string email, int userid,
            int groupid, MemoryStream picture)
        {
            SqlCommand command =
                new SqlCommand("INSERT INTO contact (fname, lname, group_id , phone, email, address, userid, pic)  VALUES (@fn, @ln, @grp, @phn, @mail, @adrs, @uid, @pic)", mydb.getConnection);
            command.Parameters.Add("fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@grp", SqlDbType.Int).Value = groupid;
            command.Parameters.Add("@phn",SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
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
        public bool deleteContact(int Id)
        {
            SqlCommand command = new SqlCommand(@"DELETE FROM contact WHERE ID = @ID", mydb.getConnection);
            command.Parameters.Add("@ID", SqlDbType.Int).Value = Id;
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
        public bool updateContact(int contactid, string fname, string lname, string phone, string address, string email,
            int groupid, MemoryStream picture)
        {
            SqlCommand command =
                new SqlCommand(
                    "UPDATE contact SET fname = @fn, lname = @ln, group_id = @grp, phone = @phn, email = @mail, address = @adrs, pic = @pic where  id = @contactid",
                    mydb.getConnection);
            command.Parameters.Add("@contactid", SqlDbType.Int).Value = contactid;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@grp", SqlDbType.Int).Value = groupid;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@mail", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
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

        public DataTable SelectContactlist(SqlCommand command)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = mydb.getConnection;
            adapter.Fill(dt);
            return dt;
        }
    }
}
