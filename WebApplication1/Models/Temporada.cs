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
        public string nombre { get; set; }
        public int numero { get; set; }
        public bool enEmision { get; set; }
        public double valor { get; set; }
        public DateTime fechaEstreno { get; set; }
                
        public int serieID { get; set; }
        public virtual Serie serie { get; set; }

        public List<Capitulo> capitulo { get; set; }

    }
}