using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsk19WpfApp1.Models
{
    static class CircleCalc
    {
        public static double DiaCalc(double a) => 2 * a;
        public static double AreCalc(double a) => Math.PI * Math.Pow(a, 2);
        public static double LenCalc(double a) => 2 * a * Math.PI;
    }
}
