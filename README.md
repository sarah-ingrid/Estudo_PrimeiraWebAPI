# 📦 PrimeiraAPI - API REST com C#, MySQL e JWT

API criada como projeto de aprendizado utilizando ASP.NET Core, Entity Framework, autenticação com JWT e integração com MySQL. Permite gerenciar funcionários, fazer upload de arquivos e visualizar dados de forma segura.
<br/> <br/>


## ✅ Funcionalidades

► Autenticação com JWT (/api/v1/auth) <br/>
► Cadastro de funcionário com imagem (/api/v1/employee) <br/>
► Download de imagem do funcionário (/api/v1/employee/{id}/download) <br/>
► Consulta de dados públicos de funcionário via DTO <br/>
► Integração com banco de dados MySQL usando Entity Framework <br/>
► Criação de tabelas via Migrations <br/>
► Armazenamento de arquivos local com serviço de Storage <br/>
► Swagger para testes e documentação da API <br/>
► AutoMapper para transformar entidades em DTOs <br/>
► Paginação e logger implementados <br/>

<br/> <br/>
<img width="1900" height="887" alt="api1" src="https://github.com/user-attachments/assets/0828ebef-ab23-4d29-81c8-5fd32178663b" />
<br/> <br/>



 ## Tecnologias e Conceitos utilizados:
 - ASP.NET Core 8
 - Entity Framework Core
 - MySQL
 - AutoMapper
 - DTOs
 - JWT (Json Web Token)
 - Storage local para as imagens
 - Swagger UI
 - Paginação
 - Logging
 - Migrations
<br/> <br/>

---
<!--
## 🔐 Como gerar o Token
Endpoint: AUTH - POST /api/v1/auth

"username": "admin", <br/>
"password": "123456" <br/>

 O retorno será um token JWT que deve ser usado no botão "Authorize" do Swagger colocando "Bearer + token" para acessar os endpoints protegidos.
 
--- -->

Melhorias futuras para continuar os estudos: <br/>
🔴 CRUD completo <br/>
🔴 Adicionar endpoints GET e POST para Company <br/>
🔴 Aprender a publicar a API publicamente <br/>
🔴 Relacionamento entre Company e Employee <br/>
🔴 Substituir Storage local por nuvem AWS <br/>
