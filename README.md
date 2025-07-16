# game-zinga
# 🧠 Boas Práticas com Git — Projeto Jogo Zinga 2D

Bem-vindas(os) ao repositório do nosso jogo! Para garantir que todos colaborem de forma organizada, siga essas instruções. 

---

## 🚀 Como clonar o projeto

### 🖥️ Usando GitHub Desktop

1. Baixe o [GitHub Desktop](https://desktop.github.com/).
2. Faça login com sua conta GitHub.
3. Clique em `File > Clone repository`.
4. Cole o link do repositório:
    https://github.com/equipe-game-cinema-nosso/game-zinga.git
5. Após clonar, clique no menu da branch e selecione `develop`.

---

### 💻 Usando o terminal

```bash
git clone https://github.com/equipe-game-cinema-nosso/game-zinga.git
cd game-zinga
git checkout develop

🧱 Criando uma branch para sua tarefa
No GitHub Desktop:

Antes de criar a branch garanta que ela esteja em develop

Clique em Current Branch > New Branch.

Nomeie como: feature/nome-da-tarefa
Exemplo : feature/movimentacao-personagem

Ou no terminal:

```bash
git checkout -b feature/nome-da-tarefa


✅ Fazendo alterações
Edite os arquivos no seu editor (VSCode, Unity, etc.).

Faça commit das mudanças:

No GitHub Desktop: Commit to feature/...

Ou no terminal:

```bash
git add .
git commit -m "feat: descrição da tarefa"

☁️ Enviando para o GitHub
No GitHub Desktop: clique em Push origin.

No terminal:

```bash
git push origin feature/nome-da-tarefa

🔁 Abrindo Pull Request
Acesse o repositório no GitHub.

Clique em Compare & pull request.

Verifique se está indo de feature/... para develop.

Escreva uma descrição e envie.

✍️ Padrão de coemtarios no commits
Use prefixos claros:

feat: nova funcionalidade

docs: documentação

refactor: melhoria no código

Exemplo:

```bash
git commit -m "feat: adiciona movimentação do personagem"

⚠️ Regras rápidas e importantes
Trabalhe na develop, não na main.

Verifique sempre se está em develop antes de criar a branch

Cada tarefa deve ter uma branch feature/....

Faça um pull sempre antes de commitar e dar push na sua branch:
```bash
git pull origin develop

Sempre faça Pull Request ao finalizar.

E Vambora criar esse jogo juntos! 🚀🎮

