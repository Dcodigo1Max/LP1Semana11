using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using PlayerManagerMV4;


namespace PlayerManager4
{
    /// <summary>
    /// The player listing program.
    /// </summary>
    public class Program
    {

        /// <summary>
        /// Program begins here.
        /// </summary>
        /// <param name="args">Not used.</param>
        private static void Main(string[] args)
        {
              //Inicialize player comparers
            // Initialize player comparers
            IComparer<Player>compareByName = new CompareByName(true);
            IComparer<Player>compareByNameReverse = new CompareByName(false);

        // Initialize the player list with two players using collection
            // initialization syntax
            PlayersList playerList = new PlayersList() {
                new Player("Marco", 100),
                new Player("Polo", 500)
            };

            Controller controller = new Controller(
                playerList, compareByName, compareByNameReverse
            );
        }
    }

}
//Console.Error.WriteLine("\n>>> Unknown player order! <<<\n");
 // Create a new instance of the player listing program
         //   Program prog = new Program();
            // Start the program instance
          //  prog.Start();