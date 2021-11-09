using System.Collections.Generic;
using System.Linq;
using Hospital.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Hospital.App.Persistencia
{
    public class RepositorioPaciente : IRepositorioPaciente
    {
        private readonly AppContext _appContext = new AppContext();

        Paciente IRepositorioPaciente.AddPaciente(Paciente paciente)
        {
            var pacienteAdicionado = _appContext.Pacientes.Add(paciente);
            _appContext.SaveChanges();
            return pacienteAdicionado.Entity;
        }
        IEnumerable<Paciente> IRepositorioPaciente.GetAllPacientes()
        {
            return _appContext.Pacientes;
        }
        Paciente IRepositorioPaciente.GetPaciente(int idPaciente)
        {
            return _appContext.Pacientes.Find(idPaciente);
            /*
            var pac = _appContext.Pacientes
                        .Where(pac => pac.Id == idPaciente)
                        .FirstOrDefault();
            return pac;
            */
        }
        void IRepositorioPaciente.DeletePaciente(int idPaciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.Find(idPaciente);
            if(pacienteEncontrado == null)
                return;
            _appContext.Pacientes.Remove(pacienteEncontrado);
            _appContext.SaveChanges();
        }
    }
}