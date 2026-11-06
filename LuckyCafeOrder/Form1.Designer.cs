namespace LuckyCafeOrder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            gbCustomerInfo = new GroupBox();
            txtQuantity = new TextBox();
            chkStudent = new CheckBox();
            lblQuantity = new Label();
            gbDrinkType = new GroupBox();
            rbJuice = new RadioButton();
            rbCoffee = new RadioButton();
            rbTea = new RadioButton();
            txtName = new TextBox();
            lblCustomerName = new Label();
            lstOrders = new ListBox();
            btnCalculate = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            btnClear = new Button();
            lblTotalPrice = new Label();
            lblLuckyMessage = new Label();
            gbCustomerInfo.SuspendLayout();
            gbDrinkType.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(88, 22);
            label1.Name = "label1";
            label1.Size = new Size(177, 30);
            label1.TabIndex = 0;
            label1.Text = "Lucky Cafe Order";
            // 
            // gbCustomerInfo
            // 
            gbCustomerInfo.Controls.Add(txtQuantity);
            gbCustomerInfo.Controls.Add(chkStudent);
            gbCustomerInfo.Controls.Add(lblQuantity);
            gbCustomerInfo.Controls.Add(gbDrinkType);
            gbCustomerInfo.Controls.Add(txtName);
            gbCustomerInfo.Controls.Add(lblCustomerName);
            gbCustomerInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbCustomerInfo.ForeColor = Color.Black;
            gbCustomerInfo.Location = new Point(41, 55);
            gbCustomerInfo.Name = "gbCustomerInfo";
            gbCustomerInfo.Size = new Size(479, 354);
            gbCustomerInfo.TabIndex = 3;
            gbCustomerInfo.TabStop = false;
            gbCustomerInfo.Text = "Customer Information";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(112, 264);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 29);
            txtQuantity.TabIndex = 5;
            // 
            // chkStudent
            // 
            chkStudent.AutoSize = true;
            chkStudent.Location = new Point(239, 268);
            chkStudent.Name = "chkStudent";
            chkStudent.Size = new Size(216, 25);
            chkStudent.TabIndex = 4;
            chkStudent.Text = "Student Member (10% Off)";
            chkStudent.UseVisualStyleBackColor = true;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(29, 264);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(77, 21);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "Quantity :";
            // 
            // gbDrinkType
            // 
            gbDrinkType.Controls.Add(rbJuice);
            gbDrinkType.Controls.Add(rbCoffee);
            gbDrinkType.Controls.Add(rbTea);
            gbDrinkType.Location = new Point(20, 110);
            gbDrinkType.Name = "gbDrinkType";
            gbDrinkType.Size = new Size(435, 142);
            gbDrinkType.TabIndex = 2;
            gbDrinkType.TabStop = false;
            gbDrinkType.Text = "Drink Type";
            // 
            // rbJuice
            // 
            rbJuice.AutoSize = true;
            rbJuice.Location = new Point(46, 107);
            rbJuice.Name = "rbJuice";
            rbJuice.Size = new Size(94, 25);
            rbJuice.TabIndex = 2;
            rbJuice.TabStop = true;
            rbJuice.Text = "Juice ($3)";
            rbJuice.UseVisualStyleBackColor = true;
            // 
            // rbCoffee
            // 
            rbCoffee.AutoSize = true;
            rbCoffee.Location = new Point(46, 76);
            rbCoffee.Name = "rbCoffee";
            rbCoffee.Size = new Size(105, 25);
            rbCoffee.TabIndex = 1;
            rbCoffee.TabStop = true;
            rbCoffee.Text = "Coffee ($2)\r\n";
            rbCoffee.UseVisualStyleBackColor = true;
            // 
            // rbTea
            // 
            rbTea.AutoSize = true;
            rbTea.Location = new Point(46, 45);
            rbTea.Name = "rbTea";
            rbTea.Size = new Size(82, 25);
            rbTea.TabIndex = 0;
            rbTea.TabStop = true;
            rbTea.Text = "Tea ($1)";
            rbTea.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(20, 66);
            txtName.Name = "txtName";
            txtName.Size = new Size(435, 29);
            txtName.TabIndex = 1;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(20, 42);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(127, 21);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "Customer Name:";
            // 
            // lstOrders
            // 
            lstOrders.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstOrders.FormattingEnabled = true;
            lstOrders.IntegralHeight = false;
            lstOrders.ItemHeight = 25;
            lstOrders.Location = new Point(537, 66);
            lstOrders.Name = "lstOrders";
            lstOrders.Size = new Size(362, 304);
            lstOrders.TabIndex = 4;
            lstOrders.Tag = "";
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnCalculate.ForeColor = Color.Black;
            btnCalculate.Location = new Point(12, 415);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(163, 54);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "CalculateOrder";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(195, 418);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(174, 51);
            btnSave.TabIndex = 7;
            btnSave.Text = "SaveToFile";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnLoad.ForeColor = Color.Black;
            btnLoad.Location = new Point(387, 420);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(160, 49);
            btnLoad.TabIndex = 8;
            btnLoad.Text = "LoadFromFile\r\n";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(559, 420);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(190, 49);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPrice.Location = new Point(50, 486);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(89, 21);
            lblTotalPrice.TabIndex = 11;
            lblTotalPrice.Text = "TotalPrice :";
            // 
            // lblLuckyMessage
            // 
            lblLuckyMessage.AutoSize = true;
            lblLuckyMessage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLuckyMessage.Location = new Point(41, 516);
            lblLuckyMessage.Name = "lblLuckyMessage";
            lblLuckyMessage.Size = new Size(124, 21);
            lblLuckyMessage.TabIndex = 10;
            lblLuckyMessage.Text = "Lucky Message:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 546);
            Controls.Add(lblTotalPrice);
            Controls.Add(lblLuckyMessage);
            Controls.Add(btnClear);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(btnCalculate);
            Controls.Add(lstOrders);
            Controls.Add(gbCustomerInfo);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbCustomerInfo.ResumeLayout(false);
            gbCustomerInfo.PerformLayout();
            gbDrinkType.ResumeLayout(false);
            gbDrinkType.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox gbCustomerInfo;
        private Label lblCustomerName;
        private TextBox txtName;
        private GroupBox gbDrinkType;
        private RadioButton rbJuice;
        private RadioButton rbCoffee;
        private RadioButton rbTea;
        private TextBox txtQuantity;
        private CheckBox chkStudent;
        private Label lblQuantity;
        private ListBox lstOrders;
        private Label label4;
        private Button btnCalculate;
        private Button btnSave;
        private Button btnLoad;
        private Button btnClear;
        private Label lblTotalPrice;
        private Label lblLuckyMessage;
    }
}
