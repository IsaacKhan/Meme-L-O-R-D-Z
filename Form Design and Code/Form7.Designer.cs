namespace Meme_L_O_R_D_Z___Forms
{
    partial class Form7
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.PrintInvoiceButton = new System.Windows.Forms.Button();
            this.CloseWindowButton = new System.Windows.Forms.Button();
            this.ViewInvoice = new System.Windows.Forms.DataGridView();
            this.form4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ViewInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form4BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PrintInvoiceButton
            // 
            this.PrintInvoiceButton.Location = new System.Drawing.Point(181, 269);
            this.PrintInvoiceButton.Name = "PrintInvoiceButton";
            this.PrintInvoiceButton.Size = new System.Drawing.Size(91, 36);
            this.PrintInvoiceButton.TabIndex = 0;
            this.PrintInvoiceButton.Text = "Print Invoice";
            this.PrintInvoiceButton.UseVisualStyleBackColor = true;
            this.PrintInvoiceButton.Click += new System.EventHandler(this.PrintInvoiceButton_Click);
            // 
            // CloseWindowButton
            // 
            this.CloseWindowButton.Location = new System.Drawing.Point(291, 269);
            this.CloseWindowButton.Name = "CloseWindowButton";
            this.CloseWindowButton.Size = new System.Drawing.Size(91, 36);
            this.CloseWindowButton.TabIndex = 1;
            this.CloseWindowButton.Text = "Close Program";
            this.CloseWindowButton.UseVisualStyleBackColor = true;
            this.CloseWindowButton.Click += new System.EventHandler(this.CloseWindowButton_Click);
            // 
            // ViewInvoice
            // 
            this.ViewInvoice.AllowUserToAddRows = false;
            this.ViewInvoice.AllowUserToDeleteRows = false;
            this.ViewInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewInvoice.Location = new System.Drawing.Point(12, 12);
            this.ViewInvoice.Name = "ViewInvoice";
            this.ViewInvoice.ReadOnly = true;
            this.ViewInvoice.Size = new System.Drawing.Size(554, 250);
            this.ViewInvoice.TabIndex = 2;
            // 
            // form4BindingSource
            // 
            this.form4BindingSource.DataSource = typeof(Meme_L_O_R_D_Z___Forms.Form4);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 317);
            this.Controls.Add(this.ViewInvoice);
            this.Controls.Add(this.CloseWindowButton);
            this.Controls.Add(this.PrintInvoiceButton);
            this.Name = "Form7";
            this.Text = "View Invoice";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form4BindingSource)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.BindingSource form4BindingSource;
        private System.Windows.Forms.Button PrintInvoiceButton;
        private System.Windows.Forms.Button CloseWindowButton;
        private System.Windows.Forms.DataGridView ViewInvoice;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
