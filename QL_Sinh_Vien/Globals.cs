using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Sinh_Vien
{
    internal static class Globals
    {
        public static int GlobalUserID { get; private set; }
        public static int GlobalContactID { get; private set; }
        public static void SetGlobalUserID(int id)
        {
            GlobalUserID = id;
        }
        public static void SetGlobalContactID(int id)
        {
            GlobalContactID = id;
        }
    }
}
