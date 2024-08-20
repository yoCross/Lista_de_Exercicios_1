/*--------------------------------------------------------------------------------------------
Questão 1: Informações do Personagem
• Contextualização: Em um jogo de RPG, o jogador precisa inserir as informações básicas do
personagem antes de começar a aventura.
• Comando: Crie um programa que receba o nome, idade, nível inicial, classe, e raça do
personagem e exiba esses dados no console.

@Lista: 01 - Lógica de Programação
@Autor: Mauricio Escobar Azevedo Lima
@Data: 19/08/2024
--------------------------------------------------------------------------------------------*/

using System;
class Class1{
    public static void Main(string[] args){
        System.Console.WriteLine("");

        string? nome, raça, classe;
        int idade, nivel;
        System.Console.Write("Qual e o seu nome: ");
        nome = Console.ReadLine();

        System.Console.Write("Qual e a sua raça: ");
        raça = Console.ReadLine();

        System.Console.Write("Qual e a sua classe: ");
        classe = Console.ReadLine();
        
        System.Console.Write("Qual e a sua idade: ");
        int.TryParse(Console.ReadLine(), out idade);

        System.Console.Write("Qual e o seu nivel: ");
        int.TryParse(Console.ReadLine(), out nivel);

        System.Console.WriteLine($"Nome: {nome}");
        System.Console.WriteLine($"Classe: {classe}");
        System.Console.WriteLine($"Idade: {idade}");
        System.Console.WriteLine($"Nivel: {nivel}");
        System.Console.WriteLine($"Raça: {raça}");

        System.Console.WriteLine("Pressione qualquer botão para fechar");
        Console.ReadKey();
    }
}