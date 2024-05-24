using System;


namespace cr
{


    public abstract class Shape
    {
        public abstract double CalculateVolume();
        public abstract void DisplayInfo();
    }

    public class Sphere : Shape
    {
        private double radius;

        public Sphere(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Сфера с радиусом {radius}");
        }
    }


    public class Cube : Shape
    {
        private double sideLength;

        public Cube(double sideLength)
        {
            this.sideLength = sideLength;
        }

        public override double CalculateVolume()
        {
            return Math.Pow(sideLength, 3);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Куб со стороной {sideLength}");
        }
    }


    public class Cylinder : Shape
    {
        private double radius;
        private double height;

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public override double CalculateVolume()
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Цилиндр с радиусом {radius} и высотой {height}");
        }
    }

    class Program
    {
        


            static void Main(string[] args)
            {
                Sphere[] spheres = {
                    new Sphere(3),
                    new Sphere(2),
                    new Sphere(4),
                    new Sphere(5),
                    new Sphere(6)
                };

                Cube[] cubes = {
                    new Cube(2),
                    new Cube(1),
                    new Cube(3),
                    new Cube(2),
                    new Cube(5),

                };

                Cylinder[] cylinders = {
                    new Cylinder(2, 4),
                    new Cylinder(1, 3),
                    new Cylinder(3, 5),
                    new Cylinder(3, 5),
                    new Cylinder(3, 8)
                };

                Console.WriteLine("кубы");

                foreach (Cube sp in cubes)
                {
                    sp.DisplayInfo();
                    double volume = sp.CalculateVolume();
                    Console.WriteLine($"Обьем {volume}");

                }
                Console.WriteLine("Сферы");
                foreach (Sphere sp in spheres)
                {
                    sp.DisplayInfo();
                    double volume = sp.CalculateVolume();
                    Console.WriteLine($"Обьем {volume}");

                }

                foreach (Cylinder sp in cylinders)
                {
                    sp.DisplayInfo();
                    double volume = sp.CalculateVolume();
                    Console.WriteLine($"Обьем {volume}");

                }


                Shape[] allShapes;






            }
        
    }
}

    

