namespace Hospital.App.Dominio
{
    /// <summary> Class <c>Medico</c>
    /// Moldea un medico del equpo de apoyo
    /// </summary>
    public class Medico : Persona
    {
        public string Especialidad {get; set;}
        public string Codigo {get; set;}
        public string RegistroMedico {get; set;}
    }
}