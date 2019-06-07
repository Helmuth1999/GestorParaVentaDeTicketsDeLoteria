using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GestorParaVentaDeLoteria.Modelo
{
    public class Sorteos
    {
        public int Id { get; set; }

        public Estado Estado { get; set; }

        public DateTime? Fecha { get; set; }
    }
}
