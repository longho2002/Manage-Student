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
    internal class COURSE
    {
        private MY_DB mydb = new MY_DB();

        public bool checkCourseName(string courseName, int courseid = 0)
        {
            //
            SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE label=@cName And id <> @cID",
                mydb.getConnection);
            command.Parameters.Add("@cName", SqlDbType.NVarChar).Value = courseName;
            command.Parameters.Add("@cID", SqlDbType.Int).Value = courseid;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool updateCourse(int Id, string label, int period, String description)
        {
            SqlCommand command = new SqlCommand("UPDATE COURSE SET  label = @label, period= @period, description=@description where id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
            command.Parameters.Add("@period", SqlDbType.Int).Value = period;
            command.Parameters.Add("@description", SqlDbType.Text).Value = description;
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
        public bool deleteCourse(int Id)
        {
            SqlCommand command = new SqlCommand(@"DELETE FROM COURSE WHERE ID = @ID", mydb.getConnection);
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
        public DataTable getAllCourse()
        {
            SqlCommand command = new SqlCommand("select *from course");
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getCourseById(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM COURSE WHERE ID = @ID");
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        private string execCount(string query)
        {
            SqlCommand cmd = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            String count = cmd.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }
        public string totalCourses()
        {
            return execCount("SELECT COUNT(*) FROM COURSE");
        }
        public bool insertCourse(int Id, string label, int period, String description)
        {
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO COURSE(Id, label, period, description)  VALUES(@id, @label, @period, @description)", mydb.getConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                command.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
                command.Parameters.Add("@period", SqlDbType.Int).Value = period;
                command.Parameters.Add("@description", SqlDbType.Text).Value = description;
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
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

    }
}
