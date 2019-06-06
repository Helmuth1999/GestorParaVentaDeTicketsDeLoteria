namespace GestorParaVentaDeLoteria.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sorteos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sorteos()
        {
            SorteoDetalleVentas = new HashSet<SorteoDetalleVentas>();
            SorteosDetalleVentas = new HashSet<SorteosDetalleVentas>();
            SorteosHistorico = new HashSet<SorteosHistorico>();
            SorteosRestriciones = new HashSet<SorteosRestriciones>();
        }

        public int Id { get; set; }

        public Estado Estado { get; set; }

        public DateTime Fecha { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SorteoDetalleVentas> SorteoDetalleVentas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SorteosDetalleVentas> SorteosDetalleVentas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SorteosHistorico> SorteosHistorico { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SorteosRestriciones> SorteosRestriciones { get; set; }
    }
}
