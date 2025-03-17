namespace JogoDeAdivinhacao.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            EscreverTexto.EscreverInicio();
            int totalTentativas = Logica.DefinirDificuldade(InserirTexto.NumeroEntradaUsuario());

            Random geradorNumeros = new Random();
            int numeroSecreto = geradorNumeros.Next(1, 21);

            Logica.AdivinharNumeroSecreto(totalTentativas, numeroSecreto);
            char continuar = InserirTexto.Continuar();
            if (continuar != 'S')
                break;
        }
    }
}
