namespace JogoDeAdivinhacao.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
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
                Console.Write("Escolha um nível de dificuldade -> ");
                int opcaoDificuldade = Convert.ToInt32(Console.ReadLine());
                int totalTentaivas = 1;

                if (opcaoDificuldade == 1)
                {
                    totalTentaivas = 10;
                    Console.Clear();
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("Dificuldade selecionada: Fácil");
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("Você tem 10 tentativas.");
                    Console.WriteLine("----------------------------------------------------");
                    Console.Write("\nPressione enter para continuar...");
                    Console.ReadLine();
                }
                else if (opcaoDificuldade == 2)
                {
                    totalTentaivas = 5;
                    Console.Clear();
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("Dificuldade selecionada: Normal");
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("Você tem 5 tentativas.");
                    Console.WriteLine("----------------------------------------------------");
                    Console.Write("\nPressione enter para continuar...");
                    Console.ReadLine();

                }
                else if (opcaoDificuldade == 3)
                {
                    totalTentaivas = 3;
                    Console.Clear();
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("Dificuldade selecionada: Difícil");
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("Você tem 3 tentativas.");
                    Console.WriteLine("----------------------------------------------------");
                    Console.Write("\nPressione enter para continuar...");
                    Console.ReadLine();
                }
                else
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
                    
                Random geradorNumeros = new Random();
                int numeroSecreto = geradorNumeros.Next(1, 21);

                for (int i = 1; i <= totalTentaivas; i++)
                {
                    Console.Clear();
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine($"Tentativa {i} de {totalTentaivas}");
                    Console.WriteLine("----------------------------------------------------");
                    Console.Write("\nDigite um número -> ");
                    int numeroDigitado = Convert.ToInt32(Console.ReadLine());

                    if (numeroDigitado == numeroSecreto)
                    {
                        Console.Clear();
                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine("Voce acertou o número secreto!");
                        Console.WriteLine("----------------------------------------------------");
                        break;
                    }
                    if (i == totalTentaivas)
                    {
                        Console.Clear();
                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine($"Você não acertou. O número secreto era: {numeroSecreto}");
                        Console.WriteLine("----------------------------------------------------");
                        break;
                    }
                    else if (numeroDigitado > numeroSecreto)
                    {
                        Console.WriteLine("\n----------------------------------------------------");
                        Console.WriteLine("O número digitado foi maior que o número secreto.");
                        Console.WriteLine("----------------------------------------------------");
                        Console.Write("\nPressione enter para continuar...");
                        Console.ReadLine();
                    }
                    else if (numeroDigitado < numeroSecreto)
                    {
                        Console.WriteLine("\n----------------------------------------------------");
                        Console.WriteLine("O número digitado foi menor que o número secreto.");
                        Console.WriteLine("----------------------------------------------------");
                        Console.Write("\nPressione enter para continuar...");
                        Console.ReadLine();
                    }
                }

                Console.Write("\nDeseja Continuar? (S/N) -> ");
                string opcaoContinuar = Console.ReadLine().ToUpper();
                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}
