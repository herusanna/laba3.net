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
        public int[] K;
        public int[] B;
        public int[] a;
        public int[] b;
        int angle;
        public int Angle { get => angle; set => angle = value; }

        public void getPoints(int seed)
        {
            r = new Random(seed);
            a = new int[2];
            b = new int[2];
            x = r.Next(1, 6);
            y = r.Next(1, 6);
            for (int i = 0; i < 2; i++)
            {
                a[i] = r.Next(1, 20);
            }
            for (int i = 0; i < 2; i++)
            {
                b[i] = r.Next(1, 20);
            }
        }
        public void getCoefficient()
        {
            K = new int[2];
            if (((x * a[1] - x * a[0]) != 0) && ((x * b[1] - x * b[0]) != 0))
            {
                K[0] = (y * (a[1] - a[0])) / (x * (a[1] - a[0]));
                K[1] = (y * (b[1] - b[0])) / (x * (b[1] - b[0]));
            }
            B = new int[2];
            B[0] = a[0] * (-K[0] * x + y);
            B[1] = b[0] * (-K[1] * x + y);
        }
        string getEquation()
        {
            string equa = "";
            for (int i = 0; i < 2; i++)
            {
                equa += $"Y = {K[i]}X + {B[i]}\n";
            }
            return equa;
        }
        public double getAngle()
        {
            Angle = (K[0] - K[1]) / (1 + K[0] * K[1]);
            return Math.Atan(Angle);
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
            /*if (checkParallel() == true)
                info += "Straight lines are parallel\n";
            else
                info += $"The angle between the lines = {getAngle()}\n";
            */
            return info;
        }
        public static Straight operator -(Straight x, Straight y)
        {
            Straight res = new Straight();
             res.Angle = x.K[0] - y.K[1];
            return res;
        }
        public static Straight operator *(Straight x, Straight y)
        {
            Straight res = new Straight();
            res.Angle = x.K[0] * y.K[1];
            return res;
        }
        public static Straight operator /(Straight x, Straight y)
        {
            Straight res = new Straight();
            res.Angle = (x.K[0] - y.K[1]) / (1 + x.K[0] * y.K[1]);
            res.Angle = (int)Math.Atan(res.Angle);
            return res;
        }
        /*
        public static Straight operator false(Straight x, Straight y)
        {          
            //bool parallel = false;
            if (x.K[0] == y.K[1])  //parallel = true;             
            return true;
        }
        */
    }    
}

