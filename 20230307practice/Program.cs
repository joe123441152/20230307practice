using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 這是我用來練習如何利用C#計算BMI程式範例
 * 作者:羅竣祥
 * 日期:2023/03/07
 */
namespace _20230307practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //下面這行是用來顯示文字
            Console.Write("BMI:");
            //底下用來計算BMI，公式:BMI = weight / (height*height)
            Console.WriteLine(Math.Round(83 / (1.7*1.7),2));
            Console.WriteLine(83 / Math.Pow(1.7,2));
        }
    }
}
