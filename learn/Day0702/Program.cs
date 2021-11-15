// function


using System;



namespace CalcuteApplication {

    class NumberManipulator {

        public int FindMax(int num1, int num2) {

            // 局部变量

            int result;

            if (num1 > num2)
            
                result = num1;
            else
                result = num2;  
            return result;
        }


       
    
    }

    class NumberManipulator2 {
        public ulong factory(ulong num)
        {
            ulong result;

            if (num > 0)
            {
                result = factory(num - 1) * num;
                return result;
            }
            else {
                return 1;
            
            }
        }
    }






    class Test {

        static void Main(string[] args)
        {
            // 局部变量定义

            int a = 100;
            int b = 200;
            int ret;

            NumberManipulator n = new NumberManipulator();

            // 调用 Find Max方法

            ret = n.FindMax(a, b);
            Console.WriteLine(ret);

            NumberManipulator2 n2 = new NumberManipulator2();
            // 利用factory 计算阶乘
            // 数据的长度会对结果的准确性造成限制
            Console.WriteLine("6 的阶乘是： {0}", n2.factory(6));
            Console.WriteLine("7 的阶乘是： {0}", n2.factory(7));
            Console.WriteLine("8 的阶乘是： {0}", n2.factory(8));
            Console.WriteLine("50 的阶乘是： {0}", n2.factory(50));
            Console.ReadLine();
        }

    }
}
