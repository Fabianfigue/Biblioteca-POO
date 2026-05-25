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