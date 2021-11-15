using System;



namespace OperatorApp {


    class program {


        public void Func1() {

            int a = 10;
            int b = 20;
            int c;

            c = a + b;
            Console.WriteLine(c);

            c = a - b;
            Console.WriteLine(c);

            c = a / b;
            Console.WriteLine(c);


            c = a * b;
            Console.WriteLine(c);


            c = a % b;
            Console.WriteLine(c);


            c = ++a;
            Console.WriteLine(c);

            c = --a;
            Console.WriteLine("Line 7 - c 的值是 {0}", c);

        }



        public void Func2() { 
        

            bool a = true;
            bool b = false;

            if (a && b)
            {
                Console.WriteLine("a && b had Runned!");
            }
            if (a || b)
            {
                Console.WriteLine("a || b had Runned!");
            }
            if (!(a && b))
            {
                Console.WriteLine("!(a && b) had Runned!");
            }
            
        }


        public void Func3() {


            int a = 60;            /* 60 = 0011 1100 */
            int b = 13;            /* 13 = 0000 1101 */
            int c = 0;

            c = a & b;           /* 12 = 0000 1100 */
            Console.WriteLine("Line 1 - c 的值是 {0}", c);

            c = a | b;           /* 61 = 0011 1101 */
            Console.WriteLine("Line 2 - c 的值是 {0}", c);

            c = a ^ b;           /* 49 = 0011 0001 */
            Console.WriteLine("Line 3 - c 的值是 {0}", c);

            c = ~a;               /*-61 = 1100 0011 */
            Console.WriteLine("Line 4 - c 的值是 {0}", c);

            c = a << 2;     /* 240 = 1111 0000 */
            Console.WriteLine("Line 5 - c 的值是 {0}", c);

            c = a >> 2;     /* 15 = 0000 1111 */
            Console.WriteLine("Line 6 - c 的值是 {0}", c);
        }

        public void Func4() {
            int a = 21;
            int c;
            c = a;
            Console.WriteLine("Line 1 - =  c 的值 = {0}", c);

            c += a;
            Console.WriteLine("Line 2 - += c 的值 = {0}", c);

            c -= a;
            Console.WriteLine("Line 3 - -=  c 的值 = {0}", c);

            c *= a;
            Console.WriteLine("Line 4 - *=  c 的值 = {0}", c);

            c /= a;
            Console.WriteLine("Line 5 - /=  c 的值 = {0}", c);

            c = 200;
            c %= a;
            Console.WriteLine("Line 6 - %=  c 的值 = {0}", c);

            c <<= 2;
            Console.WriteLine("Line 7 - <<=  c 的值 = {0}", c);

            c >>= 2;
            Console.WriteLine("Line 8 - >>=  c 的值 = {0}", c);

            c &= 2;
            Console.WriteLine("Line 9 - &=  c 的值 = {0}", c);

            c ^= 2;
            Console.WriteLine("Line 10 - ^=  c 的值 = {0}", c);

            c |= 2;
            Console.WriteLine("Line 11 - |=  c 的值 = {0}", c);
        }


        public void Func5() { 
        
            Console.WriteLine("size of int {0}", sizeof(int));
            Console.WriteLine("size of short {0}", sizeof(short));
            Console.WriteLine("size of double {0}", sizeof(double));
            

            int a, b;
            a = 10;
            b = (a == 10) ? 20 : 30;
            Console.WriteLine("value of b {0}", b);

            b = (a == 1) ? 20 : 30;
            Console.WriteLine("value of b {0}", b);


        }







        static void Main(string[] args)
        {
            program p = new program();
            p.Func5();



        }
    }



}