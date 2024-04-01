using sistemaventas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemasventas.BSS;
using sistemasventas.MODELOS;

namespace sistemasventas.BSS
{
  
        public class ProductoBss
        {
            ProductoDal dal = new ProductoDal();
            public DataTable ListarProductoBss()
            {
                return dal.ListarPersonasDal();
            }


        }
    }

