using System;
using PlayerManagerMVC;


namespace PlayerManager4
{

    public class UglyView : IView
    {
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