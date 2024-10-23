public class Usuario
{
    //atributos da classe usuario
    public string Nome {get;set;}
    public string NumIdentificacao {get; set;}
    public string Endereco { get; set; }
    public string Contato{get; set;}


//metodo construtor
     public Usuario(string nome, string numidentificacao, string endereco, string contato)
    {
        Nome = nome;
        NumIdentificacao = numidentificacao;
        Endereco = endereco;
        Contato = contato;
    }

//exibindo informaçoes do usuario
    public void ExibirInformacoes()
    {
       Console.WriteLine($"Nome:{Nome}");
       Console.WriteLine($"Numero de Identificação:{NumIdentificacao}"); 
       Console.WriteLine($"Endereço: {Endereco}"); 
       Console.WriteLine($"Contato:{Contato}"); 
    }
}