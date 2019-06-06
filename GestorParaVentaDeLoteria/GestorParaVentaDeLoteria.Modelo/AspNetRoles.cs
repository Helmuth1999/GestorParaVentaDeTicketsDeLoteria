using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GestorParaVentaDeLoteria.Modelo
{
    public class AspNetRoles
    {
        [StringLength(128)]
        public String Id { get; set; }
        [StringLength(128)]
        public String Name { get; set; }

    }
}
