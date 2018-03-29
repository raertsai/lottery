using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            // 產生亂數
            Random rand = new Random();

            // 紀錄次數之變數
            int n=0;

            string[] name = { "第一組", "第二組", "第三組", "第四組", "第五組", "第六組", "第七組", "第八組", "第九組", "第十組" };
        
           
            while (n<=10)
            {
                // 產生亂數
             
                int r1 = rand.Next(1, 43);
                int r2 = rand.Next(1, 43);
                int r3 = rand.Next(1, 43);
                int r4 = rand.Next(1, 43);
                int r5 = rand.Next(1, 43);
                int r6 = rand.Next(1, 43);
               

                int r = rand.Next(0, name.Length);

                // 秀出亂數
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine(name [r]+"   "+"the lucky number  :");

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("{0:00},{1:00},{2:00},{3:00},{4:00},{5:00}", r1 ,r2, r3, r4, r5, r6);
                
                // 次數加一
                n++;
            }
            Console.ReadLine();

        }
    }
}
