namespace HreatRateCalculater
{
    public partial class FrmHeartRateCal : Form
    {
        public FrmHeartRateCal()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DateTime DateOfBirth = dtpDateOfBirth.Value;

            if (dtpDateOfBirth.Value > DateTime.Today)
            {
                lblOutput.Text = "Invalid date. Please choose a date again";
            }
            else
            {
                DateOfBirth = dtpDateOfBirth.Value;

                HeartRate userHeartRate = new HeartRate(DateOfBirth);
                lblOutput.Text = userHeartRate.ToString();

            }
        }

        private void FrmHeartRateCal_Load(object sender, EventArgs e)
        {

        }
    }
}
