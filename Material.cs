using System;

namespace BIBLIOTECATP
{
    public class Material
    {
        //ATRIBUTOS
        private string isbn;
        private string titulo;
        private string autor;
        private int anioPublicacion;
        private int cantidadDisponible;

        //CONSTRUCTOR
        public Material(string isbn, string titulo, string autor, int anioPublicacion, int cantidadDisponible)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.anioPublicacion = anioPublicacion;
            this.cantidadDisponible = cantidadDisponible;
        }

        //PROPIEDADES
        public string ISBN
        {
            get { return isbn; }
        }

        public string Titulo
        {
            get { return titulo; }
        }
        
        public string Autor
        {
            get { return autor; }
        }

        public int AnioPublicacion
        {
            get { return anioPublicacion; }
        }

        public int CantidadDisponible
        {
            get { return cantidadDisponible; }
        }

        //METODOS RestarStock() / SumarStock()
        //.................
    }
}