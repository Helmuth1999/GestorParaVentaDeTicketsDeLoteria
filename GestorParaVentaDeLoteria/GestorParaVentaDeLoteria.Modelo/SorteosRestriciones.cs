namespace GestorParaVentaDeLoteria.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class SorteosRestriciones
    {
        public int Id { get; set; }

        public int Numero { get; set; }

        public decimal MontoMáximo { get; set; }

        public int IdSorteos { get; set; }

    }
}
