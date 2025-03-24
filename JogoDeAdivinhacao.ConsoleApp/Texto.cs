namespace JogoDeAdivinhacao.ConsoleApp;

partial class JogoAdivinhacao
{
    public class Texto
    {
        public static void EscreverInicio()
        {
            //output

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

        public static void NumeroTentativas()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Tentativa {tentativaAtual} de {totalTentativas}");
            Console.WriteLine("----------------------------------------------------");
        }

        public static void ExibirAcerto()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Voce acertou o número secreto!");
            Console.WriteLine("----------------------------------------------------");
        }

        public static void ExibirErro()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Você não acertou. O número secreto era: {numeroSecreto}");
            Console.WriteLine("----------------------------------------------------");
        }

        public static void ExibirMaior()
        {
            Console.WriteLine("\n----------------------------------------------------");
            Console.WriteLine("O número digitado foi maior que o número secreto.");
            Console.WriteLine("----------------------------------------------------");
            Console.Write("\nPressione enter para continuar...");
            Console.ReadLine();
        }

        public static void ExibirMenor()
        {
            Console.WriteLine("\n----------------------------------------------------");
            Console.WriteLine("O número digitado foi menor que o número secreto.");
            Console.WriteLine("----------------------------------------------------");
            Console.Write("\nPressione enter para continuar...");
            Console.ReadLine();
        }
        
    }
}
