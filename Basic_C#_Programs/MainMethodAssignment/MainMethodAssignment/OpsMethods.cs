using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class OpsMethods
    {
        public int methodOne(int num1)
        {
            return num1 + 10;
        }

        public int methodOne(decimal num2)
        {
            return Decimal.ToInt32(num2) - 2;
        }

        public int methodOne(string num3)
        {
            return Convert.ToInt32(num3)/3;
        }
    }
}
