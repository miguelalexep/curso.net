﻿namespace WebApiAutores2.Entidades
{
    public class AutorLibro
    {
        public int Libroid { get; set; }
        public int AutorId { get; set; }
        public int Orden { get; set; }
        public Libro Libro { get; set; }
        public Autor Autor { get; set; }


    }
}
