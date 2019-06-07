using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorParaVentaDeLoteria.Modelo
{
    public enum TipoDeModificacion
    {
        [Display(Name = "Inserción")]
        Insercion = 1,

        [Display(Name = "Activación")]
        Activacion = 2,

        [Display(Name = "Inactivación")]
        Inactivacion = 3
    }
}
