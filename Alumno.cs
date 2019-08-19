using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA
{
    class Alumno
    public string Nombre { get; set; }
    public string Matricula { get; set; }
    public DateTime FechadeNacimiento { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }

    public Alumno()
    {
        Nombre = "Pendiente";
        Matricula = "Sin asignar";
        FechadeNacimiento = "2 de Enero 1982";
        Direccion = "Los Gallos #8980";
        Telefono = "";
    }
    
    public Alumno(string nombre, string matricula)
    {
        Nombre = nombre;
        Matricula = matricula;
    }


}
