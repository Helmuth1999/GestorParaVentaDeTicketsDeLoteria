namespace GestorParaVentaDeLoteria.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SorteosHistorico")]
    public partial class SorteosHistorico
    {
        public int Id { get; set; }

        public TipoDeModificacion TipoDeModificacion { get; set; }

        public DateTime FechaDeModificacion { get; set; }

        [Required]
        [StringLength(128)]
        public string Id_AspNetUser { get; set; }

        [Required]
        public string DescripcionDeLaModificacion { get; set; }

        public int IdSorteo { get; set; }

        public virtual Sorteos Sorteos { get; set; }
    }
}
