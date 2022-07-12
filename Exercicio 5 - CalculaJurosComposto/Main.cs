using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaJurosCompostos
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            JurosComposto jurosComposto = new JurosComposto();
            decimal capitalInicial = 10000;
            decimal taxaJuro = 3;
            decimal prazo = 3;

            decimal resultadoMontante = jurosComposto.ObtenhaMontante(capitalInicial, taxaJuro, prazo);

            Console.WriteLine("Resultado montante: " + resultadoMontante.ToString("F2"));
            // O Valor do montante é 10927,27
            decimal totalJuros = jurosComposto.ObtenhaJuroTotal(resultadoMontante, capitalInicial);

            Console.WriteLine("Total juros: " + totalJuros.ToString("F2"));
            // O Valor total dos Juros é 927,27
        }
    }
}
