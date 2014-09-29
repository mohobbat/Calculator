using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAPP
{
    class Calculator
    {
        public double firstNo;
        public double secondNo;
        public double result;
        // public double result;

        public double Add()
        {
            return firstNo + secondNo;
        }

        public double Subtract()
        {
            return firstNo - secondNo;
        }

        public double multiply()
        {
            return firstNo*secondNo;
        }

        public double Divided()
        {
            return firstNo/secondNo;
        }
    }
}
