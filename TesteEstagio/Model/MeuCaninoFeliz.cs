using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading.Tasks;
using TesteDTI.Controllers;

namespace TesteDTI.Model
{
    public class MeuCaninoFeliz : Petshop
    {
        
        public MeuCaninoFeliz()
        {
            this.nome = "Meu Canino Feliz";
            this.banhoCaesPequenosSemana = 20;
            this.banhoCaesGrandesSemana = 40;
            this.distanciaEmQuilometros = 2.0;

            // Acrescentando 20% ao valor do banho no final de semana
            this.banhoCaesPequenosFimDeSemana = this.banhoCaesPequenosSemana + ((20.0 / 100.0) * this.banhoCaesPequenosSemana);
            this.banhoCaesGrandesFimDeSemana = this.banhoCaesGrandesSemana + ((20.0 / 100.0) * this.banhoCaesGrandesSemana);
        }
    }
}
