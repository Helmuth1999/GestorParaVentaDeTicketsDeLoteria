using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GestorParaVentaDeLoteria.Modelo
{
    public class SorteosDetalleVentas
    {
        public int Id { get; set; }
        public int TipoDeModificacion { get; set; }
        public DateTime FechaDeModificacion { get; set; }
        [StringLength(128)]
        public string Id_AspNetUser { get; set; }
        public string DescripcionDeLaModificacion { get; set; }
        public int IdSorteo { get; set; }

    }
}
