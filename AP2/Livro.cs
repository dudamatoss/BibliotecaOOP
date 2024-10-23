using System.Runtime.CompilerServices;

//classe livro que herda de ItemBiblioteca
public class Livro : ItemBiblioteca
{
    //tem com atributo: autor, isbn,genero,estoque
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public string Genero { get; set; }
    public int Estoque { get; set; }

//construtor
    public Livro(string titulo, string codigo, string autor, string isbn, string genero, int estoque) : base(titulo, codigo)
    {

        Autor = autor;
        ISBN = isbn;
        Genero = genero;
        Estoque = estoque;

    }

    //sobreescrevendo o metodo abstrato emprestar 
    public override void Emprestar(Livro livro, Usuario usuario)
    {
        //se tiver mais de 0 livros no estique
        if (Estoque > 0)
        {
            //sera queduzida 1 inidade no estoque
            Estoque--;
          //mensagem que passa o nome do livro que foi empraetado e a quantidade atual em estoque
            Console.WriteLine($"O livro:{Titulo}, foi emprestado. Estoque atual:{Estoque}");
        }
        //se não ira imprimir que o livro não esta disponivel para emprestimo
        else
        {
            Console.WriteLine($"O livro:{Titulo}, não esta disponivel para emprestimo.");
        }
    }

    //sobreescrevendo o metodo abstrato devolver 

    public override void Devolver(Livro livro, Usuario usuario)

    {
        //vai adicionar um livro no estoque 
            Estoque++;
            //imprimir a mensagem de que o livro foi devolvido e o estoque 
            Console.WriteLine($"O livro:{Titulo}, foi devolvido. Estoque atual:{Estoque}");
       

    }

}
