namespace JogoDeAdivinhacao.ConsoleApp;

class EscreverTexto
{
    public static void EscreverInicio()
    {
        Console.Clear();
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Jogo de adivinhação");
        Console.WriteLine("----------------------------------------------------");

        Console.WriteLine("Níveis de dificualdade:");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("1 Fácil (10 Tentativas)");
        Console.WriteLine("2 Normal (5 Tentativas)");
        Console.WriteLine("3 Difícil (3 Tentativas)");
        Console.WriteLine("----------------------------------------------------");
    }

    //dificuldades

    public static void FacilEscolhida()
    {
        Console.Clear();
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Dificuldade selecionada: Fácil");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Você tem 10 tentativas.");
        Console.WriteLine("----------------------------------------------------");
        Console.Write("\nPressione enter para continuar...");
        Console.ReadLine();
    }
    public static void NormalEscolhida()
    {
        Console.Clear();
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Dificuldade selecionada: Normal");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Você tem 5 tentativas.");
        Console.WriteLine("----------------------------------------------------");
        Console.Write("\nPressione enter para continuar...");
        Console.ReadLine();
    }
    
    public static void DificilEscolhida()
    {
        Console.Clear();
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Dificuldade selecionada: Difícil");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Você tem 3 tentativas.");
        Console.WriteLine("----------------------------------------------------");
        Console.Write("\nPressione enter para continuar...");
        Console.ReadLine();
    }
    public static void SecretaEscolhida()
    {
        Console.Clear();
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Dificuldade selecionada: Secreta");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Você tem 1 tentativa.");
        Console.WriteLine("----------------------------------------------------");
        Console.Write("\nPressione enter para continuar...");
        Console.ReadLine();
    }
    public static void NumeroTentativas(int tentativaAtual, int totalTentativas)
    {
        Console.Clear();
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine($"Tentativa {tentativaAtual} de {totalTentativas}");
        Console.WriteLine("----------------------------------------------------");
    }
    public static void Acerto()
    {
        Console.Clear();
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Voce acertou o número secreto!");
        Console.WriteLine("----------------------------------------------------");
    }
    public static void Erro(int numeroSecreto)
    {
        Console.Clear();
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine($"Você não acertou. O número secreto era: {numeroSecreto}");
        Console.WriteLine("----------------------------------------------------");
    }
    public static void Maior()
    {
        Console.WriteLine("\n----------------------------------------------------");
        Console.WriteLine("O número digitado foi maior que o número secreto.");
        Console.WriteLine("----------------------------------------------------");
        Console.Write("\nPressione enter para continuar...");
        Console.ReadLine();
    }
    public static void Menor()
    {
        Console.WriteLine("\n----------------------------------------------------");
        Console.WriteLine("O número digitado foi menor que o número secreto.");
        Console.WriteLine("----------------------------------------------------");
        Console.Write("\nPressione enter para continuar...");
        Console.ReadLine();
    }
}
