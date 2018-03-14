using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][][] tab =
            {
                new int[][]
                {
                    new int[] {1,2},
                    new int[] {3,4,5}
                },
                new int[][]
                {
                    new int[] {6,7},
                    new int[] {8,9,10}
                }
            };
            Console.WriteLine(tab[0][1][2]);    //wyswietli 5
            Console.WriteLine(tab[1][0][1]);    //wyswietli 7
            Console.ReadKey();
        }
    }
}
