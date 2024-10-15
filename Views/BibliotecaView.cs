using System;
using System.Collections.Generic;
using App_biblioteca.Models;

namespace App_biblioteca.Views
{
    public class BibliotecaView
    {
        public static void ExibirListaLivros(List<Livro> livros)
        {
            Console.WriteLine("Bem-vindo à Biblioteca!\n");
            Console.WriteLine("Lista de livros disponíveis:");
            for (int i = 0; i < livros.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {livros[i].Nome}");
            }
        }

        public static int ObterSelecaoUsuario(int totalLivros)
        {
            Console.WriteLine("\nDigite o número do livro que deseja selecionar:");
            int escolha;
            while (!int.TryParse(Console.ReadLine(), out escolha) || escolha < 1 || escolha > totalLivros)
            {
                Console.WriteLine("Seleção inválida, tente novamente :) ");
            }
            return escolha - 1;
        }

        public static void ExibirDetalhesLivro(Livro livro)
        {
            Console.Clear();
            Console.WriteLine($"Nome do Livro: {livro.Nome}");
            Console.WriteLine($"Autor: {livro.Autor}");
            Console.WriteLine($"Páginas: {livro.Paginas}");
            Console.WriteLine($"Link para compra: {livro.Link}");
            Console.WriteLine("\nPressione qualquer tecla para abrir o link no navegador...");
            Console.ReadKey();
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = livro.Link,
                UseShellExecute = true
            });
        }
    }
}
