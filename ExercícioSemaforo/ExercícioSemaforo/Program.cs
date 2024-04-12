using System;
using System.Threading;

class Program
{
    static Random random = new Random();
    static Semaphore semaphore = new Semaphore(2, 2);

    static void Main(string[] args)
    {
        for (int i = 0; i < 5; i++) 
        { 
            int valor = random.Next(200);
            Thread t = new Thread(AlocarRecurso);
            t.Start(valor);
        }
    }

    static void AlocarRecurso(object v)
    {
        int valor = (int)v;
        Console.WriteLine("A Thread " + valor + " está pronta para alocar recurso!");
        semaphore.WaitOne();
        Thread.Sleep(1000);
        Console.WriteLine("A Thread" + valor + " está utilizando o recurso!");
        Thread.Sleep(1000);
        Console.WriteLine("A Thread" + valor + " esta liberando o recurso!");
        semaphore.Release();
        Thread.Sleep(1000);
    }
}