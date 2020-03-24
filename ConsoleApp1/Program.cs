using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = {1, 5, 3, 2 };
            int[] arr2 = {5, 2, 3, 1 };
            bool result = false;
            foreach (int item1 in arr1)
            {
                foreach (int item2 in arr2)
                {
                    if (item1 == item2) { result = true; break; }
                    else result = false; continue;
                }
                if (result == false) break;
            }
        }
    }
}
