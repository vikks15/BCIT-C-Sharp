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
          private int a = 0, b = 0;
          public virtual int Area()
          {
              return a+b;
          }
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

            public override int Area()
            {
                return _width * height;
            }

        }

        static void Main(string[] args)
        {
            int s1 = 2;
            int s2 = 6;
            Rectangle rec = new Rectangle(s1,s2);
            Console.WriteLine(rec.width + " " + rec.height);

            rec.width = 4;
            Console.WriteLine(rec.width + " " + rec.height);
            Console.WriteLine(rec.Area());

            Console.ReadKey();
        }
    }
}
