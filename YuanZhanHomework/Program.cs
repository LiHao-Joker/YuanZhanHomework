using System;

namespace YuanZhanHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.阅读下面一段代码，看看你的判断和实际结果（能够使其运行）是否一致
            //let age = 28;
            ////age = 30;
            //age + 10;
            //alert(age);  /*这时候age的值是多少？*/  age = 28
            //age = age + 10;
            //alert(age);  /*这时候的age的值又是多少？*/ age =38

            //2.说一说变量和常量的区别，试着声明一个常量length，值为100
            /*
             * 变量创建后可以随意赋值
             * 常量声明时候需要加上 const 关键字
             * 常量只能在声明时候赋值, 其它时候无法进行修改
             */
            const int length = 10;

            //3.“强类型语言才区分数据类型，弱类型语言不用区分数据类型”：这种说法准确么？为什么？
            /*
             * 这种说法是不正确的, 
             * 因为它们二者的区别是弱类型语言在声明的时候不需要指定变量类型,而强类型语言需要
             * 因为这个特点, 弱类型语言在开始的时候比较自由, 但往往难以维护
             */
        }
    }
}
