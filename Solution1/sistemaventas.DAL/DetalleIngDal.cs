using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemasventas.MODELOS;

namespace sistemaventas.DAL
{
    public class DetalleIngDal
    {
        public DataTable ListarDetalleIngDal()
        {
            string consulta = "SELECT P.NOMBRE, DI.FECHAVENC\r\nFROM PRODUCTO P\r\nINNER JOIN DETALLEING DI ON P.IDPRODUCTO = DI.IDPRODUCTO\r\nWHERE DATEDIFF(day, GETDATE(), DI.FECHAVENC) <= 30\r\nAND YEAR(DI.FECHAVENC) = 2023;\r\n";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
    }
}
