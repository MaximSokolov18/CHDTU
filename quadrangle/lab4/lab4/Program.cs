using System;

namespace lab4
{
    class Program
    {

        class Triangle
        {

            public float FirstSide { get; set; }
            public float SecondSide { get; set; }
            public float ThirdSide { get; set; }
            public float FirstAngles { get; set; }
            public float SecondAngles { get; set; }
            public float p;
            public float s;

            public Triangle(float firstSide, float secondSide, float thirdSide)
            {
                FirstSide = firstSide;
                SecondSide = secondSide;
                ThirdSide = thirdSide;
            }

            public double getS(float firstSide, float secondSide, float thirdSide)
            {
                float p = (firstSide + secondSide + thirdSide);
                double p2 = p / 2.0;
                double s = Math.Sqrt(p2 * (p2 - firstSide) * (p2 - secondSide) * (p2 - thirdSide));
                return s;
            }

            public bool isExists()
            {
                if (FirstSide > (SecondSide + ThirdSide)
                    || SecondSide > (FirstSide + ThirdSide)
                    || ThirdSide > (FirstSide + SecondSide))
                {
                    return false;
                }
                return true;
            }

            public float getAnglesTri(float firstSide, float thirdSide, float secondSide) {
                float num1 = (firstSide * firstSide + thirdSide * thirdSide - secondSide * secondSide);
                float num2 = (2 * firstSide * thirdSide);
                float angles = (float)Math.Round(Math.Acos(num1 / num2) * (180 / Math.PI), 2);
                return angles;
            }
        }
        class Square : Triangle
        {
            public float FourthSide { get; set; }
            public float DiagonalOne { get; set; }
            public float DiagonalTwo { get; set; }
            public float ThirdAngles { get; set; }
            public float FourthAngeles { get; set; }

            public Square(float firstSide, float secondSide, float firstAngles, float thirdSide, float fourthSide, float secondAngles)
                : base(firstSide, secondSide, thirdSide)
            {
                FirstAngles = firstAngles;
                SecondAngles = secondAngles;
                FourthSide = fourthSide;
                double num2 = Math.Cos(firstAngles * (Math.PI / 180));
                double num1 = 2.0 * FirstSide * SecondSide * num2;
                DiagonalOne = (float)Math.Sqrt(FirstSide * FirstSide + SecondSide * SecondSide - num1);
            }

            public double getSQ()
            {
                return getS(FirstSide, SecondSide, DiagonalOne) + getS(ThirdSide, FourthSide, DiagonalOne);
            }

            public double getPQ()
            {
                return FirstSide + SecondSide + ThirdSide + FourthSide;
            }

            public bool isExistsSq()
            {
                if (isExists() || ThirdSide > (FourthSide + DiagonalOne)
                    || FourthSide > (ThirdSide + DiagonalOne)
                    || DiagonalOne > (ThirdSide + FourthSide))
                {
                    return true;
                }

                return false;
            }

            public void getAngles()
            {   
                ThirdAngles = getAnglesTri(FirstSide, DiagonalOne, SecondSide) + getAnglesTri(FourthSide, DiagonalOne, ThirdSide);
                FourthAngeles = getAnglesTri(SecondSide, DiagonalOne, FirstSide) + getAnglesTri(ThirdSide, DiagonalOne, FourthSide);
            }

            public float getDiagonalTwo()
            {
                double num2 = Math.Cos(FourthAngeles * (Math.PI / 180));
                double num1 = 2.0 * ThirdSide * SecondSide * num2;
                DiagonalTwo = (float)Math.Sqrt(ThirdSide * ThirdSide + SecondSide * SecondSide - num1);
                return DiagonalTwo;
            }

            public void showTypeSq()
            {
                if (FirstSide == SecondSide && SecondSide == ThirdSide && ThirdSide == FourthSide
                    && FirstAngles == 90 && SecondAngles == 90 && ThirdAngles == 90 && FourthAngeles == 90)
                {
                    Console.WriteLine("Тип: квадрат");

                }
                else if (FirstSide == ThirdSide && SecondSide == FourthSide && FourthAngeles == 90 && SecondAngles == 90
              && ThirdAngles == 90 && FirstAngles == 90)
                {
                    Console.WriteLine("Тип: прямокутник");
                }
                else if (FirstSide == ThirdSide && SecondSide == FourthSide && FirstAngles == SecondAngles
            && ThirdAngles == FourthAngeles)
                {
                    Console.WriteLine("Тип: паралелограм");
                }
                else
                {
                    Console.WriteLine("Тип: не паралелограм");
                }

            }
        }
            static void Main(string[] args)
            {
            Console.WriteLine("Введіть 4 сторони");
            Console.WriteLine("1)");
            float firstSide = float.Parse(Console.ReadLine());
            Console.WriteLine("2)");
            float secondSide = float.Parse(Console.ReadLine());
            Console.WriteLine("3)");
            float thirdSide = float.Parse(Console.ReadLine());
            Console.WriteLine("4)");
            float fourthSide = float.Parse(Console.ReadLine());
            Console.WriteLine("Введіть 2 протилежних кути");
            Console.WriteLine("1)");
            float firstAngle = float.Parse(Console.ReadLine());
            Console.WriteLine("2)");
            float thirdAngle = float.Parse(Console.ReadLine());
            Square one = new Square(firstSide, secondSide, firstAngle, thirdSide, fourthSide
            , thirdAngle);
                if(one.isExistsSq()){
                    Console.WriteLine("Площа: " + Math.Round(one.getSQ(), 2));
                    Console.WriteLine("Периметр: " + one.getPQ());
                    Console.WriteLine("Сторона AB: " + one.FirstSide);
                    Console.WriteLine("Сторона BC: " + one.SecondSide);
                    Console.WriteLine("Сторона CD: " + one.ThirdSide);
                    Console.WriteLine("Сторона DA: " + one.FourthSide);
                    one.getAngles();
                    Console.WriteLine("Кут A: " + one.FirstAngles);
                    Console.WriteLine("Кут B: " + one.SecondAngles);
                    Console.WriteLine("Кут C: " + one.ThirdAngles);
                    Console.WriteLine("Кут D: " + one.FourthAngeles);
                    Console.WriteLine("Діагональ AC: " + Math.Round(one.DiagonalOne, 2));
                    Console.WriteLine("Діагональ BD: " + Math.Round(one.getDiagonalTwo(), 2));
                    one.showTypeSq();
                } else {
                    Console.WriteLine("Не існує");
                }

             }
    }
}
