using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class obra
    {
        public int IdObra { get; set; }
        public string Nombre_Obra { get; set; }
        public string Direccion { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin  { get; set; }
        public int idDueño { get; set; }
        public int id_Encargado { get; set; }
    }
}
