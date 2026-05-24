using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace BIBLIOTECATP
{
    public class Biblioteca
    {   

        //ATRIBUTOS Y LISTAS PRIVADAS
        private string nombre;
        
        private List<Material> listaMateriales = new List<Material> ();
        private List<Usuario> listaUsuarios = new List<Usuario> ();
        
        private List<Prestamo> listaPrestamos = new List<Prestamo> ();
        

        //CONSTRUCTOR

        public Biblioteca(string nombre)
        {
            this.nombre = nombre;
        }
        public string Nombre
        {
            get { return nombre; }
        }

        
        
        

        //IReadOnlyList funciona como un get, para mirar y tambien recorrer los datos de la lista. no se puede agregar ni eliminar nada con esta propiedad.
        public IReadOnlyList<Usuario> Usuarios => listaUsuarios.AsReadOnly();

        //METODO AGREGAR USUARIO CON VALIDACION
        public void AgregarUsuario(Usuario nuevoUsuario)
        {
            if (nuevoUsuario == null)
                throw new ArgumentNullException(nameof(nuevoUsuario));

            //.Any() recorre la lista de usuarios y verifica si hay alguien con el mismo DNI
            bool yaExiste = listaUsuarios.Any(u => u.DNI == nuevoUsuario.DNI);
        
            //Si hay un mismo DNI lanza la siguiente excepcion
            if (yaExiste)
            {
                throw new InvalidOperationException("El usuario con DNI: " + nuevoUsuario.DNI + " ya existe en la linea. " );
            }

            listaUsuarios.Add(nuevoUsuario);
        }
        
        //METODOS AGREGAR MATERIAL Y AGREGAR PRESTAMO.
        public void AgregarMaterial(Material nuevoMaterial)
        {
            if (nuevoMaterial == null)
                throw new ArgumentNullException(nameof(nuevoMaterial));

            listaMateriales.Add(nuevoMaterial);
        }

        public void AgregarPrestamo(Prestamo nuevoPrestamo)
        {
            if (nuevoPrestamo == null)
                throw new ArgumentNullException(nameof(nuevoPrestamo));

            listaPrestamos.Add(nuevoPrestamo);
        }
    }
}