﻿using OpenAI_API.Chat;
using OpenAI_API;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new Banda(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda, banda);

        var client = new OpenAIAPI("API KEY");

        var chat = client.Chat.CreateConversation();

        chat.AppendMessage(new OpenAI_API.Chat.ChatMessage(ChatMessageRole.User, $"Resuma a banda {nomeDaBanda} em 1 Parágrafo. Adote um Estilo Informal"));

        string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
        Console.WriteLine(resposta);


        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
