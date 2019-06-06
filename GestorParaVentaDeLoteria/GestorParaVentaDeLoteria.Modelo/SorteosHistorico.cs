using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorParaVentaDeLoteria.Modelo
{
    public class SorteosHistorico
    {
        public int Id { get; set; }
        public TipoDeModificacion TipoDeModificacion { get; set; }
        public DateTime FechaDeModificacion { get; set; }
        public string Id_AspNetUser { get; set; }
        public string DescripcionDeLaModificacion { get; set; }
        public int IdSorteo { get; set; }
       // public Sorteos Sorteos { get; set; }
    }
}
