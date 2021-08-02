using System;

namespace ParallelogramLab4._1_ClassandObjects_
{
    class Parallelogram
    {
        public double length;
        public double width = 1;
        public double getArea()
        {
            return  length * width;
        }
        public double GetPerimeter()
        {
            return 2 * (length + width);
        }

        public void print()
        {
            Console.WriteLine($"Your area is: {getArea()}");
            Console.WriteLine($"Your perimeter is: {GetPerimeter()}");
        }
        public void Resize(double length2, double width2)
        {
            if (length2 < 0 || width2 < 0)
            {
                Console.WriteLine("Sorry this is less than 0 please restart");
                length = 0;
                width = 0;
            }
            else
            {
                length = length2;
                width = width2;
            }
        }
    }
    class Book
    {
        public string firstName;
        public string lastName;
        public string ID;
        public string pubName;
        public int numSold = 0;
        public int sold;

        public void sale()
        {
            numSold = numSold + sold;
        }
        public void print()
        {
            Console.WriteLine($"Total copies sold: {numSold}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parallelogram p1 = new Parallelogram() { length = 4.0, width =2.0};
            p1.print();

            p1.Resize(2, 6);
            p1.print();

            Book b1 = new Book() { sold = 5 };
            b1.sale();
            b1.print();
            
        }
    }
}
