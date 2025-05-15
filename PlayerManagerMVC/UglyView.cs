using System;



namespace PlayerManager4
{

    public class UglyView : IView
    {


        public Player AskForPlayerInfo()
        {

            // Variables
            string name;
            int score;
            

            Console.WriteLine("\nInsert player");
            Console.WriteLine("-------------\n");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Score: ");
            score = Convert.ToInt32(Console.ReadLine());
            
            // Create new player and add it to list
            return new Player(name, score);
            
        }

        public string MainMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("----\n");
            Console.WriteLine("1. Insert player");
            Console.WriteLine("2. List all players");
            Console.WriteLine("3. List players with score greater than");
            Console.WriteLine("4. Sort players");
            Console.WriteLine("0. Quit\n");
            Console.Write("Your choice > ");
            return Console.ReadLine();
        }
        public void ShowGoodbyeMessage()
        {
            Console.WriteLine("Bye");
        }

        public void ShowInvalidOptionMessage()
        {
            Console.Error.WriteLine("\n>>> Unknown option! <<<\n");
        }

        public void WaitForUser()
        {
            Console.Write("\nPress any key to continue...");
            Console.ReadKey(true);
            Console.WriteLine("\n");
        }


    }



}