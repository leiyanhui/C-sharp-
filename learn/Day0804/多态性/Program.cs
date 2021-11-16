using System;

namespace PolymorphismApplication 
{
    abstract class Shape
    {
        abstract public int area();

    
    }
    class Rectangle : Shape {

        private int length, width;
        public Rectangle(int a=0, int b = 0) {
            length = a;
            width = b;
        
        }

        public override int area() {

            return (width * length);
        
        }

    }
    /// <summary>
    /// /////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>

    public class ShapeT { 
    
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; private set; }
        public int Width { get; private set; }



        public virtual void Draw() {
            Console.WriteLine("执行基类的画图任务");
        }
    
    
    }

    class Circle : ShapeT
    {

        public override void Draw()
        {
            Console.WriteLine("画一个圆形");
            base.Draw();
        }


    }
    class RectangleT : ShapeT
    {
        public override void Draw()
        {
            Console.WriteLine("画一个长方形");
            base.Draw();
        }
    }
    class Triangle : ShapeT
    {
        public override void Draw()
        {
            Console.WriteLine("画一个三角形");
            //base.Draw();
        }
    }

    /// /////////////////////////////////////////////////////////////////////////////

    class ShapeD
    {
        protected int width, height;
        public ShapeD(int a = 0, int b = 0)
        {
            width = a;
            height = b;
        }
        public virtual int area()
        {
            Console.WriteLine("父类的面积：");
            return 0;
        }
    }
    class RectangleD : ShapeD
    {
        public RectangleD(int a = 0, int b = 0) : base(a, b)
        {

        }
        public override int area()
        {
            Console.WriteLine("Rectangle 类的面积：");
            return (width * height);
        }
    }
    class TriangleD : ShapeD
    {
        public TriangleD(int a = 0, int b = 0) : base(a, b)
        {

        }
        public override int area()
        {
            Console.WriteLine("Triangle 类的面积：");
            return (width * height / 2);
        }
    }



    class Caller
    {
        public void CallArea(ShapeD sh)
        {
            int a;
            a = sh.area();
            Console.WriteLine("面积： {0}", a);
        }
    }
    // //////////////////////////////////////////////////////////////////   
   

    class RectangleTester {
        static void Main(string[] args) {
            /*Rectangle r = new Rectangle(10, 7);
            double a = r.area();
            Console.WriteLine("面积： {0}", a);
            Console.ReadKey();*/
            ////////////////////////////////////////////////////////////////////
            /*var shapes = new List<ShapeT> {
                    new RectangleT(),
                    new Circle(),
                    new Triangle()


            };
            foreach (var each in shapes) {
                each.Draw();
            }*/
            ////////////////////////////////////////////////////////////////////////////
            Caller c = new Caller();
            RectangleD r = new RectangleD(10, 7);
            TriangleD t = new TriangleD(10, 5);
            c.CallArea(r);
            c.CallArea(t);


        }
    
    }



}




