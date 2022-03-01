using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Algorithm
{
    class Program
    {
        /*
         算法相关
         
         */
        static void Main(string[] args)
        {
            Sum1_100__n_1_ sum = new Sum1_100__n_1_();
            sum.Sum2();

            //遍历实现冒泡
            Bubbling bub = new Bubbling();
            bub.BubblingByForeach();



        }
    }
}
