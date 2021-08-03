using System;

namespace Lab4._1
{
    class Book
    {
        public string BookName;
        public string LastNameAuthor;
        public string FirstNameAuthor;
        public string ID;
        public string Publisher;
        public int CopiesSold;

        public void Sell(int copiesSold)
        {
            CopiesSold = copiesSold;
        }

        public void Print()
        {
            Console.WriteLine("\n\nThis is our book.");
            Console.WriteLine($"The book name is: {BookName}");
            Console.WriteLine($"Author's Last Name: {LastNameAuthor}");
            Console.WriteLine($"Author's First Name: {FirstNameAuthor}");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Publisher's name: {Publisher}");
            Console.WriteLine($"Copies sold: {CopiesSold}");
        }

    }
    class Parallelogram
    {
        public double Length;
        public double Width;

        public double GetArea()
        {
            double area = Length * Width;
            return area;
        }

        public double GetPerimeter()
        {
            double perimeter = 2 * (Length + Width);
            return perimeter;

        }

        public void Print()
        {
            Console.WriteLine("\n\nThis is our Parallelogram.");
            Console.WriteLine($"Length is: {Length}");
            Console.WriteLine($"Width is: {Width}");
            Console.WriteLine($"Perimeter is: {GetPerimeter()}");
            Console.WriteLine($"Area is: {GetArea()}");

        }
        public void Resize(double newL, double newW)
        {
            if (newL < 0)
            {
                return;
            }
            else
            {
                Length = newL;
            }
            if (newW < 0)
            {
                return;
            }
            else
            {
                Width = newW;
            }

            
        }

    }



    class Program
    {
        static void Main(string[] args)
        {

            Parallelogram first = new Parallelogram();
            first.Resize(5.25, -2);
            first.GetArea();
            first.GetPerimeter();
            first.Print();


            Parallelogram second = new Parallelogram() { Length = 6.0, Width = 8.75 };
            second.GetArea();
            second.GetPerimeter();
            second.Print();
            second.Resize(10.0, 14.82);

            Book b1 = new Book() { BookName = "The Living Mountain", LastNameAuthor = "Shepherd", FirstNameAuthor = "Nan", Publisher = "Canongate BOoks", ID = "9780857861832" };
            b1.Sell(50000);
            b1.Print();



            Book b2 = new Book() { BookName = "Whereabouts", FirstNameAuthor = "Jhumpa", LastNameAuthor = "Lahiri", Publisher = "Guanda", ID = "978-88-235-2136-0", CopiesSold = 456300 };
            b2.Print();
            b2.Sell(85000);
            b2.Print();





        }
    }
}
