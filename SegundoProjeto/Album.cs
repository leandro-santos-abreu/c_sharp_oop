using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProjeto
{
    public class Album
    {
        private List<Musica> musicas = new();

        public Album(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; }
        public int DuracaoTotal => musicas.Sum(m => m.Duracao);

        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
        }

        public void ExibirMusicasDoAlbum()
        {
            Console.WriteLine($"Lista de Músicas do Álbum {Nome}\n");
            foreach (var musica in musicas)
                Console.WriteLine($"Música: {musica.Nome}");

            Console.WriteLine($"\nPara ouvir esse álbum inteiro você precisa de {DuracaoTotal} segundos");
        }
    }
}
