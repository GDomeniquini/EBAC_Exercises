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

Cenário: Adicionar quantidade de produtos 
Quando eu selecionar o produto desejado
E selecionar o tamanho apropriado
E escolher a cor desejada
E adicionar uma quantidade de produtos maior que 10
Então o sistema deve exibir uma mensagem de alerta "Limite de produtos excedido."

Esquema de Cenário: Escolhendo múltiplos produtos
Quando eu selecionar o <produto>
E selecionar o <tamanho>
E escolher a <cor>
E adicionar uma <quantidade> de produtos 
Então devo clicar no <box>

Exemplos:
|produto |tamanho|cor    |quantidade|box    |                
|jaqueta |M      |azul   |2         |Comprar|                              
|calça   |S      |preto  |1         |Comprar|                              
|meias   |XS     |branco |11        |Comprar|
|camiseta|XL     |laranja|20        |Comprar|

Esquema de Cenário: Escolhendo múltiplos produtos
Quando eu selecionar o <produto>
E selecionar o <tamanho>
E escolher a <cor>
E adicionar uma <quantidade> de produtos 
Então deve exibir uma <mensagem> de alerta "Limite de produtos excedido."

Exemplos:
|produto |tamanho|cor    |quantidade|mensagem                      |                
|jaqueta |M      |azul   |15        |"Limite de produtos excedido."|
|calça   |S      |preto  |17        |"Limite de produtos excedido."|
|meias   |XS     |branco |11        |"Limite de produtos excedido."|
|camiseta|XL     |laranja|20        |"Limite de produtos excedido."|
