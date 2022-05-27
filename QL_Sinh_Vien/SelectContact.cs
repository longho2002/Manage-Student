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
    public partial class SelectContact : Form
    {
        public SelectContact()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim() != "")
                Globals.SetGlobalContactID(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            this.Close();
        }
    }
}
