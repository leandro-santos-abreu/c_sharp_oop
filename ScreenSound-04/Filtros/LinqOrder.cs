﻿using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(m => m.Artista).Select(musica => musica.Artista).Distinct().ToList();
        foreach(var artista in artistasOrdenados)
            Console.WriteLine($"- {artista}");
    }
}
