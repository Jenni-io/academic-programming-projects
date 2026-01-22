namespace ElelementryMathTestGUI
{
    public partial class frmMathTest : Form
    {

        public int NumOfQuestions { get; set; }

        public frmMathTest()
        {
            InitializeComponent();

        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {

            // Ensures the num of Questions is valid and doesnt crash the program
            if (string.IsNullOrWhiteSpace(txtNumOfQuestions.Text))
            {
                MessageBox.Show("Please enter a valid value.");
                txtNumOfQuestions.Focus();
                txtNumOfQuestions.SelectAll();
                return;
            }

            try
            {

                NumOfQuestions = int.Parse(txtNumOfQuestions.Text);

                if (NumOfQuestions <= 0)
                {
                    MessageBox.Show("The amount of questions can not be a negitive number.");
                    txtNumOfQuestions.Focus();
                    txtNumOfQuestions.SelectAll();
                    return;
                }
                // This passes the NumOfQuestions to the second form to then output the questions :)
                frmTestQuestions testForm = new frmTestQuestions(NumOfQuestions);
                testForm.Show();
                this.Hide();


            }
            catch
            {
                MessageBox.Show("The amount of questions must be a whole positive number.");
                txtNumOfQuestions.Focus();
                txtNumOfQuestions.SelectAll();

            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMathTest_Load(object sender, EventArgs e)
        {

        }
    }
}
