/*
Questão 2: Pontuação Final
• Contextualização: No final de uma missão em um jogo, a pontuação do jogador é calculada com
base nos inimigos derrotados e pontos adicionais.
• Comando: Desenvolva um programa que receba o número de inimigos derrotados, a pontuação
por inimigo, bônus por missão, e dois multiplicadores (um para tipo de inimigo e outro para
dificuldade), e então calcule e exiba a pontuação final.

@Lista: 01 - Lógica de Programação
@Autor: Mauricio Escobar Azevedo Lima
@Data: 18/08/2024
*/
using System;
class Program{
    static void Main(string[] args){
        int inimigos, missionbonus, multI, multD, inimigop;
        Console.Write("Inimigos derrotados: ");
        int.TryParse(Console.ReadLine(), out inimigos);
        
        Console.Write("Pontos por inimigo: ");
        int.TryParse(Console.ReadLine(), out inimigop);

        Console.Write("Multiplicador Tipo Inimigo: ");
        int.TryParse(Console.ReadLine(), out multI);

        Console.Write("Multiplicador Dificuldade: ");
        int.TryParse(Console.ReadLine(), out multD);

        Console.Write("Bônus por Missão: ");
        int.TryParse(Console.ReadLine(), out missionbonus);

        System.Console.WriteLine($"Pontuação final: {inimigos * inimigop * multI * multD + missionbonus}");

        System.Console.WriteLine("Pressione qualquer botão para fechar");
        Console.ReadKey();
    }
}