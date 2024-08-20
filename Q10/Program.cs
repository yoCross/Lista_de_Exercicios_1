/*
• Contextualização: Em um jogo de estratégia, um personagem pode ganhar pontos de vida
a cada nível alcançado.
• Comando: Desenvolva um programa que receba os pontos de vida iniciais e o aumento 
de vida por nível, e calcule a quantidade de pontos de vida após alcançar um novo nível.

@Lista: 01 - Lógica de Programação
@Autor: Mauricio Escobar Azevedo Lima
@Data: 20/08/2024
*/
using System;
class Program{
    static void Main(string[] args){
        int inic, upn, nal;

        Console.Write("Pontos de Vida Iniciais: ");
        int.TryParse(Console.ReadLine(), out upn);

        Console.Write("Aumento por Nível: ");
        int.TryParse(Console.ReadLine(), out inic);

        Console.Write("Nível Alcançado: ");
        int.TryParse(Console.ReadLine(), out nal);

        Console.WriteLine($"Pontos de Vida Finais: {nal * inic + upn}");

        System.Console.WriteLine("Aperte qualquer botão para fechar o programa");
        Console.ReadKey();
    }
}