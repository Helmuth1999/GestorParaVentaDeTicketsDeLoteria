using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GestorParaVentaDeLoteria.Modelo
{
    public class AspNetUserRoles
    {
        [StringLength(128)]
        public string UserId { get; set; }
        [StringLength(128)]
        public string RoleId { get; set; }
    }
}
