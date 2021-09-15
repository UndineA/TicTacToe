using System;

namespace TicTacToe
{
    class TicTacToeProgram
    {
        // Set up the grid
        public static char[] grid =  { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public static void printGrid()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  " + grid[1] + "  |  " + grid[2] + "  |  " + grid[3] + "  ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  " + grid[4] + "  |  " + grid[5] + "  |  " + grid[6] + "  ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  " + grid[7] + "  |  " + grid[8] + "  |  " + grid[9] + "  ");
            Console.WriteLine("     |     |     ");
        }
        
        public static void enterXO(char signOfPlayer, int input)
        {
            switch(input)
            {
                case 1: grid[1] = signOfPlayer;
                        break;
                case 2: grid[2] = signOfPlayer;
                        break;
                case 3: grid[3] = signOfPlayer;
                        break;
                case 4: grid[4] = signOfPlayer;
                        break;
                case 5: grid[5] = signOfPlayer;
                        break;
                case 6: grid[6] = signOfPlayer;
                        break;
                case 7: grid[7] = signOfPlayer;
                        break;
                case 8: grid[8] = signOfPlayer;
                        break;
                case 9: grid[9] = signOfPlayer;
                        break;
            }
        }

        
        public static int winStatus = -1; 
        // -1 - game continues; 0 - draw; 1 - user wins; 2 - computer wins
                        
        public static void Main(string[] args)
        {
            int userInput = 0;
            int computerInput = 0;
            Random randomNumber = new Random();
                        
            while(winStatus == -1) // while there is no winner or draw
            {
                // Ask the user to choose a field
                printGrid();
                Console.WriteLine("User: X     Computer: O");
                Console.WriteLine("Please choose a free field from the grid (write a number)");

                while(true)
                {
                    try 
                    {
                        userInput = Int32.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please write a number from 1 to 9");
                        continue;
                    }

                    if(userInput > 9 || userInput < 1)
                    {
                        Console.WriteLine("Please write a number from 1 to 9");
                        continue;
                    }

                    // Check whether the field is already taken
                    if(grid[userInput] == 'X' || grid[userInput] == 'O')
                    {
                        Console.WriteLine("The field is already taken! Please choose an another field!");
                        continue;
                    }
                    else
                    break;
                }
                enterXO('X', userInput);
                                
                // Checking is there already a winner
                winStatus = winning();
                if((winStatus == 1) || (winStatus == 2) || (winStatus == 0))
                break;

                // Make the computer to choose a field
                while(true)
                {
                    computerInput = randomNumber.Next(1, 9);
                    // Check whether the field is already taken
                    if(grid[computerInput] == 'X' || grid[computerInput] == 'O') 
                    continue;
                    else
                    break;
                }
                enterXO('O', computerInput);

                // Checking is there already a winner
                winStatus = winning();  
            }
            printGrid();

            if(winStatus == 1)
            Console.WriteLine("User wins!");
            else if(winStatus == 2)
            Console.WriteLine("Computer wins!");
            else
            Console.WriteLine("No one wins!");
        }


        public static int winning()
        {
            // Horizontal winning condition
            if(grid[1] == grid[2] && grid[2] == grid[3])
            {
                if(grid[1] == 'X')
                return 1;
                else
                return 2;
            }
            else if(grid[4] == grid[5] && grid[5] == grid[6])
            {
                if(grid[4] == 'X')
                return 1;
                else
                return 2;
            }
            else if(grid[7] == grid[8] && grid[8] == grid[9])
            {
                if(grid[7] == 'X')
                return 1;
                else
                return 2;
            }

            //Vertical winning codition
            else if(grid[1] == grid[4] && grid[4] == grid[7])
            {
                if(grid[1] == 'X')
                return 1;
                else
                return 2;
            }
            else if(grid[2] == grid[5] && grid[5] == grid[8])
            {
                if(grid[2] == 'X')
                return 1;
                else
                return 2;
            }
            else if(grid[3] == grid[6] && grid[6] == grid[9])
            {
                if(grid[3] == 'X')
                return 1;
                else
                return 2;
            }

            //Diagonal winning codition
            else if(grid[1] == grid[5] && grid[5] == grid[9])
            {
                if(grid[1] == 'X')
                return 1;
                else
                return 2;
            }
            else if(grid[3] == grid[5] && grid[5] == grid[7])
            {
                if(grid[3] == 'X')
                return 1;
                else
                return 2;
            }

            //Draw
            else if(grid[1] != '1' && grid[2] != '2' && grid[3] != '3' && grid[4] != '4' && grid[5] != '5' && grid[6] != '6' && grid[7] != '7' && grid[8] != '8' && grid[9] != '9')
            return 0;

            //Game continues
            else
            return -1;
        }
    }
}