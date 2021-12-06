using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{   
    
    public class Triangle {
        public int firstSide;
        public int secondSide;
        public int thirdSide;
        public double firstAngles;
        public double secondAngles;
        public double thirdAngles;
        public double p;
        public double s;

        public Triangle(int a, int b, int c){
            firstSide = a;
            secondSide = b;
            thirdSide = c;
            double num1 = (firstSide * firstSide + thirdSide * thirdSide - secondSide * secondSide);
            double num2 = (2 * firstSide * thirdSide);
            double num3 = (secondSide * secondSide + thirdSide * thirdSide - firstSide * firstSide);
            double num4 = (2 * secondSide * thirdSide);
            secondAngles = Math.Round(Math.Acos(num1 / num2) * (180 / Math.PI), 2);
            firstAngles = Math.Round(Math.Acos(num3 / num4) * (180 / Math.PI), 2);
            thirdAngles = 180 - (firstAngles + secondAngles);
            p = (firstSide + secondSide + thirdSide);
            double p2 = p / 2;
            s = Math.Sqrt(p2 * (p2 - firstSide) * (p2 - secondSide) * (p2 - thirdSide));
        }

        public Triangle(int a, int b, float c)
        {
            firstSide = a;
            secondSide = b;
            thirdAngles = c;
            double num2 = Math.Cos(thirdAngles / (180 / Math.PI));
            double num1 = 2 * firstSide * secondSide * num2;
            thirdSide = Convert.ToInt32(Math.Sqrt(firstSide * firstSide + secondSide * secondSide - num1));
            num1 = (firstSide * firstSide + thirdSide * thirdSide - secondSide * secondSide);
            num2 = (2 * firstSide * thirdSide);
            secondAngles = Math.Round(Math.Acos(num1 / num2) * (180 / Math.PI), 2);
            firstAngles = 180 - (thirdAngles + secondAngles);
            p = (firstSide + secondSide + thirdSide);
            double p2 = p / 2;
            s = Math.Sqrt(p2 * (p2 - firstSide) * (p2 - secondSide) * (p2 - thirdSide));
        }

        public Triangle(int a, float b, float c)
        {
            firstSide = a;
            firstAngles = b;
            secondAngles = c;
            thirdAngles = (180 - (secondAngles + firstAngles));
            double ff = Math.Sin((firstAngles * (Math.PI)) / 180);
            double ss = Math.Sin((secondAngles * (Math.PI)) / 180);
            double tt = Math.Sin((thirdAngles * (Math.PI)) / 180);
            secondSide = Convert.ToInt32(firstSide * (ff / tt));
            thirdSide = Convert.ToInt32(firstSide * (ss / tt));
            p = (firstSide + secondSide + thirdSide);
            double p2 = p / 2;
            s = Math.Sqrt(p2 * (p2 - firstSide) * (p2 - secondSide) * (p2 - thirdSide));
        }

        public void showHeights(){
            Console.WriteLine("a висота: " + Math.Round((2 * s) / firstSide, 2));
            Console.WriteLine("b висота: " + Math.Round((2 * s) / secondSide, 2));
            Console.WriteLine("c висота: " + Math.Round((2 * s) / thirdSide, 2));
        }

        public void showMedians()
        {
            double num1 = Math.Sqrt(2 * firstSide * firstSide + 2 * secondSide * secondSide - thirdSide * thirdSide);
            double num2 = Math.Sqrt(2 * firstSide * firstSide + 2 * thirdSide * thirdSide - secondSide * secondSide);
            double num3 = Math.Sqrt(2 * thirdSide * thirdSide + 2 * secondSide * secondSide - firstSide * firstSide);
            Console.WriteLine("a медiана: " + Math.Round(num1 / 2, 2));
            Console.WriteLine("b медiана: " + Math.Round(num2 / 2, 2)); 
            Console.WriteLine("c медiана: " + Math.Round(num3 / 2, 2));
        }

        public void showBisectrs()
        {
            double p2 = (firstSide + secondSide + thirdSide) / 2;
            double sum1 = (secondSide + thirdSide) * (secondSide + thirdSide);
            double num1 = (4 * secondSide * thirdSide) / sum1;
            double sum2 = (firstSide + thirdSide) * (firstSide + thirdSide);
            double num2 = (4 * firstSide * thirdSide) / sum2;
            double sum3 = (firstSide + secondSide) * (firstSide + secondSide);
            double num3 = (4 * firstSide * secondSide) / sum3;
            Console.WriteLine("a бісектриса: " + Math.Round(Math.Sqrt(num1 * p2 * (p2 - firstSide)), 2));
            Console.WriteLine("b бісектриса: " + Math.Round(Math.Sqrt(num2 * p2 * (p2 - secondSide)), 2));
            Console.WriteLine("c бісектриса: " + Math.Round(Math.Sqrt(num3 * p2 * (p2 - thirdSide)), 2));
        }

        public void showRadius()
        {
            double p2 = (firstSide + secondSide + thirdSide) / 2.0;
            double num1 = (p2 - firstSide) * (p2 - secondSide) * (p2 - thirdSide);
            double sum = firstSide * secondSide * thirdSide;
            Console.WriteLine("Радіус зовнішній: " + Math.Round(sum / (4 * Math.Sqrt(p2 * num1)), 2));
            Console.WriteLine("Радіуc внутрішній: " + Math.Round(Math.Sqrt(num1 / p2), 2));
        }

        public void showInf()
        {
            if (firstAngles > 90 || secondAngles > 90 || thirdAngles > 90){
                Console.WriteLine("Тупий");
            } else if (firstAngles == 90 || secondAngles == 90 || thirdAngles == 90){
                Console.WriteLine("Прямий");
            } else {
                Console.WriteLine("Гострий");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("1) 3 сторони");
            Console.WriteLine("2) 2 сторони i кут");
            Console.WriteLine("3) 1 сторона i 2 кути");
            int answer = Convert.ToInt32(Console.ReadLine());

            if(answer == 1){
                Console.WriteLine("Сторона AB");
                int firstSide = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Сторона BC");
                int secondSide = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Сторона CA");
                int thirdSide = Convert.ToInt32(Console.ReadLine());
                Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);
                if (triangle.firstSide + triangle.secondSide < triangle.thirdSide ||
                    triangle.firstSide + triangle.thirdSide < triangle.secondSide ||
                    triangle.thirdSide + triangle.secondSide < triangle.firstSide)
                {
                    Console.WriteLine("Помилка, трикутник не iснує");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("AB сторона: " + triangle.firstSide);
                Console.WriteLine("BC сторона: " + triangle.secondSide);
                Console.WriteLine("CD сторона: " + triangle.thirdSide);
                Console.WriteLine("a кут: " + triangle.firstAngles);
                Console.WriteLine("b кут: " + triangle.secondAngles);
                Console.WriteLine("c кут: " + triangle.thirdAngles);
                Console.WriteLine("Площа: " + Math.Round(triangle.s, 2));
                triangle.showHeights();
                triangle.showMedians();
                triangle.showBisectrs();
                triangle.showRadius();
                triangle.showInf();
            } else if (answer == 2) {
                Console.WriteLine("Сторона AB");
                int firstSide = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Сторона BC");
                int secondSide = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Кут с");
                float thirdAngles = float.Parse(Console.ReadLine());
                Triangle triangle = new Triangle(firstSide, secondSide, thirdAngles);
                if (triangle.firstSide + triangle.secondSide < triangle.thirdSide ||
                    triangle.firstSide + triangle.thirdSide < triangle.secondSide ||
                    triangle.thirdSide + triangle.secondSide < triangle.firstSide)
                {
                    Console.WriteLine("Помилка, трикутник не існує");
                    return;
                }
                Console.WriteLine("AB сторона: " + triangle.firstSide);
                Console.WriteLine("BC сторона: " + triangle.secondSide);
                Console.WriteLine("CD сторона: " + triangle.thirdSide);
                Console.WriteLine("a кут: " + triangle.firstAngles);
                Console.WriteLine("b кут: " + triangle.secondAngles);
                Console.WriteLine("c кут: " + triangle.thirdAngles);
                Console.WriteLine("Площа: " + Math.Round(triangle.s, 2));
                triangle.showHeights();
                triangle.showMedians();
                triangle.showBisectrs();
                triangle.showRadius();
                triangle.showInf();
            }
            else if (answer == 3){
                Console.WriteLine("Сторона AB");
                int firstSide = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("кут a");
                int firstAngles = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Кут b");
                float secondAngles = float.Parse(Console.ReadLine());

                Triangle triangle = new Triangle(firstSide, firstAngles, secondAngles);

                Console.WriteLine("AB сторона: " + triangle.firstSide);
                Console.WriteLine("BC сторона: " + triangle.secondSide);
                Console.WriteLine("CD сторона: " + triangle.thirdSide);
                Console.WriteLine("a кут: " + triangle.firstAngles);
                Console.WriteLine("b кут: " + triangle.secondAngles);
                Console.WriteLine("c кут: " + triangle.thirdAngles);
                Console.WriteLine("Площа: " + Math.Round(triangle.s, 2));
                triangle.showHeights();
                triangle.showMedians();
                triangle.showBisectrs();
                triangle.showRadius();
                triangle.showInf();
            }


            Console.ReadKey();
        }
    }
}
