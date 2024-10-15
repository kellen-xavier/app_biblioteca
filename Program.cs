using App_biblioteca.Views;
using App_biblioteca.Controllers;

namespace App_biblioteca
{
    class Program
    {
        static void Main()
        {
            // Instanciar a View
            BibliotecaView view = new();

            // Instanciar o Controller e passando a View como dependência
            BibliotecaController controller = new(view);

            // Iniciar o sistema
            controller.IniciarBiblioteca();
        }
    }
}