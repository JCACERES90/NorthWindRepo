using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Entity
{
    public class TbCategoriaBE
    {
        public string CodCategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public TbCategoriaBE(string codcategoria,
            string  nombre , 
            string  descripcion)
        {
            this.CodCategoria    =codcategoria;
            this.Nombre = nombre;
            this.Descripcion    = descripcion;        
        }
   
    }
}
