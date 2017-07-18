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
        public string nombre { get; set; }
        public DateTime fechaEstreno { get; set; }
        public bool enEmision { get; set; }
        public Genero genero { get; set; }
        public List<Temporada> temporadas { get; set; }

        public string image { get; set; }
    }
}