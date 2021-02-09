using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteDTI.Model
{
    public class ChowChawgas : Petshop
    {
        public ChowChawgas()
        {
            this.nome = "ChowChawgas";
            this.banhoCaesPequenosSemana = 30;
            this.banhoCaesPequenosFimDeSemana = 30;
            this.banhoCaesGrandesSemana = 45;
            this.banhoCaesGrandesFimDeSemana = 45;
            this.distanciaEmQuilometros = 0.8;
        }
    }
}
