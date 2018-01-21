using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGenerics
{
    class Program
    {

        static void Main(string[] args)
        {
            #region Simple generics
            //Point<int> p1 = new Point<int>();
            //p1.X = 45;
            //p1.Y = 49;

            //Console.WriteLine($"X: {p1.X}\nY: {p1.Y}");

            //Point<double> p2 = new Point<double>();
            //p2.X = 23.9;
            //p2.Y = 17.943;

            //Console.WriteLine($"X: {p2.X}\nY: {p2.Y}");

            //Point<string> p3 = new Point<string>();
            //p3.Y = "gmfgfgmkf";
            //p3.X = "Hello World";

            //Console.WriteLine($"X: {p3.X}\nY: {p3.Y}");

            //MCollection<string> mCo = new MCollection<string>();
            //mCo.Add("Hello");
            //mCo.Add("Sun");
            //mCo.Add("People");

            //mCo.Print();

            //var mc = new MCollection<int>();
            //mc.Add(67);
            //mc.Add(56);
            //mc.Add(13);

            //mc.Print(); 
            #endregion

            Console.ReadKey();
        }
    }

    class Point<TCord> where TCord : struct 
    {
        public TCord X { get; set; }
        public TCord Y { get; set; }
    }

    class MCollection<T>
    {
        private List<T> _list;

        public MCollection()
        {
            _list = new List<T>();
        }

        public void Add(T item)
        {
            _list.Add(item);
        }

        public void Print()
        {
            foreach (var item in _list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
