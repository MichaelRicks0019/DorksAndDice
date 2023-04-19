namespace DorksAndDiceForm.Pages
{
    partial class Update
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
            this.Products = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Products
            // 
            this.Products.DisplayMember = "Dice_Id";
            this.Products.FormattingEnabled = true;
            this.Products.Location = new System.Drawing.Point(27, 104);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(183, 199);
            this.Products.TabIndex = 0;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Products);
            this.Name = "Update";
            this.Text = "Update";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Products;
    }
}