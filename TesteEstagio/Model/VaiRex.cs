using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteDTI.Model
{
    public class VaiRex : Petshop
    {
        public VaiRex()
        {
            this.nome = "Vai Rex";
            this.banhoCaesPequenosSemana = 15;
            this.banhoCaesPequenosFimDeSemana = 20;
            this.banhoCaesGrandesSemana = 50;
            this.banhoCaesGrandesFimDeSemana = 55;
            this.distanciaEmQuilometros = 1.7;
        }
    }
}
