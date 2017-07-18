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
        public string nombre { get; set; }
        public string numero { get; set; }
        public string imagen { get; set; }
        public string video { get; set; }

        public int temporadaID { get; set; }
        public virtual Temporada temporada { get; set; }
    }
}