using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Sinh_Vien.score
{
    public partial class RemoveScoreForm : Form
    {
        private Score score = new Score();
        private int id_std;
        private int id_course;
        public RemoveScoreForm()
        {
            InitializeComponent();
        }

        private void RemoveScoreForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_sinh_vienDataSet3.score' table. You can move, or remove it, as needed.
            this.dataGridView1.DataSource = score.getStudentScore();

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                id_std = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                id_course = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                score.deleteScore(id_std, id_course);
                MessageBox.Show("Delete successfully!");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //id_std = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
