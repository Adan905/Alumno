﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            alumno1.Nombre = "Pendiente";
            alumno1.Matricula = "Sin asignar";

            Console.WriteLine("Nombre:" + alumno1.Nombre);
            Console.WriteLine("Matricula:" + alumno1.Matricula);

            Alumno alumno2 = new Alumno("Jorge", "287612");

            Console.WriteLine("Nombre" + alumno2.Nombre);
            Console.WriteLine("Matricula" + alumno2.Matricula);

            Console.Read();

        }
    }
}
