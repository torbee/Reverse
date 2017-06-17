using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Program
    {
        public static int ReverseInt(int x)
        {
            string num = new String(x.ToString().Reverse().ToArray());
            return int.Parse(num);

        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ReverseInt(num1));
            Console.ReadLine();
        }
    }
}
