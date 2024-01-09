namespace Inlämning_Affär
{
    partial class StoreScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GroceriesTextBox = new ListBox();
            addToCart = new Button();
            removeFromCart = new Button();
            customerCart = new ListBox();
            totalCostLabel = new Label();
            titleShopList = new Label();
            titleYourCart = new Label();
            SuspendLayout();
            // 
            // GroceriesTextBox
            // 
            GroceriesTextBox.FormattingEnabled = true;
            GroceriesTextBox.ItemHeight = 15;
            GroceriesTextBox.Location = new Point(22, 55);
            GroceriesTextBox.Name = "GroceriesTextBox";
            GroceriesTextBox.Size = new Size(120, 349);
            GroceriesTextBox.TabIndex = 0;
            // 
            // addToCart
            // 
            addToCart.Location = new Point(199, 120);
            addToCart.Name = "addToCart";
            addToCart.Size = new Size(91, 43);
            addToCart.TabIndex = 1;
            addToCart.Text = "Add";
            addToCart.UseVisualStyleBackColor = true;
            addToCart.Click += addToCart_Click;
            // 
            // removeFromCart
            // 
            removeFromCart.Location = new Point(199, 220);
            removeFromCart.Name = "removeFromCart";
            removeFromCart.Size = new Size(91, 43);
            removeFromCart.TabIndex = 1;
            removeFromCart.Text = "Remove";
            removeFromCart.UseVisualStyleBackColor = true;
            removeFromCart.Click += removeFromCart_Click;
            // 
            // customerCart
            // 
            customerCart.FormattingEnabled = true;
            customerCart.ItemHeight = 15;
            customerCart.Location = new Point(348, 55);
            customerCart.Name = "customerCart";
            customerCart.Size = new Size(120, 349);
            customerCart.TabIndex = 0;
            // 
            // totalCostLabel
            // 
            totalCostLabel.AutoSize = true;
            totalCostLabel.Location = new Point(501, 55);
            totalCostLabel.Name = "totalCostLabel";
            totalCostLabel.Size = new Size(56, 15);
            totalCostLabel.TabIndex = 2;
            totalCostLabel.Text = "TotalCost";
            // 
            // titleShopList
            // 
            titleShopList.AutoSize = true;
            titleShopList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleShopList.Location = new Point(41, 22);
            titleShopList.Name = "titleShopList";
            titleShopList.Size = new Size(76, 21);
            titleShopList.TabIndex = 3;
            titleShopList.Text = "Groceries";
            // 
            // titleYourCart
            // 
            titleYourCart.AutoSize = true;
            titleYourCart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleYourCart.Location = new Point(374, 22);
            titleYourCart.Name = "titleYourCart";
            titleYourCart.Size = new Size(75, 21);
            titleYourCart.TabIndex = 3;
            titleYourCart.Text = "Your Cart";
            // 
            // StoreScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(titleYourCart);
            Controls.Add(titleShopList);
            Controls.Add(totalCostLabel);
            Controls.Add(removeFromCart);
            Controls.Add(addToCart);
            Controls.Add(customerCart);
            Controls.Add(GroceriesTextBox);
            Name = "StoreScreen";
            Text = "StoreScreen";
            Load += StoreScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox GroceriesTextBox;
        private Button addToCart;
        private Button removeFromCart;
        private ListBox customerCart;
        private Label totalCostLabel;
        private Label titleShopList;
        private Label titleYourCart;
    }
}