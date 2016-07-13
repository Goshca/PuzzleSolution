using System;
using System.CodeDom;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            int MoveBack = 0;
            int MoveList = 0;
            int Cell = 0;
            ulong GoodSolution = 0; //Колличество найденных решений // number of solutions found

            Console.WriteLine("-=Enter the size of the field=-");
            Console.Write("Value horizontals: ");
            FieldHor = int.Parse(Console.ReadLine());
            Console.Write("Value vertical: ");
            FieldVer = int.Parse(Console.ReadLine());
            Console.WriteLine("Playing the Field: " + FieldHor + "x" + FieldVer);
            int[,] Field = new int[FieldHor, FieldVer];
            int[,] MoveFixArray = new int[FieldHor, FieldVer]; // будем записывать верные шаги
            FieldSize = FieldHor * FieldVer;
            Console.WriteLine("Field Size: " + FieldSize);
            int i = 0, j = 0, Xi = 0, Yj = 0;
            Console.WriteLine();
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine();


            for (Cell = 1; Cell <= FieldSize; Cell++)
            {
               // Console.WriteLine(Cell);
                if (Cell == 25)
                {
                   // Console.WriteLine("-=Puzzle Solution=-");
                    Field[i, j] = Cell;
                    GoodSolution++;
                    /*////////////////////
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
                    *////////////////////////
                   // Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    //Console.ReadLine();
                }

                Field[i, j] = Cell;
               
                for (MoveList = 1; MoveList <= 9; MoveList++)
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
                          //      Console.WriteLine("-=lockup=-");
                         //       Console.WriteLine("Step: {0} MoveFix: {1} Stop Cell: {2}", MoveList, MoveFixArray[i, j], Field[i, j]);
                         //       Console.ReadLine();
                                MoveList = MoveFixArray[i, j];
                                Cell--;
                                Field[i, j] = 0;
                                if (Cell == 0)
                                {
                                    Console.WriteLine("No Solution");
                                    Console.WriteLine("The number of solutions found: {0}", GoodSolution);
                                    Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                                    Console.ReadLine();
                                    return;
                                }
                                switch (MoveFixArray[i, j])
                                {
                                    case 1:
                                        Xi = i + 1;
                                        Yj = j + 2;
                                //        Console.WriteLine("Step: {0} MoveFix: {1} !Stop Cell: {2}", MoveList, MoveFix, Field[i, j]);
                                       break;
                                    case 2:
                                        Xi = i - 1;
                                        Yj = j + 2;
                                //        Console.WriteLine("Step: {0} MoveFix: {1} !Stop Cell: {2}", MoveList, MoveFix, Field[i, j]);
                                        break;
                                    case 3:
                                        Xi = i - 2;
                                        Yj = j + 1;
                                //        Console.WriteLine("Step: {0} MoveFix: {1} !Stop Cell: {2}", MoveList, MoveFix, Field[i, j]);
                                        break;
                                    case 4:
                                        Xi = i - 2;
                                        Yj = j - 1;
                                 //       Console.WriteLine("Step: {0} MoveFix: {1} !Stop Cell: {2}", MoveList, MoveFix, Field[i, j]);
                                        break;
                                    case 5:
                                        Xi = i - 1;
                                        Yj = j - 2;
                                  //      Console.WriteLine("Step: {0} MoveFix: {1} !Stop Cell: {2}", MoveList, MoveFix, Field[i, j]);
                                        break;
                                    case 6:
                                        Xi = i + 1;
                                        Yj = j - 2;
                                 //       Console.WriteLine("Step: {0} MoveFix: {1} !Stop Cell: {2}", MoveList, MoveFix, Field[i, j]);
                                        break;
                                    case 7:
                                        Xi = i + 2;
                                        Yj = j - 1;
                                //        Console.WriteLine("Step: {0} MoveFix: {1} !Stop Cell: {2}", MoveList, MoveFix, Field[i, j]);
                                        break;
                                    case 8:
                                        Xi = i + 2;
                                        Yj = j + 1;
                                //        Console.WriteLine("Step: {0} MoveFix: {1} !Stop Cell: {2}", MoveList, MoveFix, Field[i, j]);
                                        break;
                                }
                                MoveFixArray[i, j] = 0;
                                i = Xi;
                                j = Yj;
                               
                               // MoveList++;
                                break;  // close case 9
                            }

                    }

                    if (Xi >= 0 && Xi < FieldHor && Yj >= 0 && Yj < FieldVer && Field[Xi, Yj] == 0)
                    {
                        i = Xi;
                        j = Yj;
                        Field[i, j] = Cell;
                        MoveFixArray[i,j] = MoveList;
                      // Console.WriteLine("Step: " + MoveList);
                        break;
                    }
                    

                    }
                }
                
            }
          /*  Console.WriteLine("-=Puzzle Solution=-");
            Field[i, j] = Cell;
            GoodSolution++;
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
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.ReadLine();*/
            }
    }
//}


////////////////////////////////////
/*  MoveList = MoveFix;
for (MoveBack = 1; MoveBack <= 9; MoveBack++)
{

    switch (MoveBack)
    {
        case 1:
            Xi = i + 1;
            Yj = j + 2;
            break;
        case 2:
            Xi = i - 1;
            Yj = j + 2;
            break;
        case 3:
            Xi = i - 2;
            Yj = j + 1;
            break;
        case 4:
            Xi = i - 2;
            Yj = j - 1;
            break;
        case 5:
            Xi = i - 1;
            Yj = j - 2;
            break;
        case 6:
            Xi = i + 1;
            Yj = j - 2;
            break;
        case 7:
            Xi = i + 2;
            Yj = j - 1;
            break;
        case 8:
            Xi = i + 2;
            Yj = j + 1;
            break;
    }

*/
//////////////////////////////////////

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

/*////////////////////
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
           *////////////////////////
             /*////////////////////
             for (int a = 0; a < FieldHor; a++)
             {
                 for (int b = 0; b < FieldVer; b++)
                 {
                     //Field[a, b] = Cell;
                     Console.Write(MoveFixArray[a, b] + " ");
                 }
                 Console.WriteLine();

             }
             Console.WriteLine();
             *////////////////////////