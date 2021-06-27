using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRest_Crud.Models
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public Int64 Telefono { get; set; }
        public string Direccion { get; set; }
    }
}
