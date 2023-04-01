class Program
{
    public static void Main(){
        TPessoaFisica Eu = new TPessoaFisica();
        Eu.nome = "Rafael Alves";
        Eu.endereco = "Rua da esquina";
        Eu.nascimento = DateTime.Parse("14/07/1984");

        Console.Clear();
        Eu.Falar();
        Console.ReadKey();
    }
}

public abstract class TPessoa
{
    private string _nome = "";
    private string _endereco = "";
    private DateTime _nascimento;

    public string nome
    {
        get{return _nome;}
        set{_nome = value;}
    }

    public string endereco
    {
        get{return _endereco;}

        set{_endereco = value;}
    }

    public DateTime nascimento
    {
        get{return _nascimento;}
        set{_nascimento = value;}
    }

    public int Idade()
    {
        return DateTime.Now.Year - nascimento.Year;
    }

    public abstract void Falar();
}

public class TPessoaFisica : TPessoa
{
    public override void Falar()
    {
        Console.WriteLine("Olá, meu nome é {0} e eu tenho {1} anos. E você?", nome, Idade());
    }
}