Dictionary<string, string> clientes = new Dictionary<string, string>
{
    {"123", "Leo"},
    {"456", "Lari"},
    {"789", "Caio"},
};

Dictionary<string, double> produtos = new Dictionary<string, double>
{
    {"Notebook", 3500.00},
    {"Mouse", 100.00},
    {"Teclado", 200.00}
};

Dictionary<string, List<string>> carrinhos = new Dictionary<string, List<string>>
{
    {"123", ["Notebook", "Mouse"]},
    {"456", ["Teclado"]},
    {"789", []}
};

void ExibirMenuDeOpcoes()
{
    Console.WriteLine("\n-- PROJETO COMEX --");
    Console.WriteLine("\nDigite 1 para Cadastrar cliente");
    Console.WriteLine("Digite 2 para Listar clientes");
    Console.WriteLine("Digite 3 para Cadastrar produto");
    Console.WriteLine("Digite 4 para Ajustar preço de produto");
    Console.WriteLine("Digite 5 para Adicionar produto no carrinho");
    Console.WriteLine("Digite 6 para Fechar compra");
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
        case 5:
            AdicionaProdutoNoCarrinho();
            break;
        case 6:
            FechaCompra();
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

    carrinhos.Add(cpf, new List<string>());

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

void AdicionaProdutoNoCarrinho()
{
    Console.WriteLine($"Opção escolhida: Adicionar produto no carrinho");

    Console.WriteLine("Digite o CPF do cliente que está comprando:");
    string cpfCliente = Console.ReadLine()!;

    if (!clientes.ContainsKey(cpfCliente))
    {
        Console.WriteLine($"Usuário não cadastrado.");

        ExibirMenuDeOpcoes();

        return;
    }

    Console.WriteLine("Digite o nome do produto que deseja adicionar ao carrinho:");
    string nomeProduto = Console.ReadLine()!;

    if (!produtos.ContainsKey(nomeProduto))
    {
        Console.WriteLine($"Produto não cadastrado.");

        ExibirMenuDeOpcoes();

        return;
    }

    carrinhos[cpfCliente].Add(nomeProduto);

    Console.WriteLine($"Produto adicionado ao carrinho com sucesso.");

    ExibirMenuDeOpcoes();
}

void FechaCompra()
{
    Console.WriteLine($"Opção escolhida: Fechar compra");

    Console.WriteLine("Digite o CPF do cliente que deseja fechar a compra:");
    string cpfCliente = Console.ReadLine()!;

    if (!clientes.ContainsKey(cpfCliente))
    {
        Console.WriteLine($"Cliente não cadastrado.");

        ExibirMenuDeOpcoes();

        return;
    }

    Console.WriteLine("Produtos no carrinho:");

    foreach (var produto in carrinhos[cpfCliente])
    {
        Console.WriteLine($"{produto}");
    }

    double soma = 0;

    foreach (var produto in carrinhos[cpfCliente])
    {
        soma += produtos[produto];
    }

    Console.WriteLine($"Valor final da compra: R${soma:F2}");

    Console.WriteLine("Digite o número do cartão de crédito:");
    string numeroCartao = Console.ReadLine()!;

    Console.WriteLine("Digite a data de validade do cartão:");
    string dataValidade = Console.ReadLine()!;

    Console.WriteLine("Digite o código de segurança do cartão:");
    string codigoSeguranca = Console.ReadLine()!;

    Console.WriteLine($"Realizando pagamento de R${soma:F2} no cartão {numeroCartao}.");

    ExibirMenuDeOpcoes();
}

ExibirMenuDeOpcoes();