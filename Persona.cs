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
    //CLASE PARA CUALQUIER TIPO DE PERSONA
    public class Persona
    {
        //PROPIEDADES
        private string nombre;
        private string apellido;
        private string dni;

        //CONSTRUCTOR
        public Persona(string nombre, string apellido, string dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }


        //PROPIEDADES PUBLICAS
        public string Nombre
        {
            get { return nombre; }
        }

        public string Apellido
        {
            get{ return apellido; }
        }

        public string DNI
        {
            get{ return dni; }
        }
    }
}