using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';
            p1.Draw();

            Point p2 = new Point();
            p2.x = 4;
            p2.y = 5;
            p2.sym = '#';
            p2.Draw();


            List<char> charList = new List<char>();
            charList.Add('*');
            charList.Add('#');
            charList.Add('@');

            foreach(char i in charList)
            {
                Console.WriteLine(i);
            }

            charList.RemoveAt(0);

            foreach (char i in charList)
            {
                Console.WriteLine("\n" +i);
            }

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            var elem = pList[0];

            Console.WriteLine(elem);

            Console.ReadLine();
        }
    }       

}
