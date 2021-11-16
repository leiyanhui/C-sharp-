// 静态多态性：在编译时，函数和对性的链接机制被早期静态绑定，。C#提供了两种技术实现金泰多态性
// 函数重载和运算符重载

using System;
// 函数重载
namespace PolymorghismApplication
{
    class Program { 
    
        static void Main(string[] args) {

            /*TestData dataClass = new TestData();
            int add1 = dataClass.Add(1, 2);
            int add2 = dataClass.Add(1, 2, 3);

            Console.WriteLine("add1 :" + add1);
            Console.WriteLine("add2 :" + add2);*/

            Rectangle r = new Rectangle(10, 7);
            double a = r.area;
            Console.WriteLine("面积： {0}", a);

        }


    }

}

