<h1> Documentação de teste técnico - .net core - Api rest </h1>

<h4> Como executar o código </h4>
<h6> # Abra a Solution e dê run*;
# Usando o navegador ou Postman, dê um get na url** https://localhost:44387/api/Petshop, passando os seguintes parâmetros:
  # dataDoBanho: Dia em que os cachorros serão levados para tomarem banho;
  # caesPequenos: Quantidade de caes pequenos;
  # caesGrande: Quantidade de caes grandes;
# Será retornado um Json contendo o nome do petshop com o melhor preço e a menor distância, o valor total do banho e a distância;</h6>

 <h4>Premissas assumidas </h4>
<h6># O projeto tem que ser desenvolvido em .Net Core 2.0 ou superior
# O projeto deve possuir documentação;
# Os métodos utilizados devem conter testes;
# Deve ser retornado um JSON;
# Os parametros serão informados na URL;
# O parametro 'dataDoBanho', deve estar em um dos seguintes formatos:
    # dd/mm/aa;
    # dd/mm/aaaa;
    # aa/mm/dd;
    # aaaa/mm/dd;
# O projeto tem que ser desenvolvido de forma que, caso precise adicionar mais petshops, tenha que ser realizadas poucas alterações no código;
</h6>

<h4> Decisões de projeto </h4>}
<h6> ** Observações
__# Infelizmente não sei fazer a publicação de uma publicação web ou web api__;

__** Os parâmetros devem ser passados via URL. Exemplo: https://localhost:44387/api/Petshop?dataDoBanho=16-07-2020&caesPequenos=2&caesGrandes=3 ;__  </h6>

  By Lucas Mendes

