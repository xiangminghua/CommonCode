using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Base
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1、委托
            委托是一个类，它定义了方法的类型，使得可以将方法当作另一个方法的参数来进行传递，这种将方法动态地赋给参数的做法，可以避免在程序中大量使用If … Else(Switch)语句，同时使得程序具有更好的可扩展性
            委托总结：使用委托可以将多个方法绑定到同一个委托变量，当调用此变量时(这里用“调用”这个词，是因为此变量代表一个方法)，可以依次调用所有绑定的方法。

             */
            DelegateDemo.TestDelegate();

            /*
             
             */

        }
    }
}
