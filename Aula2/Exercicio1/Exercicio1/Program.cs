using System;
using System.Threading; 

class Program
{
    static int[] arrey = new int[5];

    static void Main(string[] args)
    {
        for (int i = 0; i < arrey.Length; i++) 
        {
            Console.WriteLine("Digite o número na casa " + i + ": ");
            arrey[i] = int.Parse(Console.ReadLine());

        }
            Thread t1 = new Thread(() => Soma());
            Thread t2 = new Thread(() => Soma());

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            int soma = Soma();
            Console.WriteLine("Soma: " + soma);  
    }

    static int Soma()
    {
        int soma = 0;
        lock (typeof(Program))
        {
            for(int i = 0; i < arrey.Length; i++)
            {
                soma += arrey[i];
            }
            return soma;
        }
    }
}
