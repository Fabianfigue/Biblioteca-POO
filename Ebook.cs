/*
 * Creado por SharpDevelop.
 * Usuario: JORGE
 * Fecha: 24/05/2026
 * Hora: 23:13
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;                                                                                     
using BIBLIOTECATP;

public class Ebook : Material, IDescargar
{
    //ATRIBUTO PRIVADO
    private string formato;

    //CONSTRUCTOR
    public Ebook(string isbn, string titulo, string autor, int anioPublicacion, int cantidadDisponible, string formato) : base(isbn, titulo, autor, anioPublicacion, cantidadDisponible)
    {
        this.formato = formato;
    }

    //PROPIEDAD DE ACCESO PUBLICO
    public string Formato
    {
        get { return formato; }
    }

    //METODO
    public void Descargar()
    {
        Console.WriteLine("Iniciando la descarga del Ebook: {0}",Titulo);
    }
}