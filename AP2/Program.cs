Biblioteca biblioteca = new Biblioteca();

bool sair = false;

while (!sair)
{
    Console.WriteLine("--------------------");

    Console.WriteLine("Digite uma opção:");
    Console.WriteLine("1. Cadastrar Livro");
    Console.WriteLine("2. Cadastrar Usuario ");
    Console.WriteLine("3. Listar Livros ");
    Console.WriteLine("4. Listar Usuários");
    Console.WriteLine("5. Pesquisar Livro");
    Console.WriteLine("6. Pesquisar por Autor");
    Console.WriteLine("7. Pesquisar por genero");
    Console.WriteLine("8. Pesquisar Usuario");
    Console.WriteLine("9. Emprestimos");
    Console.WriteLine("10. Devoluções");

    Console.WriteLine("0. Sair");
    Console.WriteLine("--------------------");


    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case"1":
        biblioteca.CadastrarLivro();
        break;
        case"2":
        biblioteca.CadastrarUsuario();
        break;
        case"3":
        biblioteca.ListarLivros();
        break;
        case"4":
        biblioteca.ExibirUsuarios();
        break;
        case"5":
        biblioteca.PesquisarLivro("");
        break;
        case"6":
        biblioteca.PesquisarAutor("");
        break;
        case"7":
        biblioteca.PesquisarGenero("");
        break;
        case"8":
        biblioteca.PesquisarUsuario("");
        break;
        case"9":
        biblioteca.EmprestarLivro();
        break;
        case"10":
        biblioteca.DevolverLivro();
        break;
        case"0":
        sair = true;
        break;


    }
}

