# Jogo de Adivinhação

![](https://i.imgur.com/OcMo1ta.gif)

## Projeto

Desenvolvido durante o curso Fullstack da Academia do Programador 2025

---
## Detalhes

O jogo gera um número aleaório entre 1 e 20. O jogador tem um número de tentativas para adivinahar o número secreto.
A quantidade de tentativas é definida pela dificualdade selecionada pelo jogador.
Após cada tentativa, o jogo informa se o número digitado pelo jogador foi acima ou abaixo do número secreto.
O jogo termina quando as tentativas acabam ou quando o número secreto é adivinhado.

Os níveis de dificuldade são: 

1. Fácil = 10 chances 
2. Médio = 5 chances     
3. Difícil = 3 chances

---
## Entrada

O jogador interage com o jogo por meio do console, digitando números e recebendo feedback instantâneo sobre suas escolhas.

---
## Funcionalidades

- **Geração de Número Secreto:** No início de cada jogo, um número secreto é gerado aleatoriamente entre 1 e 20.
- **Seleção de Dificuldade:** O jogador pode escolher entre três níveis de dificuldade (Fácil, Médio, Difícil), que influenciam o número de tentativas disponíveis.
- **Feedback Instantâneo:** Após cada tentativa, o jogo fornece feedback indicando se o número escolhido é maior ou menor que o número secreto.
---
## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.
---
## Como Usar

#### Clone o Repositório
```
git clone https://github.com/otaviobrignoni/jogo-de-adivinhacao.git 
```

#### Navegue até a pasta raiz da solução
```
cd jogo-de-adivinhacao
```

#### Restaure as dependências
```
dotnet restore
```

#### Navegue até a pasta do projeto
```
cd JogoDeAdivinhacao.ConsoleApp
```

#### Execute o projeto
```
dotnet run
```