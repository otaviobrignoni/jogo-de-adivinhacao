namespace JogoDeAdivinhacao.ConsoleApp;

partial class JogoAdivinhacao
{
    static int opcaoDificuldade;
    static int numeroSecreto;
    static int totalTentativas;
    static int tentativaAtual;

    public static void GerarNumeroSecreto()
    {
        Random geradorNumeros = new Random();
        numeroSecreto =  geradorNumeros.Next(1, 21);
    }

    public static void DefinirDificuldade()
    {     
        switch (opcaoDificuldade)
        {
            case 1:
                totalTentativas = 10;
                Texto.FacilEscolhida();
                break;
            case 2:
                totalTentativas = 5;
                Texto.NormalEscolhida();
                break;
            case 3:
                totalTentativas = 3;
                Texto.DificilEscolhida();
                break;
            default:
                totalTentativas = 1;
                Texto.SecretaEscolhida();
                break;
        }
    }

    public static void AdivinharNumeroSecreto() 
    {
        for (tentativaAtual = 1 ; tentativaAtual <= totalTentativas; tentativaAtual++)
        {
            Texto.NumeroTentativas();
            int numeroDigitado = Entrada.NumeroEntradaUsuario();

            if (numeroDigitado == numeroSecreto)
            {
                Texto.ExibirAcerto();
                break;
            }
            if (tentativaAtual == totalTentativas)
            {
                Texto.ExibirErro();
                break;
            }
            else if (numeroDigitado > numeroSecreto)
            {
                Texto.ExibirMaior();
            }
            else if (numeroDigitado < numeroSecreto)
            {
                Texto.ExibirMenor();
            }
        }
    }

}
