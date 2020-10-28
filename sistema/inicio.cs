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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == false) { panel2.Visible = true; } else { panel2.Visible = false; }

            

            /*pacientes p = new pacientes();
            p.MdiParent = this;
            p.Show();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            record r = new record();
            r.MdiParent = this;
            r.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (subpac.Visible == false) { subpac.Visible = true; } else { subpac.Visible = false; }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (subrecord.Visible == false) { subrecord.Visible = true; } else { subrecord.Visible = false; }
            
        }

        private void mantcli_Click(object sender, EventArgs e)
        {
            pacientes p = new pacientes();
            p.MdiParent = this;
            p.Show();
        }

        private void buscar_r_Click(object sender, EventArgs e)
        {
            record r = new record();
            r.MdiParent = this;
            r.Show();
        }

        private void crear_r_Click(object sender, EventArgs e)
        {
            crear_record cr = new crear_record();
            cr.MdiParent = this;
            cr.Show();
        }
    }
}
