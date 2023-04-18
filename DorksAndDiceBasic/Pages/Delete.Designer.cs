namespace DorksAndDiceBasic.Pages
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
            this.label_AmountLeft = new System.Windows.Forms.Label();
            this.textBox_Quantity = new System.Windows.Forms.TextBox();
            this.comboBox_Products = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dorksAndDiceDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dorksAndDiceDataSet = new DorksAndDiceBasic.DorksAndDiceDataSet();
            this.label_Quantity = new System.Windows.Forms.Label();
            this.diceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diceTableAdapter = new DorksAndDiceBasic.DorksAndDiceDataSetTableAdapters.DiceTableAdapter();
            this.productTableAdapter = new DorksAndDiceBasic.DorksAndDiceDataSetTableAdapters.ProductTableAdapter();
            this.groupBox_Delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dorksAndDiceDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dorksAndDiceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Delete
            // 
            this.groupBox_Delete.Controls.Add(this.label_AmountLeft);
            this.groupBox_Delete.Controls.Add(this.textBox_Quantity);
            this.groupBox_Delete.Controls.Add(this.comboBox_Products);
            this.groupBox_Delete.Controls.Add(this.label_Quantity);
            this.groupBox_Delete.Location = new System.Drawing.Point(185, 77);
            this.groupBox_Delete.Name = "groupBox_Delete";
            this.groupBox_Delete.Size = new System.Drawing.Size(294, 216);
            this.groupBox_Delete.TabIndex = 0;
            this.groupBox_Delete.TabStop = false;
            this.groupBox_Delete.Text = "Delete";
            // 
            // label_AmountLeft
            // 
            this.label_AmountLeft.AutoSize = true;
            this.label_AmountLeft.Location = new System.Drawing.Point(83, 59);
            this.label_AmountLeft.Name = "label_AmountLeft";
            this.label_AmountLeft.Size = new System.Drawing.Size(67, 13);
            this.label_AmountLeft.TabIndex = 1;
            this.label_AmountLeft.Text = "Amount Left:";
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.Location = new System.Drawing.Point(86, 118);
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.Size = new System.Drawing.Size(100, 20);
            this.textBox_Quantity.TabIndex = 2;
            // 
            // comboBox_Products
            // 
            this.comboBox_Products.DataSource = this.productBindingSource;
            this.comboBox_Products.DisplayMember = "Product_Name";
            this.comboBox_Products.FormattingEnabled = true;
            this.comboBox_Products.Location = new System.Drawing.Point(86, 35);
            this.comboBox_Products.Name = "comboBox_Products";
            this.comboBox_Products.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Products.TabIndex = 1;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.dorksAndDiceDataSetBindingSource;
            // 
            // dorksAndDiceDataSetBindingSource
            // 
            this.dorksAndDiceDataSetBindingSource.DataSource = this.dorksAndDiceDataSet;
            this.dorksAndDiceDataSetBindingSource.Position = 0;
            // 
            // dorksAndDiceDataSet
            // 
            this.dorksAndDiceDataSet.DataSetName = "DorksAndDiceDataSet";
            this.dorksAndDiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_Quantity
            // 
            this.label_Quantity.AutoSize = true;
            this.label_Quantity.Location = new System.Drawing.Point(83, 102);
            this.label_Quantity.Name = "label_Quantity";
            this.label_Quantity.Size = new System.Drawing.Size(46, 13);
            this.label_Quantity.TabIndex = 1;
            this.label_Quantity.Text = "Quantity";
            // 
            // diceBindingSource
            // 
            this.diceBindingSource.DataMember = "Dice";
            this.diceBindingSource.DataSource = this.dorksAndDiceDataSetBindingSource;
            // 
            // diceTableAdapter
            // 
            this.diceTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_Delete);
            this.Name = "Delete";
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.Delete_Load);
            this.groupBox_Delete.ResumeLayout(false);
            this.groupBox_Delete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dorksAndDiceDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dorksAndDiceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Delete;
        private System.Windows.Forms.ComboBox comboBox_Products;
        private System.Windows.Forms.Label label_Quantity;
        private System.Windows.Forms.BindingSource dorksAndDiceDataSetBindingSource;
        private DorksAndDiceDataSet dorksAndDiceDataSet;
        private System.Windows.Forms.BindingSource diceBindingSource;
        private DorksAndDiceDataSetTableAdapters.DiceTableAdapter diceTableAdapter;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DorksAndDiceDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.TextBox textBox_Quantity;
        private System.Windows.Forms.Label label_AmountLeft;
    }
}