using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json;



namespace ConsoleApp11
{
    class Program
    {

        static void Main(string[] args)
        {
            Trukytnuk t1 = new Trukytnuk(X1:1, Y1:1, X2: -2, Y2: 3, X3:0, Y3: 0);
            Metod2();
            Trukytnuk t2 = new Trukytnuk(X1: 0, Y1: 4, X2: 3, Y2: 2, X3: -4, Y3: -5);
            Rivnist();
            t1.P();
            t1.S();
            t1.M();
            t1.L();
            t1.H();
            t1.Radius();
            t1.radius();

            t1.Type();
            t1.sv = 90;
            t1.Povorot();
            t1.Povorot2();

          //  Metod1();
            void Metod1()
            {
                string file = "File2.json";
                string j = JsonConvert.SerializeObject(t1);
                File.WriteAllText(file, j);
                Console.WriteLine(File.ReadAllText(file));

            }
            void Metod2()
            {
            
                Trukytnuk t1 = JsonConvert.DeserializeObject<Trukytnuk>(File.ReadAllText("C:\\File2_2.json"));
                

            }
            void Rivnist()
            {
                if ((Math.Sqrt(Math.Pow((t1.x2 - t1.x1), 2) + Math.Pow((t1.y2 - t1.y1), 2)) == Math.Sqrt(Math.Pow((t2.x2 - t2.x1), 2) + Math.Pow((t2.y2 - t2.y1), 2))) && (Math.Sqrt(Math.Pow((t1.x3 - t1.x2), 2) + Math.Pow((t1.y3 - t1.y2), 2)) == Math.Sqrt(Math.Pow((t2.x3 - t2.x2), 2) + Math.Pow((t2.y3 - t2.y2), 2))) && (Math.Sqrt(Math.Pow((t1.x3 - t1.x1), 2) + Math.Pow((t1.y3 - t1.y1), 2)) == Math.Sqrt(Math.Pow((t2.x3 - t2.x1), 2) + Math.Pow((t2.y3 - t2.y1), 2))))
                {
                    Console.WriteLine("Трикутники рівні за 3-ма сторонами");
                }
                else Console.WriteLine("Трикутники не рівні ");
            }
            


        }
       

    }
    
}