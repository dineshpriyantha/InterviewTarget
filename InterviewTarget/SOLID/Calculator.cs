using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTarget.SOLID
{
    public interface ICalculator
    {
        double Calculate(string operation, double x, double y);
    }

    public class Add : ICalculator
    {
        public double Calculate(string operation, double x, double y)
        {
            if (operation.Equals("+"))
            {
                return x + y;
            }
            return 0;
        }
    }

    public class Subtract : ICalculator
    {
        public double Calculate(string operation, double x, double y)
        {
            if(operation.Equals("-"))
            {
                return x - y;
            }
            return 0;
        }
    }

    public class Multiply : ICalculator
    {
        public double Calculate(string operation, double x, double y)
        {
            if (operation.Equals("*"))
            {
                return x * y;
            }
            return 0;
        }
    }

    public class Division : ICalculator
    {
        public double Calculate(string operation, double x, double y)
        {
           if (operation.Equals("/"))
            {
                if( y == 0)
                {
                    Console.WriteLine("Cannot devide by zero");
                }
                return (x / y);
            }
           return 0;
        }
    }

    public class Calculator
    {
        private readonly ICalculator _add;
        private readonly ICalculator _sub;
        private readonly ICalculator _mul;
        private readonly ICalculator _div;

        public Calculator(ICalculator add, ICalculator sub, ICalculator mul, ICalculator div)
        {
            _add= add;
            _sub= sub;
            _mul= mul;
            _div= div;
        }

        public double Calculate(string opration, double x, double y)
        {
            double result;

            result = _add.Calculate(opration, x, y);
            if(result != 0) return result;

            result = _sub.Calculate(opration, x, y);
            if(result != 0) return result;

            result = _mul.Calculate(opration, x, y);
            if(result != 0) return result;

            result = _div.Calculate(opration, x, y);
            if(result != 0) return result;

            Console.WriteLine("Invalid Operation");
            return 0;
        }
    }
}
