using System;
using System.Collections.Generic;

namespace EstructuraDatos
{
    // ==========================================
    // PUNTO 3: STRUCT / RECORD
    // ==========================================
    public struct EstudianteStruct
    {
        public string Nombre;
        public int Edad;
        public double Promedio;

        public EstudianteStruct(string nombre, int edad, double promedio)
        {
            Nombre = nombre;
            Edad = edad;
            Promedio = promedio;
        }

        public void Mostrar()
        {
            Console.WriteLine($"[Struct] Nombre: {Nombre}, Edad: {Edad}, Promedio: {Promedio}");
        }
    }

    // ==========================================
    // PUNTO 4: OBJETOS (CLASES)
    // ==========================================
    public class EstudianteClase
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Promedio { get; set; }

        public EstudianteClase(string nombre, int edad, double promedio)
        {
            Nombre = nombre;
            Edad = edad;
            Promedio = promedio;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"[Objeto] Estudiante: {Nombre} | Edad: {Edad} | Promedio: {Promedio}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Pruebas Punto 3 (Struct)
            Console.WriteLine("--- PUNTO 3: STRUCT / RECORD ---");
            List<EstudianteStruct> listaStructs = new List<EstudianteStruct>
            {
                new EstudianteStruct("Carlos Gómez", 20, 3.8),
                new EstudianteStruct("María Pérez", 22, 4.2),
                new EstudianteStruct("Juan Rodríguez", 21, 3.5)
            };

            foreach (var est in listaStructs)
            {
                est.Mostrar();
            }

            // Pruebas Punto 4 (Objeto / Clase)
            Console.WriteLine("\n--- PUNTO 4: OBJETOS ---");
            List<EstudianteClase> listaObjetos = new List<EstudianteClase>
            {
                new EstudianteClase("Ana Martínez", 19, 4.0),
                new EstudianteClase("Luis Torres", 23, 3.2),
                new EstudianteClase("Sofia Castro", 20, 4.5)
            };

            foreach (var e in listaObjetos)
            {
                e.MostrarInfo();
            }
        }
    }
}