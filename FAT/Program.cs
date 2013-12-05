using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAT
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] a = new int[20];
            int j = 0;
            Random r = new Random();
            int nBloques;

            for (int i = 0; i < a.Count(); i++)
            {
                a[i] = 0;
                
            }

            Console.WriteLine("Ingrese el tamaño del bloque menor a 2000");
            int x = int.Parse(Console.ReadLine());

            if (x % 100 != 0)
                nBloques = (x / 100) + 1;
            else
                nBloques = (x / 100);

            Console.WriteLine("Bloque localizado en:");

            for (int i = 0; i < a.Count(); i++)
            {
                if (nBloques != -1)
                {
                    j = r.Next(0, 19);
                    if (a[j] != -1)
                    {
                        a[j] = 100;
                        nBloques--;
                        Console.WriteLine("Posicion {0}", j);
                    }
                }
                else
                    break;
                
            }
            

            Console.ReadLine();

			
        }
    }
}
