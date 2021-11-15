using System;



namespace TypeConversionApllication {

    class explicitConversion {



        public  void Func1() {
            double d = 3.1415926;
            int i;
            i = (int)d;
            // converse double to int;

            Console.WriteLine(i);
            //Console.ReadKey();


            int i1 = 75;
            float f = 53.005f;
            double d1 = 2345.7652;
            bool b = true;

            Console.WriteLine(i1.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d1.ToString());
            Console.WriteLine(b.ToString());
            //Console.ReadKey();


        }


        public void Func2() {

            short a;
            int b;
            double c;

            /* 实际初始化 */
            a = 10;
            b = 20;
            c = a + b;
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
            Console.ReadLine();

        }
        static void Main(string[] args) {
            explicitConversion r = new explicitConversion();
            r.Func2();



        }
    
    
    }


}