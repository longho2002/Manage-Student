using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Sinh_Vien.score
{
    internal class Score
    {
        private MY_DB mydb = new MY_DB();
        public bool insertScore(int student_ID, int courseID, float scoreValue, string description)
        {
            SqlCommand command = new SqlCommand(
                "INSERT INTO Score(student_id, course_id, student_score, description) VALUES (@sid,@cid, @scr" +
                ",@descr)", mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = student_ID;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            command.Parameters.Add("@scr", SqlDbType.Float).Value = scoreValue;
            command.Parameters.Add("@descr", SqlDbType.VarChar).Value = description;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
                return true;
            else
                return false;
        }

        public bool studentScoreExist(int studentId, int courseID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM score WHERE student_id = @sid AND course_id = @cid",
                mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentId;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            if ((table.Rows.Count == 0))
                return false;
            else
                return true;
            // tỉnh trung bình 
        }

        public DataTable getAvgScoreByCourse()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText =
                "SELECT Course.label, AVG(Score.student_score) As AverageGrade FROM Course, score where score.course_id = course.id GROUP BY Course.label";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool deleteScore(int student_ID, int courseID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM score WHERE student_id = @sid AND course_id = @cid",
                mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.Int).Value = student_ID;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
                return true;
            else
                return false;
        }

        public DataTable getStudentScore()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText =
                "select score.student_id, std.fname, std.lname, score.course_id, COURSE.label, score.student_score from std  join score on std.id = score.student_id join course on course.id = score.course_id ";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
