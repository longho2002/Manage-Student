using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_Sinh_Vien.score;

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

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 printForm = new Form1();
            printForm.Show(this);
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCourseForm f = new RemoveCourseForm();
            f.Show(this);
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCourseForm a = new EditCourseForm();
            a.Show(this);
        }

        private void manageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCourseForm a = new ManageCourseForm();
            a.Show(this);
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintCourseForm a = new PrintCourseForm();
            a.Show(this);
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScoreForm a = new AddScoreForm();
            a.Show(this);
        }

        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveScoreForm a = new RemoveScoreForm();
            a.Show(this);
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void avgScoreByCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printResultToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
