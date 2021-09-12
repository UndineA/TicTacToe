using System;

namespace TicTacToe
{
    class TicTacToeProgram
    {
        // Set up the grid
        public static char[] grid =  { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public static void printGrid()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  " + grid[0] + "  |  " + grid[1] + "  |  " + grid[2] + "  ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  " + grid[3] + "  |  " + grid[4] + "  |  " + grid[5] + "  ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  " + grid[6] + "  |  " + grid[7] + "  |  " + grid[8] + "  ");
            Console.WriteLine("     |     |     ");
        }
        
        // public static char[] signOfPlayer = {'X', 'O'};
        public static void enterXO(char signOfPlayer, int input)
        {
            switch(input)
            {
                case 1: grid[0] = signOfPlayer;
                        break;
                case 2: grid[1] = signOfPlayer;
                        break;
                case 3: grid[2] = signOfPlayer;
                        break;
                case 4: grid[3] = signOfPlayer;
                        break;
                case 5: grid[4] = signOfPlayer;
                        break;
                case 6: grid[5] = signOfPlayer;
                        break;
                case 7: grid[6] = signOfPlayer;
                        break;
                case 8: grid[7] = signOfPlayer;
                        break;
                case 9: grid[8] = signOfPlayer;
                        break;
            }
        }
        
        public static void Main(string[] args)
        {
            // Ask the user to choose a field
            int userInput = 0;
            int computerInput = 0;
            Random randomNumber = new Random();
            bool inputCorrect = true;
            
            do
            {
                printGrid();
                Console.WriteLine("User: X     Computer: O");
                Console.WriteLine("Choose a free field from the grid");
                try 
                {
                userInput = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                Console.WriteLine("Please write a number!");
                }
                
            // Check whether the field is already taken
                if((userInput == 1) && (grid[0] == '1'))
                enterXO('X', 1);
                else if ((userInput == 2) && (grid[1] == '2'))
                enterXO('X', 2);
                else if ((userInput == 3) && (grid[2] == '3'))
                enterXO('X', 3);
                else if ((userInput == 4) && (grid[3] == '4'))
                enterXO('X', 4);
                else if ((userInput == 5) && (grid[4] == '5'))
                enterXO('X', 5);
                else if ((userInput == 6) && (grid[5] == '6'))
                enterXO('X', 6);
                else if ((userInput == 7) && (grid[6] == '7'))
                enterXO('X', 7);
                else if ((userInput == 8) && (grid[7] == '8'))
                enterXO('X', 8);
                else if ((userInput == 9) && (grid[8] == '9'))
                enterXO('X', 9);
                else
                {
                    Console.WriteLine("The field is already taken!");
                    inputCorrect = false;
                }
                
                // Make the computer to choose a field
                computerInput = randomNumber.Next(1, 9);
                
                // Check whether the field is already taken
                if((computerInput == 1) && (grid[0] == '1'))
                enterXO('O', 1);
                else if ((computerInput == 2) && (grid[1] == '2'))
                enterXO('O', 2);
                else if ((computerInput == 3) && (grid[2] == '3'))
                enterXO('O', 3);
                else if ((computerInput == 4) && (grid[3] == '4'))
                enterXO('O', 4);
                else if ((computerInput == 5) && (grid[4] == '5'))
                enterXO('O', 5);
                else if ((computerInput == 6) && (grid[5] == '6'))
                enterXO('O', 6);
                else if ((computerInput == 7) && (grid[6] == '7'))
                enterXO('O', 7);
                else if ((computerInput == 8) && (grid[7] == '8'))
                enterXO('O', 8);
                else if ((computerInput == 9) && (grid[8] == '9'))
                enterXO('O', 9);
                else
                inputCorrect = false;
                
                printGrid();
            }
            while(!inputCorrect); 


        }
    }
}