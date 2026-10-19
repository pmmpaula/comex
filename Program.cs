Endereco endereco1 = new Endereco("Centro", "São Paulo", "Apto 101", "SP", "Rua A", 100);
Endereco endereco2 = new Endereco("Jardim", "Rio de Janeiro", "Casa 202", "RJ", "Rua B", 200);

List<Cliente> clientes = new List<Cliente>();

Cliente cliente1 = new Cliente("João Silva", "123.456.789-00", "joao.silva@email.com", "Engenheiro", "(11) 98765-4321", endereco1);
Cliente cliente2 = new Cliente("Maria Oliveira", "987.654.321-00", "maria.oliveira@email.com", "Designer", "(21) 98765-4321", endereco2);

clientes.Add(cliente1);
clientes.Add(cliente2);

List<Produto> produtos = new List<Produto>();

Produto produto1 = new Produto("Notebook", "Notebook Gamer", 3500.00m, 5);
Produto produto2 = new Produto("Smartphone", "Smartphone Android", 1500.00m, 10);

produtos.Add(produto1);
produtos.Add(produto2);

void ExibirMenuDeOpcoes()
{
    Console.WriteLine("\n-- Menu de opções --");
    Console.WriteLine("\nDigite 1 para Criar um produto");
    Console.WriteLine("Digite 2 para Listar os produtos");
    Console.WriteLine("Digite -1 para Sair do programa");

    int opcao = int.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case 1:
            CriaProduto();
            break;
        case 2:
            ListaProdutos();
            break;
        case -1:
            Console.WriteLine("COMEX FINALIZADO!");
            break;
    }
}

void CriaProduto()
{
    Console.WriteLine($"Opção escolhida: Criar produto");

    Console.WriteLine("Digite o nome do produto:");
    string nome = Console.ReadLine()!;

    Console.WriteLine("Digite a descrição do produto:");
    string descricao = Console.ReadLine()!;

    Console.WriteLine("Digite o preço unitário do produto:");
    decimal precoUnitario = decimal.Parse(Console.ReadLine()!);

    Console.WriteLine("Digite a quantidade em estoque:");
    int quantidade = int.Parse(Console.ReadLine()!);

    Produto produto = new Produto(nome, descricao, precoUnitario, quantidade);
    produtos.Add(produto);

    Console.WriteLine($"Produto {nome} cadastrado com sucesso!");

    ExibirMenuDeOpcoes();
}

void ListaProdutos()
{
    Console.WriteLine($"Opção escolhida: Listar produtos");


    foreach (var produto in produtos)
    {
        Console.WriteLine($"Nome: {produto.Nome}, Descrição: {produto.Descricao}, Preço: {produto.PrecoUnitario}, Quantidade: {produto.Quantidade}");
    }

    ExibirMenuDeOpcoes();
}

ExibirMenuDeOpcoes();