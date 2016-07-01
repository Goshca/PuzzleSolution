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
            int FieldSize = 0;

            Console.WriteLine("-=Enter the size of the field=-");
            Console.Write("Value horizontals: ");
            FieldHor = int.Parse(Console.ReadLine());
            Console.Write("Value vertical: ");
            FieldVer = int.Parse(Console.ReadLine());
            Console.WriteLine("Playing the Field: " + FieldHor + "x" + FieldVer);
            int[,] Field = new int[FieldHor, FieldVer];
            FieldSize = FieldHor * FieldVer;
            Console.WriteLine("Field Size: " + FieldSize);
            int i = 0, j = 0, Xi = 0, Yj = 0;
            for (int Cell = 1; Cell <= FieldSize; Cell++)
            {

                Field[i, j] = Cell;
                /////////////////////
                for (int a = 0; a < FieldHor; a++)
                {
                    for (int b = 0; b < FieldVer; b++)
                    {
                        //Field[a, b] = Cell;
                        Console.Write(String.Format("{0:00}", Field[a, b]) + " ");
                    }
                    Console.WriteLine();

                }
                Console.WriteLine();
                ////////////////////////
                for (int MoveList = 1; MoveList <= 9; MoveList++)
                {

                    switch (MoveList)
                    {
                        case 1:
                            {
                                Xi = i - 1;
                                Yj = j - 2;
                                break;
                            }
                        case 2:
                            {
                                Xi = i + 1;
                                Yj = j - 2;
                                break;
                            }
                        case 3:
                            {
                                Xi = i + 2;
                                Yj = j - 1;
                                break;
                            }
                        case 4:
                            {
                                Xi = i + 2;
                                Yj = j + 1;
                                break;
                            }
                        case 5:
                            {
                                Xi = i + 1;
                                Yj = j + 2;
                                break;
                            }
                        case 6:
                            {
                                Xi = i - 1;
                                Yj = j + 2;
                                break;
                            }
                        case 7:
                            {
                                Xi = i - 2;
                                Yj = j + 1;
                                break;
                            }
                        case 8:
                            {
                                Xi = i - 2;
                                Yj = j - 1;
                                break;
                            }
                        case 9:
                            {
                                Console.WriteLine("-=lockup=-"); Console.ReadLine(); return;
                            }
                        default:
                            {
                                Console.WriteLine("-=lockup=-");
                            }
                            /* for (int a = 0; a < FieldVer; a++)
                             {
                                 for (int b = 0; b < FieldHor; b++)
                                 {
                                     Field[a, b] = Cell;
                                     Console.Write(Field[a, b] + " ");
                                 }
                                 Console.WriteLine();

                             }
                             Console.ReadLine();*/
                            break;
                    }
                    if (Xi >= 0 && Xi < FieldHor && Yj >= 0 && Yj < FieldVer && Field[Xi, Yj] == 0)
                    {
                        i = Xi;
                        j = Yj;
                        Field[i, j] = Cell;
                        break;

                    }
                }


            }



            Console.ReadLine();
        }

        //Start point



        //Move List
        int[,] StepList = { { -1, -2 }, { 1, -2 }, { 2, -1 }, { 2, 1 }, { 1, 2 }, { -1, 2 }, { -2, 1 }, { -2, -1 } };



    }

}

