﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaventas.DAL
{
    public class ProveedorDal
    {
        public DataTable ListarPersonasDal()
        {
            string consulta = "SELECT PROVEEDOR.NOMBRE, PROVEEDOR.TELEFONO, PROVEEDOR.DIRECCION, PROVEEDOR.ESTADO, INGRESO.TOTAL\r\nFROM     INGRESO INNER JOIN\r\n                  PROVEEDOR ON INGRESO.IDPROVEEDOR = PROVEEDOR.IDPROVEEDOR";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
    }
}
