using System.Collections.Generic;

namespace PlayerManagerMVC2
{
    public interface IView
    {

        void ShowGoodbyeMessage();

        void ShowInvalidOptionMessage();

        void WaitForUser();

        string MainMenu();

        Player AskForPlayerInfo();

        void ShowPlayers(IEnumerable<Player> playersToList);

        int AskForMinScore();

        PlayerOrder AskForPlayerOrder();

    }
}