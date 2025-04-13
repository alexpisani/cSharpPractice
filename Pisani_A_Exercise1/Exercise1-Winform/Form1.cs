namespace Exercise1_Winform
{
    public partial class Form1 : Form
    {
        public const double installationCostPerHour = 35.75;
        public const double sqFtPerHour = 40;

        public Form1()
        {
            InitializeComponent();
        }
        // Initiate calculation
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get user inputs
                int length = Convert.ToInt32(txtLength.Text);
                int width = Convert.ToInt32(txtWidth.Text);
                double costPerSqFt = Convert.ToDouble(txtCostPerSqFt.Text);

                // Calculate floor area
                double floorArea = length * width;

                // Calculate flooring cost
                double flooringCost = floorArea * costPerSqFt;

                // Calculate installation hours
                double totalHours = floorArea / sqFtPerHour;

                // Calculate installation cost
                double installationCost = totalHours * installationCostPerHour;

                // Calculate total project cost
                double totalCost = flooringCost + installationCost;

                // Display results
                lblFloorArea.Text = floorArea.ToString("F2") + " sq. ft.";
                lblInstallationHours.Text = totalHours.ToString("F2") + " hours";
                lblMaterialCost.Text = flooringCost.ToString("C");
                lblTotalCost.Text = totalCost.ToString("C");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

        private void lblMaterialCost_Click(object sender, EventArgs e)
        {

        }
    }
}