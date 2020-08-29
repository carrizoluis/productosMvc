using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DB.Entidades.Model
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? IdProducto { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string CodigoBarra { get; set; }
        public string Nombre { get; set; }
        public double PrecioCosto { get; set; }
        public double Iva { get; set; }
        public double Ganancia { get; set; }
        public Boolean borrado { get; set; }
    }
}
