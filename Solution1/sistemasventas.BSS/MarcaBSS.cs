using sistemaventas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemasventas.MODELOS;
using sistemasventas.BSS;

namespace sistemasventas.BSS
{
    public class MarcaBSS
    {
        
        
            MarcaDal dal = new MarcaDal();
            public DataTable ListarMarcaBSS()
            {
                return dal.ListarPersonasDal();
            }


        }
    }

