/*--------------------------------------------------------------------------------------------
Questão 8: Cálculo de Pontos de Habilidade
•Contextualização: Ao subir de nível, um jogador recebe pontos de habilidade
 que podem ser distribuídos entre força, agilidade, inteligência e dois atributos adicionais.
•Comando: Desenvolva um programa que receba a quantidade de pontos de habilidade
 atribuídos a cada uma das cinco características e calcule o total de pontos distribuídos.

@Lista: 01 - Lógica de Programação
@Autor: Mauricio Escobar Azevedo Lima
@Data: 20/08/2024
--------------------------------------------------------------------------------------------*/
using System;
class Program{
    static void Main(string[] args){
        int[] atributos = new int [5];

        System.Console.Write("Força: ");
        int.TryParse(System.Console.ReadLine(), out atributos[0]);

        System.Console.Write("Agilidade: ");
        int.TryParse(System.Console.ReadLine(), out atributos[1]);

        System.Console.Write("Inteligencia: ");
        int.TryParse(System.Console.ReadLine(), out atributos[2]);

        System.Console.Write("Destreza: ");
        int.TryParse(System.Console.ReadLine(), out atributos[3]);

        System.Console.Write("Vitalidade: ");
        int.TryParse(System.Console.ReadLine(), out atributos[4]);
                
        System.Console.WriteLine($"Total de pontos {atributos[0] + atributos[1] + atributos[2] + atributos[3] + atributos[4]}");

        System.Console.WriteLine("Aperte qualquer botão para fechar o programa");
        Console.ReadKey();
    }
}