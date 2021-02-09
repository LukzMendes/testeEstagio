using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TesteDTI.Model;

namespace TesteDTI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PetshopController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get(string dataDoBanho, int caesPequenos, int caesGrandes)
        {
            if (string.IsNullOrEmpty(dataDoBanho))
            {
                return new JsonResult(new { 
                    Response = "Favor informar o dia do banho e a quantidade de caes pequenos e grandes "
                });
            }

            var data = Convert.ToDateTime(dataDoBanho);
            
            var vaiRex = new VaiRex();
            var meuCaninoFeliz = new MeuCaninoFeliz();
            var chowChawgas = new ChowChawgas();

            // Calcula o valor total do banho
            vaiRex.CalcularValorBanho(data, caesPequenos, caesGrandes);
            meuCaninoFeliz.CalcularValorBanho(data, caesPequenos, caesGrandes);
            chowChawgas.CalcularValorBanho(data, caesPequenos, caesGrandes);

            Petshop melhorPetshop = Petshop.ComparaValores(vaiRex, meuCaninoFeliz, chowChawgas);

            return new JsonResult(new
            {
                nome = melhorPetshop.nome,
                valorTotal = melhorPetshop.valorTotal,
                distanciaEmKm = melhorPetshop.distanciaEmQuilometros
            });
        }
    }
}
