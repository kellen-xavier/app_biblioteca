using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_biblioteca.Models
{
    public class Livro(string nome, string autor, int paginas, string link)
    {
        public string Nome { get; set; } = nome;
        public string Autor { get; set; } = autor;
        public int Paginas { get; set; } = paginas;
        public string Link { get; set; } = link;
    }
}
