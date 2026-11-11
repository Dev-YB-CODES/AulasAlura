// Screen Sound
string boasVindas = "Olá, bem-vindo ao Screen Sound!";

List<string> listaBandasRegistradas = new List<string>();
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
            Console.WriteLine($"Você digitou a opção {opcaoEscolhidaNumerica}");
            break;
        case 4:
            Console.WriteLine($"Você digitou a opção {opcaoEscolhidaNumerica}");
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
    Console.WriteLine("Registro de Bandas");
    Console.Write("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaBandasRegistradas.Add(nomeDaBanda);
    Console.WriteLine($"Banda registrada: {nomeDaBanda}");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpçõesDoMenu();
}

void MostrarBandasRegistradas() 
{
    Console.Clear();
    Console.WriteLine("Exibindo todas as bandas registradas:");
    //for (int i = 0; i < listaBandasRegistradas.Count; i++)
    //{
    //  Console.WriteLine($"Banda: {listaBandasRegistradas[i]}");
    //}
    foreach (string banda in listaBandasRegistradas)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("Digite qualquer tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpçõesDoMenu();

}

ExibirLogo();
ExibirOpçõesDoMenu();
 
