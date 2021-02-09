using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteDTI.Model
{
    interface IPetshop
    {
        public double banhoCaesPequenosSemana { get; set; }
        public double banhoCaesPequenosFimDeSemana { get; set; }
        public double banhoCaesGrandesSemana { get; set; }
        public double banhoCaesGrandesFimDeSemana { get; set; }
        public double distanciaEmQuilometros { get; set; }

        /// <summary>
        /// Calcula o valor total a ser gasto com o banho dos cachorros de acordo com a quantidade e com o dia
        /// </summary>
        /// <param name="dataDoBanho">Data do banho</param>
        /// <param name="caesPequenos">Quantidade de caes pequenos</param>
        /// <param name="caesGrandes">Quantidade de caes grandes</param>
        /// <returns>Valor total</returns>
        void CalcularValorBanho(DateTime dataDoBanho, int caesPequenos, int caesGrandes);

        /// <summary>
        /// Indica se o dia informado é final de semana ou não
        /// </summary>
        /// <param name="dateTime">Data a ser verificada</param>
        /// <returns>Retorna se é final de semana</returns>
        abstract bool VerificaFinalDeSemana(DateTime dateTime);
    }
}
