using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace clas
{
    public class Calc_class
    {
        public static double sum(double first_number, double second_number)
        {
            double result = first_number + second_number;
            return result;
        }
        public static double sub(double first_number, double second_number)
        {
            double result = first_number - second_number;
            return result;
        }
    public static double mul(double first_number, double second_number)
        {
            double result = first_number * second_number;
            return result;
        }
        public static double div(double first_number, double second_number)
        {
            double result = first_number / second_number;
            return result;
        }

    }
}
