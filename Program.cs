Dictionary<string, string> clientes = new Dictionary<string, string>();

void ExibirMenuDeOpcoes()
{
    Console.WriteLine("\n-- PROJETO COMEX --");
    Console.WriteLine("\nDigite 1 para Cadastrar cliente");
    Console.WriteLine("Digite 2 para Listar clientes");
    Console.WriteLine("Digite -1 para Sair do programa");

    int opcao = int.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case 1:
            CadastraCliente();
            break;
        case 2:
            ListaClientes();
            break;
        case -1:
            Console.WriteLine("COMEX FINALIZADO!");
            break;
    }
}

void CadastraCliente()
{
    Console.WriteLine($"Opção escolhida: Cadastrar cliente");

    Console.WriteLine("Digite o CPF do cliente:");
    string cpf = Console.ReadLine()!;

    Console.WriteLine("Digite o nome do cliente:");
    string nome = Console.ReadLine()!;

    clientes.Add(cpf, nome);

    Console.WriteLine($"Usuário {nome} ({cpf}) cadastrado com sucesso!");

    ExibirMenuDeOpcoes();
}

void ListaClientes()
{
    Console.WriteLine($"Opção escolhida: Listar clientes");

    foreach (var cliente in clientes)
    {
        Console.WriteLine($"CPF: {cliente.Key}, Nome: {cliente.Value}");
    }

    ExibirMenuDeOpcoes();
}

ExibirMenuDeOpcoes();