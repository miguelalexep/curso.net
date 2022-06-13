﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebApiAutores2.Validaciones;

namespace WebApiAutores2.Entidades
{
    public class Libro
    {
        public int Id { get; set; }
        [Required]
        [PrimeraLetraMayuscula]
        [StringLength(maximumLength: 250)]
        public string? Titulo { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public List<Comentario> Comentarios { get; set; }
        public List<AutorLibro> AutoresLibros { get; set; }
    }
}
