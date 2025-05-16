using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheWord
{
    public class BadView : IView
    {
        public string MenuLines()
        {
            Console.Write("Your guess: ");
            return Console.ReadLine();
        }


        public string WinLines()
        {
           
            Console.WriteLine("Correct! Well done!");
            Console.WriteLine($"The word was \"{chosenWord}\".");
            return Console.ReadLine();
        }






    }
}