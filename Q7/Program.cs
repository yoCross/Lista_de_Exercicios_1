/*--------------------------------------------------------------------------------------------
Atividade 7: Experiência e Nível do Jogador após Batalha
•Contextualização: Em um jogo, o jogador enfrenta dois tipos diferentes de inimigos em uma batalha.
Cada tipo de inimigo concede uma quantidade específica de XP.
Após a batalha, o jogador ganha esse XP e precisa somá-lo ao XP
total acumulado para determinar o nível atual do personagem.
•Comando: Desenvolva um programa que receba a quantidade de XP acumulado,
o XP concedido pelo primeiro tipo de inimigo, o XP concedido pelo segundo tipo de inimigo,
o número de cada tipo de inimigo derrotado, e a constante de nível.
O programa deve calcular o XP total acumulado após a batalha e determinar o nível atual do jogador.

@Lista: 01 - Lógica de Programação
@Autor: Mauricio Escobar Azevedo Lima
@Data: 20/08/2024
--------------------------------------------------------------------------------------------*/
using System;
class Program{
    static void Main(string[] args){
        double xpa, xpi1, inimigod1, xpi2, inimigod2, lvlconst;
        Console.Write("XP Acumulado: ");
        double.TryParse(Console.ReadLine(), out xpa);

        Console.Write("XP Inimigo 1: ");
        double.TryParse(Console.ReadLine(), out xpi1);
        
        Console.Write("Inimigos 1 Derrotados: ");
        double.TryParse(Console.ReadLine(), out inimigod1);
        
        Console.Write("XP Inimigo 2: ");
        double.TryParse(Console.ReadLine(), out xpi2);
        
        Console.Write("Inimigos 2 Derrotados: ");
        double.TryParse(Console.ReadLine(), out inimigod2);
        
        System.Console.Write("Constante de Nível: ");
        double.TryParse(Console.ReadLine(), out lvlconst);

        System.Console.WriteLine($"XP Total: {(xpi1 * inimigod1) + (xpi2 * inimigod2) + xpa}");
        System.Console.WriteLine($"Nivel: {((xpi1 * inimigod1) + (xpi2 * inimigod2) + xpa) / lvlconst}");

        System.Console.WriteLine("Aperte qualquer botão para fechar o programa");
        Console.ReadKey();
    }
}