using System;




namespace ArrayApplication {

    //定义字符串
    class MyString {

        public void Test() {
            string fname, lname;
            fname = "Rowan";
            lname = "Atkinson";

            string fullname = fname + lname;
            Console.WriteLine("Full Name: {0}", fullname);

            //通过使用 string 构造函数
            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string greetings = new string(letters);
            Console.WriteLine("Greetings: {0}", greetings);

            //方法返回字符串
            string[] sarray = { "Hello", "From", "Tutorials", "Point" };
            string message = String.Join(" ", sarray);
            Console.WriteLine("Message: {0}", message);

            //用于转化值的格式化方法
            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}",
            waiting);
            Console.WriteLine("Message: {0}", chat);
            //Console.ReadKey();

        }
    
    }

    // 枚举（Enum）

    public class EnumTest {

        enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };


        public void enumTest() {

            int x = (int)Days.Sun;
            int y = (int)Days.Fri;
            Console.WriteLine(x);
            Console.WriteLine(y);
        
        }
    
    }





    // 定义结构体
    struct Books {

        public string title;
        public string author;
        public string subject;
        public int book_id;
    
    }


    class MyStruct {

        public void TestStruct() {

            Books books1, books2;
            // books1 赋值
            books1.title = "C programming";
            books1.author = "leiyh";
            books1.subject = "C programming tutorial";
            books1.book_id = 325640;
            Console.WriteLine(books1);


            // books2 赋值
            books2.title = "Telecom Billing";
            books2.author = "Zara Ali";
            books2.subject = "Telecom Billing Tutorial";
            books2.book_id = 6495700;



            Console.WriteLine(books2);
        }
        
    
    
    }
    // 定义Array
    class MyArray {
        static void Main(string[] args)
        {

            int[] n = new int[10];
            for (int i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }
            foreach (int j in n)
            {
                int i = j - 100;
                Console.WriteLine("Element[{0}] = {1}", i, j);
            }


            MyString ms = new MyString();
            ms.Test();


            MyStruct mb = new MyStruct();
            mb.TestStruct();

            EnumTest et = new EnumTest();
            et.enumTest();

        }


    }






}