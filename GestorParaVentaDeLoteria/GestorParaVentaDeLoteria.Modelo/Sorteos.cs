using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorParaVentaDeLoteria.Modelo
{
    public class Sorteos
    {
        public int Id { get; set; }
        public Estado Estado { get; set; }
        public DateTime Fecha { get; set; }
        //public virtual List<SorteosHistorico> SorteosHistoricos { get; set; }

        /* [Required(ErrorMessage = "El campo nombre del cliente es requerido.")]
         [Display(Name = "Nombre del cliente")]
         public string NombreDelCliente { get; set; }*/
    }
}
