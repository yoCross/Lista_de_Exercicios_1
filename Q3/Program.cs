/*
Contextualização: Durante um combate, o jogador recebe dano e a vida do personagem
diminui.
• Comando: Crie um programa que receba o valor da vida inicial, o dano recebido, o bônus de
regeneração, do atacado, e dois modificadores, do atacante, (um para equipamentos e outro
para habilidades), e calcule a vida restante.

@Lista: 01 - Lógica de Programação
@Autor: Mauricio Escobar Azevedo Lima
@Data: 19/08/2024
--------------------------------------------------------------------------------------------*/
using System;
using System.Runtime.ConstrainedExecution;
class Program{
    static void Main(string[] args){
        double vida, dano, equip, hab, regen;

        System.Console.Write("Vida atual: ");
        double.TryParse(Console.ReadLine(), out vida);

        System.Console.Write("Dano recebido: ");
        double.TryParse(Console.ReadLine(), out dano);

        System.Console.Write("Bonus de regeneração: ");
        double.TryParse(Console.ReadLine(), out regen);

        System.Console.Write("Modificador de Equipamento: ");
        double.TryParse(Console.ReadLine(), out equip);

        System.Console.Write("Modificador de Habilidade: ");
        double.TryParse(Console.ReadLine(), out hab);

        System.Console.WriteLine($"Vida restante: {(vida - dano * equip * hab) + regen}");

        System.Console.WriteLine("Pressione qualquer botão para fechar");
        Console.ReadKey();
    }
}