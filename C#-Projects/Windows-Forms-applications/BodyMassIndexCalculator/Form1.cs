using System.Linq.Expressions;

namespace Body_Mass_Index_GUI_CH14_Lab3
{
    public partial class frmBMICalculator : Form
    {
        public frmBMICalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblInches_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double BMI = 0;
            double height = 0;
            double weight = 0;
            try
            {

                height = double.Parse(txtHeight.Text);
                if (height <= 0 || string.IsNullOrEmpty(txtHeight.Text)) { 
                    throw new FormatException("Invalid height.");
                }
            }
            catch (FormatException ex)  {

                lblOutputResult.Text = "Invalid height. Please enter a positive numerric values for height.";
                    txtHeight.SelectAll();
                    txtHeight.Focus();
                return; // prevents futhur calculation
            }

            try
            {
                weight = double.Parse(txtWeight.Text);
                if (weight <= 0 || string.IsNullOrEmpty(txtWeight.Text))
                {
                    throw new FormatException("Invalid  weight.");
                }
            }
            catch (FormatException ex) {
                lblOutputResult.Text = "Invalid weight. Please enter a positive numerric values for weight.";
                txtWeight.SelectAll();
                txtWeight.Focus();
                return; 
            }


            lblOutputResult.Text = string.Empty;  // Blanks the Output label
            if (rdoImperial.Checked)
            {
                BMI = weight * 703 / Math.Pow(height, 2);

                lblOutputResult.Text += $"Based on a height of {height}in " +
                    $"and a weight of {weight}lbs, your BMI is {BMI:F1}. ";

            }
            else if (rdoMetric.Checked)
            {
                BMI = (weight / height / height) * 10000;

                lblOutputResult.Text += $"Based on a height of {height}cm " +
                    $"and a weight of {weight}kg, your BMI is {BMI:F1}. ";
            }

            if (BMI < 18.5)
            {
                lblOutputResult.Text += "You are underweight.";

            }
            else if (BMI > 25)
            {
                lblOutputResult.Text += "You are overweight";
            }
            else
            {
                lblOutputResult.Text += "You weight is optimal";
            }

            //lblOutputResult.Text = 
        }

        private void MeasurementSys_CheckedChanged(object sender, EventArgs e)
        {

            if (sender == rdoImperial)
            {
                lblHeightMeasurement.Text = "in";
                lblWeightMeasurements.Text = "lbs";

            }
            else if (sender == rdoMetric)
            {
                lblHeightMeasurement.Text = "cm ";
                lblWeightMeasurements.Text = "kg";

            }
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // selects the Imperial radio button
            rdoImperial.Checked = true;

            // clears boxes
            txtHeight.Clear();
            txtWeight.Clear();

            // clear the result output and set focus to the first textbox
            lblOutputResult.Text = "";
            txtHeight.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
