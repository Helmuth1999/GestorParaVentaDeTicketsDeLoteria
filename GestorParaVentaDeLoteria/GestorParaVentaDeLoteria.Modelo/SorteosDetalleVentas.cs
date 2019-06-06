using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorParaVentaDeLoteria.Modelo
{
    class SorteosDetalleVentas
    {
        public int Id { get; set; }
        public int IdSorteos { get; set; }
        public int Numero { get; set; }
        public double Monto { get; set; }
        public string Id_AspNetUser { get; set; }
    }
}
