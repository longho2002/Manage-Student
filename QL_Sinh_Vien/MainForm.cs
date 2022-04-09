using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Sinh_Vien
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addNewStdudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudent = new AddStudentForm();
            addStudent.Show(this);
        }

        private void rToolStripMenuItem(object sender, EventArgs e)
        {
            StudentsListForm stdListForm = new StudentsListForm();
            stdListForm.Show(this);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintForm printForm = new PrintForm();
            printForm.Show(this);
        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statics stdStatic = new Statics();
            stdStatic.Show(this);
        }
    }
}
