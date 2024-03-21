using System;
using System.Threading;

class Program
{
    static int Finalizar = 0;
    static void Main(string[] args)
    {
        Random random1 = new Random();
        Random random2 = new Random();

        int total1 = random1.Next(1, 11);
        Console.WriteLine("Número Maximo de Passos do 1: " + total1);
        int total2 = random2.Next(1, 11);
        Console.WriteLine("Número Maximo de Passos do 2: " + total2);

        Console.WriteLine("Informe o Maximo da Corrida: ");
        string passos = Console.ReadLine();
        int final = int.Parse(passos);

        Thread t1 = new Thread(() => Corredor1(total1, final));
        Thread t2 = new Thread(() => Corredor2(total2, final));

        t1.Start();
        t2.Start();
        
        t1.Join();
        t2.Join();
    }

    static void Corredor1(int total, int final)
    {
        Random random = new Random();
        int passos = 0;
        while(Finalizar != 1)
        {
            if (passos < final)
            {
                passos += random.Next(0, total + 1);
                Console.WriteLine("\r\nLocalização Corredor 1 -> " + passos);
                Thread.Sleep(500);
            }
            else 
            {
                Finalizar = 1;
                Console.WriteLine("\r\nCorredor 1 VENCEDOR!"); ;
            }
            
        }
        
    }

    static void Corredor2(int total, int final)
    {
        Random random = new Random();
        int passos = 0;
        while (Finalizar != 1)
        {
            if (passos < final)
            {
                passos += random.Next(0, total + 1);
                Console.WriteLine("\r\nLocalização Corredor 2 -> " + passos);
                Thread.Sleep(500);
            }
            else
            {
                Finalizar = 1;
                Console.WriteLine("\r\nCorredor 2 VENCEDOR!"); ;
            }
        }
    }
}