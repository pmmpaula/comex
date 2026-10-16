class Produto
{
    public string Nome { get; }
    public string Descricao { get; }
    public decimal PrecoUnitario { get; }
    public int Quantidade { get; }

    public Produto(string nome, string descricao, decimal precoUnitario, int quantidade)
    {
        Nome = nome;
        Descricao = descricao;
        PrecoUnitario = precoUnitario;
        Quantidade = quantidade;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Descrição: {Descricao}");
        Console.WriteLine($"Preço Unitário: {PrecoUnitario:C}");
        Console.WriteLine($"Quantidade: {Quantidade}");
    }
}