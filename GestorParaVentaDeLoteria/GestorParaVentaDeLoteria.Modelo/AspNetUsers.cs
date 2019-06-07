using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GestorParaVentaDeLoteria.Modelo
{
    public class AspNetUsers
    {
        [StringLength(128)]
        public string Id { get; set; }
        [StringLength(128)]
        public string Email { get; set; }
        
        public Boolean EmailConfirmed { get; set; }
        
        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set; }

        public string PhoneNumber { get; set; }

        public Boolean PhoneNumberConfirmed { get; set; }

        public Boolean TwoFactorEnabled { get; set; }

        public DateTime LockoutEndDateUtc { get; set; }

        public Boolean LockoutEnabled { get; set; }

        public int AccessFailedCount { get; set; }
        [StringLength(128)]
        public string UserName { get; set; }

    }
}
