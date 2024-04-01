using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemasventas.MODELOS;

namespace sistemaventas.DAL
{
    public class MarcaDal
    {
        public DataTable ListarPersonasDal()
        {
            string consulta = "\r\nSELECT MARCA.NOMBRE, DETALLEVENTA.CANTIDAD\r\nFROM     MARCA INNER JOIN\r\n                  PRODUCTO ON MARCA.IDMARCA = PRODUCTO.IDMARCA INNER JOIN\r\n                  DETALLEVENTA ON PRODUCTO.IDPRODUCTO = DETALLEVENTA.IDPRODUCTO";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
    }
}
