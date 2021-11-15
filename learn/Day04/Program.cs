using System;


public class ConstTestc
{
    class SampleClass
    {
        public int x, y;
        public const int c1 = 5;
        public const int c2 = c1 + 5;


        public SampleClass(int p1, int p2)
        {   
            // is it similar to init function of python?
            x = p1;
            y = p2;

        }

    
    }

    static void Main()
    {
        SampleClass sc = new SampleClass(11, 22);
        Console.WriteLine("x = {0}, y = {1}", sc.x, sc.y);
        Console.WriteLine("c1 = {0}, c2 = {1}",
                          SampleClass.c1, SampleClass.c2);

    }




} 