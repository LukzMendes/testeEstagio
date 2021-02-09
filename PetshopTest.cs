using NUnit.Framework;
using System;
using TesteEstagio.Model;

namespace ApiTest
{
	public class PetshopTest
	{
		[Test]
		public void VerificaFinalDeSemanaTest()
		{
			var petshop = new Petshop();
			
			var dataSemana = new DateTime(2020, 07, 16);
			var dataFimDeSemana = new DateTime(2020, 07, 18);

			// Action
			var resultadoSemana = petshop.VerificaFinalDeSemana(dataSemana);
			var resultadoFimDeSemana = petshop.VerificaFinalDeSemana(dataFimDeSemana);

			// Assert
			Assert.IsTrue(resultadoFimDeSemana);
			Assert.IsFalse(resultadoSemana);
		}

		[Test]
		public void VerificaValorBanhoSemanaTest()
		{
			var meuCaninoFeliz = new MeuCaninoFeliz();
			var vaiRex = new VaiRex();
			var chowChawgas = new ChowChawgas();

			var dataSemana = new DateTime(2020, 07, 16);
			var quantCaesPequenos = 2;
			var quantCaesGrandes = 3;

			// Action
			// Calcula o valor total dos banhos em cada petshop
			meuCaninoFeliz.CalcularValorBanho(dataSemana, quantCaesPequenos, quantCaesGrandes);
			vaiRex.CalcularValorBanho(dataSemana, quantCaesPequenos, quantCaesGrandes);
			chowChawgas.CalcularValorBanho(dataSemana, quantCaesPequenos, quantCaesGrandes);

			// Verifica qual é o melhor petshop
			var melhorPetshop = Petshop.ComparaValores(meuCaninoFeliz, vaiRex, chowChawgas);

			// Assert
			Assert.AreEqual(160, meuCaninoFeliz.valorTotal);
			Assert.AreEqual(180, vaiRex.valorTotal);
			Assert.AreEqual(195, chowChawgas.valorTotal);

			Assert.AreEqual(melhorPetshop, meuCaninoFeliz);
		}

		[Test]
		public void VerificaValorBanhoFimDeSemanaTest()
		{
			var meuCaninoFeliz = new MeuCaninoFeliz();
			var vaiRex = new VaiRex();
			var chowChawgas = new ChowChawgas();

			var dataFimDeSemana = new DateTime(2020, 07, 18);
			var quantCaesPequenos = 2;
			var quantCaesGrandes = 1;

			// Action
			// Calcula o valor total dos banhos em cada petshop
			meuCaninoFeliz.CalcularValorBanho(dataFimDeSemana, quantCaesPequenos, quantCaesGrandes);
			vaiRex.CalcularValorBanho(dataFimDeSemana, quantCaesPequenos, quantCaesGrandes);
			chowChawgas.CalcularValorBanho(dataFimDeSemana, quantCaesPequenos, quantCaesGrandes);

			// Verifica qual é o melhor petshop
			var melhorPetshop = Petshop.ComparaValores(meuCaninoFeliz, vaiRex, chowChawgas);

			// Assert
			Assert.AreEqual(96, meuCaninoFeliz.valorTotal);
			Assert.AreEqual(95, vaiRex.valorTotal);
			Assert.AreEqual(105, chowChawgas.valorTotal);

			Assert.AreEqual(melhorPetshop, vaiRex);
		}
	}
}