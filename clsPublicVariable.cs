using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissor
{
    public class clsPublicVariable
    {
        public enum game
        {
            Rock,
            Paper,
            Scissor
        }
        private static string _computer_selection;
        public static string Computer_Selection
        {
            get { return _computer_selection; }
            set
            {
                if (value == clsPublicVariable.game.Rock.ToString() || value == clsPublicVariable.game.Paper.ToString() || value == clsPublicVariable.game.Scissor.ToString())
                    _computer_selection = value;
            }
        }

        private static string _user_selection;
        public static string User_Selection
        {
            get { return _user_selection; }
            set
            {
                if (value == clsPublicVariable.game.Rock.ToString() || value == clsPublicVariable.game.Paper.ToString() || value == clsPublicVariable.game.Scissor.ToString())
                    _user_selection = value;
            }
        }

        private static int _computer_win = 0;
        public static int Computer_Win
        {
            get { return _computer_win; }
            set
            {
                try
                {
                    _computer_win = value;
                }
                catch { }
            }
        }

        private static int _user_win = 0;
        public static int User_Win
        {
            get { return _user_win; }
            set
            {
                try
                {
                    _user_win = value;
                }
                catch { }
            }
        }

        public enum win
        {
            equal,
            computer_win,
            user_win
        }

        private static string _round_win;
        public static string Round_Win
        {
            get { return _round_win; }
            set
            {
                if (value == win.equal.ToString() || value == win.computer_win.ToString() || value == win.user_win.ToString())
                    _round_win = value;
                if (value == win.computer_win.ToString())
                    Computer_Win++;
                else if (value == win.user_win.ToString())
                    User_Win++;
            }

        }
    }
}
