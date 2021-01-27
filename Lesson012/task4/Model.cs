using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Model
    {
        public string Sum(string a, string b)
        {
            return (Convert.ToDouble(a) + Convert.ToDouble(b)).ToString();
        }
        public string Sub(string a, string b)
        {
            return (Convert.ToDouble(a) - Convert.ToDouble(b)).ToString();
        }
        public string Mul(string a, string b)
        {
            return (Convert.ToDouble(a) * Convert.ToDouble(b)).ToString();
        }
        public string Div(string a, string b)
        {
            if (b != "0")
                return (Convert.ToDouble(a) / Convert.ToDouble(b)).ToString();
            else return 0.ToString();
        }
    }
}
