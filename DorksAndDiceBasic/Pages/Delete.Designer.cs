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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dorksAndDiceDataSet = new DorksAndDiceBasic.DorksAndDiceDataSet();
            this.dorksAndDiceDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diceTableAdapter = new DorksAndDiceBasic.DorksAndDiceDataSetTableAdapters.DiceTableAdapter();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new DorksAndDiceBasic.DorksAndDiceDataSetTableAdapters.ProductTableAdapter();
            this.groupBox_Delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dorksAndDiceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dorksAndDiceDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Delete
            // 
            this.groupBox_Delete.Controls.Add(this.comboBox1);
            this.groupBox_Delete.Controls.Add(this.label2);
            this.groupBox_Delete.Controls.Add(this.label1);
            this.groupBox_Delete.Location = new System.Drawing.Point(264, 99);
            this.groupBox_Delete.Name = "groupBox_Delete";
            this.groupBox_Delete.Size = new System.Drawing.Size(294, 216);
            this.groupBox_Delete.TabIndex = 0;
            this.groupBox_Delete.TabStop = false;
            this.groupBox_Delete.Text = "Delete";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.productBindingSource;
            this.comboBox1.DisplayMember = "Product_Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
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
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.dorksAndDiceDataSetBindingSource;
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
            ((System.ComponentModel.ISupportInitialize)(this.dorksAndDiceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dorksAndDiceDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Delete;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource dorksAndDiceDataSetBindingSource;
        private DorksAndDiceDataSet dorksAndDiceDataSet;
        private System.Windows.Forms.BindingSource diceBindingSource;
        private DorksAndDiceDataSetTableAdapters.DiceTableAdapter diceTableAdapter;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DorksAndDiceDataSetTableAdapters.ProductTableAdapter productTableAdapter;
    }
}