using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_Sinh_Vien.Result;
using QL_Sinh_Vien.score;

namespace QL_Sinh_Vien
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Login_Form flogin = new Login_Form();
            //flogin.ShowDialog();
            //if (flogin.DialogResult == DialogResult.OK)
            //{
            //    if (flogin.rBtn_std.Checked == true)
            //        Application.Run(new MainForm());
            //    else
            //        Application.Run(new HR_Form());
            //}
            //else
            //{
            //    Application.Exit();
            //}
            Application.Run(new MainForm());
        }
    }
}
