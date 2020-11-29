using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErbiumCustomListProj
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> number = new CustomList<int>();
            CustomList<int> number2 = new CustomList<int>();
            number.Add(4);
            number.Add(5);
            number.Add(8);
            number2.Add(3);
            number2.Add(6);
            number2.Add(9);
            number2.Add(12);
            number2.Add(16);
            CustomList<int> newNumber = number.Zip(number, number2);
            Console.WriteLine(newNumber.ToString());
            Console.ReadLine();
        }
    }
}
