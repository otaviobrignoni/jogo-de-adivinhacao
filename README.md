# Jogo de Adivinha��o

![](https://i.imgur.com/OcMo1ta.gif)

## Projeto

Desenvolvido durante o curso Fullstack da Academia do Programador 2025

---
## Detalhes

O jogo gera um n�mero alea�rio entre 1 e 20. O jogador tem um n�mero de tentativas para adivinahar o n�mero secreto.
A quantidade de tentativas � definida pela dificualdade selecionada pelo jogador.
Ap�s cada tentativa, o jogo informa se o n�mero digitado pelo jogador foi acima ou abaixo do n�mero secreto.
O jogo termina quando as tentativas acabam ou quando o n�mero secreto � adivinhado.

Os n�veis de dificuldade s�o:�

1. F�cil = 10 chances�
2. M�dio = 5 chances�    
3. Dif�cil = 3 chances

---
## Entrada

O jogador interage com o jogo por meio do console, digitando n�meros e recebendo feedback instant�neo sobre suas escolhas.

---
## Funcionalidades

- **Gera��o de N�mero Secreto:** No in�cio de cada jogo, um n�mero secreto � gerado aleatoriamente entre 1 e 20.
- **Sele��o de Dificuldade:** O jogador pode escolher entre tr�s n�veis de dificuldade (F�cil, M�dio, Dif�cil), que influenciam o n�mero de tentativas dispon�veis.
- **Feedback Instant�neo:** Ap�s cada tentativa, o jogo fornece feedback indicando se o n�mero escolhido � maior ou menor que o n�mero secreto.
---
## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto.
---
## Como Usar

#### Clone o Reposit�rio
```
git clone https://github.com/otaviobrignoni/jogo-de-adivinhacao.git 
```

#### Navegue at� a pasta raiz da solu��o
```
cd jogo-de-adivinhacao
```

#### Restaure as depend�ncias
```
dotnet restore
```

#### Navegue at� a pasta do projeto
```
cd JogoDeAdivinhacao.ConsoleApp
```

#### Execute o projeto
```
dotnet run
```