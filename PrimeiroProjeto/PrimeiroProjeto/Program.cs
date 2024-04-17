using System;

namespace PrimeiroProjeto
{
    class program
    {
        static void Main(string[] args)
        {
            /* int idade = 23;
             Console.WriteLine("a minha idade é:"
               +idade  );
         }*/

            /*operaçoes matematicas*/
            /* int numero1 = 3;
             int numero2 = 9;


             int soma = numero1 + numero2;
             int subtracao = numero1 - numero2;
             int multiplicacao = numero1 * numero2;
             int divisao = numero1 / numero2;
             Console.WriteLine(soma);
             Console.WriteLine(subtracao);
             Console.WriteLine(divisao);
             Console.WriteLine(multiplicacao);*/

            /*double salario = 1500.86;
            Console.WriteLine(salario);*/

            double salario = 35.00;
            int numero2 = 8;
;           int multiplicacao = (int)(salario * numero2);
            Console.WriteLine("o salario é:"+ multiplicacao);

            int caixas = 16;
            int bombons = 27; 
            int multiplicacao2 = caixas*bombons;
            Console.WriteLine("Pamela tem:"+ multiplicacao2);

            int inteiro1 = 3;
            int inteiro2 = 9;
            int soma = inteiro1 + inteiro2;
            Console.WriteLine(soma);

            int garrafas1 = 300;
            int garrafas2 = 20;
            int divisao = garrafas1 / garrafas2;
            Console.WriteLine(divisao);

            double precoInstalacao = 300.00;
            double precoLimpeza = 150.00;
            double precoManutencao = 499.99;
            double desconto = 50.00;
            int total = (int)(precoInstalacao + precoLimpeza + precoManutencao - desconto);
            Console.WriteLine("total a ser pago é:" +total);
        }

    }
}

