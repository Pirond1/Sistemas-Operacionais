using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        float valor1 = 10;
        float valor2 = 35.5f;
        Thread t1 = new Thread(() => Soma(valor1, valor2));
        Thread t2 = new Thread(() => Sub(valor1, valor2));
        Thread t3 = new Thread(() => Mult(valor1, valor2));
        Thread t4 = new Thread(() => Div(valor1, valor2));
        t1.Start();
        t2.Start();
        t3.Start();
        t4.Start();
    }

    static void Soma(float valor1, float valor2)
    {
        float soma = valor1 + valor2;
        Console.WriteLine("Soma: " + soma);
    }

    static void Sub(float valor1, float valor2)
    {
        float sub = valor1 - valor2;
        Console.WriteLine("Subtração: " + sub);
    }

    static void Mult(float valor1, float valor2)
    {
        float mult = valor1 * valor2;
        Console.WriteLine("Multiplicação: " + mult);
    }

    static void Div(float valor1, float valor2)
    {
        float div = valor1 / valor2;
        Console.WriteLine("Divisão: " + div);
    }

}