using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Thread t1 = new Thread(() => Primeiro());
        Thread t2 = new Thread(() => Segundo());
        t1.Start();
        t2.Start();
    }

    static void Primeiro()
    {
        float valor = 1;
        float mult;
        do
        {
            mult = valor * 2;
            Console.WriteLine(valor + " * 2 -> " + mult);
            valor++;
        } while (valor <= 5);
    }

    static void Segundo()
    {
        float valor = 6;
        float mult;
        do
        {
            mult = valor * 2;
            Console.WriteLine(valor + " * 2 -> " + mult);
            valor++;
        } while (valor <= 10);
    }

}