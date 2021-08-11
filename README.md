# C# Studies Notebook

## Design Patterns I

- **[Strategy](https://github.com/luizoux/c-sharp-studies/tree/main/DesignPatternsI/Strategy):** 

Neste projeto, encapsulamos o comportamento do cálculo do imposto em classes separadas para ICMS e ISS e usamos a interface `Tax` para definir qual taxa de imposto utilizar. Dessa forma, eliminamos os condicionais com polimorfismo e com o padrão Strategy fazendo com o que o método de cálculo fique flexível a receber outras classes com outras tipos de imposto. Resaltando: repare que não e preciso alterar o código para incluir um novo tipo de imposto, é preciso apenas criar uma nova classe.

Nos diferentes tipos de padrões, é possível utilizar a orientação a objetos de uma maneira que simplifique o código escrito diminuindo no futuro os custo com a manutenção do projeto. Um padrão de projeto é uma implementação e/ou uma ideia para resolver alguns problemas no código.

> O mais importante ao estudar padrões de projeto é entender qual a real motivação do padrão, e quando ele deve ser aplicado. As implementações são menos importantes, pois eles podem variar. O importante é resolver o problema de maneira elegante, usando a ideia por trás do padrão como um guia na implementação. Uma afirmação muito comum sobre padrões de projeto é que você os aplica mil vezes, e as mil vezes você termina com uma implementação diferente do mesmo padrão. *- Alura*