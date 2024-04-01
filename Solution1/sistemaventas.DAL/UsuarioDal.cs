using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaventas.DAL
{
    internal class UsuarioDal
    {
        public DataTable ListarPersonasDal()
        {
            string consulta = "SELECT U.NOMBREUSER AS 'Vendedor', COUNT(DV.IDDETALLEVENTA) AS 'Cantidad de Productos Vendidos'\r\nFROM USUARIO U\r\nLEFT JOIN VENTA V ON U.IDUSUARIO = V.IDVENDEDOR\r\nLEFT JOIN DETALLEVENTA DV ON V.IDVENTA = DV.IDVENTA\r\nGROUP BY U.NOMBREUSER;";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
    }
}
