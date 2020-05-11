# SquadRegisterApi

#### Api de aplicação responsavel por cadastro de Squads e Membros participantes dessas Squads
##### Repositório do front desse projeto: squad-front
##### Versão do projeto: 0.1.0

## Instalando o projeto

- Instalar o .Net Core 3.1

- Instalar Microsoft.EntityFrameworkCore.Design com o comenado:

`dotnet add package Microsoft.EntityFrameworkCore.Design`

- Instalar Npgsql.EntityFrameworkCore.PostgreSQL com o comando:

`dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 3.1.3`

- Instalar o docker

- Baixar uma imagem Docker de um banco de dados PostgreSQL

`docker run -itd -e POSTGRES_PASSWORD=squadpass -p 5432:5432 postgres`

- Rodar scripts do arquivo *create scripts.sql* presente nesse repositório

- Rodar comando

`dotnet restore`

- Iniciar Api com o comando

`dotnet run`
