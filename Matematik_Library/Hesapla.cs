using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik_Library
{
    public class Hesapla
    {
        public double Topla(params double[] numbers)
        {
            double sum = 0;
            foreach(double item in numbers)
            {
                sum += item;
            }

            return sum;
        }

        //1,2,3,4,5
        public double Carpma(params double[] numbers)
        {
            double val = 1;
            foreach(double item in numbers)
            {
                val *= item;
            }

            return val;
        }

        public bool IsNumber(ref object Val)
        {
            try
            {
                Convert.ToDouble(Val);
                return true;
            }
            catch (Exception ex)
            {
                Val = 0;
                return false;
            }
        }

    }
}
