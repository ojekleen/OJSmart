using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Class2
    {
        public void r1(object obj)
        {
            Class1 c1 = obj as Class1;

            if (c1 == null)
                throw new Exception("参数类型不正确");

            c1.OutValue = c1.InValue * 2;

            System.Random random = new Random();
            int i = random.Next(1, 10);

            TimeSpan s = new TimeSpan(0,0,i);            

            System.Threading.Thread.Sleep(s);

            Console.WriteLine(string.Format("线程{0}内值为:{1}", c1.ID, c1.OutValue));

        }
    }
}
