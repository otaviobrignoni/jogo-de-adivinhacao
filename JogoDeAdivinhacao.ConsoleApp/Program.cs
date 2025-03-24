namespace JogoDeAdivinhacao.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        do
        {
            JogoAdivinhacao.NovoJogo();
        }
        while (JogoAdivinhacao.Entrada.ContinuarJogo());
    }
}
