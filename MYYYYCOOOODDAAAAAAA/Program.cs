using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
namespace MYYYYCOOOODDAAAAAAA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter total sum ");
            double money = double.Parse(Console.ReadLine());
            Console.Write("Enter percent in a day ");
            double percentInMonth = double.Parse(Console.ReadLine());
            Console.Write("Days - ");
            int days = int.Parse(Console.ReadLine());
            double salary = 0;
            bool flag = true;
            double x = 0;

            for (int i = 0; i < days; i++)
            {
                if (flag == true)
                {
                    x = money;
                    flag = false;
                }
                //Console.WriteLine((int)money);

                money += money * percentInMonth / 100;
                //if (i % 5 == 0 && i != 0)
                //{
                //    salary += (money - x) * 0.2;
                //    money -= salary;
                //}

            }
            Console.WriteLine($"total money after {money}");


        }
    }
}
    

