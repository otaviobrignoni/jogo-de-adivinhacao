namespace JogoDeAdivinhacao.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        do
        {
            JogoAdivinhacao.Texto.EscreverInicio();
            JogoAdivinhacao.Entrada.SelecionarDificuldade();
            JogoAdivinhacao.DefinirDificuldade();
            JogoAdivinhacao.GerarNumeroSecreto();
            JogoAdivinhacao.AdivinharNumeroSecreto();
        }
        while (JogoAdivinhacao.Entrada.Continuar());
    }
}
