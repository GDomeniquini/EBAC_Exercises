#language: pt-br

Funcionalidade: Login na plataforma
Como cliente da EBAC-SHOP
Quero fazer login (autenticação) na plataforma
Para visualizar meus pedidos

Contexto: 
Dado que eu acesse a página de autenticação da plataforma da EBAC-SHOP

Cenário: Autenticação válida
Quando eu digitar o usuário "luizd@ebac.com.br"
E inserir a senha "123teste"
Então deve me direcionar para a página de checkout

Cenário: Autenticação inválida
Quando eu digitar o usuário "luizd@ebac.com"
E inserir a senha "123test"
Então deve exibir uma mensagem de alerta "E-mail ou senha inválidos."

Esquema de Cenário: Autenticar diversos usuários
Quando eu digitar o <usuário> 
E inserir a <senha>
Então deve me direcionar para a página de checkout

Exemplos:
|usuário            |senha      |
|"luizd@ebac.com"   |"123teste" |
|"luizd1@ebac.com"  |"123teste" |
|"luizd2@ebac.com"  |"123teste" |
|"luizd3ebac.com"   |"123teste" |

Esquema de Cenário: Autenticar diversos usuários
Quando eu digitar o <usuário>
E inserir a <senha>
Então deve exibir uma <mensagem> de alerta "E-mail ou senha inválidos."

Exemplos:
|usuário|           |senha     |mensagem                    |
|"luizd@ebac.com.br"|"123test" |"E-mail ou senha inválidos."|
|"luiz1@ebac.com"   |"123teste"|"E-mail ou senha inválidos."|
|"luizd2@eba.com.br"|"teste123"|"E-mail ou senha inválidos."|
|"luizd3.ebac.com"  |"teste321"|"E-mail ou senha inválidos."|






