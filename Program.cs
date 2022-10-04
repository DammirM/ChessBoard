using System;
using System.Text;

namespace ChessBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("                                                   ChessBoard");

            Console.WriteLine("Please write a number");

            int number = int.Parse(Console.ReadLine());

            

            Console.Clear();

            chess(number);


            //for (int i = 0; i < number; i++)
            //{

            //    for (int j = 0; j < number; j++)
            //    {


            //        if ((i + j) % 3 == 0)
            //        {
            //            Console.Write("■");

            //        }
            //        else
            //        {
            //            Console.Write("□");

            //        }


            //    }
            //    Console.WriteLine();
            //}

            Console.ReadKey();
            Console.Clear();




            Console.WriteLine("Do you wish to put a character on your board? Please type Yes or No");

            string userChoice = Console.ReadLine();

            userChoice = userChoice.ToUpper();

            if (userChoice == "YES")
            {
                Console.WriteLine("Welcome to play!");

                Console.WriteLine("Select the size of your chessboard");
                int size = int.Parse(Console.ReadLine());

                Console.WriteLine("Select the letter for the black square");
                string blackSquare = Console.ReadLine();

                Console.WriteLine("Select the letter for the white square");
                string whiteSquare = Console.ReadLine();

                Console.WriteLine("where would you like to put your character");


                for (int i = 0; i < size; i++)
                {

                    for (int j = 0; j < size; j++)
                    {


                        if ((i + j) % 2 == 0)
                        {
                            Console.Write(blackSquare);

                        }
                        else
                        {
                            Console.Write(whiteSquare);

                        }


                    }
                    Console.WriteLine();
                }

            }
            else if (userChoice == "No")
            {
                Console.WriteLine("Bye!!");
            }






            static void chess(int number)
            {
                for (int i = 0; i < number; i++)
                {

                    for (int j = 0; j < number; j++)
                    {


                        if ((i + j) % 3 == 0)
                        {
                            Console.Write("■");

                        }
                        else
                        {
                            Console.Write("□");

                        }


                    }
                    Console.WriteLine();
                }
            }




        }


    }
}
