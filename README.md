# Sistema de CRUD de Clientes em C#

Este repositório contém um sistema simples de CRUD (Create, Read, Update, Delete) para gerenciamento de clientes utilizando C# com Windows Forms e MySQL.

## Tecnologias Utilizadas
- **C#** (Windows Forms)
- **MySQL** (banco de dados relacional)
- **Biblioteca MySql.Data** (para interações com o banco)

## Funcionalidades do Sistema
O sistema permite realizar as seguintes operações:

1. **Cadastro de Clientes:**
   - O usuário pode cadastrar um novo cliente informando nome, e-mail, CPF e endereço.
   - Verificação da unicidade do CPF para evitar registros duplicados.
   - Validação de dados, como formato de e-mail e caracteres especiais no nome.

2. **Pesquisa de Clientes:**
   - Pesquisa pelo CPF.
   - Exibição das informações do cliente caso encontrado.

3. **Atualização de Dados:**
   - Permite a atualização de e-mail e endereço de clientes cadastrados.
   - Nome e CPF não podem ser alterados após o registro.

4. **Exclusão de Clientes:**
   - Remoção de clientes do banco de dados a partir do ID informado.

## Estrutura do Projeto

- **BaseConnect.cs:** Responsável pela configuração da string de conexão com o banco de dados.
- **Form1.cs:** Contém a interface e a lógica dos botões de cadastro, pesquisa, atualização e exclusão.
- **CustomerRegister.cs:** Classe de modelo que lida com operações do banco de dados, como inserção, busca, atualização e exclusão.

## Pré-requisitos para Execução

1. Instalar o [MySQL Server](https://dev.mysql.com/downloads/installer/).
2. Criar um banco de dados chamado `db-crud-csharp` com a tabela `clientes`.
3. Configurar as credenciais de conexão no arquivo `BaseConnect.cs`.
4. Ter o .NET Framework instalado em sua máquina.

## Como Rodar o Projeto

1. Abra o projeto no Visual Studio.
2. Compile e execute a aplicação.
