﻿using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Selecione uma operação");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Miltiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("------------");
            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch(res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
        }
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine("O resultado da soma é " + resultado);
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.ReadKey();
            Menu();

        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine("O resultado da divisão é " + resultado);
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear ();

            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;
            Console.WriteLine("O resultado da multiplicação é " + (v1 * v2));
            Console.ReadKey();
            Menu();
        }
    }
    // Aprendi a separar as coisas em metodos.
    // como fazer uma tela de menu simples e armazenar valor que o usuário informa em variaveis.
    // converter o valor de string para numero inteiro.
    // aproveitar o switch para estruturar melhor que o if else.
}