namespace Meme_L_O_R_D_Z___Forms
{
    partial class CreateOrderForm
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
            this.ViewProducts = new System.Windows.Forms.DataGridView();
            this.AddToCardButton = new System.Windows.Forms.Button();
            this.removeItem = new System.Windows.Forms.Button();
            this.cancelOrder = new System.Windows.Forms.Button();
            this.ConfirmOrder = new System.Windows.Forms.Button();
            this.CatalogLabel = new System.Windows.Forms.Label();
            this.CustomerCart = new System.Windows.Forms.Label();
            this.ViewCart = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCart)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewProducts
            // 
            this.ViewProducts.AllowUserToAddRows = false;
            this.ViewProducts.AllowUserToDeleteRows = false;
            this.ViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewProducts.Location = new System.Drawing.Point(12, 33);
            this.ViewProducts.MultiSelect = false;
            this.ViewProducts.Name = "ViewProducts";
            this.ViewProducts.ReadOnly = true;
            this.ViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ViewProducts.ShowEditingIcon = false;
            this.ViewProducts.Size = new System.Drawing.Size(733, 249);
            this.ViewProducts.TabIndex = 6;
            // 
            // AddToCardButton
            // 
            this.AddToCardButton.Location = new System.Drawing.Point(146, 306);
            this.AddToCardButton.Name = "AddToCardButton";
            this.AddToCardButton.Size = new System.Drawing.Size(93, 37);
            this.AddToCardButton.TabIndex = 8;
            this.AddToCardButton.Text = "Add to Cart";
            this.AddToCardButton.UseVisualStyleBackColor = true;
            this.AddToCardButton.Click += new System.EventHandler(this.AddToCardButton_Click);
            // 
            // removeItem
            // 
            this.removeItem.Location = new System.Drawing.Point(271, 306);
            this.removeItem.Name = "removeItem";
            this.removeItem.Size = new System.Drawing.Size(93, 37);
            this.removeItem.TabIndex = 15;
            this.removeItem.Text = "Remove Item";
            this.removeItem.UseVisualStyleBackColor = true;
            this.removeItem.Click += new System.EventHandler(this.removeItem_Click);
            // 
            // cancelOrder
            // 
            this.cancelOrder.Location = new System.Drawing.Point(389, 306);
            this.cancelOrder.Name = "cancelOrder";
            this.cancelOrder.Size = new System.Drawing.Size(93, 37);
            this.cancelOrder.TabIndex = 14;
            this.cancelOrder.Text = "Cancel Order";
            this.cancelOrder.UseVisualStyleBackColor = true;
            this.cancelOrder.Click += new System.EventHandler(this.cancelOrder_Click);
            // 
            // ConfirmOrder
            // 
            this.ConfirmOrder.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ConfirmOrder.Location = new System.Drawing.Point(506, 306);
            this.ConfirmOrder.Name = "ConfirmOrder";
            this.ConfirmOrder.Size = new System.Drawing.Size(93, 37);
            this.ConfirmOrder.TabIndex = 13;
            this.ConfirmOrder.Text = "Confirm Order";
            this.ConfirmOrder.UseVisualStyleBackColor = true;
            this.ConfirmOrder.Click += new System.EventHandler(this.confirmOrder_Click);
            // 
            // CatalogLabel
            // 
            this.CatalogLabel.AutoSize = true;
            this.CatalogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatalogLabel.Location = new System.Drawing.Point(284, 5);
            this.CatalogLabel.Name = "CatalogLabel";
            this.CatalogLabel.Size = new System.Drawing.Size(197, 25);
            this.CatalogLabel.TabIndex = 16;
            this.CatalogLabel.Text = "Here is our Catalog";
            // 
            // CustomerCart
            // 
            this.CustomerCart.AutoSize = true;
            this.CustomerCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerCart.Location = new System.Drawing.Point(234, 360);
            this.CustomerCart.Name = "CustomerCart";
            this.CustomerCart.Size = new System.Drawing.Size(270, 25);
            this.CustomerCart.TabIndex = 17;
            this.CustomerCart.Text = "Here is what is in your Cart";
            // 
            // ViewCart
            // 
            this.ViewCart.AllowUserToAddRows = false;
            this.ViewCart.AllowUserToDeleteRows = false;
            this.ViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewCart.Location = new System.Drawing.Point(12, 388);
            this.ViewCart.MultiSelect = false;
            this.ViewCart.Name = "ViewCart";
            this.ViewCart.ReadOnly = true;
            this.ViewCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ViewCart.ShowEditingIcon = false;
            this.ViewCart.Size = new System.Drawing.Size(733, 249);
            this.ViewCart.TabIndex = 18;
            this.ViewCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewCart_CellContentClick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 649);
            this.Controls.Add(this.ViewCart);
            this.Controls.Add(this.CustomerCart);
            this.Controls.Add(this.CatalogLabel);
            this.Controls.Add(this.removeItem);
            this.Controls.Add(this.cancelOrder);
            this.Controls.Add(this.ConfirmOrder);
            this.Controls.Add(this.AddToCardButton);
            this.Controls.Add(this.ViewProducts);
            this.Name = "Form4";
            this.Text = "Create Order";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewProducts;
        private System.Windows.Forms.Button AddToCardButton;
        private System.Windows.Forms.Button removeItem;
        private System.Windows.Forms.Button cancelOrder;
        private System.Windows.Forms.Button ConfirmOrder;
        private System.Windows.Forms.Label CatalogLabel;
        private System.Windows.Forms.Label CustomerCart;
        private System.Windows.Forms.DataGridView ViewCart;
    }
}