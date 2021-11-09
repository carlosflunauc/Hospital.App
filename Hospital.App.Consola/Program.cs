using System;
using System.Collections.Generic;
using Hospital.App.Dominio;
using Hospital.App.Persistencia;

namespace Hospital.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente();
        static void Main(string[] args)
        {
            Console.WriteLine("Resultado de la Consulta: ");

            //AddPaciente();
            MostrarPacientes();
        }
        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre = "Pepito",
                Apellidos = "Perez",
                NumeroTelefono = "6068848",
                Genero = Genero.Otro,
                Direccion = "Calle 4 No 6-9",
                Ciudad = "Manizales",
                FechaNacimiento = new DateTime(1985,05,19)
            };
            _repoPaciente.AddPaciente(paciente);
        }
        private static void MostrarPacientes()
        {
            IEnumerable<Paciente> pacientes = _repoPaciente.GetAllPacientes();
            foreach (var paciente in pacientes)
            {
                Console.WriteLine(paciente.Nombre+" "+paciente.Apellidos);
            }
        }
    }
}
