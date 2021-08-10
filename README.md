# C# Studies Notebook

## Design Patterns I

- **Strategy:** neste projeto, encapsulamos o comportamento do cálculo do imposto em classes separadas para ICMS e ISS e usamos a interface `Tax` para definir qual taxa de imposto utilizar. Dessa forma, eliminamos os condicionais com polimorfismo e com o padrão Strategy fazendo com o que o método de cálculo fique flexível a receber outras classes com outras tipos de imposto. Resaltando: repare que não e preciso alterar o código para incluir um novo tipo de imposto, é preciso apenas criar uma nova classe.