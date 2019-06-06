namespace GestorParaVentaDeLoteria.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SorteosRestriciones
    {
        public int Id { get; set; }

        public int Numero { get; set; }

        [Column(TypeName = "money")]
        public decimal MontoMáximo { get; set; }

        public int IdSorteos { get; set; }

        public virtual Sorteos Sorteos { get; set; }
    }
}
