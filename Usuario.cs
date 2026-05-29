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
    public class Usuario : Persona
    {
        //ATRIBUTO PRIVADO
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

