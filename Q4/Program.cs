/*--------------------------------------------------------------------------------------------
Contextualização: No seu jogo, o jogador coleta moedas durante uma fase. A cada coleta, o total
de moedas aumenta.
• Comando: Desenvolva um programa que receba cinco valores de moedas coletadas e some-os,
exibindo o total de moedas coletadas ao final.

@Lista: 01 - Lógica de Programação
@Autor: Mauricio Escobar Azevedo Lima
@Data: 19/08/2024
--------------------------------------------------------------------------------------------*/

using System;
class Program{
    static void Main(string[] args){
        int[] moedas = new int[5];

        System.Console.Write("Moedas Coletadas: ");
        int.TryParse(Console.ReadLine(), out moedas[0]);
        
        System.Console.Write("Moedas Coletadas: ");
        int.TryParse(Console.ReadLine(), out moedas[1]);

        System.Console.Write("Moedas Coletadas: ");
        int.TryParse(Console.ReadLine(), out moedas[2]);

        System.Console.Write("Moedas Coletadas: ");
        int.TryParse(Console.ReadLine(), out moedas[3]);

        System.Console.Write("Moedas Coletadas: ");
        int.TryParse(Console.ReadLine(), out moedas[4]);

        System.Console.Write($"Total de Moedas: {moedas[0] + moedas[1] + moedas[2] + moedas[3] + moedas[4]}");

        System.Console.WriteLine("Pressione qualquer botão para fechar");
        Console.ReadKey();
    }
}