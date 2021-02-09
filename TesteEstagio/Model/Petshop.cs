using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Threading.Tasks;
using TesteDTI.Controllers;

namespace TesteDTI.Model
{
    public class Petshop : AbstractPetShop
    {
        private string _nome;
        private double _banhoCaesPequenosSemana;
        private double _banhoCaesPequenosFimDeSemana;
        private double _banhoCaesGrandesSemana;
        private double _banhoCaesGrandesFimDeSemana;
        private double _distanciaEmQuilometros;
        private double _valorTotal;

        public override string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public override double banhoCaesPequenosSemana
        {
            get { return _banhoCaesPequenosSemana; }
            set { _banhoCaesPequenosSemana = value; }
        }

        public override double banhoCaesPequenosFimDeSemana
        {
            get { return _banhoCaesPequenosFimDeSemana; }
            set { _banhoCaesPequenosFimDeSemana = value; }
        }

        public override double banhoCaesGrandesSemana
        {
            get { return _banhoCaesGrandesSemana; }
            set { _banhoCaesGrandesSemana = value; }
        }

        public override double banhoCaesGrandesFimDeSemana
        {
            get { return _banhoCaesGrandesFimDeSemana; }
            set { _banhoCaesGrandesFimDeSemana = value; }
        }

        public override double distanciaEmQuilometros
        {
            get { return _distanciaEmQuilometros; }
            set { _distanciaEmQuilometros = value; }
        }

        public override double valorTotal
        {
            get { return _valorTotal; }
            set { _valorTotal = value; }
        }

        public override void CalcularValorBanho(DateTime dataDoBanho, int caesPequenos, int caesGrandes)
        {
            double valorCaesPequenos;
            double valorCaesGrandes;
            if (this.VerificaFinalDeSemana(dataDoBanho))
            {
                valorCaesPequenos = caesPequenos * this.banhoCaesPequenosFimDeSemana;
                valorCaesGrandes = caesGrandes * this.banhoCaesGrandesFimDeSemana;
            }
            else
            {
                valorCaesPequenos = caesPequenos * this.banhoCaesPequenosSemana;
                valorCaesGrandes = caesGrandes * this.banhoCaesGrandesSemana;
            }

            this.valorTotal = valorCaesPequenos + valorCaesGrandes;
        }

        public override bool VerificaFinalDeSemana(DateTime dateTime)
        {
            DayOfWeek dia = dateTime.DayOfWeek;
            if (dia == DayOfWeek.Saturday || dia == DayOfWeek.Monday)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Retorna o petshop com o menor valor. Caso tenha 2 com valores iguais, retorna o mais perto.
        /// </summary>
        /// <param name="petshops">Lista dos petshops</param>
        /// <returns>Retorna o melhor petshop</returns>
        public static Petshop ComparaValores(params Petshop[] petshops)
        {
            var petshopMenorValor = new Petshop();

            foreach (var petshop in petshops)
            {
                if (petshopMenorValor.nome == null)
                    petshopMenorValor = petshop;
                else
                {
                    if (petshopMenorValor.valorTotal > petshop.valorTotal)
                        petshopMenorValor = petshop;
                    else if (petshopMenorValor.valorTotal == petshop.valorTotal && (petshopMenorValor.distanciaEmQuilometros > petshop.distanciaEmQuilometros))
                        // Caso o valor seja o mesmo, será escolhido aquele que tem a menor distância
                        petshopMenorValor = petshop;
                }
            }

            return petshopMenorValor;
        }
    }
}
