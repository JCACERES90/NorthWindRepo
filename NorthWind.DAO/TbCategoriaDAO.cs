using NorthWind.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.DAO
{
    public class TbCategoriaDAO
    {
        public static List<TbCategoriaBE> SelectAll()
        {
            List<TbCategoriaBE> categorias = new List<TbCategoriaBE>();
            categorias.Add(new TbCategoriaBE("cat1", "Lacteos", "Descripcion1"));
            categorias.Add(new TbCategoriaBE("cat2", "Verduras", "Descripcion 2"));
            categorias.Add(new TbCategoriaBE("cat3", "Aceites", "Descripcion 3"));
            categorias.Add(new TbCategoriaBE("cat4", "Carnes", "Descripcion 4"));
            return categorias;
        }
    }
}
