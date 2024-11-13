using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertion_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] {10,2 ,-32,1,5,9};
            Insertion_Sort(a);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadKey();
        }
        private static void Insertion_Sort(int[]a)
        {
            int cnt = a.Length;
            // key is the cornt element
            int key;
            for (int i = 0; i < cnt; i++)
            {
                key = a[i];
                int j = i - 1;
                while (j >= 0 && a[j] > key) 
                {
                    a[j+1] = a[j];
                    j--;
                }
                a[j + 1] = key;
            }
        }
    }
}
