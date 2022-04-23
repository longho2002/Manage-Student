using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Sinh_Vien
{
    public partial class StudentsListForm : Form
    {
        private STUDENT student = new STUDENT();
        public static bool flag = true;
        public StudentsListForm()
        {
            flag = true;
            InitializeComponent();
        }

        private void StudentsListForm_Load(object sender, EventArgs e)
        {
            if (flag)
            {
                // TODO: This line of code loads data into the 'qL_sinh_vienDataSet.std' table. You can move, or remove it, as needed.
                this.stdTableAdapter.Fill(this.qL_sinh_vienDataSet.std);
                SqlCommand command = new SqlCommand("SELECT * FROM std");
                DataGridView.ReadOnly = true;
                DataGridViewImageColumn picol = new DataGridViewImageColumn();
                DataGridView.RowTemplate.Height = 80;
                DataGridView.DataSource = student.getStudents(command);
                picol = (DataGridViewImageColumn) DataGridView.Columns[7];
                picol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                DataGridView.AllowUserToAddRows = false;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            this.stdTableAdapter.Fill(this.qL_sinh_vienDataSet.std);
            DataGridView.Controls.Clear();
            DataGridView.Refresh();
            DataGridView.DataSource = this.qL_sinh_vienDataSet.std;
        }

        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateDeleteStudentForm updateDeleteStd = new UpdateDeleteStudentForm();
            updateDeleteStd.tb_ID.Text = DataGridView.CurrentRow.Cells[0].Value.ToString();
            updateDeleteStd.tb_FName.Text = DataGridView.CurrentRow.Cells[1].Value.ToString();
            updateDeleteStd.tb_LName.Text = DataGridView.CurrentRow.Cells[2].Value.ToString();
            updateDeleteStd.dateTimePicker1.Value = (DateTime)DataGridView.CurrentRow.Cells[4].Value;
            if ((DataGridView.CurrentRow.Cells[3].Value.ToString().Trim().Equals("Female")))
            {
                updateDeleteStd.radioButtonFemale.Checked = true;
            }
            else
            {
                updateDeleteStd.radioButtonMale.Checked = true;
            }
            updateDeleteStd.tb_Phone.Text = DataGridView.CurrentRow.Cells[5].Value.ToString();
            updateDeleteStd.tb_Address.Text = DataGridView.CurrentRow.Cells[6].Value.ToString();
            byte[] pic;
            pic = (byte[])DataGridView.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateDeleteStd.PictureBoxStudentImage1.Image = Image.FromStream(picture);
            updateDeleteStd.PictureBoxStudentImage1.SizeMode = PictureBoxSizeMode.StretchImage;
            updateDeleteStd.Show();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
