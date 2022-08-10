using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class material
    {
        public int IdMaterial { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Presentacion { get; set; }
        public int id_tipo { get; set; }
    }
}
