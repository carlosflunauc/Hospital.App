namespace Hospital.App.Dominio
{
    public class Persona
    {
        public int Id {get; set;} //ID lo reconoce como Primary Key
        public string Nombre {get; set;}
        public string Apellidos {get; set;}
        public string NumeroTelefono {get; set;}
        //Genero de la Persona
        public Genero Genero {get; set;}
    }
}