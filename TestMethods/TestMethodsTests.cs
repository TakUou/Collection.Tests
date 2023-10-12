using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TestMethods
{
    public class TestMethodsTests
    {
        public List<string> TestMethod(double a, double b, double c)
        {
            List<string> ret = new List<string>();
            double x1, x2;
            var discriminant = Math.Pow(b, 2) - 4 * a * c;
            if (discriminant < 0)
            {
                ret.Add("корней нет");
                return ret;
            }
            else
            {
                if (discriminant == 0) //квадратное уравнение имеет два одинаковых корня
                {
                    x1 = -b / (2 * a);
                    ret.Add(x1.ToString());
                    return ret;
                    
                }
                else //уравнение имеет два разных корня
                {
                    x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    ret.Add(x2.ToString());
                    ret.Add(x1.ToString());
                    return ret;
                }
            }
        }
        public double CalculatePercentage(double number, double percentage)
        {
            return number * percentage / 100;
        }
    }
}
