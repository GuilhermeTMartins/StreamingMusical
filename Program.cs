// Screen Sound
using System.Net.Http.Headers;

string boasVindas = "Boas vindas ao Screen Sound";
//List<string> bandas = new List<string> { "Iron Maiden", "The Strokes", "Linkin Park" };

Dictionary<string, List<int>> bandas = new Dictionary<string, List<int>>();
bandas.Add("Linkin Park", new List<int> { 10, 9, 10 });
bandas.Add("Aurora", new List<int>());


void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(boasVindas);
}

void ExibirOpcoesMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 5 para remover uma banda");
    Console.WriteLine("Digite 6 para sair");

    Console.Write("\nDigite sua opcao: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNum)
    {
        case 1:
            RegistrarBandas();
            break;
        case 2:
            ExibirBandas();
            break;
        case 3:
            AvaliarBandas();
            break;
        case 4:
            ExibirMedia();
            break;
        case 5:
            RemoverBanda();
            break;
        case 6:
            Console.WriteLine("Até logo :3");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void RegistrarBandas()
{
    Console.Clear();
    Console.WriteLine("Registro de Bandas\n");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();
}

void ExibirBandas()
{
    Console.Clear();
    Console.WriteLine("Exibindo bandas registradas\n");
    //for (int i = 0; i < bandas.Count; i++)
    //{
    //  Console.WriteLine($"Banda: {bandas[i]}");
    //}

    foreach (string banda in bandas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite qualquer tecla para voltar ao Menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

void AvaliarBandas()
{
    Console.Clear();
    Console.WriteLine("Avaliando bandas registradas\n");
    Console.Write("Digite a banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota da banda {nomeDaBanda}: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandas[nomeDaBanda].Add(nota);
        Console.WriteLine("\nNota registrada com sucesso");
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} nao foi encontrada");
    }
    Console.WriteLine("\nDigite qualquer tecla para voltar ao Menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();

}

void ExibirMedia()
{
    Console.Clear();
    Console.WriteLine("Exibindo média das bandas registradas");
    Console.Write("Digite a banda que deseja ver a media");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandas[nomeDaBanda];
        Console.WriteLine($"A média de {nomeDaBanda} é {notasDaBanda.Average()}");

    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} nao foi encontrada");
    }
    Console.WriteLine("\nDigite qualquer tecla para voltar ao Menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

void RemoverBanda()
{
    Console.Clear();
    Console.WriteLine("Remoção de Bandas\n");
    Console.Write("Digite o nome da banda que deseja remover: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandas.ContainsKey(nomeDaBanda))
    {
        bandas.Remove(nomeDaBanda);
        Console.WriteLine($"A banda {nomeDaBanda} foi removida com sucesso!");
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada.");
    }

    Console.WriteLine("\nDigite qualquer tecla para voltar ao Menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

ExibirLogo();
ExibirOpcoesMenu();

