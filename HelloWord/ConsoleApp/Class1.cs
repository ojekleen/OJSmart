using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Class1
    {
        public int ID { get; set; }

        public int InValue { get; set; }

        public long OutValue { get; set; }

        public Class1(int inValue)
        {
            this.InValue = inValue;
        }

        //public System.Threading.Thread CurThread { get; set; }

    }
}
