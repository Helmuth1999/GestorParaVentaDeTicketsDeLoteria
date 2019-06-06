using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GestorParaVentaDeLoteria.Modelo
{
    public class SorteoDetalleVentas
    {

        public int Id { get; set; }
        [Display(Name = "Identificador de Sorteos")]
        public int IdSorteos { get; set; }

        public int Numero { get; set; }

        public decimal Monto { get; set; }

    }
}
