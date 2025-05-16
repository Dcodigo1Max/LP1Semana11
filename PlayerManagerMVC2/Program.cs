using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;



namespace PlayerManagerMVC2
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
            if (args.Length < 1)
            {
                Console.WriteLine("This is wrong");
            }
            else
            {
                string file_name = args[0];

                string[] file_Lines = File.ReadAllLines(file_name);


                PlayersList playerList = new PlayersList();


                foreach (string line in file_Lines)
                {
                    string[] partes = line.Split(",");

                    playerList.Add(new Player(partes[0], int.Parse(partes[1])));
                }



                //Inicialize player comparers
                // Initialize player comparers
                IComparer<Player> compareByName = new CompareByName(true);
                IComparer<Player> compareByNameReverse = new CompareByName(false);

                // Initialize the player list with two players using collection
                // initialization syntax


                Controller controller = new Controller(
                    playerList, compareByName, compareByNameReverse
                );


                IView view = new UglyView();

                controller.Run(view);


            }




        }



    }

}
