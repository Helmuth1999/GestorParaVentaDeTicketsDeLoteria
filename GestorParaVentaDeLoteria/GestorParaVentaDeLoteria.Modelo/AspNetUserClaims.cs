using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace GestorParaVentaDeLoteria.Modelo
{
    public class AspNetUserClaims
    {
        public int Id { get; set; }
        [StringLength(128)]
        public string UserId { get; set; }
        [StringLength(128)]
        public string ClaimType { get; set; }
        [StringLength(128)]
        public string ClaimValue { get; set; }

    }
}
