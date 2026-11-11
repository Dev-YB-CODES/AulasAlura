// Screen Sound
string boasVindas = "Olá, bem-vindo ao Screen Sound!";

//List<string> listaBandasRegistradas = new List<string>();

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 9 });
bandasRegistradas.Add("The Beatles", new List<int> { 10, 9, 10 });

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");


    Console.WriteLine(boasVindas);

}

void ExibirOpçõesDoMenu() 
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para ver a média das avaliações de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a opção desejada: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = 0;
    try {
        opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    } catch (FormatException) {
        Console.WriteLine("Opção inválida");
        ExibirOpçõesDoMenu();
    }

  switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBandas();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarBandas();
            break;
        case 4:
            ExibirAMediaDaBanda();
            break;
        case -1:
            Console.WriteLine("Saindo do programa...");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

}

void RegistrarBandas() 
{
    ExibirLogo();
    Console.Clear();
    ExibirTitulosOpcoes("Registro de Bandas");
    Console.Write("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"Banda registrada: {nomeDaBanda}");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpçõesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTitulosOpcoes("Bandas Registradas");
    Console.WriteLine("Exibindo todas as bandas registradas:");
    //for (int i = 0; i < listaBandasRegistradas.Count; i++)
    //{
    //  Console.WriteLine($"Banda: {listaBandasRegistradas[i]}");
    //}
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("Digite qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpçõesDoMenu();

}

void AvaliarBandas()
{
    Console.Clear();
    ExibirTitulosOpcoes("Avaliar Bandas");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda)) 
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece?");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota da banda {nomeDaBanda} foi registrada com sucesso");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpçõesDoMenu();
    } else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.Write("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpçõesDoMenu();
    }
}



void ExibirTitulosOpcoes(string titulo)
{ 
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void ExibirAMediaDaBanda()
{
    Console.Clear();
    ExibirTitulosOpcoes("Média das Avaliações");
    Console.Write("Digite o nome da banda que deseja ver a média das avaliações: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        double mediaDasNotas = notasDaBanda.Average();
        Console.WriteLine($"\nA média das avaliações da banda {nomeDaBanda} é: {mediaDasNotas}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpçõesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.Write("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpçõesDoMenu();
    }
}

ExibirOpçõesDoMenu();
 