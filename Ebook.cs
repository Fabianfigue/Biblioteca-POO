using System;                                                                                                                                                                                                                                                                                                                              
using BIBLIOTECATP;

public class Ebook : Material
{
    private string formato;
    //CONSTRUCTOR
    public Ebook(string isbn, string titulo, string autor, int anioPublicacion, int cantidadDisponible, string formato) : base(isbn, titulo, autor, anioPublicacion, cantidadDisponible)
    {
        this.formato = formato;
    }

    public string Formato
    {
        get { return formato; }
    }


    public void Descargar()
    {
        Console.WriteLine("Iniciando la descarga del Ebook: {0}",Titulo);
    }
}