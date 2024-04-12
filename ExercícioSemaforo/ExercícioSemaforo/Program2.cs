using System;
using System.Threading;

class Program2
{
    static Mutex mutex = new Mutex();

    static void Main(string[] args)
    {
        for (int i = 0; i < 5; i++)
        {
            Thread t = new Thread(AlocarRecurso);
            t.Start(i);
        }
        Console.ReadLine();
    }

    static void AlocarRecurso(object v) 
    {
        int valor = (int)v;
        Console.WriteLine("A Thread " + valor + " está pronta para alocar recurso!");
        mutex.WaitOne();
        Console.WriteLine("A Thread" + valor + " está utilizando o recurso!");
        Thread.Sleep(1000);
        Console.WriteLine("A Thread" + valor + " esta liberando o recurso!");
        mutex.ReleaseMutex();
    }
}