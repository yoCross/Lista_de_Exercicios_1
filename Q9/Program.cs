/*--------------------------------------------------------------------------------------------
Atividade 9: Comparação de Poder de Ataque
•Contextualização: Em um jogo de luta, cada personagem tem um valor de ataque baseado em sua força,
arma e bônus de habilidades. O total de ataque é afetado por modificadores críticos e pelo tipo da arma.
•Crie um programa que receba o valor da força do personagem, o poder da arma,
o bônus de Comando: habilidades, um modificador de crítico, 
e um modificador para o tipo da arma. O programa deve calcular o total de ataque do personagem

@Lista: 01 - Lógica de Programação
@Autor: Mauricio Escobar Azevedo Lima
@Data: 20/08/2024
--------------------------------------------------------------------------------------------*/
using System;
class Program{
    static void Main(string[] args){
        double forç, pweapon, skillbonus, crit, weptype;

        System.Console.Write("Força: ");
        double.TryParse(System.Console.ReadLine(), out forç);

        System.Console.Write("Poder da Arma: ");
        double.TryParse(System.Console.ReadLine(), out pweapon);

        System.Console.Write("Modificador Crítico: ");
        double.TryParse(System.Console.ReadLine(), out crit);

        System.Console.Write("Bônus de Habilidades: ");
        double.TryParse(System.Console.ReadLine(), out skillbonus);

        System.Console.Write("Modificador Tipo da Arma: ");
        double.TryParse(System.Console.ReadLine(), out weptype);

        System.Console.WriteLine($"Total Ataque: {forç + pweapon * (skillbonus * crit * weptype)}");

        System.Console.WriteLine("Aperte qualquer botão para fechar o programa");
        Console.ReadKey();        
    }
}