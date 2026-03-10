## PROJETO - API HEXADECIMAL

API desenvolvida em **ASP.NET Core** para gerenciamento de estudantes utilizando o padrão de arquitetura **Ports and Adapters (Arquitetura Hexagonal)**.

O objetivo do projeto é demonstrar uma **separação clara entre as regras de negócio da aplicação e as tecnologias externas**, facilitando manutenção, testes e evolução do sistema.

**🚀 Tecnologias Utilizadas**

- ASP.NET Core

- C#

- Arquitetura Hexagonal (Ports and Adapters)

- Dependency Injection

REST API
---

## 📌 Arquitetura Utilizada

O projeto segue o padrão **Arquitetura Hexagonal**, também conhecido como **Ports and Adapters**, onde:

- O **Domain** contém as regras centrais da aplicação.
- A **Application** coordena os casos de uso.
- A **Infrastructure** implementa o acesso a dados.
- A **API** expõe os endpoints HTTP.

Essa separação permite trocar tecnologias externas (banco de dados, APIs, etc.) **sem alterar as regras de negócio**.

---

# 📂 Estrutura do Projeto
Alunos

Domain
├─ Enties
│ └─ Aluno.cs
└─ Interfaces
└─ IAlunoRepository.cs

Application
└─ Services
└─ AlunoService.cs

Infrastructure
└─ Repositories
└─ AlunoRepository.cs

API
└─ Controllers
└─ AlunoController.cs

---

# 🧩 Camadas da Aplicação

## Domain

Contém os **elementos centrais da aplicação** e não depende de nenhuma tecnologia externa.

**Aluno**

Entidade que representa um estudante no sistema.

**IAlunoRepository**

Interface que define os métodos de acesso aos dados, permitindo que diferentes implementações sejam utilizadas sem impactar o domínio.

---

## Application

Responsável pela **lógica de negócio da aplicação**.

**AlunoService**

Implementa os casos de uso e aplica as regras de negócio antes de salvar ou consultar informações.

---

## Infrastructure

Camada responsável pelas **implementações concretas de acesso aos dados**.

**AlunoRepository**

Implementação do repositório utilizando uma **lista em memória**, simulando um banco de dados.

---

## API

Responsável por **expor os endpoints HTTP da aplicação**.

**AlunoController**

Recebe requisições HTTP e delega o processamento para os serviços da camada de Application.

---

# 📌 Regras de Negócio

As validações são implementadas no método **Enroll** da classe `StudentService`.

As seguintes regras são aplicadas:

- O campo **Name** não pode ser nulo ou vazio.
- O campo **Name** deve possuir **no máximo 50 caracteres**.
- O **email deve terminar com `@faculdade.edu`**.
- O **email deve ser único**, não podendo existir outro estudante com o mesmo endereço.

---

# ⚙️ Injeção de Dependência

As dependências são registradas no arquivo **Program.cs**, utilizando o sistema de **Dependency Injection** do ASP.NET Core.

```csharp
builder.Services.AddScoped<AlunoService>();
builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();

---
