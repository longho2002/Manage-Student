using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeBi.Libraries.PagedList;

namespace QL_Sinh_Vien
{
    public partial class PrintForm : Form
    {
        private STUDENT student = new STUDENT();
        DateTime sDate = new DateTime();
        DateTime fDate = new DateTime();

        public PrintForm()
        {
            InitializeComponent();
        }

        public void fillGrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn piccol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            piccol = (DataGridViewImageColumn) dataGridView1.Columns[7];
            piccol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void Print_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from STD");
            fillGrid(cmd);
            if (rBtn_No.Checked)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }

            dateTimePicker1.CustomFormat = "yyyy-MM-dddd";
            dateTimePicker2.CustomFormat = "yyyy-MM-dddd";
        }


        private void btn_Check_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            String query;

            if (rBtn_Yes.Checked)
            {
                string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                if (rBtn_Male.Checked)
                {
                    query = @"Select * from std where gender = 'Male' and bdate BETWEEN '" + date1 + "' AND '" + date2 +
                            "'";
                }
                else if (rBtn_Female.Checked)
                {
                    query = @"Select * from std where gender = 'FeMale' and bdate BETWEEN'" + date1 + "' AND '" +
                            date2 + "'";
                }
                else
                {
                    query = @"Select * from std where bdate BETWEEN '" + date1 + "' AND '" + date2 + "'";
                }

                cmd = new SqlCommand(query);
                fillGrid(cmd);
            }
            else
            {
                if (rBtn_Male.Checked)
                {
                    query = @"Select * from std where gender = 'Male'";
                }
                else if (rBtn_Female.Checked)
                {
                    query = @"Select * from std where gender = 'FeMale'";
                }
                else
                {
                    query = @"Select * from std";
                }

                cmd = new SqlCommand(query);
                fillGrid(cmd);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "export.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_Word(dataGridView1, sfd.FileName);
            }
            return;
            String path;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.DefaultExt = "doc";
            saveFileDialog1.Filter = "Text file (*.doc)|*.doc";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Title = "Where do you want to save the file?";
            saveFileDialog1.InitialDirectory = @"C:/";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
            }
            else
            {
                MessageBox.Show("You hit cancel or closed the dialog.");
                return;
            }

            saveFileDialog1.Dispose();
            saveFileDialog1 = null;
            using (var writer = new StreamWriter(path))
            {
                if (!File.Exists(path))
                    File.Create(path);
                DateTime bdate;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                    {
                        if (j == 4)
                        {
                            bdate = Convert.ToDateTime(dataGridView1.Rows[i].Cells[j].Value.ToString());
                            writer.Write("\t" + bdate.ToString("yyyy-MM-dd") + "\t" + "|");
                        }
                        else if (j == dataGridView1.Columns.Count - 2)
                            writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString());
                        else
                        {
                            writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                        }
                    }

                    writer.WriteLine("");
                    writer.WriteLine(
                        "=================================================================================================================================");
                }
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            PrintDialog pDlg = new PrintDialog();

            PrintDocument pDoc = new PrintDocument();
            //pDoc.PrintPage += PDoc_PrintPage;
            pDoc.DocumentName = "Student";
            pDlg.Document = pDoc;
            pDlg.AllowSelection = true;
            pDlg.AllowSomePages = true;
            if (pDlg.ShowDialog() == DialogResult.OK)
            {
                pDoc.Print();
            }
            else
            {
                MessageBox.Show("Đã hủy in");
            }
        }


        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm updateDeleteStd = new UpdateDeleteStudentForm();
            updateDeleteStd.tb_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateDeleteStd.tb_FName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateDeleteStd.tb_LName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateDeleteStd.dateTimePicker1.Value = (DateTime) dataGridView1.CurrentRow.Cells[4].Value;
            if ((dataGridView1.CurrentRow.Cells[3].Value.ToString().Trim().Equals("Female")))
            {
                updateDeleteStd.radioButtonFemale.Checked = true;
            }
            else
            {
                updateDeleteStd.radioButtonMale.Checked = true;
            }

            updateDeleteStd.tb_Phone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            updateDeleteStd.tb_Address.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            byte[] pic;
            pic = (byte[]) dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateDeleteStd.PictureBoxStudentImage1.Image = Image.FromStream(picture);
            updateDeleteStd.PictureBoxStudentImage1.SizeMode = PictureBoxSizeMode.StretchImage;
            updateDeleteStd.Show();
        }

        private void rBtn_Yes_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        private void rBtn_No_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }


        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Microsoft.Office.Interop.Word.Document oDoc = new Microsoft.Office.Interop.Word.Document();
                oDoc.Application.Visible = true;
                oDoc.PageSetup.Orientation = Microsoft.Office.Interop.Word.WdOrientation.wdOrientLandscape;
                //dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                Object oMissing = System.Reflection.Missing.Value;
                for (int r = 0; r <= RowCount - 1; r++)
                {
                    oTemp = "";
                    for (int c = 0; c < ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DGV.Rows[r].Cells[c].Value + "\t";
                    }

                    var oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara1.Range.Text = oTemp;
                    oPara1.Range.InsertParagraphAfter();
                    byte[] imgbyte = (byte[])DGV.Rows[r].Cells[7].Value;
                    MemoryStream ms = new MemoryStream(imgbyte);
                    System.Drawing.Image sparePicture = System.Drawing.Image.FromStream(ms);
                    System.Drawing.Image finalPic = (System.Drawing.Image)(new Bitmap(sparePicture, new
                        Size(90, 90)));
                    Clipboard.SetDataObject(finalPic);
                    var oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara2.Range.Paste();
                    oPara2.Range.InsertParagraphAfter();
                    //oTemp += "\n";
                }
                //save the file
                oDoc.SaveAs2(filename);
            }
        }
    }
}