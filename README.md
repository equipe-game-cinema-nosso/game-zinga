# 🧠 Boas Práticas com Git — Projeto Jogo Código do invisivel 2D

Bem-vindas(os) ao repositório do nosso jogo! Para garantir que todos colaborem de forma organizada, siga essas instruções. 

---

## 🚀 Como clonar o projeto

### 🖥️ Usando GitHub Desktop

1. Baixe o [GitHub Desktop](https://desktop.github.com/).
2. Faça login com sua conta GitHub.
3. Clique em `File > Clone repository`.
4. Cole o link do repositório:
```

https://github.com/equipe-game-cinema-nosso/game-zinga.git

````
5. Após clonar, clique no menu da branch e selecione `develop`.

---

### 💻 Usando o terminal

```bash
git clone https://github.com/equipe-game-cinema-nosso/game-zinga.git
cd game-zinga
git checkout develop
````

---

## 🧱 Criando uma branch para sua tarefa

### GitHub Desktop

> Antes de criar a branch, garanta que você está em `develop`.

* Clique em `Current Branch > New Branch`
* Nomeie como: `feature/nome-da-tarefa`
  Exemplo: `feature/movimentacao-personagem`

### Terminal

```bash
git checkout develop
git pull origin develop
git checkout -b feature/nome-da-tarefa
```

---

## ✅ Fazendo alterações

Edite os arquivos no seu editor (VSCode, Unity, etc.).

### GitHub Desktop

* Faça commit em: `Commit to feature/...`

### Terminal

```bash
git add .
git commit -m "feat: descrição da tarefa"
```

---

## ☁️ Enviando para o GitHub

### GitHub Desktop

Clique em `Push origin`.

### Terminal

```bash
git push origin feature/nome-da-tarefa
```

---

## 🔁 Abrindo Pull Request

1. Acesse o repositório no GitHub.
2. Clique em **Compare & pull request**.
3. Verifique se está indo de `feature/...` para `develop`.
4. Escreva uma descrição e envie.

---

## ✍️ Padrão de comentários nos commits

Use prefixos claros:

* `feat:` nova funcionalidade
* `fix:` correção de bug
* `docs:` documentação
* `refactor:` melhoria no código

**Exemplo:**

```bash
git commit -m "feat: adiciona movimentação do personagem"
```

---

## ⚠️ Regras rápidas e importantes

* Trabalhe na `develop`, **nunca direto na `main`**.
* Verifique sempre se está em `develop` antes de criar a branch.
* Cada tarefa deve ter sua própria branch `feature/...`.
* Sempre atualize sua branch com:

```bash
git pull origin develop
```

* Sempre faça **Pull Request** ao finalizar.

---

E vambora criar esse jogo juntos! 🚀🎮

```
