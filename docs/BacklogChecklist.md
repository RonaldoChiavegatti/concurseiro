# Checklist de desenvolvimento

Este documento acompanha o progresso das histórias do produto Concurseiro. Cada história traz os critérios de aceite como subitens para facilitar o acompanhamento granular durante as sprints.

## Épico 1 – Autenticação e contas de usuário

- [ ] **História 1.1 – Cadastro de usuário**
  - [ ] Permitir cadastro de nome, e-mail e senha.
  - [ ] Validar força mínima da senha.
  - [ ] Garantir e-mail único.
  - [ ] Armazenar senha com hash seguro.
  - [ ] Logar ou redirecionar para login após cadastro.
- [ ] **História 1.2 – Login**
  - [ ] Autenticar usuário com e-mail e senha.
  - [ ] Retornar token JWT ao sucesso.
  - [ ] Exibir mensagem clara em caso de erro.
  - [ ] Expirar sessão por inatividade ou validade do token.
- [ ] **História 1.3 – Logout**
  - [ ] Limpar token/localStorage ao sair.
  - [ ] Redirecionar para tela de login.
- [ ] **História 1.4 – Perfil básico do usuário**
  - [ ] Exibir nome, e-mail e avatar.
  - [ ] Editar nome e foto.
  - [ ] Manter política de alteração de e-mail com confirmação.

## Épico 2 – Onboarding e diagnóstico

- [ ] **História 2.1 – Formulário de perfil de concurseiro**
  - [ ] Capturar tipo de concurso, bancas, carga horária, tempo até prova e autoavaliação.
  - [ ] Persistir dados vinculados ao usuário.
  - [ ] Permitir edição posterior em "Configurações de estudo".
- [ ] **História 2.2 – Teste diagnóstico opcional**
  - [ ] Selecionar conjunto de 10–20 questões básicas.
  - [ ] Exibir barra de progresso.
  - [ ] Armazenar taxa de acerto por disciplina.
  - [ ] Usar dados na priorização do estudo.
- [ ] **História 2.3 – Geração automática de trilha inicial**
  - [ ] Considerar carga horária, prazo, tipo de concurso, autoavaliação e diagnóstico.
  - [ ] Criar `StudyPlan` com `StudySessions` distribuídas.
  - [ ] Mostrar explicação de como a trilha foi montada.
  - [ ] Destacar o que estudar hoje no dashboard.

## Épico 3 – Trilhas de estudo (StudyPlan)

- [ ] **História 3.1 – Visualizar trilha de estudos**
  - [ ] Listar `StudySessions` com data, disciplina, tipo e status.
  - [ ] Permitir filtro por semana ou disciplina.
  - [ ] Exibir status (pendente, em andamento, concluída).
- [ ] **História 3.2 – Marcar sessão como concluída**
  - [ ] Disponibilizar botão "Concluir".
  - [ ] Atualizar status e data/hora de conclusão.
  - [ ] Atualizar progresso de metas semanais.
- [ ] **História 3.3 – Personalizar trilha (ajustes básicos)**
  - [ ] Alterar data da sessão.
  - [ ] Ajustar duração planejada.
  - [ ] Excluir sessão.
  - [ ] Criar sessão manualmente.
- [ ] **História 3.4 – Destacar conteúdos "chave"**
  - [ ] Permitir marcar tópicos/aulas como chave.
  - [ ] Destacar visualmente sessões ligadas a conteúdos chave.

## Épico 4 – Banco de questões e resolução

- [ ] **História 4.1 – Filtro de questões**
  - [ ] Filtrar por banca, disciplina, assunto, nível e tipo.
  - [ ] Exibir listagem paginada com enunciado e alternativas.
- [ ] **História 4.2 – Resolver questões em modo estudo**
  - [ ] Feedback imediato de acerto/erro.
  - [ ] Exibir gabarito e comentário.
  - [ ] Registrar resposta, acerto e tempo gasto.
- [ ] **História 4.3 – Histórico de desempenho por disciplina**
  - [ ] Mostrar taxa de acerto por disciplina.
  - [ ] Mostrar taxa de acerto por assunto.
  - [ ] Exibir gráfico (barra ou pizza) com porcentagem.
- [ ] **História 4.4 – Lista de questões erradas**
  - [ ] Listar questões respondidas incorretamente.
  - [ ] Permitir re-responder em modo revisão.

## Épico 5 – Agenda de provas e metas

- [ ] **História 5.1 – Cadastro de provas futuras**
  - [ ] Cadastrar concurso, banca, cargo e data.
  - [ ] Associar prova a um `StudyPlan` existente.
  - [ ] Exibir prova na agenda/calendário.
- [ ] **História 5.2 – Agenda / calendário de estudos**
  - [ ] Visualização mensal ou semanal.
  - [ ] Mostrar sessões de estudo por dia.
  - [ ] Destacar provas cadastradas.
- [ ] **História 5.3 – Metas semanais de estudo**
  - [ ] Definir metas (horas ou questões) com valor semanal.
  - [ ] Atualizar progresso conforme sessões/questões concluídas.
  - [ ] Exibir barra de progresso no dashboard.

## Épico 6 – Conteúdos (apostilas e vídeo aulas)

- [ ] **História 6.1 – Catálogo de conteúdos**
  - [ ] Listar conteúdos com filtros por disciplina, assunto e tipo.
  - [ ] Exibir título, tipo, duração (vídeo) e nível.
- [ ] **História 6.2 – Marcar conteúdo como concluído**
  - [ ] Disponibilizar ação "Marcar como concluído".
  - [ ] Atualizar status do conteúdo.
  - [ ] Refletir conclusão em sessões vinculadas.
- [ ] **História 6.3 – Favoritar conteúdo**
  - [ ] Permitir favoritar conteúdos.
  - [ ] Listar conteúdos favoritos em área dedicada.

## Épico 7 – Dashboard e feedback visual

- [ ] **História 7.1 – Dashboard inicial**
  - [ ] Card "O que estudar hoje".
  - [ ] Card "Próxima prova".
  - [ ] Card com progresso das metas da semana.
- [ ] **História 7.2 – Resumo de desempenho**
  - [ ] Contabilizar questões resolvidas na semana.
  - [ ] Exibir taxa de acerto geral e por disciplina.
  - [ ] Indicar dias consecutivos estudando.

## Épico 8 – Administração (conteúdo e questões)

- [ ] **História 8.1 – CRUD de disciplinas e assuntos**
  - [ ] CRUD completo de `Subject`.
  - [ ] CRUD completo de `Topic`.
- [ ] **História 8.2 – CRUD de questões**
  - [ ] Formulário de criação com metadados, alternativas, gabarito e comentário.
  - [ ] Listagem com filtros e paginação.
  - [ ] Edição ou desativação de questões.
- [ ] **História 8.3 – CRUD de conteúdos**
  - [ ] Upload de PDF ou cadastro de URL de vídeo.
  - [ ] Associação a disciplina/assunto e nível.

## Épico 9 – UX/UI e visual

- [ ] **História 9.1 – Tema visual "estudo focado"**
  - [ ] Definir paleta suave com destaques em botões.
  - [ ] Garantir tipografia legível e hierarquia clara.
  - [ ] Assegurar consistência de espaçamentos e componentes.
- [ ] **História 9.2 – Modo escuro**
  - [ ] Disponibilizar toggle claro/escuro.
  - [ ] Ajustar paleta respeitando contraste e legibilidade.
