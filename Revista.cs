using System;
namespace BIBLIOTECATP;

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