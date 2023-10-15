using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int next = 0;
            int prev = 0;
            for (int i = 0; i <= 10; i++) 
            {
                Console.WriteLine(next);
                if(next==0)
                {
                    next = 1;
                }
                else
                {
                    int temp = next;
                    next = next + prev;
                    prev = next;
                }
            }
            Console.ReadLine();
        }
    }
}
