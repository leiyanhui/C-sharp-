using System;



namespace InteritanceApplication {

    class Shape {

        public void setWidth(int w) {
            width = w;
        }

        public void setHeight(int h) {
            height = h;
        }

        protected int width;
        protected int height;

    }

    // 派生类
    class Rectangle:Shape 
    {
        public int getArea() {
            return (width*height);
        }
    }

    // 基类的初始化
    class Rectangle2 {

        protected double length;
        protected double width;

        public Rectangle2(double l, double w) {

            length = l;
            width = w;
        }

        public double GetArea() {

            return length * width;
        }

        public void display() {
            Console.WriteLine("长度： {0}", length);
            Console.WriteLine("宽度： {0}", width);
            Console.WriteLine("面积： {0}", GetArea());
        }
    
    }


    class Tabletop : Rectangle2 {
        private double cost;
        public Tabletop(double l, double w):base(l, w) {
            Console.WriteLine("初始化打印成本： {0}", cost);

        }

        public double GetCost() {
            double cost;
            cost= GetArea()*70;
            return cost;
        }

        public void Display() {
            base.display();
            Console.WriteLine("成本： {0}", GetCost());
        
        
        }

    
    }


    // 多重继承

    class Shap2 {


        protected double width, height;
        public void setWidth(double w) {
            width = w;
        }

        public void setHeight(double h) {
            height = h;
        }
    
    }
    // 基类，PaintCost
    public interface PaintCost
    {
        double GetCost(double Area);
    }


    // 派生类

    class Rectangle3 : Shap2, PaintCost
    {

        public double getArea() {
            return (width * height);
        }

        public double GetCost(double Area){
            return Area*70;
        }
    
    }









    class RectangleTester
    {
        static void Main(string[] args)
        {
            //Rectangle Rect = new Rectangle();
            //Rect.setWidth(5);
            //Rect.setHeight(7);

            // 打印对象面积
            //Console.WriteLine("总面积： {0}", Rect.getArea());
            //Console.ReadKey();
            /*Tabletop t = new Tabletop(4.5, 7.5);
            t.Display();
            Tabletop t1 = new Tabletop(8.5, 12.5);
            t1.Display();*/

            Rectangle3 Rect = new Rectangle3();
            double area;
            Rect.setWidth(5);
            Rect.setHeight(7);
            area = Rect.getArea();
            // 打印对象的面积
            Console.WriteLine("总面积： {0}", Rect.getArea());
            Console.WriteLine("油漆总成本： ${0}", Rect.GetCost(area));



        }
    }


}

