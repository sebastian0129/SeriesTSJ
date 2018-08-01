using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models {
    public class Serie {
        [Key]
        public int serieID { get; set; }

        [Display(Name = "Nombre")]
        public string nombre { get; set; }

        [Display(Name = "Fecha de Estreno")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime fechaEstreno { get; set; }

        [Display(Name = "¿Está en emisión?")]
        public bool enEmision { get; set; }

        [Display(Name = "Género")]
        public Genero genero { get; set; }

        public virtual ICollection<Temporada> temporadas { get; set; }

        [Display(Name = "Imagen")]
        public string image { get; set; }
    }
}   