using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema
{
    public partial class buscar : Form
    {
        public buscar()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int indice = dataGridView1.CurrentRow.Index;
            crear_record cr = new crear_record();
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            // this.Hide();
        }

        private void buscar_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }
    }
}
