using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naughts_and_crosses
{
    class Program
    {
        static void Main(string[] args)
        {

            var picArray = new char[3][];// new array with 3 inputs
            picArray[0] = new char[3] { 'o', 'x', 'o' };// first part of the array
            picArray[1] = new char[3] { 'x', 'o', 'x' };// second part of the array
            picArray[2] = new char[3] { 'o', 'x', 'o' };// third part of the array

            for (int row = 0; row < picArray.Length; row++)
            {
                for (int column = 0; column<picArray[row].Length; column++)
                {
                    Console.Write(picArray[column][row]);// column and row outputed to console
                }
                Console.WriteLine("/n"); //write line /n
            }
        }
    }
}
