using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculateAPI
{
    public class Business
    {
        public double Multiple(double a, double b)
        {
            return a * b;
        }
        public double Sum(double a, double b)
        {
            return a + b;
        }
        public double Extraction(double a, double b)
        {
            return a - b;
        }

        public double BaseOperation(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public double Divide(double a, double b)
        {
            return a / b;
        }

    }
}
