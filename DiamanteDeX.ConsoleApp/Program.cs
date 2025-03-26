namespace DiamanteDeX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanhoDoDiamante = 5;

            // Desenho da parte do meio
            for (int coluna = 0; coluna < tamanhoDoDiamante; coluna++)
            {
                Console.Write("x");
            }

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
