using System;

namespace BIBLIOTECATP
{
    public class Usuario : Persona
    {
        //PROPIEDAD DE USUARIO
        private string telefono;

        //CONSTRUCTOR
        public Usuario(string nombre, string apellido, string dni, string telefono): base(nombre, apellido, dni)
        {
            this.telefono = telefono;
        }
        
        //PROPIEDAD DE ACCESO PUBLICO A PRIVADO
        public string Telefono
        {
            get { return telefono; }
        }
    }
}

