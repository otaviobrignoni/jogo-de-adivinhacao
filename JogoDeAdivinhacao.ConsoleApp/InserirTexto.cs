using static System.Runtime.InteropServices.JavaScript.JSType;

namespace JogoDeAdivinhacao.ConsoleApp;

class InserirTexto
{
    public static char Continuar()
    {
        Console.Write("\nDeseja continuar? (S/N) -> ");
        string entradaUsuario = Console.ReadLine()!.ToUpper();
        while (entradaUsuario != "S" && entradaUsuario != "N")
        {
            Console.Write("Opção inválida, tente novamente -> ");
            entradaUsuario = Console.ReadLine()!.ToUpper();
        }
        return entradaUsuario[0];
    }
    public static int NumeroEntradaUsuario()
    {
        int numero;
        Console.Write("\nDigite um número -> ");
        while (!int.TryParse(Console.ReadLine(), out numero))
            Console.Write("Número inválido tente novamente ->");
        return numero;
    }

    public static int SelecionarDificuldade()
    {
        int numero;
        Console.Write("Escolha um nível de dificuldade -> ");
        while (!int.TryParse(Console.ReadLine(), out numero))
            Console.Write("Dificuldade inválida tente novamente ->");
        return numero;
    }
}

