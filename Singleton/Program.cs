using Singleton;

Auth sessao = Auth.getInstance();

Cliente cliente = new Cliente("João", sessao);
Console.WriteLine(cliente.acessarPainel());