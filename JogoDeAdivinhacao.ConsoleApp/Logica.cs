using System.Numerics;

namespace JogoDeAdivinhacao.ConsoleApp;

class Logica
{
    public static int DefinirDificuldade(int opcao)
    {
        int tentativas;
        switch (opcao)
        {
            case 1:
                tentativas = 10;
                EscreverTexto.FacilEscolhida();
                break;
            case 2:
                tentativas = 5;
                EscreverTexto.NormalEscolhida();
                break;
            case 3:
                tentativas = 3;
                EscreverTexto.DificilEscolhida();
                break;
            default:
                tentativas = 1;
                EscreverTexto.SecretaEscolhida();
                break;
        }
        return tentativas;
    }

    public static void AdivinharNumeroSecreto(int totalTentativas, int numeroSecreto) 
    {
        for (int i = 1 ; i <= totalTentativas; i++)
        {
            EscreverTexto.NumeroTentativas(i, totalTentativas);
            int numeroDigitado = InserirTexto.NumeroEntradaUsuario();

            if (numeroDigitado == numeroSecreto)
            {
                EscreverTexto.Acerto();
                break;
            }
            if (i == totalTentativas)
            {
                EscreverTexto.Erro(numeroSecreto);
                break;
            }
            else if (numeroDigitado > numeroSecreto)
            {
                EscreverTexto.Maior();
            }
            else if (numeroDigitado < numeroSecreto)
            {
                EscreverTexto.Menor();
            }
        }
    }
}
