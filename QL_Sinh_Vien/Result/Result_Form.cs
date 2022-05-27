using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Sinh_Vien.Result
{
    public partial class Result_Form : Form
    {
        public Result_Form()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //MY_DB db = new MY_DB();
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //DataTable tableUser = new DataTable();
            //SqlCommand command = new SqlCommand("SELECT * FROM SCORE WHERE CONCAT(fname, id) LIKE '%" + tb_search.Text.Trim() + "%'", db.getConnection);
            //adapter.SelectCommand = command;
            //adapter.Fill(tableUser);
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            MY_DB db = new MY_DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable tableUser = new DataTable();
            SqlCommand command =
                new SqlCommand
                    ("select * from (select std.id as stdid,fname, lname, COURSE.id as courseid, LABEL  from std, course) as q left join score on stdid = student_id and courseid = course_id WHERE CONCAT(fname, stdid) LIKE '%" + tb_search.Text.Trim() + "%'", db.getConnection);
            adapter.SelectCommand = command;
            adapter.Fill(tableUser);

            DataTable tableCourse = new DataTable();
            command = new SqlCommand("select * from course", db.getConnection);
            adapter.SelectCommand = command;
            adapter.Fill(tableCourse);

            int nCourse = tableCourse.Rows.Count;
            int nUser = tableUser.Rows.Count;
            int total = nUser / nCourse;
            dataGridView1.Columns.Add("id", "Student ID");
            dataGridView1.Columns.Add("fname", "First Name");
            dataGridView1.Columns.Add("lname", "Last Name");
            foreach (DataRow VARIABLE in tableCourse.Rows)
            {
                dataGridView1.Columns.Add(VARIABLE["id"].ToString(), VARIABLE["label"].ToString());
            }
            dataGridView1.Columns.Add("av", "Average Score");
            dataGridView1.Columns.Add("res", "Results");
            double tong = 0;
            int dem = 1;
            for (int i = 0; i < total; i++)
            {
                dataGridView1.Rows.Add((DataGridViewRow)dataGridView1.Rows[0].Clone());
                dataGridView1.Rows[i].Cells[0].Value = tableUser.Rows[i + i * nCourse][0].ToString();
                dataGridView1.Rows[i].Cells[1].Value = tableUser.Rows[i + i * nCourse][1].ToString();
                dataGridView1.Rows[i].Cells[2].Value = tableUser.Rows[i + i * nCourse][2].ToString();
                tong = dem = 0;
                for (int j = 0; j < nCourse; j++)
                {
                    if (tableUser.Rows[j + i * nCourse][7].ToString().Trim() != "")
                    {
                        tong += Convert.ToDouble(tableUser.Rows[j + i * nCourse][7].ToString());
                        dem += 1;
                    }
                    dataGridView1.Rows[i].Cells[3 + j].Value = tableUser.Rows[j + i * nCourse][7].ToString();
                }

                if (dem != 0)
                {
                    double diem = (tong * 1.0 / dem);
                    dataGridView1.Rows[i].Cells[3 + nCourse].Value = diem;
                    dataGridView1.Rows[i].Cells[4 + nCourse].Value = diem > 5 ? "Đạt" : "Rớt";
                }
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "export.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Export_Data_To_Word(dataGridView1, sfd.FileName);
            }
        }
        //SELECT * FROM SCORE WHERE CONCAT(fname,id) LIKE '%" + tb_search.Text.Trim() + "%'"
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Result_Form_Load(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable tableUser = new DataTable();
            SqlCommand command = new SqlCommand("select * from (select std.id as stdid,fname, lname, COURSE.id as courseid, LABEL  from std, course) as q left join score on stdid = student_id and courseid = course_id", db.getConnection);
            adapter.SelectCommand = command;
            adapter.Fill(tableUser);

            DataTable tableCourse = new DataTable();
            command = new SqlCommand("select * from course", db.getConnection);
            adapter.SelectCommand = command;
            adapter.Fill(tableCourse);

            int nCourse = tableCourse.Rows.Count;
            int nUser = tableUser.Rows.Count;
            int total = nUser / nCourse;
            dataGridView1.Columns.Add("id", "Student ID");
            dataGridView1.Columns.Add("fname", "First Name");
            dataGridView1.Columns.Add("lname", "Last Name");
            foreach (DataRow VARIABLE in tableCourse.Rows)
            {
                dataGridView1.Columns.Add(VARIABLE["id"].ToString(), VARIABLE["label"].ToString());
            }
            dataGridView1.Columns.Add("av", "Average Score");
            dataGridView1.Columns.Add("res", "Results");
            double tong = 0;
            int dem = 1;
            for (int i = 0; i < total; i++)
            {
                dataGridView1.Rows.Add((DataGridViewRow)dataGridView1.Rows[0].Clone());
                dataGridView1.Rows[i].Cells[0].Value = tableUser.Rows[i * nCourse][0].ToString();
                dataGridView1.Rows[i].Cells[1].Value = tableUser.Rows[i * nCourse][1].ToString();
                dataGridView1.Rows[i].Cells[2].Value = tableUser.Rows[i * nCourse][2].ToString();
                tong = dem = 0;
                for (int j = 0; j < nCourse; j++)
                {
                    if (tableUser.Rows[j + i * nCourse][7].ToString().Trim() != "")
                    {
                        tong += Convert.ToDouble(tableUser.Rows[j + i * nCourse][7].ToString());
                        dem += 1;
                    }
                    dataGridView1.Rows[i].Cells[3 + j].Value = tableUser.Rows[j + i * nCourse][7].ToString();
                }

                if (dem != 0)
                {
                    double diem = (tong * 1.0 / dem);
                    dataGridView1.Rows[i].Cells[3 + nCourse].Value = Math.Round(diem, 2);
                    string kq;
                    if (diem >= 8.5)
                        kq = "Giỏi";
                    else if (diem < 8.5 && diem >= 6.5)
                        kq = "Khá";
                    else if (diem < 6.5 && diem >= 5)
                        kq = "TB";
                    else
                    {
                        kq = "Rớt";
                    }
                    dataGridView1.Rows[i].Cells[4 + nCourse].Value = kq;
                }
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tb_stdID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tb_fname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tb_lname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    } //end row loop
                } //end column loop

                Microsoft.Office.Interop.Word.Document oDoc = new Microsoft.Office.Interop.Word.Document();
                oDoc.Application.Visible = true;

                //page orintation
                oDoc.PageSetup.Orientation = Microsoft.Office.Interop.Word.WdOrientation.wdOrientLandscape;

                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }

                //table format
                oRange.Text = oTemp;

                object Separator = Microsoft.Office.Interop.Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                //table style 
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                //header text
                foreach (Microsoft.Office.Interop.Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "SCORE";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                //save the file
                oDoc.SaveAs2(filename);

                //NASSIM LOUCHANI
            }
        }

        private void Print_std_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "student.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {//
                Export_std_Data_To_Word(dataGridView1, @"C:\Users\Thai Long\Downloads\template.docx");
            }
        }
        public void Export_std_Data_To_Word(DataGridView DGV, object filename)
        {
            if (DGV.CurrentRow.Selected != null)
            {
                int RowCount = DGV.CurrentRow.Index;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[ColumnCount - 3 - 2, 2];

                //add rows
                int r = 0;
                for (r = 3; r <= ColumnCount - 3; r++)
                {
                    DataArray[r-3, 0] = DGV.Columns[r].HeaderText;
                }
                for (r = 3; r <= ColumnCount - 3; r++)
                {
                    DataArray[r-3, 1] = DGV.Rows[RowCount].Cells[r].Value;
                }
                //Microsoft.Office.Interop.Word.Document oDoc = new Microsoft.Office.Interop.Word.Document();
                //oDoc.Application.Visible = true;

                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                object missing = Missing.Value;
                Microsoft.Office.Interop.Word.Document myWordDoc = null;
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;
                object sss = @"C:\Users\Thai Long\Downloads\student.docx";
                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();

                //find and replace
                this.FindAndReplace(wordApp, "<<name>>", (DGV.Rows[RowCount].Cells[2].Value.ToString() +" "+ DGV.Rows[RowCount].Cells[1].Value.ToString()));
                this.FindAndReplace(wordApp, "<<mssv>>", DGV.Rows[RowCount].Cells[0].Value.ToString());
                this.FindAndReplace(wordApp, "<<printdate>>", DateTime.Now.ToShortDateString());
                //page orintation
                    
                string oTemp = "";

                for (r = 3; r <= ColumnCount - 3; r++)
                {
                    oTemp = oTemp + DataArray[r-3, 0] + "\t";
                }
                for (r = 3; r <= ColumnCount - 3; r++)
                {
                    oTemp = oTemp + DataArray[r-3, 1] + "\t";
                }
                //table format

                dynamic oRange = myWordDoc.Content.Application.Selection.Range;
                oRange.Text = oTemp;
                object Separator = Microsoft.Office.Interop.Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent;
                RowCount = ColumnCount-3-2;
                ColumnCount = 2;
                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                

                myWordDoc.Application.Selection.Tables[1].Select();
                myWordDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                myWordDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                myWordDoc.Application.Selection.Tables[1].Rows[1].Select();
                myWordDoc.Application.Selection.Tables[1].Rows[1].Select();



                //table style 
                //5 / 21 / 2022
                myWordDoc.Application.Selection.InsertAfter("999");
                myWordDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                myWordDoc.Application.Selection.Tables[1].Rows[1].Select();
                myWordDoc.Application.Selection.Cells.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                //save the file
                myWordDoc.SaveAs2("student.docx");
            }
        }

        private void FindAndReplace(Microsoft.Office.Interop.Word.Application wordApp, object ToFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllforms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref ToFindText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundLike,
                ref nmatchAllforms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiactitics, ref matchAlefHamza,
                ref matchControl);
        }
    }
}
