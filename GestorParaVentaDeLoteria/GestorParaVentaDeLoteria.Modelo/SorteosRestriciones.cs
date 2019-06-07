using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorParaVentaDeLoteria.Modelo
{
    public class SorteosRestriciones
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public decimal MontoMáximo { get; set; }
        public int IdSorteos { get; set; }
    }
}
