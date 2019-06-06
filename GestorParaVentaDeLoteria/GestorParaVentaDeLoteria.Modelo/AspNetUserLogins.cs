using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace GestorParaVentaDeLoteria.Modelo
{
    public class AspNetUserLogins
    {
        [StringLength(128)]
        public string LoginProvider { get; set; }
        [StringLength(128)]
        public string ProviderKey { get; set; }
        [StringLength(128)]
        public string UserId { get; set; }

    }
}
