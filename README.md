# dm117-game
Projeto disciplina DM117 - Pós Graduação Inatel

**Sistema Operacional:**

- *Windows 11*

---

**Ferramentas:**

- *Visual Studio Code 2023 1.82.2*
- *Unity 2022.3.25f1*

---

**Descrição e Instruções:**

- Jogo em 3D desenvolvido para avaliação da disciplina DM117
- O jogo consiste em controlar um personagem que deverá se mover por um labirinto, e coletar o maior número de moedas possíveis antes do cronometro de contagem regressiva chegar ao zero.
- O tempo do jogo é de 2 minutos.
- Para controlar a direção do personagem, basta utilizar as `setas de direção` do teclado. É possível saltar utilizando a `barra de espaço`, e para correr basta segurar a tecla `shift` e apertar simultaneamente uma das setas de direção do teclado.
- O jogo possui uma barra de energia no canto superior direito, que vai se esgotando a cada 10 segundos passados no cronometro, que está visivel acima da própria barra de energia.
- Cada vez que o personagem coleta uma moeda, além de ganhar um ponto, ele também recupera 10 segundos, que são adicionados ao cronometro, o que também restaura um pouco da barra de energia.
- É possível informar o nome do usuário ou qualquer apelido, antes do jogo começar, e esse nome ficará visível no canto superior esquerdo durante todo o jogo.
- A contagem dos pontos, referente as moedas coletadas também fica visivel durante o jogo, no canto superior esquerdo, logo abaixo do nome/apelido do jogador.
- Após o tempo se esgotar, é exibido uma tela sinalizando o fim do jogo. Essa tela possui um botão para que seja possível começar o jogo novamente.
- A qualquer momento é possível finalizar e sair do jogo pressionando a tecla `ESC` do teclado.

---

**Como instalar e jogar:**

- Existem duas formas de executar o jogo. Você pode usar uma ou outra, ou ambas.
  -  a) Clone o repositório do git na sua pasta de preferencia, importe o projeto para dentro da IDE do Unity e execute a cena `StartScene` que se encontra na caminho `Assets\Scenes`.
  -  b) Descompacte o arquivo `MazeCoins.rar`, que foi baixado durante a clonagem do projeto do git, e na pasta que descompactou, execute o arquivo `MazeCoins.exe`. O jogo terá inicio.
  		
---

**Referencias e Implementações:**

- Server Room (Animaçao inicial)
  - Assets
    - https://assetstore.unity.com/packages/3d/environments/lowpoly-server-room-props-197268
  - Melhorias e alterações feitas por mim.
    - Criado e inserido animação de abertura. Inserido mudança de cena.
    - Criado scripts e controllers.
- Tela de Instruções
  - Assets, criação da cena e chamada para mudança de cena
    - Criados localmente por mim.
    - Criação de scripts e controller.
- Labirinto (Jogo)
  - Assets e geração do labirinto
    - https://assetstore.unity.com/packages/tools/modeling/maze-generator-38689
  - Melhorias e alterações feitas por mim.
    - Inserido personagem, barra de energia, cronometro, nome do player, pontuação
    - Criado mudança de cena ao finalizar o jogo.
    - Criação de scripts e controller.
- Tela de fim de Jogo
  - Assets
    - https://www.mixamo.com/#/?page=1&type=Character (Mousey)
  - Melhorias e alterações feitas por mim.
    - Inserido personagem com animação, botão para reiniciar, e criação da cena.
    - Criado mudança de cena ao reiniciar o jogo.
    - Criação de scripts e controller.

---

