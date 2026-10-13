void ExibirMenuDeOpcoes()
{
    Console.WriteLine("-- PROJETO COMEX --");

    Console.WriteLine("\nDigite 1 para Cadastrar cliente");

    int opcao = int.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case 1:
            CadastrarCliente();
            break;
        case -1:
            Console.WriteLine("COMEX FINALIZADO!");
            break;
    }
}

void CadastrarCliente()
{
    Console.WriteLine($"Opção escolhida: Cadastrar cliente");
}

ExibirMenuDeOpcoes();