#language: pt-br

Funcionalidade: Login na plataforma
Como cliente da EBAC-SHOP
Quero fazer login (autenticação) na plataforma
Para visualizar meus pedidos

Contexto: 
Dado que eu acesse a página de autenticação da plataforma da EBAC-SHOP

Cenário: Autenticação válida
Quando eu digitar o usuário "luizd@ebac.com.br"
E inserir a senha "123mudar"
Então deve direcionar para a página de checkout

Cenário: Usuário inválido
Quando eu digitar o usuário "luiz@ebac.com.br"
E inserir a senha "123mudar"
Então deve exibir uma mensagem de alerta "Usuário ou senha inválidos"

Cenário: Senha inválida
Quando eu digitar o usuário "luizd@ebac.com.br"
E inserir a senha "mudar"
Então deve exibir uma mensagem de alerta "Usuário ou senha inválidos"

Esquema de Cenário: Autenticar diversos usuários
Quando eu digitar o <usuário> 
E inserir a <senha>
Então deve exibir a <mensagem> de alerta

Exemplos:
|usuário            |senha     |mensagem                    |
|"luizd@ebac.com.br"|"12mudar" |"Usuário ou senha inválidos"|
|"luizd@ebac.com"   |"123mudar"|"Usuário ou senha inválidos"|
|"luizd@ebac.com.br"|"123"     |"Usuário ou senha inválidos"|
|"luizd2ebac.com.br"|"123mudar"|"Usuário ou senha inválidos"|






