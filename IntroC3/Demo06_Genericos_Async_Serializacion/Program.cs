using System;
using System.Threading.Tasks;
using System.Collections.Generic;

using Demo06_Genericos_Async_Serializacion.Clases;
using Demo06_Genericos_Async_Serializacion.Servicios;

namespace Demo06_Genericos_Async_Serializacion
{
    class Program
    {
        async static Task Main(string[] args)
        {
            var a1 = new Alumno(1, "Juan", "Sistemas", 70);
            var a2 = new Alumno(1, "Ana", "Bioquimica", 80);
            var a3 = new Alumno(1, "Pedro", "Mecanica", 90);
            
            var listaAlumnos = new List<Alumno>();
                        listaAlumnos.Add(a1);
                        listaAlumnos.Add(a2);
                        listaAlumnos.Add(a3);
            
            var srvAlumno = new ServicioArchivo<Alumno>();
                        await srvAlumno.Guardar("alumnos.json", listaAlumnos);
            listaAlumnos = await srvAlumno.Leer("alumnos.json");
            Console.WriteLine(listaAlumnos.Count);

            var p1 = new Profesor(10, "Susana", "RH", 1000);
            var p2 = new Profesor(11, "Adrian", "Sistemas y Computacion", 2000);
            var p3 = new Profesor(12, "Rocio", "Gestion", 3000);
            var listaProfesores = new List<Profesor>() { p1, p2, p3 };

            var srvProfesor = new ServicioArchivo<Profesor>();
            await srvProfesor.Guardar("profesores.json", listaProfesores);
            var profes = await srvProfesor.Leer("profesores.json");
            Console.WriteLine(profes[0].Nombre);

            var pr1 = new Producto("Galletas", 3);
            var pr2 = new Producto("Refresco", 15);
            var pr3 = new Producto("Papas", 20);
            var listaProductos = new List<Producto>() { pr1, pr2, pr3 };

            //var srvProducto = new ServicioArchivo<Producto>();
            //srvProducto.Guardar("productos.json", listaProductos);
        }
    }
}
