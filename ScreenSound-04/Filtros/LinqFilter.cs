using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(m => m.Genero).Distinct().ToList();
        foreach(var genero in todosOsGenerosMusicais)
            Console.WriteLine($"- {genero}");
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var todosOsGenerosMusicais = musicas.Where(m => m.Genero!.Contains(genero)).Select(m => m.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");
        foreach (var artista in todosOsGenerosMusicais)
            Console.WriteLine($"- {artista}");
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(m => m.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach (var musica in musicasDoArtista)
            Console.WriteLine($"- {musica.Nome}");
    }

    public static void FiltrarMusicasPeloAno(List<Musica> musicas, int ano)
    {
        var musicasDoAno = musicas.Where(musica => musica.Ano == ano)
            .OrderBy(musicas => musicas.Nome) // ordena as músicas pelo nome
            .Select(musicas => musicas.Nome) // seleciona apenas o nome das músicas
                    .Distinct() // remove as duplicidades
                    .ToList(); // converte o resultado em uma lista

        Console.WriteLine($"Músicas de {ano}");
        foreach (var musica in musicasDoAno)
        {
            Console.WriteLine($"- {musica}");
        }
    }

    internal static void FiltrarMusicasEmCSharp(List<Musica> musicas)
    {
        var musicasEmCSharp = musicas.Where(m => m.Tonalidade.Equals("C#")).Select(m => m.Nome);

        Console.WriteLine("Músicas em C#");
        foreach (var musica in musicasEmCSharp)
            Console.WriteLine($"- {musica}");
    }
}
