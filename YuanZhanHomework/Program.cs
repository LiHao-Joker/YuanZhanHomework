using System;

namespace YuanZhanHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //写一段代码，能根据半径获取圆的周长（= 2倍半径乘以圆周率）和面积（= 半径的平方乘以圆周率）
            //    声明一个变量radius，代表半径，给它赋一个任意值；
            //    使用alert(/*这里放表达式*/)输出周长;
            //    使用alert(/*这里放表达式*/)输出面积;

            double radius = 10; // 半径
            Console.WriteLine(radius*2*Math.PI);//周长
            Console.WriteLine(radius*radius*Math.PI);//面积
        }
    }
}
