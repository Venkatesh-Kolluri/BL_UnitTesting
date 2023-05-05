using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    public class Maths
    {
        public long Add(int x, int y)
        {
            long result =(long) x +(long) y;
            return result;
          
        }
         public long Add2(int x, int y)
        {
             x = int.MaxValue; y = int.MinValue;
            long result = (long) x + (long) y;
            return result; 
        }
        public long Add3(int x, int y)
        {
            long result = (long)x + (long)y;
            return result;

        }
        public double Divide(double x, double y)
        {
            double result = x / y;
            return result;

        }
        public string Concate(string x,string y)
        {
            string result= x +" "+ y;
            return result;
        }
        public int ConcateValue(char x, char y)
        {
            int result = x + y;
            return result;
        }
    }
}
