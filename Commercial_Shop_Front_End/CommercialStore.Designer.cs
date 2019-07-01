namespace Commercial_Shop_Front_End
{
    partial class CommercialStore
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
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.ShoppingCartListBox = new System.Windows.Forms.ListBox();
            this.ItemsListBoxLabel = new System.Windows.Forms.Label();
            this.ShopingCartItemsListBoxLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Purchase = new System.Windows.Forms.Button();
            this.TotalAmountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(12, 111);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(265, 212);
            this.ItemsListBox.TabIndex = 0;
            // 
            // ShoppingCartListBox
            // 
            this.ShoppingCartListBox.FormattingEnabled = true;
            this.ShoppingCartListBox.Location = new System.Drawing.Point(497, 111);
            this.ShoppingCartListBox.Name = "ShoppingCartListBox";
            this.ShoppingCartListBox.Size = new System.Drawing.Size(469, 212);
            this.ShoppingCartListBox.TabIndex = 1;
            // 
            // ItemsListBoxLabel
            // 
            this.ItemsListBoxLabel.AutoSize = true;
            this.ItemsListBoxLabel.Location = new System.Drawing.Point(13, 92);
            this.ItemsListBoxLabel.Name = "ItemsListBoxLabel";
            this.ItemsListBoxLabel.Size = new System.Drawing.Size(57, 13);
            this.ItemsListBoxLabel.TabIndex = 2;
            this.ItemsListBoxLabel.Tag = "";
            this.ItemsListBoxLabel.Text = "StoreItems";
            // 
            // ShopingCartItemsListBoxLabel
            // 
            this.ShopingCartItemsListBoxLabel.AutoSize = true;
            this.ShopingCartItemsListBoxLabel.Location = new System.Drawing.Point(497, 92);
            this.ShopingCartItemsListBoxLabel.Name = "ShopingCartItemsListBoxLabel";
            this.ShopingCartItemsListBoxLabel.Size = new System.Drawing.Size(65, 13);
            this.ShopingCartItemsListBoxLabel.TabIndex = 3;
            this.ShopingCartItemsListBoxLabel.Text = "ShopingCart";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 68);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add To Shoping Cart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddToCart);
            // 
            // Purchase
            // 
            this.Purchase.Location = new System.Drawing.Point(643, 370);
            this.Purchase.Name = "Purchase";
            this.Purchase.Size = new System.Drawing.Size(145, 68);
            this.Purchase.TabIndex = 5;
            this.Purchase.Text = "Purchase";
            this.Purchase.UseVisualStyleBackColor = true;
            // 
            // TotalAmountLabel
            // 
            this.TotalAmountLabel.AutoSize = true;
            this.TotalAmountLabel.Location = new System.Drawing.Point(497, 399);
            this.TotalAmountLabel.Name = "TotalAmountLabel";
            this.TotalAmountLabel.Size = new System.Drawing.Size(49, 13);
            this.TotalAmountLabel.TabIndex = 6;
            this.TotalAmountLabel.Text = "Total: 0$";
            // 
            // CommercialStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 450);
            this.Controls.Add(this.TotalAmountLabel);
            this.Controls.Add(this.Purchase);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShopingCartItemsListBoxLabel);
            this.Controls.Add(this.ItemsListBoxLabel);
            this.Controls.Add(this.ShoppingCartListBox);
            this.Controls.Add(this.ItemsListBox);
            this.Name = "CommercialStore";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.ListBox ShoppingCartListBox;
        private System.Windows.Forms.Label ItemsListBoxLabel;
        private System.Windows.Forms.Label ShopingCartItemsListBoxLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Purchase;
        private System.Windows.Forms.Label TotalAmountLabel;
    }
}

