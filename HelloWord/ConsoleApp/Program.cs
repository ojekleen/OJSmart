using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Class2 p1 = new Class2();

            long sum = 0;
            List<System.Threading.Thread> ls = new List<System.Threading.Thread>();
            List<Class1> cs = new List<Class1>();

            for (int i = 0; i < 100; i++)
            {
                Class1 c1 = new Class1(new Random().Next());
                c1.ID = i;
                System.Threading.Thread t1 = new System.Threading.Thread(p1.r1);
                ls.Add(t1);
                cs.Add(c1);

                t1.Start(c1);
            }

            foreach (System.Threading.Thread t in ls)
            {
                t.Join();
            }

            foreach (Class1 c in cs)
            {
                Console.WriteLine(string.Format("线程{0}外值为:{1}", c.ID, c.OutValue));

                sum += (int)c.OutValue;
            }
            
            Console.WriteLine(string.Format("返回总值为：{0}", sum));

            //Class1 c2 = new Class1(2);
            //System.Threading.Thread t2 = new System.Threading.Thread(p1.r1);
            //t2.Start(c2);
            //t2.Join();
           
            //Console.WriteLine(c2.OutValue);
            Console.ReadLine();
            
        }


    }
}
