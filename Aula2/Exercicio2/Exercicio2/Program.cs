using System;
using System.Threading;

class Program
{
    static string[] arquivo = new string[5];
    static int i = 0;
    static void Main(string[] args)
    {

        for(i = 0; i < arquivo.Length; i++)
        {
            Console.WriteLine("Digite um Arquivo (Digite Fim para Finalizar): ");
            arquivo[i] = Console.ReadLine();
        }

        Thread t1 = new Thread(() => { Impressora(arquivo[0]); });
        Thread t2 = new Thread(() => { Impressora(arquivo[1]); });
        Thread t3 = new Thread(() => { Impressora(arquivo[2]); });
        Thread t4 = new Thread(() => { Impressora(arquivo[3]); });
        Thread t5 = new Thread(() => { Impressora(arquivo[4]); });

        t1.Start();
        t2.Start();
        t3.Start();
        t4.Start();
        t5.Start();

        t1.Join();
        t2.Join();
        t3.Join();
        t4.Join();
        t5.Join();

    }

    static void Impressora(string arquivo)
    {
        lock (typeof(Program))
        {
            for (i = 0;i < arquivo.Length;i++)
            {
                //* Thread.Sleep(5000); *//
                Console.WriteLine($"Arquivo {i} Impresso -> {arquivo[i]}");;
            }
        }
    }
}
