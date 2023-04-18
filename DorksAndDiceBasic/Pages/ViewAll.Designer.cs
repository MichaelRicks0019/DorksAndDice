namespace DorksAndDiceBasic.Pages
{
    partial class ViewAll
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
            this.listBox_Products = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox_Products
            // 
            this.listBox_Products.FormattingEnabled = true;
            this.listBox_Products.Location = new System.Drawing.Point(12, 12);
            this.listBox_Products.Name = "listBox_Products";
            this.listBox_Products.Size = new System.Drawing.Size(776, 420);
            this.listBox_Products.TabIndex = 1;
            // 
            // ViewAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox_Products);
            this.Name = "ViewAll";
            this.Text = "ViewAll";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Products;
    }
}