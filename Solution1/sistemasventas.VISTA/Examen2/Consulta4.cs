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
    public partial class Consulta4 : Form
    {
        public Consulta4()
        {
            InitializeComponent();
        }
        ProductoBss bss = new ProductoBss();
        private void Consulta4_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProductoBss();
        }
    }
}
