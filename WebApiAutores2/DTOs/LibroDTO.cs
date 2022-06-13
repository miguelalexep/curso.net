using System;
using System.Collections.Generic;

namespace WebApiAutores2.DTOs
{
    public class LibroDTO
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime FechaPublicacion { get; set; }
        //public List<ComentarioDTO> comentarios { get; set; }
    }
}
