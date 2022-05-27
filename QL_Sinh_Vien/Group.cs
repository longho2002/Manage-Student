using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Sinh_Vien
{
    internal class Group
    {
        MY_DB mydb = new MY_DB();

        public bool insertGroup(int id, string name, int uid)
        {
            SqlCommand command = new SqlCommand(
                "INSERT INTO groups (id, name , userid ) VALUES(@id, @name, @uid)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = uid;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            mydb.closeConnection();
            return false;
        }
        public bool updateGroup(int id, string name)
        {
            SqlCommand command = new SqlCommand(
                "update groups set name = @name where id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            mydb.closeConnection();
            return false;
        }

        public bool deleteGroup(int groupid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM groups WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = groupid;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }

            mydb.closeConnection();
            return false;
        }
        public DataTable getGroups(int userid)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM groups WHERE userid = @uid", mydb.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool groupExist(string name, string operation, int userid = 0, int groupid = 0)
        {
            string query = "";
            SqlCommand command = new SqlCommand();
            if (operation == "add")
            {
                query = "SELECT * FROM groups WHERE name = @name AND userid = @uid";
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;

            }
            else if (operation == "edit")
            {
                query = "SELECT * FROM groups WHERE name = @name AND userid = @uid AND id <> @gid";
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
                command.Parameters.Add("@gid", SqlDbType.Int).Value = groupid;
            }
            command.Connection = mydb.getConnection;
            command.CommandText = query;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

    }
}
