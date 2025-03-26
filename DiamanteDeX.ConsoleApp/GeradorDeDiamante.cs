namespace DiamanteDeX.ConsoleApp;

public static class GeradorDeDiamante
{
    public static int QuantidadeDeX;
    public static int QuantidadeDeEspacos;
    public static int QuantidadeDeLinhas;

    public static void Iniciar(int tamanhoDoDiamante)
    {
        QuantidadeDeX = 1;
        QuantidadeDeEspacos = CalcularQuantidadeDeEspacos(tamanhoDoDiamante);
        QuantidadeDeLinhas = CalcularQuantidadeDeLinhas(tamanhoDoDiamante);
    }

    public static string ObterEspacosDaLinha()
    {
        string espacosDaLinha = "";

        for (int espacos = 0; espacos < QuantidadeDeEspacos; espacos++)
            espacosDaLinha += " ";

        return espacosDaLinha;
    }

    public static string ObterXsDaLinha()
    {
        string xsDaLinha = "";

        for (int x = 0; x < QuantidadeDeX; x++)
            xsDaLinha += "x";

        return xsDaLinha;
    }

    public static int CalcularQuantidadeDeLinhas(int tamanhoDoDiamante)
    {
        return (tamanhoDoDiamante - 1) / 2;
    }

    public static int CalcularQuantidadeDeEspacos(int tamanhoDoDiamante)
    {
        return (tamanhoDoDiamante - 1) / 2;
    }

    public static void IncrementarLinha()
    {
        QuantidadeDeX += 2;
        QuantidadeDeEspacos--;
    }

    public static void DecrementarLinha()
    {
        QuantidadeDeX -= 2;
        QuantidadeDeEspacos++;
    }

    public static bool TamanhoDoDiamanteEstaValido(int tamanhoDoDiamante)
    {
        return tamanhoDoDiamante <= 1 || tamanhoDoDiamante > 99 || tamanhoDoDiamante % 2 == 0;
    }
}
