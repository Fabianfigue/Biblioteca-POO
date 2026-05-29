/*
 * Creado por SharpDevelop.
 * Usuario: JORGE
 * Fecha: 24/05/2026
 * Hora: 23:10
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq.Expressions;
//using System.Security.Cryptography.X509Certificates;
//using System.Threading.Tasks;
using System.Threading;

namespace BIBLIOTECATP
{
		public class Program
	{
	    public static void Main(string[] args)
	    {
	        try
	        {
	            Console.Clear();
	            Biblioteca biblioteca = new Biblioteca("ALEJANDRIA");
	            bool salir = false; 
	            //MENU DE APLICACION
	            while (!salir)
	            {
	                Console.WriteLine("\t***** BIBLIOTECA DE " + biblioteca.Nombre + " *****");
	                Console.WriteLine("----------------------------------------------------");
	                Console.WriteLine("BIENVENIDOS AL SISTEMA DE GESTION DE LA BIBLIOTECA");
	                Console.WriteLine("----------------------------------------------------");
	                Console.WriteLine("   Este sistema permite gestionar la biblioteca");
	                Console.WriteLine("----------------------------------------------------");
	                Console.WriteLine(" 1. Agregar un material a la biblioteca.");
	                Console.WriteLine(" 2. Eliminar un material utilizando el ISBN.");
	                Console.WriteLine(" 3. Registrar un usuario.");
	                Console.WriteLine(" 4. Realizar un préstamo de un material.");
	                Console.WriteLine(" 5. Mostrar listado de materiales.");
	                Console.WriteLine(" 6. Mostrar listado de usuarios.");
	                Console.WriteLine(" 7. Mostrar historial de préstamos realizados.");
	                Console.WriteLine(" 8. Mostrar únicamente los materiales descargables.");
	                Console.WriteLine("\n 0. Salir.");
	                Console.Write(" -Seleccione una opcion: ");
	
	                int opcion = Convert.ToInt32(Console.ReadLine());
	                
	                    switch(opcion)
	                    {
	                        case 1: 
	                            try{
	                                Console.Clear();
	                                Console.WriteLine("\n--- AGREGAR NUEVO MATERIAL ---");
	                                Console.WriteLine("¿Qué tipo de material desea agregar?");
	                                Console.WriteLine(" 1. Libro");
	                                Console.WriteLine(" 2. Revista");
	                                Console.WriteLine(" 3. Ebook");
	                                Console.Write(" -Seleccione una opción: ");
	                                
	                                // Leemos qué tipo de material quiere cargar
	                                int tipoMaterial = Convert.ToInt32(Console.ReadLine());
	
	                                // Si elige algo distinto a 1, 2 o 3, cortamos la ejecución del case
	                                if (tipoMaterial < 1 || tipoMaterial > 3)
	                                {
	                                    Console.WriteLine("\nERROR: Opción de material no válida.");
	                                    Console.ReadKey(true);
	                                    break;
	                                }
	                                Console.Clear();
	                                // Pedimos los datos que son COMUNES a todos los materiales
	                                Console.Write("Ingrese el ISBN: ");
	                                string isbn = Console.ReadLine();
	
	                                Console.Write("Ingrese el Título: ");
	                                string titulo = Console.ReadLine();
	
	                                Console.Write("Ingrese el Autor: ");
	                                string autor = Console.ReadLine();
	
	                                Console.Write("Ingrese el Año de Publicación: ");
	                                int anio = Convert.ToInt32(Console.ReadLine());
	
	                                Console.Write("Ingrese la Cantidad Disponible: ");
	                                int cantidad = Convert.ToInt32(Console.ReadLine());
	
	                                // USO DE POLIMORFISMO. Declaramos una variable del tipo de la clase Material
	                                Material nuevoMaterial = null;
	
	                                //SUBMENU DE CASE 1.
	                                switch (tipoMaterial)
	                                {
	                                    case 1:
	                                        Console.Write("Ingrese el genero: ");
	                                        string generoLibro = Console.ReadLine();
	                                        nuevoMaterial = new Libro(isbn, titulo, autor, anio, cantidad, generoLibro);
	                                        break;
	                                    case 2:
	                                        Console.Write("Ingrese el genero: ");
	                                        string generoRevista = Console.ReadLine();
	                                        nuevoMaterial = new Revista(isbn, titulo, autor, anio, cantidad, generoRevista);
	                                        break;
	                                    case 3:
	                                        Console.Write("Ingrese el formato del material: ");
	                                        string formato = Console.ReadLine();
	                                        nuevoMaterial = new Ebook(isbn, titulo, autor, anio, cantidad, formato);
	                                        break;
	                                }
	
	                                MostrarAnimacion("Cargando material.");
	
	                                // Guardamos el objeto en la lista de la biblioteca
	                                biblioteca.AgregarMaterial(nuevoMaterial);
	                                
	                                Console.WriteLine("\n¡Material agregado exitosamente a la biblioteca!");
	                            }
	                            catch (FormatException) // Captura el error si el usuario escribe letras en lugar de números
	                            {
	                                Console.WriteLine("\nERROR: Ingrese una opción válida.");
	                            }
	                            catch (Exception ex)
	                            {
	                                Console.WriteLine("\nERROR: " + ex.Message);
	                                
	                            }
	                            Console.WriteLine("---Presione una tecla para volver al menu---");
	                            Console.ReadKey(true);
	                            break;
	                        case 2:
	                            try
	                            {
	                                Console.Clear();
	                                Console.WriteLine("\n--- ELIMINAR MATERIAL ---");
	                                Console.Write("Ingrese el ISBN del material que desea eliminar: ");
	                                string isbnBuscado = Console.ReadLine();
	
	                                MostrarAnimacion("Buscando material en la base de datos");
	                                
	                                //LLAMADA AL METODO DE BIBLIOTECA
	                                biblioteca.EliminarMaterial(isbnBuscado);
	
	                                Console.WriteLine("\n Material eliminado exitosamente!");
	                                
	                                Console.WriteLine("---Presione una tecla para volver al menu---");
	                                Console.ReadKey(true);
	                            }
	                            catch (Exception ex)
	                            {
	                            //Si no existe lanzamos excepcion
	                            Console.WriteLine("\nERROR: " + ex.Message);
	                            Console.WriteLine("---Presione una tecla para volver al menu---");
	                            Console.ReadKey(true);
	                            }
	                            break;
	                        case 3:
	                            try
	                            {
	                                Console.Clear();
	                                Console.WriteLine("\n--- REGISTRAR NUEVO USUARIO ---");
	
	                                Console.Write("Ingrese el nombre: ");
	                                string nombreUsuario = Console.ReadLine();
	
	                                Console.Write("Ingrese el Apellido: ");
	                                string apellidoUsuario = Console.ReadLine();
	
	                                Console.Write("Ingrese el DNI: ");
	                                string dniUsuario = Console.ReadLine();
	
	                                Console.Write("Ingrese el Telefono: ");
	                                string telefonoUsuario = Console.ReadLine();
	
	                                //ANIMACION DE CARGA
	                                MostrarAnimacion("Registrando usuario en el sistema");
	
	                                //INSTANCIAMOS EL USUARIO
	                                Usuario nuevoUsuario = new Usuario(nombreUsuario, apellidoUsuario, dniUsuario, telefonoUsuario);
	
	                                //USAMOS METODO DE BIBLIOTECA
	                                biblioteca.AgregarUsuario(nuevoUsuario);
	
	                                Console.WriteLine("\n Usuario registrado exitosamente!");
	                            }
	                            catch (InvalidOperationException ex)
	                            {
	                                //Si ya existe el DNI:
	                                Console.WriteLine("\nATENCIÓN: " + ex.Message);
	                            }
	                            catch (Exception ex)
	                            {
	                                Console.WriteLine("\nERROR: " + ex.Message);
	                            }
	                            Console.WriteLine("\n---Presione una tecla para volver al menú---");
	                            Console.ReadKey(true);
	                            break;
	                        case 4:
	                            try
	                            {
	                                Console.Clear();
	                                Console.WriteLine("\n--- REALIZAR PRESTAMO ---");
	
	                                Console.Write("Ingrese el ISBN del material que desea llevar: ");
	                                string isbnPrestamo = Console.ReadLine();
	
	                                Console.Write("Ingrese el DNI del usuario: ");
	                                string dniPrestamo = Console.ReadLine();
	
	                                MostrarAnimacion("Procesando prestamo");
	
	                                biblioteca.RealizarPrestamo(isbnPrestamo, dniPrestamo);
	
	                                Console.WriteLine("\n Prestamo registrado exitosamente!");
	                            }
	                            catch (InvalidOperationException ex)
	                            {
	                                //Excepcion de material no disponible
	                                Console.WriteLine("\nATENCION: " + ex.Message);
	                            }
	                            catch (Exception ex)
	                            {
	                                //Si el usuario o el ISBN no existen
	                                Console.WriteLine("\nERROR: " + ex.Message);
	                            }
	
	                            Console.WriteLine("\n --- Presione una tecla para volver al menu ---");
	                            Console.ReadKey(true);
	                            break;
	                        case 5:
	                            Console.Clear();
	                            Console.WriteLine("\n--- LISTADO DE MATERIALES ---");
	                            //Verificamos si la lista esta vacia
	                            if (biblioteca.Materiales().Count == 0)
	                            {
	                                Console.WriteLine("No se encontraron materiales, primero registrelos.");
	                            }
	                            else
	                            {
	                            	foreach(Material mat in biblioteca.Materiales())
	                                {
	                                    Console.WriteLine("ISBN: {0} | Titutlo: {1} | Autor: {2} | Stock: {3}", mat.ISBN, mat.Titulo, mat.Autor, mat.CantidadDisponible);
	                                }
	                            }
	                            Console.WriteLine("\n---Presione una tecla para volver al menu---");
	                            Console.ReadKey(true);
	                            break;
	                        case 6:
	                            Console.Clear();
	                            Console.WriteLine("\n--- LISTADO DE USUARIOS ---");
	
	                            if (biblioteca.Usuarios().Count == 0)
	                            {
	                                Console.WriteLine("No se encontraron usuarios registrados, primero registrelos.");
	                            }
	                            else
	                                {
	                            	foreach(Usuario usr in biblioteca.Usuarios())
	                                    {
	                                        Console.WriteLine("Nombre: {0} {1} | DNI: {2} | Telefono: {3}", usr.Nombre,usr.Apellido,usr.DNI,usr.Telefono);
	                                    }
	                                }
	                            Console.WriteLine("\n---Presione una tecla para volver al menu---");
	                            Console.ReadKey(true);
	                            break;
	                        case 7:
	                            Console.Clear();
	                            Console.WriteLine("\n--- HISTORIAL DE PRÉSTAMOS ---");
	
	                            if (biblioteca.Prestamos().Count == 0)
	                            {
	                                Console.WriteLine("No se encontraron préstamos registrados.");
	                            }
	                            else
	                                {
	                                    
	                            	foreach(Prestamo pres in biblioteca.Prestamos())
	                                    {
	                                        string textoFormato = "";
	                                        if (pres.MaterialPrestado is Ebook)
	                                    {
	                                        Ebook miEbook = (Ebook)pres.MaterialPrestado;
	                                        textoFormato = "." + miEbook.Formato;
	                                    }
	                                        Console.WriteLine("Fecha: {0} | Material: {1}{5} | Usuario: {2} {3} | DNI: {4}", pres.FechaDelPrestamo,pres.MaterialPrestado.Titulo,pres.UsuarioAsignado.Nombre,pres.UsuarioAsignado.Apellido,pres.UsuarioAsignado.DNI,textoFormato);
	                                    }
	                                }
	                            Console.WriteLine("\n---Presione una tecla para volver al menu---");
	                            Console.ReadKey(true);
	                            break;
	                        case 8: 
	                            Console.Clear();
	                            Console.WriteLine("\n--- MATERIALES DESCARGABLES");
	
	                            bool hayDescargables = false;
	
	                            foreach (Material mat in biblioteca.Materiales())
	                            {
	                                //POLIMORFISMO POR INTERFAZ
	                                if (mat is IDescargar)
	                                {
	                                    Console.WriteLine("ISBN: {0} | Título: {1} | Autor: {2} | Stock: {3}", mat.ISBN, mat.Titulo, mat.Autor, mat.CantidadDisponible);
	                                    hayDescargables = true;
	                                }
	                            }
	                            if (!hayDescargables)
	                                {
	                                Console.WriteLine("No hay materiales descargables en este momento.");
	                                }
	                            Console.WriteLine("\n---Presione una tecla para volver al menú---");
	                            Console.ReadKey(true);
	                            break;
	                        default: 
	                        //SI NO ES UN 0 al 8 ENTRA ACA.
	                            Console.Clear();
	                            Console.WriteLine("Saliendo...");
	                            Console.WriteLine("\n---Presione una tecla para confirmar.");
	                            Console.ReadKey(true);
	                            salir = true;
	                            break;
	                    }
	            Console.Clear();
	            }
	        }
	        catch (FormatException)
	        {
	            //FORMATOS NO NUMERICOS.
	            Console.WriteLine("Formato invalido. Solamente se aceptan numeros.");
	            Console.WriteLine("Presione una tecla para salir.");
	            Console.ReadKey(true); 
	        }
	        catch (Exception ex)
	        {
	            //CUALQUIER OTRO ERROR.
	            Console.WriteLine("ERROR: " + ex.Message);
	            Console.WriteLine("Presione una tecla para salir.");
	            Console.ReadKey(true); 
	        }
	        finally
	        {
	            Console.Clear();
	            MostrarAnimacion("Cerrando aplicacion.");
	        }
	    }
	
	    //FUNCION ANIMACION DE CARGA
	    public static void MostrarAnimacion(string mensaje)
	    {
	        Console.WriteLine("\n" + mensaje);
	        for (int i = 0; i < 3; i++) //Cantidad de puntos a repetir
	        {
	            Thread.Sleep(500); //Pausa de medio segundo
	            Console.Write(".");
	        }
	        Console.WriteLine(); //Salto de linea
	    }
	}
}
