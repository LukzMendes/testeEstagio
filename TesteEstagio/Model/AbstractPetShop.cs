using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using TesteDTI.Model;

namespace TesteDTI.Model
{
    public abstract class AbstractPetShop : IPetshop
    {
        public abstract string nome { get; set; }
        public abstract double banhoCaesPequenosSemana { get; set; }
        public abstract double banhoCaesPequenosFimDeSemana { get; set; }
        public abstract double banhoCaesGrandesSemana { get; set; }
        public abstract double banhoCaesGrandesFimDeSemana { get; set; }
        public abstract double distanciaEmQuilometros { get; set; }
        public abstract double valorTotal { get; set; }

        public abstract void CalcularValorBanho(DateTime dataDoBanho, int caesPequenos, int caesGrandes);

        public abstract bool VerificaFinalDeSemana(DateTime dateTime);

    }
}
