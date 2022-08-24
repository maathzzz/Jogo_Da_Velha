# Jogo Da Velha - C#/Xamarin

Desenvolvimento do jogo da velha, pela biblioteca do Xamarin em C#.

##  Estrutura

- Jogo da velha 
- Alerta do vencendor (sendo "X" ou "O")
- Reinício automático após a partida
- Botão de reinício

##  Lógica

Declarado a variável ```vez```, o aplicativo alterna a vez do jogador referente aos toques consecutivos na tela do dispositivo:

![vez](https://user-images.githubusercontent.com/86098429/186290342-67f5e7ae-a606-4091-b20e-a10c72255fc8.png)

- O toque no botão da grid ```altera seu texto de " " para "X" ou "O"```
##
O aplicativo irá verificar a sucessão de três símbolos iguais no texto dos botões ```por meio da estrutura if/else```

![vencedor](https://user-images.githubusercontent.com/86098429/186294219-e1083fa0-005e-4c3e-b949-e45584ec60e6.png)

- Há o total de ```3 linhas, 3 colunas e 2 diagonais a serem verificadas```, e após as definições serem preenchidas, o sistema anuncia o vencedor.
- Caso não haja um vencedor e o jogo se defina como empate, o ```botão de reinício```, posicionado abaixo da grid central, define texto dos botões como " " novamente.
