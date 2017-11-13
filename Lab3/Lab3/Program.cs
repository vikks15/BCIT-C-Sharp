using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
namespace Lab3
{
    class FigureMatrCheckEmpty
    {
        public GeomFigure getEmptyElement()
        {
            return null;
        }

        public bool checkEmpty(GeomFigure figure)
        {
            bool res = false;
            if (figure == null) res = true;
            return res;
        }
    }

    public class Matrix<T>
    {
        /// <summary>
        /// Dictionary to store data
        /// </summary>
        Dictionary<string, T> _matrix = new Dictionary<string, T>();
        int maxX; // max number of columns
        int maxY; // max number of strings

        T nullElement; // Empty element, returns if there is no element with needed coordinats 
        public Matrix(int px, int py, T nullElementParam) //Constructor
        {
            this.maxX = px;
            this.maxY = py;
            this.nullElement = nullElementParam;
        }

        void CheckBounds(int x, int y)
        {
            if (x < 0 || x >= this.maxX) throw new Exception("x=" + x + " overflow");

            if (y < 0 || y >= this.maxY) throw new Exception("y=" + y + " overflow");
        }
        /// <summary>
        /// Form the key
        /// </summary>
        string DictKey(int x, int y)
        {
            return x.ToString() + "_" + y.ToString();
        }

        /// <summary>
        /// Indexer to access data
        /// </summary>
        public T this[int x, int y]
        {

            get
            {
                CheckBounds(x, y);
                string key = DictKey(x, y);
                if (this._matrix.ContainsKey(key))
                {
                    return this._matrix[key];
                }
                else
                {
                    return this.nullElement;
                }
            }
            set
            {
                CheckBounds(x, y);
                string key = DictKey(x, y);
                this._matrix.Add(key, value);
            }
        }

        public override string ToString()
        {
            //Class StringBuilder - for long strings, faster then making from lots of normal str   
            StringBuilder b = new StringBuilder();
            for (int j = 0; j < this.maxY; j++)
            {
                b.Append("[");
                for (int i = 0; i < this.maxX; i++)
                {
                    if (i > 0) b.Append("\t");
                    if (this[i, j].Equals(nullElement)) b.Append("-");
                    else b.Append(this[i, j].ToString());
                }
                b.Append("]\n");
            }
            return b.ToString();
        }
    }

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
            return "Rectangle area = " + Area().ToString();
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
            return "Square area = " + Area().ToString();
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
            return "Circle area = " + Area().ToString();
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
            Console.WriteLine("ArrayList");
            foreach(object obj in al) Console.WriteLine(obj.ToString()); //or through str type = obj.GetType().Name + ifs

            Rectangle rec2 = new Rectangle(4, 5);
            Square sq2 = new Square(4);
            Circle circ2 = new Circle(1);
            List<GeomFigure> list = new List<GeomFigure>();
            list.Add(rec2);
            list.Add(sq2);
            list.Add(circ2);
            list.Sort();
            Console.WriteLine("\nList with " + list.Count() + " elements");
            foreach (GeomFigure figure in list)
            {
                Console.WriteLine(figure.ToString());
            }

            Console.WriteLine("\nMatrix");
            Square nullFigure = new Square(0);
            Matrix<GeomFigure> matr = new Matrix<GeomFigure>(3, 3, nullFigure);
            matr[0, 0] = rec;
            matr[1, 1] = sq;
            matr[2, 2] = circ;
            Console.WriteLine(matr.ToString());
            Console.ReadKey();

        }
       
    }
}
