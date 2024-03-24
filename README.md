Projeto de desafio do Programa TEIA da Caixa Econômica Federal

Requisitos: 
1. Receber uma string no body da requisição.   
2. Implementar operações para manipular a string de acordo com as seguintes especificações:
- Verificar se a string é um palíndromo. 
- Contar o número de ocorrências de cada caractere na string.
3. Retornar uma resposta indicando o resultado de cada operação solicitada. 


Observações:
  Para a definição de palíndromos, foram descartados todos os caracteres que não são letras ou números e consideradas diferentes as letras acentuadas das suas equivalentes sem acento, portanto:
    "ana" e "subi no onibus" são considerados palíndromos enquanto "anã" e "subi no ônibus" não são considerados palíndromos.

    Outros exemplos de palíndromos: "111", "171", "subi no onibus"

  Já na contagem dos caracteres, todos foram considerados, incluindo espaços e caracteres especiais. Então para o texto "subi no onibus",
  o caractere de espaço também entrará na contagem, apesar de ter sido descartado ná análise de palíndromo.

  Caso seja passado um texto vazio, totalmente preenchido com caracteres de espaço ou nulo como parâmetro, ele não será considerado como palíndromo e a contagem de caracteres estará zerada.

  O endpoint apenas retornará uma exceção caso o parêmetro de requisição do método Post não contenha um JSON válido, dentro do foramato "{"Texto":"..."}.
  
