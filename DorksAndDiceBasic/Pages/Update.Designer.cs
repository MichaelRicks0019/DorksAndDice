namespace DorksAndDiceBasic
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
            this.dorksAndDiceDataSet = new DorksAndDiceBasic.DorksAndDiceDataSet();
            this.dorksAndDiceDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diceTableAdapter = new DorksAndDiceBasic.DorksAndDiceDataSetTableAdapters.DiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dorksAndDiceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dorksAndDiceDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Products
            // 
            this.Products.DataSource = this.diceBindingSource;
            this.Products.DisplayMember = "Dice_Id";
            this.Products.FormattingEnabled = true;
            this.Products.Location = new System.Drawing.Point(27, 104);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(183, 199);
            this.Products.TabIndex = 0;
            // 
            // dorksAndDiceDataSet
            // 
            this.dorksAndDiceDataSet.DataSetName = "DorksAndDiceDataSet";
            this.dorksAndDiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dorksAndDiceDataSetBindingSource
            // 
            this.dorksAndDiceDataSetBindingSource.DataSource = this.dorksAndDiceDataSet;
            this.dorksAndDiceDataSetBindingSource.Position = 0;
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
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Products);
            this.Name = "Update";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dorksAndDiceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dorksAndDiceDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Products;
        private System.Windows.Forms.BindingSource dorksAndDiceDataSetBindingSource;
        private DorksAndDiceDataSet dorksAndDiceDataSet;
        private System.Windows.Forms.BindingSource diceBindingSource;
        private DorksAndDiceDataSetTableAdapters.DiceTableAdapter diceTableAdapter;
    }
}