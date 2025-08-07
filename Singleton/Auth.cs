namespace Singleton;
public class Auth
{

    private static Auth conexao;
    private bool statusConexao = false;

    private Auth()
    {
        this.statusConexao = true;
    }

    public static Auth getInstance()
    {
        if (conexao == null) conexao = new Auth();
        return conexao;
    }
    public bool getStatusConexao()
    {
        return this.statusConexao;
    }
}