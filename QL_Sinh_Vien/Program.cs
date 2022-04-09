using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Login_Form flogin = new Login_Form();
            //flogin.ShowDialog();
            //if (flogin.DialogResult == DialogResult.OK)
            //{
            //    Application.Run(new MainForm());
            //}
            //else
            //{
            //    Application.Exit();
            //}
            Application.Run(new PrintForm());
        }
    }
}
