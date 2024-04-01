using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemasventas.BSS;

namespace sistemasventas.VISTA.Examen2
{
    public partial class Consulta1 : Form
    {
        public Consulta1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {


            {

            }

        }
        ClienteBss bss = new ClienteBss();
        private void Consulta1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource=bss.ListarClienteBss();
        }
    }

}
