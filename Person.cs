

namespace Person
{
    public class Persona
    {
        private string? nombre;
        private int edad;
        private string? dirección;

        public void EnviarCorreoElectronico(string destinatario, string mensaje)
        {
            // Lógica para enviar el correo electrónico
            Console.WriteLine($"Enviando correo a: {destinatario}");
            Console.WriteLine($"Mensaje: {mensaje}");
        }

        public void ImprimirEnConsola()
        {
            // Lógica para imprimir información en la consola
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad} años");
            Console.WriteLine($"Dirección: {dirección}");
        }
    }  
}
