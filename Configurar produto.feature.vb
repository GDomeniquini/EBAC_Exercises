#language: pt-br

Funcionalidade: Configurar produto
Como cliente da EBAC-SHOP
Quero configurar meu produto de acordo com meu tamanho e gosto
E escolher a quantidade
Para depois inserir no carrinho

Contexto: 
Dado que eu acesse a página de produtos EBAC-SHOP

Cenário: Escolher produto 
Quando eu selecionar o produto desejado
E selecionar o tamanho apropriado
E escolher a cor desejada
E adicionar uma quantidade <=10 de produtos
Então vou clicar no box "Comprar"

Cenário: Desfazer compra
Quando eu selecionar o produto desejado
E selecionar o tamanho apropriado
E escolher a cor desejada
E adicioner uma quantidade <=10 de produtos
E clicar no box "Limpar"
Então devo ser redirecionado a página de produtos 

Esquema de Cenário: Escolhendo produtos em tabela
Quando eu selecionar o <produto>
E selecionar o <tamanho>
E escolher a <cor>
E adicionar uma <quantidade<=10> 
Então devo clicar no <box>

Exemplos:
|produto |tamanho|cor    |quantidade|box|
|jaqueta |M      |azul   |2         |Comprar|
|calça   |S      |preto  |1         |Comprar|
|meias   |XS     |branco |10        |Comprar|
|camiseta|XL     |laranja|4         |Comprar|

Cenário: Adicionar quantidade de produtos
Dado que eu acesse a página de produtos 
|produto |tamanho|cor    |quantidade|mensagem|
|jaqueta |M      |azul   |11        |"Quantidade permitida de até 10 produtos!"|     
|calça   |S      |preto  |12        |"Quantidade permitida de até 10 produtos!"| 
|meias   |XS     |branco |13        |"Quantidade permitida de até 10 produtos!"| 
|camiseta|XL     |laranja|14        |"Quantidade permitida de até 10 produtos!"| 
Quando eu selecionar o <produto>
E selecionar o <tamanho>
E escolher a <cor>
E adicionar uma <quantidade >10> de produtos
Então o sistema deve exibir uma <mensagem> de alerta