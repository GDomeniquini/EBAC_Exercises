#language: pt-br

Funcionalidade: Tela de cadastro (Checkout)
Como cliente da EBAC-SHOP
Quero concluir meu cadastro
Para finalizar minha compra

Contexto: 
Dado que eu acesse a página de cadastro (Checkout) da EBAC-SHOP

Cenário: Cadastro com informações obrigatórias
Quando eu preencher todos com os campos obrigatórios
E os campos com asterisco
Então deve me direcionar para a página onde finalizo a compra

Cenário: Validar campo e-mail
Quando eu preencher todos os campos obrigatórios
E os campos com asterisco
E digitar o e-mail incorretamente
Então deve exibir uma mensagem de alerta "E-mail inválido."

Cenário: Validar campos preenchidos
Dado que eu acesse a página de cadastro (Checkout) da EBAC-SHOP
Quando eu não preencher algum campo
E os campos com asterisco
Então deve exibir uma mensagem de alerta "Preencher todos os campos com asterisco (*)."

Esquema de Cenário: Validar campo e-mail
Quando preencher todos os campos obrigatórios 
E os campos com asterisco
E digitar o <email> incorretamente 
Entao deve exibir uma <mensagem> de alerta "E-mail inválido."

Exemplos:
|e-mail             |mensagem          |
|"luizd@ebac.com.br"|"E-mail inválido."|
|"luizd.ebac.com"   |"E-mail inválido."|

Esquema de Cenário: Validar campos preenchidos
Quando eu não preencher algum campo
E os campos com <asterisco>
Entao deve exibir uma <mensagem> de alerta "Preencher todos os campos com asterisco (*)."

Exemplo: 
|asterisco |mensagem                                     |
|*         |"Preencher todos os campos com asterisco (*)" |


