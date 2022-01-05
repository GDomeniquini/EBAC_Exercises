#language: pt-br

Funcionalidade: Tela de cadastro (Checkout)
Como cliente da EBAC-SHOP
Quero concluir meu cadastro
Para finalizar minha compra

Contexto: 
Dado que eu acesse a página de cadastro (Checkout) da EBAC-SHOP

Cenário: Autenticação válida 
Quando eu digitar os dados "Gabriela" / "Domeniquini"
E digitar o país "Brasil"
E digitar o endereço "Rua Dom Bento Pickel"
E digitar a cidade "São Paulo"
E digitar o CEP "02544-000"
E digitar o nº "(11)98295-2009"
E digitar o usuário "gabivitalinodomeniquini@outlook.com"
Então devo ser direcionado a página para finalizar a compra 


Cenário: Campo nome / sobrenome incompletos
Quando eu digitar os dados "-" / "-"
E digitar o país "Brasil"
E digitar o endereço "Rua Dom Bento Pickel"
E digitar a cidade "São Paulo"
E digitar o CEP "02544-000"
E digitar o nº "(11)98295-2009"
E digitar o usuário "gabivitalinodomeniquini@outlook.com"
Então deve exibir uma mensagem de erro "Cadastro incompleto. Favor preencher o (s) campo (s) vazio (s)."

Cenário: Campo país incompleto
Quando eu digitar os dados "Gabriela" / "Domeniquini"
E digitar o país "-"
E digitar o endereço "Rua Dom Bento Pickel"
E digitar a cidade "São Paulo"
E digitar o CEP "02544-000"
E digitar o nº "(11)98295-2009"
E digitar o usuário "gabivitalinodomeniquini@outlook.com"
Então deve exibir uma mensagem de erro "Cadastro incompleto. Favor preencher o (s) campo (s) vazio (s)."

Cenário: Campo endereço incompleto
Quando eu digitar os dados "Gabriela" / "Domeniquini"
E digitar o país "Brasil"
E digitar o endereço "-"
E digitar a cidade "São Paulo"
E digitar o CEP "02544-000"
E digitar o nº "(11)98295-2009"
E digitar o usuário "gabivitalinodomeniquini@outlook.com"
Então deve exibir uma mensagem de erro "Cadastro incompleto. Favor preencher o (s) campo (s) vazio (s)."

Cenário: Campo cidade incompleto
Quando eu digitar os dados "Gabriela" / "Domeniquini"
E digitar o país "Brasil"
E digitar o endereço "Rua Dom Bento Pickel"
E digitar a cidade "-"
E digitar o CEP "02544-000"
E digitar o nº "(11)98295-2009"
E digitar o usuário "gabivitalinodomeniquini@outlook.com"
Então deve exibir uma mensagem de erro "Cadastro incompleto. Favor preencher o (s) campo (s) vazio (s)."

Cenário: Campo CEP incompleto
Quando eu digitar os dados "Gabriela" / "Domeniquini"
E digitar o país "Brasil"
E digitar o endereço "Rua Dom Bento Pickel"
E digitar a cidade "São Paulo"
E digitar o CEP "-"
E digitar o nº telefone "(11)98295-2009"
E digitar o usuário "gabivitalinodomeniquini@outlook.com"
Então deve exibir uma mensagem de erro "Cadastro incompleto. Favor preencher o (s) campo (s) vazio (s)."

Cenário: Campo nº telefone incompleto
Quando eu digitar os dados "Gabriela" / "Domeniquini"
E digitar o país "Brasil"
E digitar o endereço "Rua Dom Bento Pickel"
E digitar a cidade "São Paulo"
E digitar o CEP "02544-000"
E digitar o nº telefone "-"
E digitar o e-mail "gabivitalinodomeniquini@outlook.com"
Então deve exibir uma mensagem de erro "Cadastro incompleto. Favor preencher o (s) campo (s) vazio (s)."

Cenário: Campo e-mail incompleto
Quando eu digitar os dados "Gabriela" / "Domeniquini"
E digitar o país "Brasil"
E digitar o endereço "Rua Dom Bento Pickel"
E digitar a cidade "São Paulo"
E digitar o CEP "02544-000"
E digitar o nº "(11)98295-2009"
E digitar o usuário "-"
Então deve exibir uma mensagem de erro "Cadastro inválido. Favor preencher o (s) campo (s) corretamente."

Esquema de Cenário: Autenticar diversos dados
Quando eu digitar os dados <nome> / <sobrenome>
E digitar o <país>
E digitar o <endereço>
E digitar a <cidade>
E digitar o <CEP>
E digitar o <nº telefone>
E digitar o <usuário>
Então deve exibir uma <mensagem> de erro

Exemplos:
|campo         |informação              |mensagem
|nome/sobrenome|Gabriela/D              |"Cadastro inválido. Favor preencher o (s) campos (s) corretamente."|
|país          |-                       |"Cadastro inválido. Favor preencher o (s) campos (s) corretamente."|
|CEP           |02430-091               |"Cadastro inválido. Favor preencher o (s) campos (s) corretamente."|
|e-mail        |jw.domeniquini@gmail.com|"Cadastro inválido. Favor preencher o (s) campos (s) corretamente."|                                                                   |

Cenário: Usuário inexistente
Dado que eu acesse a página de cadastro (Checkout) da EBAC-SHOP
|usuário                                 |mensagem             |
|"gabivitalinodominiquini@outlook.com"   |"Usuário inexistente"|
|"gabivitalinodomeniquini@outlook.com.br"|"Usuário inexistente"|
|"gabivitalino@outlook.com"              |"Usuário inexistente"|
|"gabidomeniquini@outlook.com"           |"Usuário inexistente"|
Quando eu digitar o <usuário>
Então deve exibir uma <mensagem> de erro
