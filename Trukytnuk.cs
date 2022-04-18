using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp11
{
    class Trukytnuk
    {
        public double x1;
        public double y1;

        public double x2;
        public double y2;

        public double x3;
        public double y3;


        private double kyt;


        double v1; double v2; double v3; double p; double s; double m1; double m2; double m3; double h1; double h2; double h3; double l1; double l2; double l3; double R; double r; double k1; double k2; double k3;
        public Trukytnuk(double X1, double Y1, double X2, double Y2, double X3, double Y3)
        {
            x1 = X1;
            y1 = Y1;

            x2 = X2;
            y2 = Y2;

            x3 = X3;
            y3 = Y3;

        }
        [JsonIgnore]
        public double sv
        {
            get { return kyt; }
            set { kyt = value; }
        }
        public void Vidrizok()

        {
            v1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            v2 = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            v3 = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));

        }
        public double P()
        {
            Vidrizok();
            p = v1 + v2 + v3;
            Console.WriteLine("Периметр: " + p);
            return p;
        }
        public double S()
        {

            s = Math.Sqrt(p / 2 * (p / 2 - v1) * (p / 2 - v2) * (p / 2 - v3));
            Console.WriteLine("Площа: " + s);
            return s;
        }
        public double M()
        {

            m1 = Math.Sqrt(Math.Pow(2 * v1, 2) + Math.Pow(2 * v2, 2) - Math.Pow(v3, 2)) / 2;
            m2 = Math.Sqrt(Math.Pow(2 * v1, 2) + Math.Pow(2 * v3, 2) - Math.Pow(v2, 2)) / 2;
            m3 = Math.Sqrt(Math.Pow(2 * v3, 2) + Math.Pow(2 * v2, 2) - Math.Pow(v1, 2)) / 2;
            Console.WriteLine("Медіана1: " + m1);
            Console.WriteLine("Медіана2: " + m2);
            Console.WriteLine("Медіана3: " + m3);
            return m1; return m2; return m3;
        }
        public double H()
        {

            h1 = 2 * s / v1;
            h2 = 2 * s / v2;
            h3 = 2 * s / v3;
            Console.WriteLine("Висота1: " + h1);
            Console.WriteLine("Висота2: " + h2);
            Console.WriteLine("Висота3: " + h3);
            return h1; return h2; return h3;
        }
        public double L()
        {

            l1 = Math.Sqrt(v1 * v2 * (v1 + v2 + v3) * (v1 + v2 - v3)) / (v1 + v2);
            l2 = Math.Sqrt(v3 * v2 * (v1 + v2 + v3) * (v3 + v2 - v1)) / (v3 + v2);
            l3 = Math.Sqrt(v1 * v3 * (v1 + v2 + v3) * (v1 + v3 - v2)) / (v1 + v3);
            Console.WriteLine("Бісектриса1: " + l1);
            Console.WriteLine("Бісектриса2: " + l2);
            Console.WriteLine("Бісектриса3: " + l3);
            return l1; return l2; return l3;
        }
        public double Radius()
        {

            R = v1 * v2 * v3 / 4 * s;
            Console.WriteLine("Радіус(опис): " + R);
            return R;
        }
        public double radius()
        {

            r = Math.Sqrt((p / 2 - v1) * (p / 2 - v2) * (p / 2 - v3) / (p / 2));
            Console.WriteLine("Радіус(впис): " + r);
            return r;
        }
        public double Kyt()
        {
            k1 = ((Math.Pow(v2, 2) + Math.Pow(v3, 2) - Math.Pow(v1, 2)) / 2 * v2 * v3);
            k2 = ((Math.Pow(v1, 2) + Math.Pow(v3, 2) - Math.Pow(v2, 2)) / 2 * v1 * v3);
            k3 = ((Math.Pow(v2, 2) + Math.Pow(v1, 2) - Math.Pow(v3, 2)) / 2 * v2 * v1);

            return k1; return k2; return k3;
        }

        public void Type()
        {
            if (v1 == v2 && v2 == v3)
            {
                Console.WriteLine("Трикутник рівносторонній");
            }
            else if (v1 == v2 || v3 == v2 || v1 == v3)
            {
                Console.WriteLine("Трикутник рівнобедрений");
            }
            else if (k1 == Math.Cos(Math.PI) || k2 == Math.Cos(Math.PI) || k3 == Math.Cos(Math.PI))
            {
                Console.WriteLine("Трикутник прямокутний");
            }
            else if (k1 < Math.Cos(Math.PI) && k2 < Math.Cos(Math.PI) && k3 < Math.Cos(Math.PI))
            {
                Console.WriteLine("Трикутник гострокутній");
            }
            else if (k1 > Math.Cos(Math.PI) || k2 > Math.Cos(Math.PI) || k3 > Math.Cos(Math.PI))
            {
                Console.WriteLine("Трикутник тупокутній");
            }

        }
        public void Povorot()
        {


            kyt = kyt * Math.PI / 180;
            x1 = x1 - x3;
            y1 = y1 - y3;
            double x = x1 * Math.Cos(kyt) - y1 * Math.Sin(kyt);
            double y = x1 * Math.Sin(kyt) + y1 * Math.Cos(kyt);


            x2 = x2 - x3;
            y2 = y2 - y3;
            double xx = x2 * Math.Cos(kyt) - y2 * Math.Sin(kyt);
            double yy = x2 * Math.Sin(kyt) + y2 * Math.Cos(kyt);

            Console.Write("При повороті відносно вершини: ");
            Console.WriteLine("x1; y1: " + x + "; " + y);
            Console.WriteLine("x2; y2: " + xx + "; " + yy);
            Console.WriteLine("x3; y3: " + x3 + "; " + y3);


        }
        public void Povorot2()
        {
            double xO = (1 / (4 * s)) * ((Math.Pow(x1, 2) + Math.Pow(y1, 2)) * y2 + y1 * (Math.Pow(x3, 2) + Math.Pow(y3, 2)) + y3 * (Math.Pow(x2, 2) + Math.Pow(y2, 2)) - y2 * (Math.Pow(x3, 2) + Math.Pow(y3, 2)) - y1 * (Math.Pow(x2, 2) + Math.Pow(y2, 2)) - y3 * (Math.Pow(x1, 2) + Math.Pow(y1, 2)));
            double yO = -(1 / (4 * s));
            x1 = x1 - xO;
            y1 = y1 - yO;
            double x = x1 * Math.Cos(kyt) - y1 * Math.Sin(kyt);
            double y = x1 * Math.Sin(kyt) + y1 * Math.Cos(kyt);

            x2 = x2 - xO;
            y2 = y2 - yO;
            double xx = x2 * Math.Cos(kyt) - y2 * Math.Sin(kyt);
            double yy = x2 * Math.Sin(kyt) + y2 * Math.Cos(kyt);

            x3 = x2 - xO;
            y3 = y2 - yO;
            double xxx = x3 * Math.Cos(kyt) - y3 * Math.Sin(kyt);
            double yyy = x3 * Math.Sin(kyt) + y3 * Math.Cos(kyt);


            Console.Write("При повороті відносно центра: ");
            Console.WriteLine("x1; y1: " + x + "; " + y);
            Console.WriteLine("x2; y2: " + xx + "; " + yy);
            Console.WriteLine("x3; y3: " + xxx + "; " + yyy);
        }
    }
}
