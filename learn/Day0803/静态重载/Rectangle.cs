// 静态多态性：在编译时，函数和对性的链接机制被早期静态绑定，。C#提供了两种技术实现金泰多态性
// 函数重载和运算符重载

// 函数重载
namespace PolymorghismApplication
{
    class Rectangle : Shape {


        private int length;
        private int width;


        public Rectangle(int a = 0, int b=0) {

            this.length = a;
            this.width = b;
        }

        public override int area
        {
            get
            {
                Console.WriteLine("Rectangle 的 面积：");
                Console.WriteLine($"this：{this.GetType()}");
                return length * width;
            }
        }
    }

}

