namespace PrimerMvcNetCore.Models
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, string email, int edad) {
            this.Nombre = nombre;
            this.Email = email;
            this.Edad = edad;
        }
    }
}
