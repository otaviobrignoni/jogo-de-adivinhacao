namespace JogoDeAdivinhacao.ConsoleApp;

partial class JogoAdivinhacao
{
    public class Entrada
    {
        public static bool Continuar()
        {
            Console.Write("\nDeseja continuar? (S/N) -> ");
            string entradaUsuario = Console.ReadLine()!;
            while (entradaUsuario != "S" && entradaUsuario != "N" && entradaUsuario != "s" && entradaUsuario != "n" || (entradaUsuario == null))
            {
                Console.Write("Opção inválida, tente novamente -> ");
                entradaUsuario = Console.ReadLine()!;
            }
            return entradaUsuario.ToUpper()[0] == 'S';
        }

        public static int NumeroEntradaUsuario()
        {
            int numero;
            Console.Write("\nDigite um número -> ");
            while (!int.TryParse(Console.ReadLine(), out numero))
                Console.Write("Número inválido tente novamente ->");
            return numero;
        }

        public static void SelecionarDificuldade()
        {
            Console.Write("Escolha um nível de dificuldade -> ");
            while (!int.TryParse(Console.ReadLine(), out opcaoDificuldade))
                Console.Write("Dificuldade inválida tente novamente ->");
        }

    }
}
