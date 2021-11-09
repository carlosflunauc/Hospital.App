using System.Collections.Generic;
using Hospital.App.Dominio;

namespace Hospital.App.Persistencia
{
    public interface IRepositorioPaciente
    {
        IEnumerable<Paciente> GetAllPacientes(); 
        Paciente AddPaciente(Paciente paciente);
        Paciente GetPaciente(int idPaciente);
        void DeletePaciente(int idPaciente);
    }
}