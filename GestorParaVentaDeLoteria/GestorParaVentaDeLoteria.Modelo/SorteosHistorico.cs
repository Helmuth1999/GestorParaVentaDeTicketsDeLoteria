namespace GestorParaVentaDeLoteria.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class SorteosHistorico
    {
        public int Id { get; set; }

        public TipoDeModificacion TipoDeModificacion { get; set; }

        public DateTime FechaDeModificacion { get; set; }


        public string Id_AspNetUser { get; set; }


        public string DescripcionDeLaModificacion { get; set; }

        public int IdSorteo { get; set; }

    }
}
