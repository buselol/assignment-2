using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment_2
{
     class Program
     {
        static void Main(string[]args)
        {
            Selection();  
        }
        static void Selection()
        {
            Console.WriteLine("Choose Option To contuinue");
            Console.WriteLine("1.New Game");
            Console.WriteLine("2.About The Author");
            Console.WriteLine("3.exit");

            ConsoleKeyInfo menuselection;
            menuselection = Console.ReadKey(true);

            switch(menuselection.KeyChar)
            {
                case '1':
                Console.WriteLine("selection 1");
                    using System;
                    using System.Collections.Generic;
                    using System.Linq;
                    using System.Text;
                    using System.Threading;
                    using System.IO;

namespace Assignment_2
    {
        class Program
        {



            static String[] board = new String[9];
            static String playsAgain = "Y";
            static int counter = 0;

            static void initializeVariable()
            {
                for (int i = 0; i < 9; i++)
                {
                    board[i] = i.ToString();
                }
            }

            static void playAgainMsg(String message)
            {
                Console.WriteLine(message + "do you want to play again?");
                if (Console.ReadLine().Equals("Y"))
                    playsAgain.Equals("Y");
                else
                    playsAgain.Equals("N");
            }

            static void Main(string[] args)
            {
                introduction();
                while (playsAgain.Equals("Y"))
                {
                    initializeVariable();
                    while (hasWon() == false && counter < 9)
                    {
                        askData("X");
                        if (hasWon() == true)
                            break;
                        askData("O");
                    }
                    if (hasWon() == true)
                        playAgainMsg("!Player won!");
                    else
                        playAgainMsg("!Sorry, nobody wins this round!");
                }
                goodBye();
            }

            static void goodBye()
            {
                Console.WriteLine("Tthanks for playing :))");
                Console.ReadLine();

            }

            static void askData(String player)
            {
                Console.Clear();

                Console.WriteLine("Player1: " + player);
                int selection;

                while (true)
                {
                    Console.WriteLine("Please enter your selection.");
                    drawBoard();
                    selection = Convert.ToInt32(Console.ReadLine());
                    if (selection < 0 || selection > 9 || (board[selection].Equals("X") || board[selection].Equals("O")))
                        Console.WriteLine("Invalid selection!");
                    else
                        break;
                }
                board[selection] = player;


            }

            static void drawBoard()
            {
                for (int i = 0; i < 7; i += 3)
                    Console.WriteLine(board[i] + "|" + board[i + 1] + "|" + board[i + 2]);
            }

            static Boolean hasWon()
            {
                for (int i = 0; i < 7; i += 3)
                {
                    if (board[i].Equals(board[i + 1]) && board[i + 1].Equals(board[i + 2]))
                    {
                        return true;
                    }
                }
                if (board[0].Equals(board[3]) && board[3].Equals(board[6]))
                    return true;
                if (board[1].Equals(board[4]) && board[4].Equals(board[7]))
                    return true;
                if (board[2].Equals(board[5]) && board[3].Equals(board[8]))
                    return true;
                if (board[2].Equals(board[4]) && board[4].Equals(board[6]))
                    return true;
                if (board[0].Equals(board[4]) && board[4].Equals(board[8]))
                    return true;
                return false;
            }


            static void introduction()
            {
                Console.Title = ("assignment 2");
                Console.WriteLine("Welcome to Tic Tac Toe.\n");
                Console.WriteLine("Press any key to continue.");
                Console.ReadLine();
                Console.Clear();
            }

        }
    }
    Console.ReadKey();


                    break;
                case '2':
                    Console.WriteLine("selection 2");
                    Console.ReadKey();
                    break;
            }
        }
     }
        
        
        
}