using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models {
    public class Capitulo {

        [Key]
        public int capituloID { get; set; }

        [Display(Name = "Nombre")]
        public string nombre { get; set; }

        [Display(Name = "Número")]
        public string numero { get; set; }

        public string imagen { get; set; }

        public string video { get; set; }

        [Display(Name = "Temporada")]
        [ForeignKey("temporada")]
        public int temporadaID { get; set; }

        public virtual Temporada temporada { get; set; }
    }
}