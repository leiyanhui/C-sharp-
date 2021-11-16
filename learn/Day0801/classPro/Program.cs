// class 的默认访问标识符是internal ，成员的默认访问标识符是private



using System;


namespace BoxApplication {

    class Box {
        public double length;
        public double breadth;
        public double height;

        public void setLength(double len) {

            length = len;
        
        
        }
    
    }
    class Box2
    {
        private double length;
        private double breadth;
        private double height;

        public Box2()
        {

            Console.WriteLine("对象已创建");
            // 也可以给构造函数直接传参，初始化的时候直接默认length的值；

        }


        // 析构函数， 类的同名函数前面+~;它不返回值也不需要传参数，析构函数是不能继承和重载的
        ~Box2()
        {
            Console.WriteLine("执行析构函数");
        }


        public void setLength(double len)
        {
            length = len;
        }

        public void setBreadth(double bre)
        {
            breadth = bre;
        }

        public void setHeight(double hei)
        {
            height = hei;
        }

        public double GetVolume() {

            return length * breadth * height;
        
        }

    }


    // 类的构造函数


    class Line {

        private double length;

        public Line() {

            Console.WriteLine("对象已创建");
            // 也可以给构造函数直接传参，初始化的时候直接默认length的值；
            
        }

        public void SetLength(double len) {

            length = len;
        
        }

        public double GetLength() {
            return length;
        }


        // 析构函数， 类的同名函数前面+~;它不返回值也不需要传参数，析构函数是不能继承和重载的
        ~Line() {
            Console.WriteLine("执行析构函数");
        }
    
    }



    // 静态成员
    // 我们可以使用static关键字把类成员定义为静态的。当我们声明一个类成员为静态时，意味着无论有多少个类的对象被创建，只会有一个静态的该成员副本。
    // 关键字static意味着类中只有一个该成员的实例。静态变量用于定义常量，因为它们的值可以通过直接调用类而不需要创建类的实例来获取。
    // 静态变量可在成员函数或类的定义外部进行初始化，也可以在类的定义内部进行初始化；



    
    class Boxtester
    {
        static void Main(string [] args) {

            Box Box1 = new Box();
            Box Box2 = new Box();
            double volume = 0.0;

            // Box1 详述；
            Box1.length = 5.0;
            Box1.breadth = 6.0;
            Box1.height = 7.0;


            // Box2 详述；
            Box2.length = 10.0;
            Box2.breadth = 12.0;
            Box2.height = 13.0;


            // Box1 的体积
            volume = Box1.length * Box1.breadth * Box1.height;
            Console.WriteLine("Box1 的 体积是：{0}", volume);


            // Box2 的体积
            volume = Box2.length * Box2.breadth * Box2.height;
            Console.WriteLine("Box2 的 体积是：{0}", volume);

            Box2 Box3 = new Box2();

            Box3.setLength(50);
            Box3.setBreadth(60);
            Box3.setHeight(70);
            Console.WriteLine("Box3的体积是：{0}", Box3.GetVolume());

        }
    }





}