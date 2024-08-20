/*--------------------------------------------------------------------------------------------
Questão 6: Conversão de Moeda do Jogo
•Contextualização: O jogo possui uma loja onde os jogadores podem trocar moedas de ouro por cristais.
•Comando: Desenvolva um programa que receba o valor de moedas de ouro, 
o valor da taxa de conversão (1 cristal = X moedas de ouro), 
e dois bônus de conversão (um baseado em eventos e outro em habilidades), 
e calcule o número de cristais que o jogador pode obter.

@Lista: 01 - Lógica de Programação
@Autor: Mauricio Escobar Azevedo Lima
@Data: 20/08/2024
--------------------------------------------------------------------------------------------*/
using System;
class Program{
    static void Main(string[] args){
        double skill, moedas, taxa, even;

        System.Console.Write("Moedas de Ouro: ");
        double.TryParse(Console.ReadLine(), out moedas);

        System.Console.Write("Taxa de Conversão: ");
        double.TryParse(Console.ReadLine(), out taxa);

        System.Console.Write("Bônus de Evento: ");
        double.TryParse(Console.ReadLine(), out even);

        System.Console.Write("Bônus de Habilidade: ");
        double.TryParse(Console.ReadLine(), out skill);

        System.Console.WriteLine($"Cristais Obtidos: {moedas / taxa * even * skill}");

        Console.ReadKey();
        System.Console.WriteLine("Aperte qualquer botão para fechar o programa");
    }
}