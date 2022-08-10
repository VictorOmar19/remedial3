using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class proveedor_materiales
    {
        public string recibo { get; set; }
        public string entrega { get; set; }
        public string cantidad { get; set; }
        public int fecha_entrega { get; set; }
        public float precio { get; set; }
        public int id_Obra { get; set; }
        public int id_Materiales { get; set; }
        public int id_Proveedor { get; set; }
    }
}
