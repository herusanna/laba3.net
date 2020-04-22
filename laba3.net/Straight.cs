using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3.net
{
    class Straight
    {
        Random r;
        public int x;
        public int y;
        public int K1;
        public int K2;
        public int[] B;
        public int[] a;
        public int[] b;
        double angle;
        public double Angle { get => angle; set => angle = value; }
        public Straight()
        {
            r = new Random();
            a = new int[2];
            b = new int[2];
            do
            {
                x = r.Next(1, 6);
                y = r.Next(1, 6);
                if (x != 0)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        a[i] = r.Next(1, 10);
                        b[i] = r.Next(1, 10);
                    }
                    K1 = (a[1] - a[0]) * (y / x);
                    K2 = (b[1] - b[0]) * (y / x);
                }
            } while (K1 == 0 || K2 == 0 && (a[1] - a[0]) != (b[1] - b[0]));
            B = new int[2];
            B[0] = a[0] * (-K1 * x + y);
            B[1] = b[0] * (-K2 * x + y);
        }
        string getEquation()
        {
            string equa = "";
            equa += $"Y = {K1}X + {B[0]}\n";
            equa += $"Y = {K2}X + {B[1]}\n";
            return equa;
        }
        public string showInfo()
        {
            string info = "";
            info += "--------------------------------------First line points\n";

            for (int i = 0; i < 2; i++)
            {
                info += $"Point {i + 1}: х = {x * a[i]},\t у = {y * a[i]}\n";
            }
            info += "-------------------------------------Second line points\n";
            for (int i = 0; i < 2; i++)
            {
                info += $"Point {i + 3}: х = {x * b[i]},\t у = {y * b[i]}\n";
            }
            info += "---------------------------------------------------------\n";
            info += getEquation();
            return info;
        }
        public static double operator %(Straight x, Straight y)
        {
            double Angle = ((x.K1 - y.K2) / (1 + x.K1 * y.K2)) * 180 / Math.PI;
            return Angle;
        }
        public static bool operator ==(Straight x, Straight y)
        {
            bool isParalel = false;
            if (x.K1 == y.K2)
            {
                isParalel = true;
            }
            return isParalel;
        }
        public static bool operator !=(Straight x, Straight y)
        {
            bool isParalel = true;
            if (x.K1 != y.K2)
            {
                isParalel = false;
            }
            return isParalel;
        }
    }
}