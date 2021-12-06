using System;

namespace lab6
{
    class Program
    {

        abstract class Person
        {
            protected string firstName;
            protected int age;
            protected string lastName;
            protected string work;
            protected int id;

            public Person(string firstName, int age, string lastName, string work, int id)
            {
                this.firstName = firstName;
                this.age = age;
                this.lastName = lastName;
                this.work = work;
                this.id = id;
            }

            public string getFullname() {
                return this.firstName + this.lastName;
            }

            public string getName() {
                return this.firstName;  
            }

            public string getLastname()
            {
                return this.firstName;
            }

            public int getAge()
            {
                return this.age;
            }

            public int getId()
            {
                return this.id;
            }
        }

        class Client : Person 
        {
            private int money; 
            
            public Client(string firstName, int age, string lastName, string work, int id, int money)
            : base(firstName, age, lastName, work, id)
            {
                this.money = money;
            }

            public int getMoney() {
                return this.money;
            }
        }

        abstract class Circle
        {
            protected int radius;

            public Circle(int radius)
            {
                this.radius = radius;
            }

            public int getRadius()
            {
                return this.radius;
            }

            public int getDiameter()
            {
                return this.radius * 2;
            }

            public double getS()
            {
                return Math.PI * this.radius * this.radius;
            }

            public double getC()
            {
                return this.getDiameter() * Math.PI;
            }
        }

        class Wheel : Circle
        {
            private int width;

            public Wheel(int radius, int width)
            : base(radius)
            {
                this.width = width;
            }

            public int getWidth()
            {
                return this.width;
            }
        }

        abstract class Rectangle
        {
            protected int firstSide;
            protected int secondSide;

            public Rectangle(int firstSide, int secondSide)
            {
                this.firstSide = firstSide;
                this.secondSide = secondSide;
            }

            public int getFirstSide()
            {
                return this.firstSide;
            }

            public int getSecondSide()
            {
                return this.secondSide;
            }

            public double getS()
            {
                return this.firstSide * this.secondSide;
            }

            public void showFirstSide()
            {
                Console.WriteLine(this.firstSide);
            }

            public void showSecondSide()
            {
                Console.WriteLine(this.secondSide);
            }
        }

        class Wall : Rectangle
        {
            private int width;    

            Wall(int firstSide, int secondSide, int width)
            : base (firstSide, secondSide)
            {
                this.width = width;
            }
        }

        public abstract class Car
        {

            private String model;
            private String color;
            private int maxSpeed;

            public abstract void gas();

            public abstract void brake();

            public String getModel()
            {
                return model;
            }

            public void setModel(String model)
            {
                this.model = model;
            }

            public String getColor()
            {
                return color;
            }

            public void setColor(String color)
            {
                this.color = color;
            }

            public int getMaxSpeed()
            {
                return maxSpeed;
            }

            public void setMaxSpeed(int maxSpeed)
            {
                this.maxSpeed = maxSpeed;
            }
        }

        class Sedan : Car
        {

            private int speed;

            Sedan(int speed) {
                this.speed = speed;
            }
  
            public override void gas()
            {
                this.speed += 1;
            }

            public override void brake()
            {
                this.speed -= 1;
            }
        }

        abstract class Figure
        {
            protected string name;

            public abstract void showName();
            public abstract double area();
            public abstract double getP();

            public string GetName()
            {
                return this.name;
            }
        }

        class Square : Figure
        {
            private int lengthSide;

            Square(string name, int lengthSide)
            {
                this.lengthSide = lengthSide;
                this.name = name;
            }

            public override void showName()
            {
                Console.WriteLine(this.name);
            }

            public override double area() 
            {
                return this.lengthSide * this.lengthSide;
            }

            public override double getP(){
                return this.lengthSide * 4;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
