﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemaventas.DAL;

namespace sistemaventas.DAL
{
    public class ClienteDal
    {
        public DataTable ListarClienteDal()
        {
            string consulta = "SELECT CLIENTE.IDCLIENTE, PERSONA.NOMBRE, PERSONA.APELLIDO\r\nFROM     CLIENTE INNER JOIN\r\n                  PERSONA ON CLIENTE.IDPERSONA = PERSONA.IDPERSONA";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
    }
}
