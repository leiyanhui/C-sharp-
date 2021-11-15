using System;
/*namespace RectangleApplication
{
    class Rectangle
    {
        // 成员变量
        double length;
        double width;
        public void Acceptdetails()
        {
            length = 4.5;
            width = 3.5;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
        }
    }
}*/



namespace Application
{

    class Rectangle{
        // 成员变量
        double length, width;

        public void AcceptDetail()
        {
            // get data

            length = 4.5;
            width = 3.5;
        }


        private double GetArea()
        {
            // 返回面积
            return length * width;

        }

        public void Display()
        {
            Console.WriteLine("length:{0}", length);
            Console.WriteLine("width:{0}", width);
            Console.WriteLine("Area:{0}", GetArea());

        }

    }
    class Excute { 
        
        static void Main(string[] args) {

                Rectangle r = new Rectangle();
                r.AcceptDetail();
                r.Display();

        }
    
    
    }

}