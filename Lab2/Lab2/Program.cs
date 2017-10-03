using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab2
{
    class Program
    {
       /// <summary>
       /// Abstract class
       /// </summary>
        abstract class GeomFigure
        {
          public abstract double Area();
         
        }
     
        class Rectangle : GeomFigure
        {
            //------------------properties------------------------------
            private int _width; //data storage for properties
            public int width //definition 
            {
                get { return _width; }
                set { _width = value; }
            }

            public int height { get; set; } //autodefinition
            //----------------------------------------------------------

            public Rectangle(int w, int h) { _width = w; height = h; } //constructor 

            public override double Area()
            {
                return _width * height;
            }

        }

        class Square : Rectangle
        {
            public Square(int s) : base(s, s) { } //call of rect constructor in square constructor

        }

        class Circle : GeomFigure
        {
            public int r { get; set; }
            public Circle(int r) { this.r=r; }

            public override double Area()
            {
                return 2 * 3.14 * r * r;
            }

            public override string ToString()
            {
                return "r = " + r.ToString() + ";" + " Circle area = " + Area().ToString();
            }
        }


        static void Main(string[] args)
        {
            int s1 = 2;
            int s2 = 6;
            Rectangle rect = new Rectangle(s1,s2);
            Console.WriteLine(rect.width + " " + rect.height);
            rect.width = 4;
            Console.WriteLine(rect.width + " " + rect.height);
            Console.WriteLine(rect.Area());

            Square sq = new Square(s1);
            Console.WriteLine(sq.width);

            Circle circ = new Circle(s2);
            Console.WriteLine(circ.Area());
            Console.WriteLine(circ.ToString());

            Console.ReadKey();
        }
    }
}
