namespace Singleton;

public class Cliente
{
    private string nome;
    private Auth sessao;

    public Cliente(string nome, Auth sessao)
    {
        this.nome = nome;
        this.sessao = sessao;
    }

    public string acessarPainel()
    {
        if (this.sessao != null) return "painel acessado";
        return "acesso negado";
    }

    public Cliente getCliente()
    {
        if (this.sessao != null) return this;
        return null;
    }

    public Cliente setInformacaoCliente(string novoNome)
    {
        if (this.sessao != null)
        {
            setNome(novoNome);
            return this;
        }
        return null;
    }

    private void setNome(string nome)
    {
        this.nome = nome;
    }
}