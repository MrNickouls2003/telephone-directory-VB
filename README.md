# Lista de Contatos em Visual Basic com Conexão ao PostgreSQL

Este projeto é uma aplicação de lista de contatos desenvolvida em **Visual Basic (VB.NET)** que se conecta ao banco de dados **PostgreSQL** para armazenar, gerenciar e manipular informações de contatos. O sistema oferece funcionalidades completas de CRUD (Create, Read, Update, Delete) para gerenciar contatos, como adicionar, editar, excluir e visualizar dados.

## Funcionalidades

- **Adicionar Contato**: Permite ao usuário inserir um novo contato na base de dados.
- **Editar Contato**: Permite ao usuário atualizar as informações de um contato existente (nome, telefone, e-mail e endereço).
- **Excluir Contato**: Remove um contato da base de dados.
- **Listar Contatos**: Exibe todos os contatos registrados.
- **Pesquisar Contato**: Permite ao usuário buscar um contato pelo nome.

## Estrutura da Base de Dados

O banco de dados utilizado é o **PostgreSQL**, e contém uma tabela chamada `contatos` com os seguintes campos:

- `id`: Chave primária, auto-incremento.
- `nome`: Armazena o nome do contato (texto).
- `telefone`: Armazena o número de telefone (texto).
- `email`: Armazena o e-mail do contato (texto).
- `endereco`: Armazena o endereço do contato (texto).

## Tecnologias Utilizadas

- **Visual Basic (VB.NET)**: Linguagem de programação usada para criar a aplicação.
- **PostgreSQL**: Banco de dados relacional onde os contatos são armazenados.
- **Npgsql**: Biblioteca para conectar o Visual Basic ao PostgreSQL.

## Configuração do Ambiente

### Pré-requisitos

- **PostgreSQL** instalado e em execução no seu ambiente.
- **Npgsql**: Biblioteca .NET para PostgreSQL. Pode ser instalada através do NuGet no Visual Studio.

### Configuração da Conexão com PostgreSQL

No código, a string de conexão com o banco de dados PostgreSQL deve ser configurada corretamente com as credenciais do seu ambiente:

```vb
Dim connString As String = "Host=localhost;Port=5432;Username=seu_usuario;Password=sua_senha;Database=contatosdb"
