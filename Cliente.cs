class Cliente
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string Email { get; set; }
    public string Profissao { get; set; }
    public string Telefone { get; set; }
    public Endereco Endereco { get; set; }

    public Cliente(string nome, string cPF, string email, string profissao, string telefone, Endereco endereco)
    {
        Nome = nome;
        CPF = cPF;
        Email = email;
        Profissao = profissao;
        Telefone = telefone;
        Endereco = endereco;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"CPF: {CPF}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Profissão: {Profissao}");
        Console.WriteLine($"Telefone: {Telefone}");
        Console.WriteLine($"Endereço: {Endereco.ExibirEndereco()}");
    }
}