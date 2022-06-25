## 1. Configuração local

### 1.1. Adicionando identificação
1. Abra o Git Bash
2. Defina um nome de usuário do Git: 
```
$ git config --global user.name "Fulano de Tal"

```
3. Confirme que você configurou o nome de usuário corretamente no Git:
```
$ git config --global user.name
> Fulano de Tal
```

4. Defina um e-mail no Git:

```
$ git config --global user.email fulanodetal@gmail.com

```

5. Confirme que você configurou o e-mail corretamente no Git:

```
$ git config --global user.email
> Fulano de Tal
```

### 1.2. Configurando o DE/IDE padrão
1. Para configurar seu editor padrão:
```
$ git config --global core.editor editorexemplo

```

