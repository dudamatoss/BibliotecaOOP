
public class Biblioteca
{
    //lista privada de livros e ususarios
    private List<Livro> livros;
    private List<Usuario> usuarios;

    //construtor
    public Biblioteca()
//sendo iniciada uma lista de livros e usuarios 
    {
        livros = new List<Livro>();
        usuarios = new List<Usuario>();
    }
    //função de cadastrar livros
    public void CadastrarLivro()
    {
        //novo livro com os parametros estipulados 
        Livro livro = new Livro("", "", "", "", "", 10);
        Console.WriteLine("Cadastro de livros");
        Console.WriteLine("Titulo:");
        //sera inserido o novo titulo
        livro.Titulo = Console.ReadLine();

        Console.WriteLine("Codigo:");
        livro.Codigo = Console.ReadLine();

        Console.WriteLine("Autor:");
        livro.Autor = Console.ReadLine();

        Console.WriteLine("ISBN:");
        livro.ISBN = Console.ReadLine();

        Console.WriteLine("Genero:");
        livro.Genero = Console.ReadLine();

        Console.WriteLine("Estoque:");
        livro.Estoque = Convert.ToInt32(Console.ReadLine());
        // adicionado a lista de livros 
        livros.Add(livro);
        Console.WriteLine("Livro cadastrado com sucesso!");
    }
    //listar livros, se tiver 0 livros imprimir mensagem 
    public void ListarLivros()
    {
        if (livros.Count == 0)
        {
            Console.WriteLine("Nenhum livro cadastrado.");
            return;
        }
        Console.WriteLine("Lista de Livros:");
        //puxando da lista livros
        foreach (var livro in livros)
        {
            //todos os atributos estaram listados aqui
            Console.WriteLine($"Título: {livro.Titulo}");
            Console.WriteLine($"Codigo: {livro.Codigo}");
            Console.WriteLine($"Autor: {livro.Autor}");
            Console.WriteLine($"ISBN:{livro.ISBN}");
            Console.WriteLine($"Genero:{livro.Genero}");
            Console.WriteLine($"Estoque: {livro.Estoque}");
            Console.WriteLine("-------------------------");
        }
    }
    public void CadastrarUsuario()
    {
        //novo usuario com os parametros estipulados 

        Usuario usuario = new Usuario("", "", "", "");
        Console.WriteLine("Cadastro de Usuário:");

        Console.WriteLine("Nome:");
        //sera adicionado um novo nome
        usuario.Nome = Console.ReadLine();

        Console.WriteLine("Numero de Identificação:");
        usuario.NumIdentificacao = Console.ReadLine();


        Console.WriteLine("Endereço:");
        usuario.Endereco = Console.ReadLine();


        Console.WriteLine("Contato:");
        usuario.Contato = Console.ReadLine();
        //adicionando a lista de usuario
        usuarios.Add(usuario);
        Console.WriteLine("Usuario cadastrado com sucesso!");
    }
    //lista esta protegida 
    protected void ListarUsuarios()
    {
        //puxando da lista usuarios
        foreach (var usuario in usuarios)
        {
            //sera listado cada atributo
            Console.WriteLine($"Nome:{usuario.Nome}");
            Console.WriteLine($"Numero de Identificação: {usuario.NumIdentificacao}");
            Console.WriteLine($"Endereço:{usuario.Endereco}");
            Console.WriteLine($" Contato:{usuario.Contato}");
            Console.WriteLine("----------------------------------------------");
        }
    }
    //possibilita acesso a lista de usuarios
    public void ExibirUsuarios()
    {
        ListarUsuarios();
    }
    //pesquisar por titulo, parametro titulo
    public void PesquisarLivro(string titulo)
    {
        Console.WriteLine("Digite o título do livro que deseja pesquisar:");
        //a entrada por titulo
        titulo = Console.ReadLine();
        bool encontrado = false;
        foreach (var livro in livros)

        {   //se em livro tiver o mesmo titulo do que foi digitado
            if (livro.Titulo == titulo)
            {
                //ira exibir as informaçoes do livro
                Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, ISBN: {livro.ISBN}, Estoque: {livro.Estoque}");
                encontrado = true;
                //função encerrada
                break;
            }
            //caso for diferente de encontrado
            if (!encontrado)
            {
                //ira exibir esta mensagem
                Console.WriteLine("Nenhum livro encontrado com esse título.");
            }

        }
    }
    //pesquisa por autor
    public void PesquisarAutor(string autor)
    {
        Console.WriteLine("Digite o autor que deseja pesquisar:");
        //entrada por autor
        autor = Console.ReadLine();
        //encontrado é falso
        bool encontrado = false;
        foreach(var livro in livros)
        {
            //se em livros tiver o mesmo autor do que foi digitado
            if(livro.Autor == autor)
            {
                //imprimor mensagem com todos os livros do autor
             Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, ISBN: {livro.ISBN}, Estoque: {livro.Estoque}");
             //encontrado se torna ture
                encontrado = true;
                //função encerrada
                break;   
            }
            //caso for diferente de encontrado

            if (!encontrado)   
            {
                //ira exibir esta mensagem
                Console.WriteLine("Nenhum autor com este nome encontrado");
            }
        }

    }
    //pesquisa por genero
    public void PesquisarGenero(string genero)
    {
        Console.WriteLine("Digite o genero que deseja pesquisar:");
        //entrada por genero
        genero = Console.ReadLine();
        //encontrado é falso
        bool encontrado = false;
        foreach(var livro in livros)
        {
            //se em livros tiver o mesmo genero do que foi digitado
            //
            if(livro.Genero == genero)
            {
                //sera listado todos os livro deste genero
             Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, ISBN: {livro.ISBN}, Estoque: {livro.Estoque}");
               //encontrado se torna true
                encontrado = true;
                //função encerrada
                break;   
            }
             if (!encontrado)
            {
                Console.WriteLine("Nenhum livro deste genero encontrado");
            }
        }

    }
    //pesqusar usuario
    public void PesquisarUsuario(string numidentificacao)
    {
        Console.WriteLine("Digite o Usuário que deseja pesquisar:");
        //entrada por numero de identificação
        numidentificacao = Console.ReadLine();
        //encontrado é falso
        bool encontrado = false;
        foreach (var usuario in usuarios)
        {
            //se na lista ususario tiver o mesmo numero de identificação do digitado
            if (usuario.NumIdentificacao == numidentificacao)
            {
                //imprime todas as informaçãoes do usuario
                Console.WriteLine($"Nome:{usuario.Nome}, Numero de Identificação: {usuario.NumIdentificacao}, Contato:{usuario.Contato}");
                //encontrado se torna true
                encontrado = true;
                //função encerrada
                break;
            }
            if(!encontrado)
            {
                Console.WriteLine("Nenhum usuário encontrado.");

            }
        }
    }
    //criar um metodo para emprestar livro, vai receber o nome do livo, voce vai procurar o livro na lista de livro existente, se vocÊ encontrar
    //ai vc chama a função emprestar do livro.

    //metodo emprstar livro
    public void EmprestarLivro()
    {
        //pesquisando o livro
        Livro livro = new Livro("titulo", "1234", "autor", "isbn", "genero", 3 );
        //pesquisando usuario
        Usuario usuario = new Usuario("eu","1234","rua","eueu");
        foreach(var livroItem in livros)
        {
            //se na lista de livros tiver o mesmo autor pesquisado
            if(livro.Autor == livroItem.Autor){
                //chama a função de devolver
                livroItem.Emprestar(livro, usuario);
            }
        }

    }
    public void DevolverLivro()
    {   
        //pesquisando livro
         Livro livro = new Livro("teste", "1234", "autor", "isbn", "genero", 3 );
        //pesquisando usuario
        Usuario usuario = new Usuario("eduarda","1234","rua","12345");
        foreach(var livroItem in livros)
        {
            //se na lista de livros tiver o mesmo autor pesquisado
            if(livro.Autor == livroItem.Autor){
                //chama a função devolver 
                livroItem.Devolver(livro, usuario);
            }
        }
    }

    //para devolver ao inves do livro chamar a funcao de emprestar, chama a função de devolver.
}