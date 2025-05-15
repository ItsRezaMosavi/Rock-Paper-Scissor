using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissor
{
    public class clsWin
    {
        public static void Round_Winner()
        {
            string user = clsPublicVariable.User_Selection;
            string computer = clsPublicVariable.Computer_Selection;
            if (user == computer)
                      clsPublicVariable.Round_Win = clsPublicVariable.win.equal.ToString();
            else if (user == clsPublicVariable.game.Rock.ToString() && computer == clsPublicVariable.game.Scissor.ToString())
                clsPublicVariable.Round_Win = clsPublicVariable.win.user_win.ToString();
            else if (user == clsPublicVariable.game.Paper.ToString() && computer == clsPublicVariable.game.Rock.ToString())
                clsPublicVariable.Round_Win = clsPublicVariable.win.user_win.ToString();
            else if (user == clsPublicVariable.game.Scissor.ToString() && computer == clsPublicVariable.game.Paper.ToString())
                clsPublicVariable.Round_Win = clsPublicVariable.win.user_win.ToString();
            else
                clsPublicVariable.Round_Win = clsPublicVariable.win.computer_win.ToString();
        }
    }
}
