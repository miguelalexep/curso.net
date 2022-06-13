using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebApiAutores2.Validaciones;

namespace WebApiAutores2.DTOs
{
    public class LibroCreacionDTO
    {
        [PrimeraLetraMayuscula]
        [StringLength(maximumLength: 250)]
        public string Titulo { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public List<int> AutoresIds { get; set; }
    }
}
