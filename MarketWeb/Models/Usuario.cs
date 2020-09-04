using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarketWeb.Models
{
    [Serializable()]
    public class Usuario
    {
        public string Correo { get; set; }
        [DataType(DataType.Password)]
        public string Contrasena { get; set; }
        public string Nombre { get; set; }
    }
}
