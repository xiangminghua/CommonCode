using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Inherit
{
    /*
     Inherit:继承

     */

    class Program
    {
        static void Main(string[] args)
        {
            Class2 o = new Class2();
            // o.MethodA();
            o.MethodB();

            Console.WriteLine("33");

        }
    }
    abstract class Baseclass
    {
        public virtual void MethodA() { }
        public virtual void MethodB() { }

    }

    class Class1 : Baseclass
    {
        public void MethodA(string arg) { }
        public override void MethodB() { }

    }

    class Class2 : Class1
    {
        new public void MethodB() { }

    }

}

/*
 具体的检查的流程如下：

1、当调用一个对象的函数时，系统会直接去检查这个对象申明定义的类，即申明类，看所调用的函数是否为虚函数；
2、如果不是虚函数，那么它就直接执行该函数。而如果有virtual关键字，也就是一个虚函数，那么这个时候它就不会立刻执行该函数了，而是转去检查对象的实例类。
3、在这个实例类里，他会检查这个实例类的定义中是否有重新实现该虚函数（通过override关键字），如果是有，那么OK，它就不会再找了，而马上执行该实例类中的这个重新实现的函数。
而如果没有的话，系统就会不停地往上找实例类的父类，并对父类重复刚才在实例类里的检查，直到找到第一个重载了该虚函数的父类为止，然后执行该父类里重载后的函数。


    class A
    {
        public virtual void Func() // 注意virtual,表明这是一个虚拟函数
        {
            Console.WriteLine("Func In A");
        }
    }

    class B : A // 注意B是从A类继承,所以A是父类,B是子类
    {
        public override void Func() // 注意override ,表明重新实现了虚函数
        {
            Console.WriteLine("Func In B");
        }
    }

    class C : B // 注意C是从A类继承,所以B是父类,C是子类
    {
    }

    class D : A // 注意B是从A类继承,所以A是父类,D是子类
    {
        public new void Func() // 注意new ，表明覆盖父类里的同名类，而不是重新实现
        {
            Console.WriteLine("Func In D");
        }
    }

    class program
    {
        static void Main()
        {
            A a;         // 定义一个a这个A类的对象.这个A就是a的申明类
            A b;         // 定义一个b这个A类的对象.这个A就是b的申明类
            A c;         // 定义一个c这个A类的对象.这个A就是b的申明类
            A d;         // 定义一个d这个A类的对象.这个A就是b的申明类

            a = new A(); // 实例化a对象,A是a的实例类
            b = new B(); // 实例化b对象,B是b的实例类
            c = new C(); // 实例化b对象,C是b的实例类
            d = new D(); // 实例化b对象,D是b的实例类

            a.Func();    // 执行a.Func：1.先检查申明类A 2.检查到是虚拟方法 3.转去检查实例类A，就为本身 4.执行实例类A中的方法 5.输出结果 Func In A
            b.Func();    // 执行b.Func：1.先检查申明类A 2.检查到是虚拟方法 3.转去检查实例类B，有重载的 4.执行实例类B中的方法 5.输出结果 Func In B
            c.Func();    // 执行c.Func：1.先检查申明类A 2.检查到是虚拟方法 3.转去检查实例类C，无重载的 4.转去检查类C的父类B，有重载的 5.执行父类B中的Func方法 5.输出结果 Func In B
            d.Func();    // 执行d.Func：1.先检查申明类A 2.检查到是虚拟方法 3.转去检查实例类D，无重载的（这个地方要注意了，虽然D里有实现Func()，但没有使用override关键字，所以不会被认为是重载） 4.转去检查类D的父类A，就为本身 5.执行父类A中的Func方法 5.输出结果 Func In A
            D d1 = new D();
            d1.Func(); // 执行D类里的Func()，输出结果 Func In D
            Console.ReadLine();
        }
    } 
 
 */