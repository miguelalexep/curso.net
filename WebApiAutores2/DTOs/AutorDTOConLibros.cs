using System.Collections.Generic;

namespace WebApiAutores2.DTOs
{
    public class AutorDTOConLibros: AutorDTO
    {
        public List<LibroDTO> libros { get; set; }
    }
}
