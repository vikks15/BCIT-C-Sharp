using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    interface IPrint
    {
        void Print();
    }

    /// <summary>
    /// Abstract class
    /// </summary>
    abstract class GeomFigure : IComparable
    {
        public abstract double Area();

         public int CompareTo(object ob) //with IComparable
        {
            GeomFigure f = (GeomFigure)ob;
            if (this.Area() == f.Area()) return 0;
            else if (this.Area() > f.Area()) return 1;
            else return -1;

        }
       
    }
    class Rectangle : GeomFigure, IPrint
    {
        //------------------properties------------------------------
        private double _width; //data storage for properties
        public double width //definition 
        {
            get { return _width; }
            set { _width = value; }
        }

        public double height { get; set; } //autodefinition
        //----------------------------------------------------------

        public Rectangle(double w, double h) { _width = w; height = h; } //constructor 

        public override double Area()
        {
            return _width * height;
        }

        public override string ToString()
        {
            return "Rectangle width = " + this._width.ToString() + "\nRectangle height = " + this.height.ToString() + "\nRectangle area = " + Area().ToString() + "\n";
        }

        public void Print()
        {
            System.Console.WriteLine(ToString());
        }

    }

    class Square : Rectangle, IPrint
    {
        public Square(double s) : base(s, s) { } //call of rect constructor in square constructor
        public override string ToString()
        {
            return "Square side = " + this.width.ToString() + "\nSquare area = " + Area().ToString() + "\n";
        }

        public void Print()
        {
            System.Console.WriteLine(ToString());
        }

    }

    class Circle : GeomFigure, IPrint
    {
        public double r { get; set; }
        public Circle(double r) { this.r = r; }

        public override double Area()
        {
            return 2 * Math.PI * r * r;
        }

        public override string ToString()
        {
            return "Circle radius = " + r.ToString() + "\nCircle area = " + Area().ToString() + "\n";
        }

        public void Print()
        {
            System.Console.WriteLine(ToString());
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            double a = 3, b = 4, r = 5;
            Rectangle rec = new Rectangle(a, b);
            Square sq = new Square(a);
            Circle circ = new Circle(r);

            ArrayList al = new ArrayList();
            al.Add(rec);
            al.Add(sq);
            al.Add(circ);

            al.Sort();

            foreach(object obj in al)
            {
                string type = obj.GetType().Name;
                if (type == "Rectangle")
                {
                    Rectangle rr = (Rectangle)obj;
                    rr.Print();                          
                }
                else if (type == "Square") Console.WriteLine(obj.ToString());
                else if (type == "Circle") Console.WriteLine(obj.ToString());
                
            }

            Console.ReadKey();

        }
       
    }
}
