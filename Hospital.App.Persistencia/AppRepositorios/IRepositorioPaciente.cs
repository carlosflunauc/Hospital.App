using System.Collections.Generic;
using Hospital.App.Dominio;

namespace Hospital.App.Persistencia
{
    public interface IRepositorioPaciente
    {
         Paciente AddPaciente(Paciente paciente);
         IEnumerable<Paciente> GetAllPacientes();
    }
}