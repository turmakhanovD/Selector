using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BigMath
{
    class Program
    {
        static void Main(string[] args)
        {
            FactorialAsync();
          
        }
        static void Factorial()
        {
            int result = 1;
            for (int i = 1; i <= 600; i++)
            {
                result *= i;
            }
        
        }

        static async void FactorialAsync()
        {
  
            await Task.Run(() => Factorial());                           
      
        }
    }
}
