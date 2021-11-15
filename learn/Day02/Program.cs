using System;




namespace DataTypeApplication {

    class Program
    {

        

        static void Main(string[] args)
        {
            // sizeof return the size of storage;
            Console.WriteLine("size of int:{0}", sizeof(int));

            // Object  Common Type System - CTS
            object obj;
            obj = 100;
            Console.WriteLine(obj);

            // dynamic
            dynamic obj2 = 200;
            Console.WriteLine(obj2);


            // string Type is cname of System.String;

            String str = "leiyanhui";
            Console.WriteLine(str); 
            String str2 = @"run allaways";
            Console.WriteLine(str2);
            String str3 = @"C:\windows";
            Console.WriteLine(str3);
            String str4 = "C:\\windows";
            Console.WriteLine(str4);

            Console.ReadLine();

        }
    }
}