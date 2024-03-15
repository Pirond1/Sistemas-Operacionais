using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Random random1 = new Random();
        Random random2 = new Random();

        int total1 = random1.Next(0, 11);
        Console.WriteLine("Número Maximo de Passos do 1: " + total1);
        int total2 = random2.Next(0, 11);
        Console.WriteLine("Número Maximo de Passos do 2: " + total2);

        Console.WriteLine("Informe o Maximo da Corrida: ");
        string passos = Console.ReadLine();
        int final = int.Parse(passos);

        Thread t1 = new Thread(() => Corredor1(total1, final));
        Thread t2 = new Thread(() => Corredor2(total2, final));
        t1.Start();
        t2.Start();
    }

    static void Corredor1(int total, int final)
    {
        Random random = new Random();
        int passos = 0;
        while(passos < final)
        {
            passos += random.Next(0, total+1);
            Console.WriteLine("Localização Corredor 1 -> " + passos);
            Thread.Sleep(1000);
        }
        Console.WriteLine("Corredor 1 VENCEDOR!"); ;
    }

    static void Corredor2(int total, int final)
    {
        Random random = new Random();
        int passos = 0;
        while (passos < final)
        {
            passos += random.Next(0, total+1);
            Console.WriteLine("Localização Corredor 2 -> " + passos);
            Thread.Sleep(1000);
        }
        Console.WriteLine("Corredor 2 VENCEDOR!");
    }
}