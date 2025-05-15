using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissor
{
    public class clsSelect
    {
        public static string Computer_Select()
        {
            Random rnd = new Random();
            int Select = rnd.Next(0, 3);
            string Computer_Select = "";
            if (Select == (int)clsPublicVariable.game.Rock)
                Computer_Select = clsPublicVariable.game.Rock.ToString();

            else if (Select == (int)clsPublicVariable.game.Paper)
                Computer_Select = clsPublicVariable.game.Paper.ToString();

            else
                Computer_Select = clsPublicVariable.game.Scissor.ToString();

            clsPublicVariable.Computer_Selection = Computer_Select;
            return clsPublicVariable.Computer_Selection;
        }
    }
}
