using System.Collections.Generic;

namespace PlayerManagerMV
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