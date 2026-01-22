using System.Diagnostics.Eventing.Reader;

namespace GuessingGameGUI
{
    public partial class FrmGuessingGame : Form
    {
        private int chosenNum = 0;

        public FrmGuessingGame()
        {
            InitializeComponent();
        }


        private void FrmGuessingGame_Load(object sender, EventArgs e)
        {
            // populates the list box
            for (int i = 1; i <= 100; i++)
            {
                lstNumbers.Items.Add(i);
            }
            // choses a random number 
            Random rnd = new Random();
            chosenNum = rnd.Next(1, 101);
        }

        public void lstNumbers_Click(object sender, EventArgs e)
        {
            // makes sure the user choses a valid number in list items
            if (lstNumbers.SelectedIndex > -1)
            {
                int UsersGuess = int.Parse(lstNumbers.SelectedItem.ToString());
                CheckGuess(UsersGuess, chosenNum);
                int itemCount = lstNumbers.Items.Count;
                int incorrectGuesses = 100 - itemCount;
                lblOutputCountWrongGuess.Text = $"{incorrectGuesses}";
                lblOutPutNumCountRemaining.Text = $"{itemCount}";

            }
        }



        public string CheckGuess(int UserGuess, int chosenNum)
        {
            // based on usersGuess and chosenNum
            // outputs if they guess correct num or not
            if (chosenNum == UserGuess)
            {
                return stblOutput.Text = "Congrats! You guess the correct Number!";

            }
            else if (chosenNum > UserGuess)
            {
                lstNumbers.Items.Remove(UserGuess);
                return stblOutput.Text = $"Opsies the number {UserGuess} is to low. Try Again.";


            }
            else if (chosenNum < UserGuess)
            {
                lstNumbers.Items.Remove(UserGuess);
                return stblOutput.Text = $"Opsies the number {UserGuess} is  to high. Try Again.";

            }
            else
            {
                return stblOutput.Text = "Ops! Try Again";
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // clears the list box
            lstNumbers.Items.Clear();

            // repopulats the list box
            for (int i = 1; i <= 100; i++)
            {
                lstNumbers.Items.Add(i);
            }
            // choses a random number 
            Random rnd = new Random();
            chosenNum = rnd.Next(1, 101);

            // resets the count
            lblOutputCountWrongGuess.Text = $"0";
            lblOutPutNumCountRemaining.Text = $"100";
            stblOutput.Text = $"Click a number to guess that number";
        }
    }
}
