using System;
using System.Globalization;

namespace ExerciciosEstruturaWhile {
    class Program {
        static void Main(string[] args) {

            /* Exercício 01 - Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
             * incorreta informada, escrever a mensagem "Senha Inválida!". Quando a senha for informada corretamente deve ser
             * impressa a mensagem "Acesso permitido!" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.


            string senha;

            Console.Write("Digite a senha: ");
            senha = Console.ReadLine();

            while (senha != "2002") {
                Console.WriteLine("Senha Inválida!");
                Console.Write("Digite a senha: ");
                senha = Console.ReadLine();
            }

            Console.WriteLine("Acesso permitido!"); */



            /* Exercício 02 - Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
             * cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
             * menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma). 

            int x, y;

            Console.WriteLine("Escreva dois valores inteiros (na mesma linha): ");
            string[] var = Console.ReadLine().Split(' ');
            x = int.Parse(var[0]);
            y = int.Parse(var[1]);

            while (x != 0 && y!= 0) {
                if (x > 0 && y > 0) {
                    Console.WriteLine("Primeiro quadrante!");
                }
                else if (x < 0 && y > 0) {
                    Console.WriteLine("Segundo quadrante!");
                }
                else if (x < 0 && y < 0) {
                    Console.WriteLine("Terceiro quadrante!");
                }
                else {
                    Console.WriteLine("Quarto quadrante!");
                }
                string[] vari = Console.ReadLine().Split(' ');
                x = int.Parse(vari[0]);
                y = int.Parse(vari[1]);
            } */

        }
    }
}