using ScreenSound_04.Filtros;
using ScreenSound_04.Modelos;
using System.Text.Json;

using (HttpClient client = new())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        LinqFilter.FiltrarMusicasEmCSharp(musicas);
        //musicas[0].ExibirDetalhesDaMusica();

        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Post Malone");

        //var musicasPreferidasDoDaniel = new MusicasPreferidas("Daniel");
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[377]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[4]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[6]);
        //musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1467]);

        //musicasPreferidasDoDaniel.GerarArquivoJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
