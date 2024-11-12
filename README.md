# ControlePro
Trabalho interdiciplinar da Fatec São José do Rio Preto, para o curso de Analise e Desenvolvimento de Sistemas

## Sobre
O projeto trata-se de um software para gerenciamento de uma empresa. 

Todos os processos da empresa eram feitos manualmente com papel e caneta, por isso, carinhosamente apelidamos o projeto de ControlePro.

Neste repositorio encontra-se todo código fonte utilizado para criar o software. 
Encontram-se também o script SQL para criação do banco de dados e todos os materiais criados/utilizados durante todo o processo da analise e do desenvolvimento do sistema.

## Tecnologias Utilizadas
- Asp Net Core
- SQL Server

## Dependências
- .NET SDK > 8.0.301
- SQL Server > 2019

## Como Executar
- Execute o script ```controle_pro_db.sql``` do banco de dados no SQLServer
- Atualize a connection string encontrada no arquivo ```.\src\ControlePro\appsettings.json```
- Execute os seguintes comandos no diretório principal
```
cd .\src\ControlePro\
dotnet restore
dotnet run
```

## Integrantes
- Matheus Henrique Viudes
