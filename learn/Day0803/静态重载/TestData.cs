// 静态多态性：在编译时，函数和对性的链接机制被早期静态绑定，。C#提供了两种技术实现金泰多态性
// 函数重载和运算符重载

// 函数重载
namespace PolymorghismApplication
{
    // 静态多态性
    public class TestData
    {
        public int Add(int a, int b, int c) {

            return a + b + c;
        }

        public int Add(int a, int b) {
            return a + b;
        }
    
    }

}

