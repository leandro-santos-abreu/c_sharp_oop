using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProjeto
{
    public class Podcast
    {
        private List<Episodio> episodios = new List<Episodio>();
        public Podcast(string nome, string host)
        {
            Nome = nome;
            Host = host;
        }

        public string Nome { get; set; }
        public string Host { get; set; }
        public int  TotalEpisodios => episodios.Count;

        public void AdicionarEpisodio(Episodio episodio)
        {
            episodios.Add(episodio);
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Podcast {Nome} apresentado por {Host}\n");

            foreach(var episodio in episodios.OrderBy(e => e.Ordem))
                Console.WriteLine(episodio.Resumo);

            Console.WriteLine($"\nEste podcast possui {TotalEpisodios} episódios.");

        }
    }
}
