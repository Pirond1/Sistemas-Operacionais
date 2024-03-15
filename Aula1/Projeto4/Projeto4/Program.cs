using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe N1: ");
        string n1 = Console.ReadLine();
        Console.WriteLine("Informe N2: ");
        string n2 = Console.ReadLine();
        Console.WriteLine("Informe N3: ");
        string n3 = Console.ReadLine();
        Console.WriteLine("Informe N4: ");
        string n4 = Console.ReadLine();
        Console.WriteLine("Informe N5: ");
        string n5 = Console.ReadLine();

        float f1 = float.Parse(n1);
        float f2 = float.Parse(n2);
        float f3 = float.Parse(n3);
        float f4 = float.Parse(n4);
        float f5 = float.Parse(n5);

        Thread t1 = new Thread(() => Media(f1, f2, f3, f4, f5));
        Thread t2 = new Thread(() => Maior(f1, f2, f3, f4, f5));
        Thread t3 = new Thread(() => Menor(f1, f2, f3, f4 ,f5));
        t1.Start();
        t2.Start();
        t3.Start();
    }

    static void Media(float n1, float n2, float n3, float n4, float n5)
    {
        float media;
        media = (n1 + n2 + n3 + n4 + n5) / 5;
        Console.WriteLine("Media dos Numeros Informados: " + media);
    }

    static void Maior(float n1, float n2, float n3, float n4, float n5)
    {
        float maior = 0;
        maior = n1;
        if(n2 > maior)
        {
            maior = n2;
        }
        if(n3 > maior)
        {
            maior = n3;
        }
        if(n4 > maior)
        {
            maior = n4;
        }
        if(n5 > maior)
        {
            maior = n5;
        }
        Console.WriteLine("Maior Numero: " + maior);
    }

    static void Menor(float n1, float n2, float n3, float n4, float n5)
    {
        float menor = 0;
        menor = n1;
        if(n2 < menor)
        {
            menor = n2;
        }
        if(n3 < menor)
        {
            menor = n3;
        }
        if(n4 < menor)
        {
            menor = n4;
        }
        if(n5 < menor)
        {
            menor = n5;
        }
        Console.WriteLine("Menor Numero: " + menor);
    }

}