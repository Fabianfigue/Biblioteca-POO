using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;

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
                    case 2: Console.WriteLine("2");
                    break;
                    case 3: Console.WriteLine("3"); 
                    break;
                    case 4: Console.WriteLine("4"); 
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

        
}