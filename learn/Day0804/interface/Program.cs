// 接口定义了所有类继承接口时应遵循的语法合同。接口定义了语法合同“是什么”部分。 派生类定义了语法合同“怎么做”部分
// 接口定义了属性、方法和事件， 这些都是接口的成员。接口只包含了成员的声明。成员的定义是派生类的责任。接口定义了派生类应遵循的标准结构。
// 接口使得实现接口的类或结构在形式上保持一致；
// 抽象类在某种程度上与接口类似，但是他们大多只是用在当只有少数方法由基类声明，由派生类是实现；
// 接口本省并不实现任何功能。他只是和声明实现该接口的对象订立了一个必须实现那些行为的契约；
// 抽象类不能直接实例化，但允许派生出具体的、具有实际功能的类

using System;
interface ImyInterface {

    void MethodToImplement();

}


class InterfaceImplementer : ImyInterface {


    public void MethodToImplement() {

        Console.WriteLine("MethodToImplement() called.");

    }

}
// 如果一个接口继承了其他接口，那么继承该接口的类就必须实现所有的接口方法