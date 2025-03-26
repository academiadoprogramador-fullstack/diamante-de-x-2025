namespace DiamanteDeX.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            ExibirCabecalho();

            GeradorDeDiamante.Iniciar(ObterTamanhoDoDiamante());

            DesenharParteSuperior();

            DesenharParteDoMeio();

            DesenharParteInferior();

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

    static void DesenharParteInferior()
    {
        GeradorDeDiamante.QuantidadeDeEspacos = 1;
        GeradorDeDiamante.QuantidadeDeX -= 2;

        for (int linha = 0; linha < GeradorDeDiamante.QuantidadeDeLinhas; linha++)
        {
            Console.Write(GeradorDeDiamante.ObterEspacosDaLinha());
            Console.Write(GeradorDeDiamante.ObterXsDaLinha());

            GeradorDeDiamante.DecrementarLinha();

            Console.WriteLine();
        }
    }

    static void DesenharParteDoMeio()
    {
        Console.Write(GeradorDeDiamante.ObterXsDaLinha());
        Console.WriteLine();
    }

    static void DesenharParteSuperior()
    {
        for (int linha = 0; linha < GeradorDeDiamante.QuantidadeDeLinhas; linha++)
        {
            Console.Write(GeradorDeDiamante.ObterEspacosDaLinha());
            Console.Write(GeradorDeDiamante.ObterXsDaLinha());

            GeradorDeDiamante.IncrementarLinha();

            Console.WriteLine();
        }
    }

    static bool UsuarioDesejaSair()
    {
        Console.WriteLine("---------------------------------------------");
        Console.Write("Deseja desenhar outro diamante? s/N ");

        return Console.ReadLine()?.ToUpper() != "S";
    }
}
