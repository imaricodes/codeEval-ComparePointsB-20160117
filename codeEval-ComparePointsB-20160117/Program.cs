using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeEval_ComparePointsB_20160117
{
    class Program
    {
        static void Main(string[] args)
        {
            //string line = "12 1 3 6"; //input          
            //string[] words = line.Split(' '); // Split string on spaces.This will separate all the words. we now have an array with the words
            //foreach (string word in words)
            //{
            //    Console.WriteLine(word);
            //}


            //my version
            string line = "10 5 0 5"; //input          
            string[] words = line.Split(' '); // Split string based on spaces.This will separate "string line" into separate words and assgin them to an array called "words"
            int o = Convert.ToInt16(words[0]); // converts an item with index [0] (first word) from the array "words" to an interger and assigns to variable "o" ..repeated below
            int p = Convert.ToInt16(words[1]);
            int q = Convert.ToInt16(words[2]);
            int r = Convert.ToInt16(words[3]);

            int deltaX = q - o;
            int deltaY = r - p;

            if (deltaX == 0 && deltaY > 0)
                Console.WriteLine("N");
            else if (deltaX == 0 && deltaY < 0)
                Console.WriteLine("S");

            else if (deltaX > 0 && deltaY == 0)
                Console.WriteLine("E");

            else if (deltaX < 0 && deltaY == 0)
                Console.WriteLine("W");

            else if (deltaX < 0 && deltaY > 0)
                Console.WriteLine("NW");

            else if (deltaX > 0 && deltaY > 0)
                Console.WriteLine("NE");

            else if (deltaX < 0 && deltaY < 0)
                Console.WriteLine("SW");

            else if (deltaX < 0 && deltaY > 0)
                Console.WriteLine("SE");

            else
                Console.WriteLine("here");



            Console.ReadKey();


        }
    }
}
