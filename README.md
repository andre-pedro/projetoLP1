# Relatório Projecto LP1 - Simplexity




## Metadados

 Autores: 
 * [André Santos][AS], nº a21700034
 * [André Pedro][AP], nº a21701115
 * [Tiago Alves][TA], nº a21701031
 
## Repositório do Projeto
 * O repositório do projeto está disponível através do seguinte [link][rp].

## Repartição de Tarefas

O nosso trabalho foi repartido irmamente e trabalhámos em todos os parâmetros de forma unânime através do nosso [repositório do GitHub][rp]. Contudo, existiram certos aspectos em que cada um se focou mais. 
 * André Santos
	* Criação das classes e as suas nomenclaturas 
	* Verificação da relação entre classes
 * André Pedro
	* Elaboração do Fluxograma e UML
	* Estruturação e Redação do ficheiro README.md
 * Tiago Alves
	* Tratamento das opções apresentadas ao jogador
	* Resolução de Bugs


## Descrição da Solução

 * Arquitetura da Solução:
	* De forma a simplificar a interpretação do nosso programa, separamos o código em diversas classes:
		* A classe `Program` é responsável por inicializar o programa;
		* O `Board` cria um tabuleiro de 7x7 que representa a área em que o jogador pode colocar as peças;
		* Já a classe `Layout` é responsável por desenhar as peças (mediante o input do jogador) e também os dados provenientes da classe `Board`;
		* É na classe `Player` que estão localizadas as decisões que são apresentadas ao jogador, podendo escolher o tipo de peça (quadrado ou cilindro) e a posição a colocar da mesma. Encontra-se também um <i>loop</i> que impede jogadas inválidas (por exemplo, no caso de um jogador querer jogar a peça [1] e existirem 0 peças [1], é perguntado outra vez ao jogador qual peça ele quer jogar até este escolher uma peça válida;
		* Em `State` encontram-se os tipos de peças (cubo e cilindro) que são posteriormente desenhadas no `Layout`. 
		* `Position` é uma classe apenas de leitura, que representar a localização das linhas e colunas no tabuleiro. 
		* Por último, `WinChecker` faz uma verificação vertical, horizontal e diagonal para detetar a presença de 4 peças iguais em sequência.
		
	* breve explicação de como o programa foi organizado (check)
	* indicação das estruturas de dados (para o tabuleiro de jogo, por exemplo) 
	* e algoritmos (para verificação da situação de vitória, por exemplo)
	utilizados.
	* succ2
 * Fluxograma:

	![Alt text](https://raw.githubusercontent.com/andre-pedro/projetoLP1/master/Fluxograma.svg?sanitize=true "Fluxograma do Projeto")
 * Diagrama UML:
 
## Conclusões 

## Referências
 * [Enunciado do Projeto][ref1]
 * Capítulo 20 do Livro "[The C# Player's Guide (3rd Edition)][ref2]"
 * [Solução do Exercicio nº 8][ref3] do repositório [@VideojogosLusofona][ref4], em [Programação Orientada a Objetos][ref5]
 
Curso:
* [Licenciatura em Aplicações Multimédia e Videojogos][lamv]
	
Instituição: 
* [Universidade Lusófona de Humanidades e Tecnologias][ULHT]



[AS]:https://github.com/Snigy24
[AP]:https://github.com/andre-pedro
[TA]:https://github.com/synpse
[lamv]:https://www.ulusofona.pt/licenciatura/aplicacoes-multimedia-e-videojogos
[ULHT]:https://www.ulusofona.pt/
[rp]:https://github.com/andre-pedro/projetoLP1
[ref1]:https://github.com/VideojogosLusofona/lp12017p1
[ref2]:http://starboundsoftware.com/books/c-sharp/
[ref3]:https://github.com/VideojogosLusofona/lp1_exercicios/blob/master/solucoes/03_poo/08.md
[ref4]:https://github.com/VideojogosLusofona/
[ref5]:https://github.com/VideojogosLusofona/lp1_exercicios/blob/master/solucoes/03_poo/