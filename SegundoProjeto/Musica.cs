using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProjeto
{
    public class Musica
    {
        public Musica(Banda artista, string nome)
        {
            Artista = artista;
            Nome = nome;
        }

        public string Nome { get; }
        public Banda Artista { get; }
        public int Duracao { get; set; }
        public bool Disponivel { get; set; }
        public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";
        public Genero Genero { get; set; }

        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Artista: {Artista.Nome}");
            Console.WriteLine($"Duracao: {Duracao}");
            if (Disponivel)
                Console.WriteLine($"Disponivel no plano");
            else
                Console.WriteLine("Adquira o plano Plus+");
            Console.WriteLine($"Descrição Resumida: {DescricaoResumida}");

        }
    }
}
