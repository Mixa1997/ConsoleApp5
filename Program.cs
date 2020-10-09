using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
                //Высокий уровень!
            {
                Console.Write("Введите x1:");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Введите y1:");
                double y = double.Parse(Console.ReadLine());
                if (y >= x && y >= -x && y <= 1 && y >= -2 + 0) Console.WriteLine("Попадает");
                else Console.WriteLine("Не попадет");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
