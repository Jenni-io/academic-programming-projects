namespace NumberingSystemConverter3000
{
    public partial class FrmNumberSysConverter : Form
    {
        public FrmNumberSysConverter()
        {
            InitializeComponent();
        }
        private void FrmNumberSysConverter_Load(object sender, EventArgs e)
        {
            cboCurrentBase.SelectedIndex = 0; // base 2
            cboTargetBase.SelectedIndex = 8; //  base 10

        } // end method


        private void btnReset_Click(object sender, EventArgs e)

        {
            txtNumtoConvert.Clear();
            txtNumtoConvert.Focus();
            lblOutPutBase.Text = "";
            cboCurrentBase.SelectedIndex = 0; // rests the base to base 2
            cboTargetBase.SelectedIndex = 8; // rests the base to base 10

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // exits the program
        }



        private void btnConvert_Click(object sender, EventArgs e)
        {
            // check if input is null or if empty
            if (string.IsNullOrWhiteSpace(txtNumtoConvert.Text))
            {
                MessageBox.Show("Please enter a valid value.");
                txtNumtoConvert.Focus();
                txtNumtoConvert.SelectAll();
                return;
            }
            // gets user input from txt to string var
            string numberGiven = txtNumtoConvert.Text;

            // gets user selected bases
            int fromBase = int.Parse(cboCurrentBase.SelectedItem?.ToString());
            int toBase = int.Parse(cboTargetBase.SelectedItem?.ToString());

            try
            {
                // Convert value to decimal 
                int decimalVal = BaseToDecimal(numberGiven, fromBase);

                if (decimalVal == -1) // prevents program from crashing if invalid input 
                {                     // that is reviewed in the BaseToDecimal method
                    txtNumtoConvert.Focus();
                    txtNumtoConvert.SelectAll();
                    return;

                }
                // Converts decimal to target base
                string result = DecimalToBaseX(decimalVal, toBase);

                lblOutPutBase.Text = result;
 

            } catch {
                MessageBox.Show("Please enter a number.");
                txtNumtoConvert.Focus();
                txtNumtoConvert.SelectAll();
    
            }
        }

        // Method to convert any base (2-10) to decimal
        public static int BaseToDecimal (string numberGiven, int fromBase) {

            int decimalNum = 0;
            int exponent = 1;

            for (int i = numberGiven.Length - 1; i >= 0; i--) {
                int digit = int.Parse(numberGiven[i].ToString()); // takes the individual digits from the whole number
                if (digit >= fromBase) {
                    MessageBox.Show($"The number {numberGiven} is invalid for base {fromBase}");
                    return -1; // raises a custom flag ish in the click event of convert
                }
                decimalNum += digit * exponent;
                exponent = exponent * fromBase;
            }
            return decimalNum;
        }
        
        // Method to convert from decimal to any base (2-10)
        public static string DecimalToBaseX(int decimalValue, int toBase)
        {
            if (toBase == 10) // if to base is 10 the previous method has already converted it
            {
                return decimalValue.ToString();
            }

            string result = "";
            int quotient = decimalValue;

            while (quotient > 0) // once the quotiont is zero loop stops since the calculation has then been performed
            {
                int remainder = quotient % toBase;
                result = remainder.ToString() + result; // result added last so that when the 
                quotient = quotient / toBase;           // characters are combined they are in correct order
            }

            if (result == "") { // special case if input is 0
                result = "0"; 
            }
            return result;
        }

        public void cmb_SelectedIndexChanged(object sender, EventArgs e)
        { 
            // changes the txt of group box  based on base selected
            string currentBase = cboCurrentBase.SelectedItem?.ToString();
            string targetBase = cboTargetBase.SelectedItem?.ToString();
            grpConvertingBases.Text = $"Converting from base {currentBase} to base {targetBase}"; // changes the txt of group box 

            lblOutPutBase.Text = "";
            txtNumtoConvert.Focus();
            txtNumtoConvert.SelectAll();
        
        }
    }
}

