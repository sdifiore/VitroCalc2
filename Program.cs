using System;

namespace VitroCalc
{
    class Program
    {
        static void Main()
        {
            double largura, altura, comprimentoMadeira, areaVidro;
            const double comprimentoMaximo = 5.0;
            const double comprimentoMinimo = 0.5;
            const double alturaMaxima = 3.0;
            const double alturaMinima = 0.75;
            string larguraString, alturaString;

        do
        {
            Console.Write("Forneça a largura da janela entre " + comprimentoMinimo + " e " + comprimentoMaximo + " :");
            larguraString = Console.ReadLine();
            largura = double.Parse(larguraString);
        } while (largura < comprimentoMinimo || largura > comprimentoMaximo);

        do
        {
            Console.Write("Forneça a altura da janela entre " + alturaMinima + " e " + alturaMaxima + " :");
            alturaString = Console.ReadLine();
            altura = double.Parse(alturaString);
        } while (altura < alturaMinima || altura > alturaMaxima);

        comprimentoMadeira = 2 * (largura + altura) * 3.25;
        areaVidro = 2 * largura * altura;
		
		Console.WriteLine($"O comprimento da madeira é { comprimentoMadeira } pés.\n"
					    + $"A área envidraçada é { areaVidro } metros quadrados");
        }
    }
}
