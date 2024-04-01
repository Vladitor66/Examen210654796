using sistemasventas.BSS;
using sistemasventas.MODELOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace sistemasventas.VISTA.Examen2
{
    public partial class Consulta2 : Form
    {
        public Consulta2()
        {
            InitializeComponent();
        }
        ProveedorBss bss = new ProveedorBss();
        private void Consulta2_Load(object sender, EventArgs e)
        {
           dataGridView1.DataSource = bss.ListarProveedorBss();
        }
    }
}
