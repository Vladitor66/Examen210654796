using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemasventas.MODELOS;

namespace sistemaventas.DAL
{
    public class ProductoDal
    {
        public DataTable ListarPersonasDal()
        {
            string consulta = "SELECT SUM(CANTIDAD) AS CantidadTotal\r\nFROM DETALLEING;\r\n";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
    }
}
