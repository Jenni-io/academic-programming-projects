using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElelementryMathTestGUI
{


    public partial class frmTestQuestions : Form {
        private int UsersNumOfQuestions;
        private int CurrentQuestionIndex = 0;
        private int NumberCorrect = 0;

        private static int _leftOperand;
        private static int _rightOperand;
        private static MathOperation _operation;

        private static readonly string[] POSITIVE_COMMENT = { "Correct!", "That's right!", "Yes!", "You got this" };

        private static readonly string[] NEGATIVE_COMMENT = { "Incorrect.", "That's wrong.", "Nope." };

        private static readonly Random m_rnd = new Random();

        public enum MathOperation {
            Addition = 0,
            Subtraction = 1,
            Multiplication = 2,
            Modulus = 3
        }

        // Initailizes the form and sets the num of questions chosen by user
        public frmTestQuestions(int numOfQuestions) {
            InitializeComponent();
            UsersNumOfQuestions = numOfQuestions;

            // Loads the first Test problem
            LoadNextProblem();
        }


        private void LoadNextProblem() {
            // Ensures we only make as many questions the user asks for
            if (CurrentQuestionIndex >= UsersNumOfQuestions) {
                // End of test if you stayed to end
                DialogResult result = MessageBox.Show($"Test complete! You answered {NumberCorrect} out of {UsersNumOfQuestions} correctly. Do you want to start another test", "Do you want to start another test?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) {
                    frmMathTest mathTest = new frmMathTest();
                    mathTest.Show();
                    this.Close();
                    return;
                } else {
                    this.Close();
                    return;
                }

                return;
            }

            CurrentQuestionIndex++;

            // Updates the labels and input for the next questions
            grpQuestionsContainer.Text = $"Question {CurrentQuestionIndex}";
            lblMathQuestion.Text = GetProblem();
            lblIsAnswerRight.Text = string.Empty;
            txtUsersAns.Clear();
            txtUsersAns.Focus();
        }

        // randomly selects a Operator
        private static MathOperation GetOperator() {
            return (MathOperation)m_rnd.Next(0, 4);
        }

        // choses a random number for the operands
        private static int GetOperand() {
            return m_rnd.Next(0, 10);
        }

        // Asembles the problem
        public static string GetProblem() {
            _leftOperand = GetOperand();
            _rightOperand = GetOperand();
            _operation = GetOperator();

            // prevents a problem resulting a number modulus by 0
            while (_operation == MathOperation.Modulus && _rightOperand == 0) {
                _rightOperand = GetOperand();
            }

            string symbol = "";

            // assigns the correct symbole from the num from MathOperation 
            switch (_operation) {
                case MathOperation.Addition:
                    symbol = "+";
                    break;
                case MathOperation.Subtraction:
                    symbol = "-";
                    break;
                case MathOperation.Multiplication:
                    symbol = "X";
                    break;
                case MathOperation.Modulus:
                    symbol = "%";
                    break;
                default:
                    symbol = "?";
                    break;
            }

            return $"{_leftOperand} {symbol} {_rightOperand} = ";
        }

        public static int GetAnswer() {
            int result = 0;

            // finds the correct answer to the question given to the user
            switch (_operation) {
                case MathOperation.Addition:
                    result = _leftOperand + _rightOperand;
                    break;
                case MathOperation.Subtraction:
                    result = _leftOperand - _rightOperand;
                    break;
                case MathOperation.Multiplication:
                    result = _leftOperand * _rightOperand;
                    break;
                case MathOperation.Modulus:
                    result = _leftOperand % _rightOperand;
                    break;
                default:
                    result = 0;
                    break;
            }
            // returns correct answer to be then compared
            return result;
        }
        // Get a random postive message
        private static string GetPositiveComment() {
            return POSITIVE_COMMENT[m_rnd.Next(POSITIVE_COMMENT.Length)];
        }
        // Get a random negative message
        private static string GetNegativeComment() {
            return NEGATIVE_COMMENT[m_rnd.Next(NEGATIVE_COMMENT.Length)];
        }


        private async void btnCheckAnser_Click(object sender, EventArgs e) {
            int actualAnswer = GetAnswer();
            int userAnswer = 0;

            try {
                // if userers ans is not a whole number or left blank its automaticaly counter wrong
                userAnswer = int.Parse(txtUsersAns.Text);

            } catch {

                lblIsAnswerRight.Text = $" {GetNegativeComment()} \n (Correct Answer: {actualAnswer})";
                // allows user to see if answer is wrong or right adding a delay
                await Task.Delay(1500);
                // Move to next problem
                LoadNextProblem();
                return;
            }
            // Checks if the answer is actualy correct
            if (userAnswer == actualAnswer) {
                NumberCorrect++;
                lblIsAnswerRight.Text = GetPositiveComment();
            } else {
                lblIsAnswerRight.Text = $" {GetNegativeComment()} \n (Correct Answer: {actualAnswer})";
            }

            // allows user to see if answer is wrong or right adding a delay
            await Task.Delay(1500);

            // Move to next problem
            LoadNextProblem();
        }

        private void btnGradeQuestionsAnswered_Click(object sender, EventArgs e) {
            // based on how many question you did answer and the ones you got write it grades it also allows you to take another test
            DialogResult result = MessageBox.Show($"You answered {NumberCorrect} out of {CurrentQuestionIndex} correctly. Do you want to start another test", "Do you want to start another test?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {
                frmMathTest mathTest = new frmMathTest();
                mathTest.Show();
                this.Close();
            } else {
                this.Close();
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e) {
            Application.Exit();
        }

        private void frmTestQuestions_Load(object sender, EventArgs e) {

        }
    }

}
