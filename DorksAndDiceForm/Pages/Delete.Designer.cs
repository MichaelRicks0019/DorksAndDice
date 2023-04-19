namespace DorksAndDiceForm.Pages
{
    partial class Delete
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
            this.groupBox_Delete = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.label_AmountLeft = new System.Windows.Forms.Label();
            this.textBox_Quantity = new System.Windows.Forms.TextBox();
            this.comboBox_Products = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_Quantity = new System.Windows.Forms.Label();
            this.dorksAndDiceDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox_Delete.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dorksAndDiceDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Delete
            // 
            this.groupBox_Delete.Controls.Add(this.groupBox1);
            this.groupBox_Delete.Controls.Add(this.label_AmountLeft);
            this.groupBox_Delete.Controls.Add(this.textBox_Quantity);
            this.groupBox_Delete.Controls.Add(this.comboBox_Products);
            this.groupBox_Delete.Controls.Add(this.label_Quantity);
            this.groupBox_Delete.Location = new System.Drawing.Point(216, 89);
            this.groupBox_Delete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox_Delete.Name = "groupBox_Delete";
            this.groupBox_Delete.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox_Delete.Size = new System.Drawing.Size(343, 249);
            this.groupBox_Delete.TabIndex = 0;
            this.groupBox_Delete.TabStop = false;
            this.groupBox_Delete.Text = "Delete";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.button_Cancel);
            this.groupBox1.Controls.Add(this.button_Delete);
            this.groupBox1.Controls.Add(this.button_Reset);
            this.groupBox1.Location = new System.Drawing.Point(31, 175);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(279, 68);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(189, 22);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(88, 27);
            this.button_Cancel.TabIndex = 8;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(0, 22);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(88, 27);
            this.button_Delete.TabIndex = 6;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(94, 22);
            this.button_Reset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(88, 27);
            this.button_Reset.TabIndex = 7;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            // 
            // label_AmountLeft
            // 
            this.label_AmountLeft.AutoSize = true;
            this.label_AmountLeft.Location = new System.Drawing.Point(97, 68);
            this.label_AmountLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_AmountLeft.Name = "label_AmountLeft";
            this.label_AmountLeft.Size = new System.Drawing.Size(77, 15);
            this.label_AmountLeft.TabIndex = 1;
            this.label_AmountLeft.Text = "Amount Left:";
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.Location = new System.Drawing.Point(100, 136);
            this.textBox_Quantity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.Size = new System.Drawing.Size(116, 23);
            this.textBox_Quantity.TabIndex = 2;
            // 
            // comboBox_Products
            // 
            this.comboBox_Products.FormattingEnabled = true;
            this.comboBox_Products.Location = new System.Drawing.Point(100, 40);
            this.comboBox_Products.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_Products.Name = "comboBox_Products";
            this.comboBox_Products.Size = new System.Drawing.Size(140, 23);
            this.comboBox_Products.TabIndex = 1;
            this.comboBox_Products.SelectedIndexChanged += new System.EventHandler(this.comboBox_Products_SelectedIndexChanged);
            // 
            // label_Quantity
            // 
            this.label_Quantity.AutoSize = true;
            this.label_Quantity.Location = new System.Drawing.Point(97, 118);
            this.label_Quantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Quantity.Name = "label_Quantity";
            this.label_Quantity.Size = new System.Drawing.Size(53, 15);
            this.label_Quantity.TabIndex = 1;
            this.label_Quantity.Text = "Quantity";
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.groupBox_Delete);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Delete";
            this.Text = "Delete";
            this.groupBox_Delete.ResumeLayout(false);
            this.groupBox_Delete.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dorksAndDiceDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Delete;
        private System.Windows.Forms.ComboBox comboBox_Products;
        private System.Windows.Forms.Label label_Quantity;
        private System.Windows.Forms.BindingSource dorksAndDiceDataSetBindingSource;
        private System.Windows.Forms.BindingSource diceBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TextBox textBox_Quantity;
        private System.Windows.Forms.Label label_AmountLeft;
        private GroupBox groupBox1;
        private Button button_Cancel;
        private Button button_Delete;
        private Button button_Reset;
    }
}