namespace FractionCalculatorFromsApp
{
    public partial class FrmFractionCalculator : Form {
        public FrmFractionCalculator() {
            InitializeComponent();
        }
        private void FrmFractionCalculator_Load(object sender, EventArgs e) {
            // Ensures that the user can't accidently not enter a value in the combo box
            cboOperation.SelectedIndex = 0;
        }

        private void btnCalculate_Click(object sender, EventArgs e) {
            // creats two new objects that will later be assigned a numerator and denominator
            Fraction frac1 = new Fraction();
            Fraction frac2 = new Fraction();

            try {
                // Validates users input
                if (string.IsNullOrEmpty(txtNumerator1.Text) || string.IsNullOrEmpty(txtDenominator1.Text)) {
                    throw new FormatException("Please enter a number in the empty textbox.");
                }

                if (int.Parse(txtDenominator1.Text) < 0) {
                    throw new FormatException("Denominators must be a positive whole number");
                }

                frac1 = new Fraction(int.Parse(txtNumerator1.Text), int.Parse(txtDenominator1.Text));

            } catch (DivideByZeroException ex) {

                // Catch the specific DivideByZeroException
                txtDenominator1.SelectAll();
                txtDenominator1.Focus();
                statOutputDecimal.Text = $"{ex.Message}";
                return;
            } catch (FormatException ex) {

                if (string.IsNullOrEmpty(txtNumerator1.Text)) {
                    txtNumerator1.SelectAll();
                    txtNumerator1.Focus();
                    statOutputDecimal.Text = $"{ex.Message}";
                    return;
                }
                if (string.IsNullOrEmpty(txtDenominator1.Text)) {
                    txtDenominator1.SelectAll();
                    txtDenominator1.Focus();
                    statOutputDecimal.Text = $"{ex.Message}";
                    return;
                }

                statOutputDecimal.Text = $"Please enter a numeric value";
                return; // prevents futhur calculation
            }

            int operand = cboOperation.SelectedIndex;

            try {
                if (string.IsNullOrEmpty(txtNumerator2.Text) || string.IsNullOrEmpty(txtDenominator2.Text)) {
                    throw new FormatException("Please enter a number in the empty textbox.");
                }

                if (operand == 3 && int.Parse(txtNumerator2.Text) == 0) {                                                                                                                    //
                    throw new InvalidOperationException("Invalid numerator. Calculation requires division by Zero and math doesn't allow that >_<");
                }

                frac2 = new Fraction(int.Parse(txtNumerator2.Text), int.Parse(txtDenominator2.Text));

            } catch (DivideByZeroException ex) {
                // Catch the specific DivideByZeroException
                txtDenominator2.SelectAll();
                txtDenominator2.Focus();
                statOutputDecimal.Text = $"{ex.Message}";
                return;

            } catch (FormatException ex) {

                if (string.IsNullOrEmpty(txtNumerator2.Text)) {
                    txtNumerator2.SelectAll();
                    txtNumerator2.Focus();
                    statOutputDecimal.Text = $"{ex.Message}";
                    return;
                }

                if (string.IsNullOrEmpty(txtDenominator2.Text)) {
                    txtDenominator2.SelectAll();
                    txtDenominator2.Focus();
                    statOutputDecimal.Text = $"{ex.Message}";
                    return;
                }

                statOutputDecimal.Text = $"Please enter a numeric value";
                return;
            } catch (InvalidOperationException ex) {

                txtNumerator2.SelectAll();
                txtNumerator2.Focus();
                statOutputDecimal.Text = $"{ex.Message}";
                return;
            }



            Fraction FinalFrac = frac1;
            switch (operand) {
                case 0:
                    FinalFrac = frac1 + frac2;
                    break;
                case 1:
                    FinalFrac = frac1 - frac2;
                    break;
                case 2:
                    FinalFrac = frac1 * frac2;
                    break;
                case 3:
                    FinalFrac = frac1 / frac2;
                    break;
                default:
                    FinalFrac = frac1 - frac2;
                    break;

            }


            lblOutputFrac.Text = $"{FinalFrac}";
            statOutputDecimal.Text = $"Decimal equivalent: {FinalFrac.ToDecimal()}";
        }



        private void btnClear_Click(object sender, EventArgs e) {
            txtNumerator1.Clear();
            txtDenominator1.Clear();
            txtNumerator2.Clear();
            txtDenominator2.Clear();
            cboOperation.SelectedIndex = 0;
            lblOutputFrac.Text = "";
            statOutputDecimal.Text = "Enter a new equation.";

            txtNumerator1.Focus();
        }


    }
}
