using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace QL_Sinh_Vien
{
    internal class STUDENT
    {
        MY_DB mydb = new MY_DB();
        public bool insertStudent(int Id, string fname, string lname, DateTime bdate, string gender, string phone,
            string address, MemoryStream picture)
        {
            SqlCommand command =
                new SqlCommand(
                    "INSERT INTO std (id, fname, lname, bdate, gender, phone, address, picture)" +
                    "VALUES(@id, @fname, @lname, @bdate, @gender, @phone, @address, @picture)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@bdate", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@picture", SqlDbType.Image).Value = picture.ToArray();

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

        private string execCount(string query)
        {
            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            String count = cmd.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }
        internal object totalFemale()
        {
            return execCount("SELECT COUNT(*) FROM STD WHERE GENDER = 'Female'");
        }

        internal object totalMale()
        {
            return execCount("SELECT COUNT(*) FROM STD WHERE GENDER = 'Male'");
        }

        internal object totalStudents()
        {
            return execCount("SELECT COUNT(*) FROM STD");
        }

        public bool updateStudent(int Id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE std SET  fname = @fname, lname= @lname, bdate=@bdate, gender=@gender, phone=@phone, address=@address, picture=@picture where id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@bdate", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@picture", SqlDbType.Image).Value = picture.ToArray();
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

        public bool deleteStudent(int Id)
        {
            SqlCommand command = new SqlCommand(@"DELETE FROM STD WHERE ID = @ID", mydb.getConnection);
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
        public DataTable getStudents(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool updateStudents(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
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
        public bool removeStudents(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
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

        //public bool validInfor(int Id, string fname, string lname, DateTime bdate, string gender, string phone,
        //    string address, MemoryStream picture)
        //{

        //}
    }
}
