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

        private void Print_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_sinh_vienDataSet1.std' table. You can move, or remove it, as needed.
            this.stdTableAdapter.Fill(this.qL_sinh_vienDataSet1.std);
            SqlCommand command = new SqlCommand("SELECT * FROM std ORDER BY bdate ASC");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
            MY_DB db = new MY_DB();
            using (SqlConnection connection = db.getConnection)
            {
                connection.Open();
                command = new SqlCommand("SELECT bdate FROM std", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cb_DateStart.Items.Add(Convert.ToDateTime(reader["bdate"]).ToString("dd/MM/yyyy"));
                    cb_DateFinish.Items.Add(Convert.ToDateTime(reader["bdate"]).ToString("dd/MM/yyyy"));
                }
            }
        }


        private void btn_Check_Click(object sender, EventArgs e)
        {
            //(cb_DateStart.SelectedItem.ToString() + " 0:0:0 AM")

            if (rBtn_Yes.Checked && DateTime.Compare(sDate, fDate) > 0)
            {
                MessageBox.Show("Date start must be bigger than date finish!Please choose another value!");
                return;
            }
            string cmd = "SELECT * FROM std where gender in (@gender,@gender1) and bdate >= @sDate and bdate <= @fDate";
            this.stdTableAdapter.Fill(this.qL_sinh_vienDataSet1.std);
            SqlCommand command = new SqlCommand(cmd);
            command.Parameters.Add("@sDate", SqlDbType.DateTime).Value = rBtn_Yes.Checked ? sDate : DateTime.Now.AddYears(-150);
            command.Parameters.Add("@fDate", SqlDbType.DateTime).Value = rBtn_Yes.Checked ? fDate : DateTime.Now;

            if (rBtn_Female.Checked)
            {
                command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = "Female";
                command.Parameters.Add("@gender1", SqlDbType.NVarChar).Value = "FeMale";
            }
            else if (rBtn_Male.Checked)
            {
                command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = "Male";
                command.Parameters.Add("@gender1", SqlDbType.NVarChar).Value = "Male";
            }
            else
            {
                command.Parameters.Add("@gender", SqlDbType.NVarChar).Value = "Male";
                command.Parameters.Add("@gender1", SqlDbType.NVarChar).Value = "FeMale";
            }
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }
        private void btn_Print_Click(object sender, EventArgs e)
        {
            PrintDialog pDlg = new PrintDialog();

            PrintDocument pDoc = new PrintDocument();
            pDoc.PrintPage += PDoc_PrintPage;
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

        private void PDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);

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

        private void cb_DateStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sDate = DateTime.ParseExact((sender as ComboBox).SelectedItem.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            }
            catch (Exception exception)
            {
                MessageBox.Show("Invalid value!");
            }
        }

        private void cb_DateFinish_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                fDate = DateTime.ParseExact((sender as ComboBox).SelectedItem.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Invalid value!");
            }

        }
    }
}
