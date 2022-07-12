using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaJurosCompostos
{
    public class JurosComposto
    {
        public decimal ObtenhaMontante(decimal capitalInicial, decimal taxaJuro, decimal prazo)
        {
            decimal porcentagemTaxaJuro = (taxaJuro / 100);

            decimal montante = capitalInicial * Potencia(1 + porcentagemTaxaJuro, prazo);

            return montante;
        }

        public decimal ObtenhaJuroTotal(decimal montante, decimal capitalInicial)
        {
            return montante - capitalInicial;
        }

        public decimal Potencia(decimal x, decimal y)
        {
            decimal xBase = x;

            for (int i = 1; i < y; i++)
            {
                x *= xBase;
            }
            return x;
        }
    }
}