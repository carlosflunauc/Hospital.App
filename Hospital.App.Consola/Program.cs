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
            //BuscarPaciente(2);
            //EliminarPaciente(1);
        }
        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre = "Antonio",
                Apellidos = "Luna",
                NumeroTelefono = "6068848",
                Genero = Genero.Pansexual,
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
                Console.WriteLine(paciente.Id+" "+paciente.Nombre+" "+paciente.Apellidos+" "+paciente.Genero);
            }
        }
        private static void BuscarPaciente(int idPaciente)
        {
            var paciente =_repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine(paciente.Id+" "+paciente.Nombre+" "+paciente.Apellidos+" "+paciente.Genero);
        }
        private static void EliminarPaciente(int idPaciente)
        {
            _repoPaciente.DeletePaciente(idPaciente);
            Console.WriteLine("Paciente Eliminado");
        }
    }
}
