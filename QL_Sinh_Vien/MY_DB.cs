﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Sinh_Vien
{
    internal class MY_DB
    {
        private SqlConnection con =
            new SqlConnection(@"Data Source=DESKTOP-PH7VFOH;Initial Catalog=QL_Sinh_Vien;Integrated Security =True;");

        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }

        public void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }
        }
        public void closeConnection(){
            if ((con.State == ConnectionState.Closed))
            {
                con.Close();
            }
        }
    }
}
