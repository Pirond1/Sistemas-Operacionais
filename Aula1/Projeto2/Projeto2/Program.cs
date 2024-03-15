using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Thread t1 = new Thread(() => Par());
        Thread t2 = new Thread(() => Impar());
        t1.Start();
        t2.Start();
    }

    static void Par()
    {
        float valor = 0;
        do
        {
            Console.WriteLine("Par -> " + valor);
            valor += 2;
            Thread.Sleep(50);
        } while (valor <= 100);
    }

    static void Impar()
    {
        float valor = 1;
        do
        {
            Console.WriteLine("Impar -> " + valor);
            valor += 2;
            Thread.Sleep(50);
        } while (valor <= 100);
    }

}
