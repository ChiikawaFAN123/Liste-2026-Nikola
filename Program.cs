using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste_2026_Nikola
{
    class Program
    {
        static void Main(string[] args)
        {
            //NIZ
            int[] a;
            a = new int[10];
            a[1] = 7;
            Console.WriteLine(a[1]);

            //MATRICA
            int[,] b = new int[3, 4];
            b[1, 1] = 5;
            Console.WriteLine(b[1, 1]);

            //LISTA
            List<string> lista = new List<string>();
            lista.Add("milos");
            lista.Add("ana");
            lista.Add("milica");
            Console.WriteLine(lista[1]);

            lista.RemoveAt(1);
            Console.WriteLine(lista[1]);

            //STEK
            Stack<int> c = new Stack<int>();
            c.Push(5);
            c.Push(3);
            c.Push(4);
            Console.WriteLine(c.Peek());
            c.Pop();
            Console.WriteLine(c.Peek());
            Console.WriteLine(c.Pop());
            Console.WriteLine(c.Peek());


            //RED
            Queue<string> d = new Queue<string>();
            d.Enqueue("petar");
            d.Enqueue("andjela");
            d.Enqueue("andrej");
            Console.WriteLine(d.Count);
            Console.WriteLine(d.Peek());
            d.Dequeue();
            Console.WriteLine(d.Peek());

        }
    }
}
