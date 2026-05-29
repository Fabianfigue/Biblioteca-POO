/*
 * Creado por SharpDevelop.
 * Usuario: JORGE
 * Fecha: 24/05/2026
 * Hora: 23:14
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
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