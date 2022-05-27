using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Documents;
using System.Windows.Forms;

using Image = System.Drawing.Image;
using MessageBox = System.Windows.Forms.MessageBox;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;

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
            piccol = (DataGridViewImageColumn)dataGridView1.Columns[7];
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
            updateDeleteStd.dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[4].Value;
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
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
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
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        if (c ==4 )
                            DataArray[r, c] = ((DateTime)DGV.Rows[r].Cells[c].Value).ToShortDateString() ;

                        else
                        {
                            DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                        }
                    } //end row loop
                } //end column loop

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;

                //page orintation
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;

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

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

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
                oDoc.Application.Selection.Cells.VerticalAlignment =
                    Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                //header text
                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "STUDENT";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                int n = DGV.Rows.Count;
                for (int i = 0; i < n; i++)
                {
                    byte[] imgbyte = (byte[])DGV.Rows[i].Cells[7].Value;
                    Object oMissing = System.Reflection.Missing.Value;
                    MemoryStream ms = new MemoryStream(imgbyte);
                    System.Drawing.Image sparePicture = System.Drawing.Image.FromStream(ms);
                    System.Drawing.Image finalPic = (System.Drawing.Image)(new Bitmap(sparePicture, new
                        Size(90, 90)));
                    Clipboard.SetDataObject(finalPic);
                    var oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oDoc.Tables[1].Cell(2 + i, 8).Range.Paste();
                }
                //oDoc.Tables[1].Range.Shading.BackgroundPatternColor = Word.WdColor.wdColorGray05;
                // oDoc.Application.Selection.Tables[1].Rows[1].Range.Shading.BackgroundPatternColor = Word.WdColor.wdColorWhite;
                // oDoc.Tables[1].Cell(1, 4).Range.Shading.BackgroundPatternColor = Word.WdColor.wdColorDarkRed;

                //.                foreach (Word.Row tb in oDoc.Tables[1].Rows)
                //                {
                //                    MessageBox.Show(tb[0].ToString());
                //                }

                //save the file
                try
                {
                    oDoc.SaveAs2(filename);

                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show(e.Message.ToString());
                }

                //NASSIM LOUCHANI
            }
        }

        private void printExel()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            worksheet.Columns[8].ColumnWidth = 20;
            worksheet.Columns[7].ColumnWidth = 20;
            worksheet.Columns[5].ColumnWidth = 20;
            // storing header part in Excel  
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (j == 7)
                    {
                        //worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        byte[] imgbyte = (byte[])dataGridView1.Rows[i].Cells[7].Value;
                        MemoryStream ms = new MemoryStream(imgbyte);
                        System.Drawing.Image sparePicture = System.Drawing.Image.FromStream(ms);
                        System.Drawing.Image finalPic = (System.Drawing.Image)(new Bitmap(sparePicture, new
                            Size(90, 90)));
                        //Clipboard.SetDataObject(finalPic);
                        System.Windows.Forms.Clipboard.SetImage(finalPic);
                        Excel.Range position = (Excel.Range)worksheet.Cells[i + 2, j + 1];
                        position.RowHeight = 80;
                        worksheet.Paste(position);
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            // save the application  )
            workbook.SaveAs();

        }

        private void btn_Execl_Click(object sender, EventArgs e)
        {
            printExel();
        }
    }
}