using System;

namespace CalculateLibrary
{
    public class CalculateFigure
    {
        public static double r;
        public static double a, b, c;
        //public double m, n;

        public static string Calc(double r)
        {
            double y = Math.PI * Math.Pow(r, 2);
            return ("Площадь круга: " + Convert.ToString(y));
        }

        public static string Calc(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double x = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            bool isrec = false;
            if ((a > b) && (a > c))
                {
                    if (Math.Pow(a, 2) == (Math.Pow(b, 2) + (Math.Pow(c, 2)))) isrec = true;
                }
            else if ((b > a) && (b > c))
                {
                    if (Math.Pow(b, 2) == (Math.Pow(a, 2) + (Math.Pow(c, 2)))) isrec = true;
                }
            else if (Math.Pow(c, 2) == (Math.Pow(b, 2) + (Math.Pow(a, 2)))) isrec = true;
            return ("Площадь Треугольника: " + Convert.ToString(x) + ". Является ли он прямоугольниым: "+ Convert.ToString(isrec));
        }

        //public static string Calc(double n, double m)
        //{ return ("Площадь прямоугольника: " + Convert.ToString(m*n)); }
    }
}
