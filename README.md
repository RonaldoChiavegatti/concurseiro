# Concurseiro

Concurseiro é uma plataforma em .NET 8 desenhada para apoiar concurseiros na organização das rotinas de estudo, no acompanhamento de desempenho e no consumo de conteúdos preparatórios. Este repositório contém o esqueleto arquitetural criado no pull request anterior, que estabelece as camadas, entidades de domínio e um primeiro fluxo de busca de questões para evoluções futuras.

## Visão geral da solução

A solução (`Concurseiro.sln`) está dividida em quatro projetos principais que implementam uma arquitetura em camadas:

| Projeto | Responsabilidade principal |
| ------- | -------------------------- |
| `Concurseiro.Domain` | Modelagem das entidades centrais (usuários, provas, sessões de estudo, conteúdos, questões, metas) e contratos de repositórios. |
| `Concurseiro.Application` | Serviços de aplicação e DTOs que orquestram casos de uso a partir dos repositórios. |
| `Concurseiro.Infrastructure` | Configuração do `AppDbContext`, implementação de repositórios com EF Core e dependências de persistência/identity. |
| `Concurseiro.Api` | API ASP.NET Core (net8.0) com autenticação JWT, controllers e configuração geral do host. |

Esse esqueleto já configura autenticação via `Identity` e `JwtBearer`, expõe um endpoint de saúde (`/health`) e inclui suporte ao Swagger para inspeção manual da API durante o desenvolvimento.

## Domínio modelado

As entidades de domínio representam os principais blocos de informação da plataforma:

* Usuários: `ApplicationUser` estende `IdentityUser<Guid>` e mantém dados adicionais, como nome completo e vínculo com o perfil diagnóstico (`UserProfile`).
* Planejamento: `StudyPlan`, `StudySession`, `UserGoal` e `ExamSchedule` descrevem planos de estudo, sessões diárias, metas e agenda de provas para cada usuário.
* Conteúdo e questões: `Content`, `Question`, `Bank`, `Subject`, `Topic` e `UserQuestionResult` estruturam o catálogo de materiais, o banco de questões e o histórico de respostas dos estudantes.
* Diagnóstico e onboarding: `UserProfile` reúne os dados coletados durante o onboarding (área de interesse, carga horária, autoavaliação) que serão usados na geração de trilhas personalizadas.

O `AppDbContext` declara `DbSet<>` para todas as entidades e aplica validações básicas (como limites de tamanho e chave primária explícita para o perfil do usuário), oferecendo um ponto de partida para evoluções de persistência.

## Camada de aplicação

A camada de aplicação expõe DTOs simples e serviços focados em casos de uso. O exemplo inicial é o fluxo de consulta de questões:

* `QuestionFilterDto` centraliza os filtros (banca, disciplina, tópico, nível, tipo) e paginação.
* `QuestionAppService` consulta o repositório, aplica o filtro e retorna um `PagedResult` anônimo pronto para exposição via API.

Esse serviço utiliza a abstração `IQuestionRepository`, definida no domínio, que por sua vez já possui uma implementação em `QuestionRepository` usando Entity Framework Core.

## API REST inicial

A API inclui um controller de questões com endpoint `GET /api/questions` que aceita os filtros definidos no DTO e devolve os resultados paginados. O projeto também registra autenticação JWT, políticas de autorização e Swagger, permitindo evolução incremental sem necessidade de reestruturação futura.

## Como executar

1. Configure uma instância PostgreSQL e ajuste a connection string `Default` em `appsettings.Development.json`.
2. Aplique migrations (ainda não geradas) com `dotnet ef migrations add InitialCreate` seguido de `dotnet ef database update` quando os modelos estiverem prontos.
3. Execute a API com:
   ```bash
   dotnet run --project src/Concurseiro.Api
   ```
4. Acesse `https://localhost:5001/swagger` (ou a porta configurada) para testar os endpoints.

Para rodar a suíte de testes (ainda vazia), utilize:
```bash
dotnet test
```

## Próximos passos

O arquivo [`docs/BacklogChecklist.md`](docs/BacklogChecklist.md) apresenta uma checklist completa baseada no backlog fornecido pelo produto. Ele deve ser usado para acompanhar a implementação das histórias nas próximas sprints.
