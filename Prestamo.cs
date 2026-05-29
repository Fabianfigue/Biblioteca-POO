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
    public class Prestamo
    {

        //PROPIEDADES
        public Material MaterialPrestado { get; private set; }
        public Usuario UsuarioAsignado { get; private set; }
        public DateTime FechaDelPrestamo { get; private set; }

        //CONSTRUCTOR
        public Prestamo(Material material, Usuario usuario)
        {
            MaterialPrestado = material;
            UsuarioAsignado = usuario;

            FechaDelPrestamo = DateTime.Now; 
        }
    }
}