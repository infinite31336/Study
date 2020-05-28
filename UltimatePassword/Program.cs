using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimatePassword
{
    class Program
    {
        static void Main(string[] args)
        {
            int number; 
            int answer; 
            int min;    
            int max;    
            //設定範圍
            min = 1;
            max = 100;
            //建立亂數
            Random rm = new Random();
            answer = rm.Next(1, 100);
            Console.WriteLine("終極密碼");
            Console.WriteLine();
            do
            {
                Console.Write("猜數字範圍 {0} < ? < {1}：", min, max);
                number = int.Parse(Console.ReadLine());
                if (number >= min && number < max) 
                {
                    
                    if (number == answer)
                    {
                        Console.WriteLine("恭喜你，正確答案d(OwO)b!答案是{0}",answer);
                        break; //正確答案,結束迴圈
                    }
                    else if (number > answer)
                    {
                        max = number; //將最大值改為輸入的數字
                        Console.Write("答案要更小");
                    }
                    else if (number < answer)
                    {
                        min = number;//將最小值改為輸入的數字
                        Console.Write("答案要更大");
                    }
                    
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("請輸入提示範圍內的數字");
                }
            }
            while (true); 
            Console.Read();
        }
    }
}
