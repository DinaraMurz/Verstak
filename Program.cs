using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verstak
{
    class Program
    {
        static void Main(string[] args)
        {


            int zero = 0, one = 1, three = 3, two = 2, four = 4, five = 5, six = 6, seven = 7 , nine = 9,sixtine = 16;

            Box box = new Box();

            box.DrawVerstak();
            box.WriteThings();

            Console.SetCursorPosition(zero, sixtine);
            box.ShowList();
            Console.SetCursorPosition(zero, 13);
            box.ShowInfo();
            Console.SetCursorPosition(zero, zero);
            ConsoleKeyInfo key;

            int positionX = 0, positionY = 0;


            while (true)
            {
                key = Console.ReadKey();
                //Console.WriteLine(key.Key);
                
                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (positionX > zero)
                            positionX--;
                        break;

                    case ConsoleKey.RightArrow:
                        if (positionX < two)
                            positionX++;
                        break;

                    case ConsoleKey.DownArrow:
                        if (positionY < two)
                            positionY++;
                        break;

                    case ConsoleKey.UpArrow:
                        if (positionY > zero)
                            positionY--;
                        break;

                    case ConsoleKey.NumPad0:
                        box.filling[positionY, positionX] = zero;
                        break;
                    case ConsoleKey.NumPad1:
                        box.filling[positionY, positionX] = one;
                        break;
                    case ConsoleKey.NumPad2:
                        box.filling[positionY, positionX] = two;
                        break;
                    case ConsoleKey.NumPad3:
                        box.filling[positionY, positionX] = three;
                        break;
                    case ConsoleKey.NumPad4:
                        box.filling[positionY, positionX] = four;
                        break;
                    case ConsoleKey.NumPad5:
                        box.filling[positionY, positionX] = five;
                        break;
                    case ConsoleKey.NumPad6:
                        box.filling[positionY, positionX] = six;
                        break;
                    case ConsoleKey.NumPad7:
                        box.filling[positionY, positionX] = seven;
                        break;


                    case ConsoleKey.D0:
                        box.filling[positionY, positionX] = zero;
                        break;
                    case ConsoleKey.D1:
                        box.filling[positionY, positionX] = one;
                        break;
                    case ConsoleKey.D2:
                        box.filling[positionY, positionX] = two;
                        break;
                    case ConsoleKey.D3:
                        box.filling[positionY, positionX] = three;
                        break;
                    case ConsoleKey.D4:
                        box.filling[positionY, positionX] = four;
                        break;
                    case ConsoleKey.D5:
                        box.filling[positionY, positionX] = five;
                        break;
                    case ConsoleKey.D6:
                        box.filling[positionY, positionX] = six;
                        break;
                    case ConsoleKey.D7:
                        box.filling[positionY, positionX] = seven;
                        break;


                    case ConsoleKey.Enter:
                        Console.SetCursorPosition(five, five);
                        Console.WriteLine($"you have:{box.Create()}                                            ");
                        break;

                }
                box.WriteThings();
                Console.SetCursorPosition(positionX * two, positionY);

            }

            Console.ReadLine();
        }
    }
}