using System;

namespace BIBLIOTECATP
{
    public class Libro : Material
    {
        private string genero;
        //CONSTRUCTOR
        public Libro(string isbn, string titulo, string autor, int anioPublicacion, int cantidadDisponible, string genero): base(isbn, titulo, autor, anioPublicacion, cantidadDisponible)
        {
            this.genero = genero;
        }
    
        public string Genero
        {
            get{ return genero; }
        }
    }
}