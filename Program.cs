Dictionary<string, string> clientes = new Dictionary<string, string>();

Dictionary<string, double> produtos = new Dictionary<string, double>();

void ExibirMenuDeOpcoes()
{
    Console.WriteLine("\n-- PROJETO COMEX --");
    Console.WriteLine("\nDigite 1 para Cadastrar cliente");
    Console.WriteLine("Digite 2 para Listar clientes");
    Console.WriteLine("Digite 3 para Cadastrar produto");
    Console.WriteLine("Digite 4 para Ajustar preço de produto");
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
        case 3:
            CadastraProduto();
            break;
        case 4:
            AjustarPrecoDeProduto();
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

void CadastraProduto()
{
    Console.WriteLine($"Opção escolhida: Cadastrar produto");

    Console.WriteLine("Digite o nome do produto:");
    string nome = Console.ReadLine()!;

    Console.WriteLine("Digite o preço do produto:");
    double preco = double.Parse(Console.ReadLine()!);

    produtos.Add(nome, preco);

    Console.WriteLine($"Produto {nome} cadastrado com sucesso!");

    ExibirMenuDeOpcoes();
}

void AjustarPrecoDeProduto()
{
    Console.WriteLine($"Opção escolhida: Ajustar preço de produto");

    Console.WriteLine("Qual produto deseja ajustar o preço?");
    string nome = Console.ReadLine()!;

    if (produtos.ContainsKey(nome))
    {
        Console.WriteLine("Digite o novo preço do produto:");
        double novoPreco = double.Parse(Console.ReadLine()!);
        produtos[nome] = novoPreco;
        Console.WriteLine($"Preço do produto atualizado.");
    }
    else
    {
        Console.WriteLine($"Produto não cadastrado no sistema.");
    }

    ExibirMenuDeOpcoes();
}

ExibirMenuDeOpcoes();