namespace DiamanteDeX.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            ExibirCabecalho();

            int tamanhoDoDiamante = ObterTamanhoDoDiamante();

            GeradorDeDiamante.Iniciar(tamanhoDoDiamante);

            // Desenho da parte superior
            for (int linha = 0; linha < GeradorDeDiamante.QuantidadeDeLinhas; linha++)
            {
                Console.Write(GeradorDeDiamante.ObterEspacosDaLinha());
                Console.Write(GeradorDeDiamante.ObterXsDaLinha());

                GeradorDeDiamante.IncrementarLinha();

                Console.WriteLine();
            }

            // Desenho da parte do meio
            Console.Write(GeradorDeDiamante.ObterXsDaLinha());
            Console.WriteLine();

            // Desenho da parte inferior
            GeradorDeDiamante.QuantidadeDeEspacos = 1;
            GeradorDeDiamante.QuantidadeDeX -= 2;

            for (int linha = 0; linha < GeradorDeDiamante.QuantidadeDeLinhas; linha++)
            {
                Console.Write(GeradorDeDiamante.ObterEspacosDaLinha());
                Console.Write(GeradorDeDiamante.ObterXsDaLinha());

                GeradorDeDiamante.DecrementarLinha();

                Console.WriteLine();
            }

            if (UsuarioDesejaSair())
                break;
        }
    }
    static void ExibirCabecalho()
    {
        Console.Clear();
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Diamante de X");
        Console.WriteLine("---------------------------------------------");
    }

    static int ObterTamanhoDoDiamante()
    {
        int tamanhoDoDiamante;
        bool numeroEhValido = false;

        do
        {
            Console.Write("Digite um número ímpar positivo: ");
            numeroEhValido = int.TryParse(Console.ReadLine(), out tamanhoDoDiamante);

            Console.WriteLine("---------------------------------------------");

            if (GeradorDeDiamante.TamanhoDoDiamanteEstaValido(tamanhoDoDiamante))
            {
                numeroEhValido = false;
                Console.WriteLine("Por favor, digite um número ímpar maior que 1 e menor que 100!");
                Console.WriteLine("---------------------------------------------");

                Console.ReadLine();
            }

        } while (numeroEhValido == false);

        return tamanhoDoDiamante;
    }

    static bool UsuarioDesejaSair()
    {
        Console.WriteLine("---------------------------------------------");
        Console.Write("Deseja desenhar outro diamante? s/N ");

        return Console.ReadLine()?.ToUpper() != "S";
    }
}
