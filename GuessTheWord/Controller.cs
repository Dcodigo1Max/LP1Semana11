using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace GuessTheWord
{

    public class Controller
    {

        public Controller()
        {

        }

        public void Run(IView view)
        {
            //Stays on controller
            string guess;
            do
            {
                //Remove and put on BView
                view.MenuLines();
                guess = Console.ReadLine().Trim().ToLower();

            if (guess != chosenWord)
                view.ShowInvalidOptionMessage();
            } while (guess != chosenWord);

            view.WinLines();
       
        }





       
    }
}