using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseCourseRun
{
    class Program
    {
        static void Main(string[] args)
        {
            int FieldHor = 0;
            int FieldVer = 0;
            Console.WriteLine("-=Enter the size of the field=-");
            Console.Write("Value horizontals: ");
            FieldHor = int.Parse(Console.ReadLine());
            Console.Write("Value vertical: ");
            FieldVer = int.Parse(Console.ReadLine());
            Console.WriteLine("Playing the Field: " + FieldHor + "x" + FieldVer);
            string[,] Field = new string[FieldVer, FieldHor];
            for (int i = 0; i < FieldVer; i++)
            {
                for (int j = 0; j < FieldHor; j++)
                {
                    Field[i, j] = "o";
                    Console.Write(Field[i, j] + " ");
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
