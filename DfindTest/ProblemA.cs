using System;

namespace DfindTest.Main
{
    public class ProblemA
    {
        public static double GetPNorm(double x1, double y1, double x2, double y2, double p)
        {
            double pNorm = Math.Pow((Math.Pow(Math.Abs(x1 - x2), p) + Math.Pow(Math.Abs(y1 - y2), p)) , 1 / p);
            pNorm = Math.Round(pNorm, 10);

            return pNorm;
        }
    }
}
