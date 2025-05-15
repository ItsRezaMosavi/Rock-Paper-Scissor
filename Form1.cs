namespace Rock_Paper_Scissor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblComputer_Click(object sender, EventArgs e)
        {

        }
        private void User_Click(object sender, EventArgs e)
        {
            string Computer_select = clsSelect.Computer_Select();
            lblComputer.Text = Computer_select;

            if (sender == btnRock)
                clsPublicVariable.User_Selection = btnRock.Text;
            else if (sender == btnPaper)
                clsPublicVariable.User_Selection = btnPaper.Text;
            else
                clsPublicVariable.User_Selection = btnScissor.Text;

            lblUser.Text = clsPublicVariable.User_Selection;
            clsWin.Round_Winner();
            lblComputerWin.Text = clsPublicVariable.Computer_Win.ToString();
            lblUserWin.Text=clsPublicVariable.User_Win.ToString();
        }

    }
}
