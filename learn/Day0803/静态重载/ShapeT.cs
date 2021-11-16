// 静态多态性：在编译时，函数和对性的链接机制被早期静态绑定，。C#提供了两种技术实现金泰多态性
// 函数重载和运算符重载

// 函数重载
namespace PolymorghismApplication
{
    public class ShapeT {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }
        // 动态多态性 通过虚方法实现动态多态性
        // 虚方法
        public virtual void Drew() => Console.WriteLine("虚拟方法");

    }

}

