using System;

namespace BIBLIOTECATP
{
    public class Material
    {
        //ATRIBUTOS PRIVADOS
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

        //PROPIEDADES DE ACCESO PUBLICO
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

        //METODOS
        public void RestarStock()
        {
            if (cantidadDisponible <= 0)
            {
                throw new InvalidOperationException("Material no disponible.");
            }

            cantidadDisponible--;
        }
    }
}