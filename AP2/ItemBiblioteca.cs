//class abrstata com os atributos titulo e codigo
public abstract class ItemBiblioteca
{
    public string Titulo { get; set; }
    public string Codigo { get; set; }

//construtor
    public ItemBiblioteca(string titulo, string codigo)
    {
        Titulo = titulo;
        Codigo = codigo;
    }

//metodo abstrato de empresta com parametro de livro e usuario
    public abstract void Emprestar(Livro livro, Usuario usuario);
//metodo abstrato de devolver com o parametro livro e usuario
    public abstract void Devolver(Livro livro, Usuario usuario);
}
