using sistemasventas.BSS;
using sistemaventas.DAL;
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
    public partial class Consulta5 : Form
    {
        public Consulta5()
        {
            InitializeComponent();
        }
        DetalleIngBss   bss= new DetalleIngBss();
        private void Consulta5_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarDetalleIngBss();
        }
    }
}
