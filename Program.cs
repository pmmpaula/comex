Produto produto1 = new Produto("Notebook", "Notebook Gamer", 3500.00m, 5);
Produto produto2 = new Produto("Smartphone", "Smartphone Android", 1500.00m, 10);

Console.WriteLine("Informações dos Produtos");
produto1.ExibirInformacoes();
produto2.ExibirInformacoes();

Endereco endereco1 = new Endereco("Centro", "São Paulo", "Apto 101", "SP", "Rua A", 100);
Endereco endereco2 = new Endereco("Jardim", "Rio de Janeiro", "Casa 202", "RJ", "Rua B", 200);

Console.WriteLine("\nInformações dos Endereços");
endereco1.ExibirEndereco();
endereco2.ExibirEndereco();

Cliente cliente1 = new Cliente("João Silva", "123.456.789-00", "joao.silva@email.com", "Engenheiro", "(11) 98765-4321", endereco1);
Cliente cliente2 = new Cliente("Maria Oliveira", "987.654.321-00", "maria.oliveira@email.com", "Designer", "(21) 98765-4321", endereco2);

Console.WriteLine("\nInformações dos Clientes");
cliente1.ExibirInformacoes();
cliente2.ExibirInformacoes();