using System.Collections.Generic;
using App_biblioteca.Models;
using App_biblioteca.Views;

namespace App_biblioteca.Controllers
{
    public class BibliotecaController(BibliotecaView view)
    {
        private readonly List<Livro> _livros =
            [
                new Livro("O Senhor dos Anéis", "J.R.R. Tolkien", 1178, "https://lojaexemplo.com/senhor-dos-aneis"),
                new Livro("Harry Potter e a Pedra Filosofal", "J.K. Rowling", 223, "https://lojaexemplo.com/harry-potter"),
                new Livro("O Código Da Vinci", "Dan Brown", 489, "https://lojaexemplo.com/codigo-da-vinci")
            ];
        private readonly BibliotecaView _view = view;

        public BibliotecaView View => _view;

        // Método que controla o fluxo da aplicação
        public void IniciarBiblioteca()
        {
            // Chamando métodos estáticos da classe BibliotecaView diretamente pelo nome da classe
            BibliotecaView.ExibirListaLivros(_livros);
            int escolha = BibliotecaView.ObterSelecaoUsuario(_livros.Count);
            BibliotecaView.ExibirDetalhesLivro(_livros[escolha]);
        }
    }
}
