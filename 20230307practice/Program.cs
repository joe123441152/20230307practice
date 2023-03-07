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
//const常數(不能改)
//有些字不能當變數，例:for(可用For,但不建議)，可參考C# keywords reserved
//WriteLine輸出、Readline輸入
namespace _20230307practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // float weight = 83.0F, height = 1.70F;
            //下面這行是用來顯示文字
            //Console.Write("BMI:");
            //底下用來計算BMI，公式:BMI = weight / (height*height)
            //Console.WriteLine(Math.Round(83 / (1.7*1.7),2));
            //Console.WriteLine(83 / Math.Pow(1.7,2));
            //Console.WriteLine(Math.Round(w / Math.Pow(h, 2)));

            Double Weight, Height;
            Console.Write("身高(公尺):");
            Height = Convert.ToDouble(Console.ReadLine());
            Console.Write("體重(公斤):");
            Weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Round(Weight / Math.Pow(Height, 2)));

            //int x, y, z;
            //x = y = z = 50;
            //Console.WriteLine(x+y+z);

        }
    }
}
