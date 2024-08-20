/*--------------------------------------------------------------------------------------------
Questão 5: Cálculo de Distância Percorrida
• Contextualização: Um veículo no jogo percorre uma certa distância em um tempo determinado.
• Comando: Crie um programa que receba a velocidade do veículo, o tempo de viagem e dois
multiplicadores (um para condições climáticas e outro para estado do veículo), e calcule a
distância total percorrida.

@Lista: 01 - Lógica de Programação
@Autor: Mauricio Escobar Azevedo Lima
@Data: 19/08/2024
--------------------------------------------------------------------------------------------*/


using System;
class Program{
    static void Main(string[] args){
        double speed, time, weather, carCondition;

        System.Console.Write("Velocidade: ");
        double.TryParse(Console.ReadLine(), out speed);

        System.Console.Write("Tempo: ");
        double.TryParse(Console.ReadLine(), out time);

        System.Console.Write("Multiplicador Climático: ");
        double.TryParse(Console.ReadLine(), out weather);

        System.Console.Write("Multiplicador Estado do Veículo: ");
        double.TryParse(Console.ReadLine(), out carCondition);

        System.Console.WriteLine($"Distancia Percorrida: {speed * time * weather * carCondition}");

        System.Console.WriteLine("Pressione qualquer botão para fechar");
        Console.ReadKey();
    }
}