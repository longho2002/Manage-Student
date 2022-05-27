using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_Sinh_Vien.course;
using QL_Sinh_Vien.Result;
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
            AddCourse printForm = new AddCourse();
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
            ManageScoreForm a = new ManageScoreForm();
            a.Show(this);
        }

        private void avgScoreByCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            avgScoreByCourseForm a = new avgScoreByCourseForm();
            a.Show(this);
        }

        private void printResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintScore a = new PrintScore();
            a.Show(this);
        }

        private void aVGResultByScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Result_Form a = new Result_Form();
            a.Show(this);
        }

        private void statisticResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statisticForm a = new statisticForm();
            a.Show(this);
        }

        private void messageStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudentsForm a = new ManageStudentsForm();
            a.Show(this);
        }
    }
}
