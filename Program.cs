using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Threading;

namespace BIBLIOTECATP;
public class Program
{
    public static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca("Alejandria");
        bool salir = false; 
        
        while (!salir)
        {
            Console.WriteLine("\t***** Biblioteca de " + biblioteca.Nombre + "*****");
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

                            // Declaramos una variable del tipo BASE
                            Material nuevoMaterial = null;

                            // Instanciamos el objeto específico según la opción elegida
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

                            // Guardamos el objeto en la lista de la biblioteca
                            biblioteca.AgregarMaterial(nuevoMaterial);
                            
                            Console.WriteLine("\n¡Material agregado exitosamente a la biblioteca!");
                            Console.WriteLine("---Presione una tecla para volver al menu---");
                            Console.ReadKey(true);
                        }
                        catch (FormatException) // Captura el error si el usuario escribe letras en lugar de números
                        {
                            Console.WriteLine("\nERROR: El año de publicacion y la cantidad deben ser numeros enteros.");
                            Console.ReadKey(true);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("\nERROR: " + ex.Message);
                            Console.ReadKey(true);
                        }
                        break;
                    case 2:
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("\n--- ELIMINAR MATERIAL ---");
                            Console.Write("Ingrese el ISBN del material que desea eliminar: ");
                            string isbnBuscado = Console.ReadLine();

                            //PAUSA DE 2 SEGUNDOS
                            //Console.WriteLine("Buscando material....");
                            //Task.Delay(2000).Wait(); 


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
                    case 5: Console.WriteLine("5"); 
                    break;
                    case 6: Console.WriteLine("6"); 
                    break;
                    case 7: Console.WriteLine("7"); 
                    break;
                    case 8: Console.WriteLine("8"); 
                    break;
                    default: Console.WriteLine("Saliendo...");
                    break; 
                }
                    Console.WriteLine("1. Agregar un material a la biblioteca.");
                    Console.WriteLine("2. Eliminar un material utilizando el ISBN.");
                    Console.WriteLine("3. Registrar un usuario.");
                    Console.WriteLine("4. Realizar un préstamo de un material.");
                    Console.WriteLine("5. Mostrar listado de materiales.");
                    Console.WriteLine("6. Mostrar listado de usuarios.");
                    Console.WriteLine("7. Mostrar historial de préstamos realizados.");
                    Console.WriteLine("8. Mostrar únicamente los materiales descargables.");
                    Console.WriteLine("\n");
                    Console.WriteLine("0. Salir.");
                    Console.WriteLine("\n");
                    Console.Clear();
        }
        
        Console.ReadKey(true); 
    }

    //FUNCION ANIMACION DE CARGA
    public static void MostrarAnimacion(string mensaje)
    {
        Console.WriteLine("\n" + mensaje);
        for (int i = 0; i < 5; i++) //Cantidad de puntos a repetir
        {
            Thread.Sleep(500); //Pausa de medio segundo
            Console.Write(".");
        }
        Console.WriteLine(); //Salto de linea
    }

        
}