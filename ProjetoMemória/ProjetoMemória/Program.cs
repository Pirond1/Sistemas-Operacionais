using System;
using System.Drawing;
using System.Security.AccessControl;

class Program
{
    static void Main()
    {
        List<int> list = new List<int>();
        int tamanho = list.EnsureCapacity(10);
        List<int> list2 = new List<int>();
        List<int> cheio = new List<int>();
        int tamanho2 = cheio.EnsureCapacity(10);

        Console.WriteLine("Tamanho da Memória: " + tamanho);

        for(int i = 0; i < tamanho; i++)
        {
            Console.WriteLine("Tamanho desejado para a posição " + i + ": ");
            list2.Add(int.Parse(Console.ReadLine()));
        }

        var teste = true;

        while (teste = true)
        {
            Console.WriteLine("Informe o Tamanho do arquivo (Digite 0 para finalizar): ");
            int arquivo = int.Parse(Console.ReadLine());
            if(arquivo == 0)
            {
                teste = false;
            }
            else
            {
                    if (!cheio.Contains(1))
                    {
                        if (arquivo <= list2[1])
                        {
                            Console.WriteLine("Arquivo salvo na posição 1!");
                            cheio.Add(1);
                        }
                    else if (!cheio.Contains(2))
                    {
                        if (arquivo <= list2[2])
                        {
                            Console.WriteLine("Arquivo salvo na posição 2!");
                            cheio.Add(2);
                        }
                        else if (!cheio.Contains(3))
                        {
                            if (arquivo <= list2[3])
                            {
                                Console.WriteLine("Arquivo salvo na posição 3!");
                                cheio.Add(3);
                            }
                            else if (!cheio.Contains(4))
                            {
                                if (arquivo <= list2[4])
                                {
                                    Console.WriteLine("Arquivo salvo na posição 4!");
                                    cheio.Add(4);
                                }
                                else if (!cheio.Contains(5))
                                {
                                    if (arquivo <= list2[5])
                                    {
                                        Console.WriteLine("Arquivo salvo na posição 5!");
                                        cheio.Add(5);
                                    }
                                    else if (!cheio.Contains(6))
                                    {
                                        if (arquivo <= list2[6])
                                        {
                                            Console.WriteLine("Arquivo salvo na posição 6!");
                                            cheio.Add(6);
                                        }
                                        else if (!cheio.Contains(7))
                                        {
                                            if (arquivo <= list2[7])
                                            {
                                                Console.WriteLine("Arquivo salvo na posição 7!");
                                                cheio.Add(7);
                                            }
                                            else if (!cheio.Contains(8))
                                            {
                                                if (arquivo <= list2[8])
                                                {
                                                    Console.WriteLine("Arquivo salvo na posição 8!");
                                                    cheio.Add(8);
                                                }
                                                else if (!cheio.Contains(9))
                                                {
                                                    if (arquivo <= list2[9])
                                                    {
                                                        Console.WriteLine("Arquivo salvo na posição 9!");
                                                        cheio.Add(9);
                                                    }
                                                    else if (!cheio.Contains(10))
                                                    {
                                                        if (arquivo <= list2[10])
                                                        {
                                                            Console.WriteLine("Arquivo salvo na posição 10!");
                                                            cheio.Add(10);
                                                        }
                                                        else
                                                            Console.WriteLine("!ERRO! Arquivo muito grande!!!");
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                } 
            }
        } 
    }
}