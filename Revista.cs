/*
 * Creado por SharpDevelop.
 * Usuario: JORGE
 * Fecha: 24/05/2026
 * Hora: 23:15
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
namespace BIBLIOTECATP
{
	public class Revista : Material
	{
	    //PROPIEDADES DE REVISTA
	    private string genero;
	    //CONSTRUCTOR
	    public Revista(string isbn, string titulo, string autor, int anioPublicacion, int cantidadDisponible, string genero) : base(isbn, titulo, autor, anioPublicacion, cantidadDisponible)
	    {
	        this.genero = genero;
	    }
	    
	    //PROPIEDAD DE ACCESO PUBLICO A PRIVADO
	    public string Genero
	    {
	        get { return genero; }
	    }
	}
}