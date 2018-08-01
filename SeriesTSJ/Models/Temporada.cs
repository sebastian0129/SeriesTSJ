using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models {
    public class Temporada {
        [Key]
        public int temporadaID { get; set; }

        [Display(Name = "Nombre")]
        public string nombre { get; set; }

        [Display(Name = "Número")]
        public int numero { get; set; }

        [Display(Name = "¿Está en emisión?")]
        public bool enEmision { get; set; }

        [Display(Name = "Valor")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public double valor { get; set; }

        [Display(Name = "Fecha de estreno")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime fechaEstreno { get; set; }

        [Display(Name = "Serie")]
        [ForeignKey("serie")]
        public int serieID { get; set; }

        public virtual Serie serie { get; set; }

        public virtual ICollection<Capitulo> capitulos { get; set; }

    }
}