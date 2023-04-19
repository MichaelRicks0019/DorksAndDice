namespace DorksAndDiceForm.Pages
{
    partial class MainPage
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
            this.button_Add = new System.Windows.Forms.Button();
            this.button_ViewAllItems = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(330, 141);
            this.button_Add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(88, 87);
            this.button_Add.TabIndex = 0;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_ViewAllItems
            // 
            this.button_ViewAllItems.Location = new System.Drawing.Point(446, 247);
            this.button_ViewAllItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_ViewAllItems.Name = "button_ViewAllItems";
            this.button_ViewAllItems.Size = new System.Drawing.Size(88, 87);
            this.button_ViewAllItems.TabIndex = 1;
            this.button_ViewAllItems.Text = "View All Items";
            this.button_ViewAllItems.UseVisualStyleBackColor = true;
            this.button_ViewAllItems.Click += new System.EventHandler(this.button_ViewAllItems_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(330, 247);
            this.button_Update.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(88, 87);
            this.button_Update.TabIndex = 2;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(446, 141);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(88, 87);
            this.button_Delete.TabIndex = 3;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_ViewAllItems);
            this.Controls.Add(this.button_Add);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_ViewAllItems;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
    }
}