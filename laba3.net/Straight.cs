using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3.net
{
    class Straight
    {
       
        public int x;
        public int y;
        public double K1;
        public double K2;
        public double B1, B2;
        public int[] a;
        public int[] b;
        double angle;
        
        public double Angle { get => angle; set => angle = value; }
        public Straight(int seed)
        {
            Random r = new Random(seed);
            a = new int[2];
            b = new int[2];
            do
            {
                x = r.Next(1, 5);
                y = r.Next(1, 5);
                if (x != 0)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        a[i] = r.Next(1, 5);
                        b[i] = r.Next(1, 5);
                    }
                    K1 = (a[1] - a[0]) * (y / x);
                    K2 = (b[1] - b[0]) * (y / x);
                }
            } while (K1 == 0 || K2 == 0 && (a[1] - a[0]) != (b[1] - b[0]));
                B1 = a[0] * (-K1 * x + y);
                B2 = b[0] * (-K2 * x + y);
        }
        public Straight() { }
        string getEquation()
        {
            string equa = "";
            equa += $"Y = {K1}X + {B1}\n";
            equa += $"Y = {K2}X + {B2}\n";
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
            double Angle =(x.K2 - y.K1) / (1 + x.K1 * y.K2);
            Angle = Math.Atan(Angle);
            Angle = Angle * (180 / Math.PI);
            Angle = Math.Round(Angle);
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