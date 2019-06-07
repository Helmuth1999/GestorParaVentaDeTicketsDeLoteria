using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GestorParaVentaDeLoteria.Modelo
{
    public class SorteosHistorico
    {
        public int Id { get; set; }
        [Display(Name = "Tipo de modificación")]
        public TipoDeModificacion TipoDeModificacion { get; set; }
        [Display(Name = "Fecha de modificacion")]
        public DateTime FechaDeModificacion { get; set; }
        [Display(Name = "Identificador del usuario")]
        [StringLength(128)]
        public string Id_AspNetUser { get; set; }
        [Display(Name = "Descripcion de la modificación")]
        public string DescripcionDeLaModificacion { get; set; }
        [Display(Name = "Identificador del sorteo")]
        public int IdSorteo { get; set; }
    }
}
