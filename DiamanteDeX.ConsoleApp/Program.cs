namespace DiamanteDeX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanhoDoDiamante;
            bool numeroEhValido = false;

            do
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Diamante de X");
                Console.WriteLine("---------------------------------------------");

                Console.Write("Digite um número impar positivo: ");
                numeroEhValido = int.TryParse(Console.ReadLine(), out tamanhoDoDiamante);

                Console.WriteLine("---------------------------------------------");

                if (tamanhoDoDiamante <= 1 || tamanhoDoDiamante > 99 || tamanhoDoDiamante % 2 == 0)
                {
                    numeroEhValido = false;
                    Console.WriteLine("Por favor, digite um número impar maior que 1 e menor que 100!");
                    Console.WriteLine("---------------------------------------------");

                    Console.ReadLine();
                }
            } while (numeroEhValido == false);

            int quantidadeDeLinhas = (tamanhoDoDiamante - 1) / 2;
            int quantidadeDeEspacos = (tamanhoDoDiamante - 1) / 2;
            int quantidadeDeX = 1;

            // Desenho da parte superior
            for (int linha = 0; linha < quantidadeDeLinhas; linha++)
            {
                for (int espacos = 0; espacos < quantidadeDeEspacos; espacos++)
                    Console.Write(" ");

                for (int x = 0; x < quantidadeDeX; x++)
                    Console.Write("x");

                quantidadeDeEspacos--;
                quantidadeDeX += 2;

                Console.WriteLine();
            }

            // Desenho da parte do meio
            for (int coluna = 0; coluna < tamanhoDoDiamante; coluna++)
                Console.Write("x");

            Console.WriteLine();

            // Desenho da parte inferior
            quantidadeDeEspacos = 1;
            quantidadeDeX -= 2;

            for (int linha = 0; linha < quantidadeDeLinhas; linha++)
            {
                for (int espacos = 0; espacos < quantidadeDeEspacos; espacos++)
                    Console.Write(" ");

                for (int x = 0; x < quantidadeDeX; x++)
                    Console.Write("x");

                quantidadeDeEspacos++;
                quantidadeDeX -= 2;

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
