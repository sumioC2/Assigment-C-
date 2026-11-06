namespace LuckyCafeOrder
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the customer name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity < 1)
            {
                MessageBox.Show("Please enter a valid quantity (1 or more).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            decimal unitPrice = 0;
            string drinkName = "";

            if (rbTea.Checked)
            {
                unitPrice = 1.00m;
                drinkName = "Tea";
            }
            else if (rbCoffee.Checked)
            {
                unitPrice = 2.00m;
                drinkName = "Coffee";
            }
            else if (rbJuice.Checked)
            {
                unitPrice = 3.00m;
                drinkName = "Juice";
            }
            else
            {
                MessageBox.Show("Please select a drink type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            lstOrders.Items.Clear();

            decimal totalBeforeDiscount = unitPrice * quantity;
            bool gotLucky = false;

           
            for (int i = 1; i <= quantity; i++)
            {
                int luckyNumber = random.Next(1, 51); // Lambar u dhexeeya 1 iyo 50[cite: 2]

                if (luckyNumber == 7 || luckyNumber == 17)
                {
                    gotLucky = true;
                }

                string orderLine = $"{i}) {txtName.Text.Trim()} - {drinkName} - Lucky: {luckyNumber} - ${unitPrice:F2}";
                lstOrders.Items.Add(orderLine);
            }

           
            decimal finalTotal = totalBeforeDiscount;

            lstOrders.Items.Add($"Member Discount: {(chkStudent.Checked ? "10%" : "0%")}");
            lstOrders.Items.Add($"Total Before Discount: ${totalBeforeDiscount:F2}");

            if (chkStudent.Checked)
            {
                finalTotal = totalBeforeDiscount - (totalBeforeDiscount * 0.10m);
            }

            lstOrders.Items.Add($"Total After Discount: ${finalTotal:F2}");

           
            string luckyMessage = "";
            if (gotLucky)
            {
                luckyMessage = "You got a Free Cookie!";
            }
            else
            {
                luckyMessage = "You got a free cookie!";
            }

            lstOrders.Items.Add($"Lucky Message: {luckyMessage}");

            // Ku soo bandhig xogta Label-yada hoose
            lblTotalPrice.Text = $"Total Price: ${finalTotal:F2}";
            lblLuckyMessage.Text = $"Lucky Message: {luckyMessage}";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("orders.txt"))
                {
                    foreach (var item in lstOrders.Items)
                    {
                        writer.WriteLine(item.ToString());
                    }
                }
                MessageBox.Show("Xogta waa lagu kaydiyay faylka!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cillad ayaa dhacday: " + ex.Message);
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("orders.txt"))
                {
                    lstOrders.Items.Clear();
                    string[] lines = File.ReadAllLines("orders.txt");
                    foreach (string line in lines)
                    {
                        lstOrders.Items.Add(line);
                    }
                    MessageBox.Show("Xogta waa la soo akhriyay!");
                }
                else
                {
                    MessageBox.Show("Faylka kaydinta lama helin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cillad ayaa dhacday: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtQuantity.Clear();
            rbTea.Checked = false;
            rbCoffee.Checked = false;
            rbJuice.Checked = false;
            chkStudent.Checked = false;
            lstOrders.Items.Clear();
            lblTotalPrice.Text = "Total Price: $0.00";
            lblLuckyMessage.Text = "Lucky Message:";
        }
    }
}

