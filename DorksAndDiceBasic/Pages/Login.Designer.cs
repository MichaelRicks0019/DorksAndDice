namespace DorksAndDiceBasic
{
    partial class Login
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
            this.Text_DorksAndDice = new System.Windows.Forms.Label();
            this.label_UserName = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.GroupBox_UserDetails = new System.Windows.Forms.GroupBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.GroupBox_UserDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // Text_DorksAndDice
            // 
            this.Text_DorksAndDice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Text_DorksAndDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_DorksAndDice.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Text_DorksAndDice.Location = new System.Drawing.Point(0, 0);
            this.Text_DorksAndDice.Name = "Text_DorksAndDice";
            this.Text_DorksAndDice.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.Text_DorksAndDice.Size = new System.Drawing.Size(722, 450);
            this.Text_DorksAndDice.TabIndex = 0;
            this.Text_DorksAndDice.Text = "Dorks And Dice";
            this.Text_DorksAndDice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Location = new System.Drawing.Point(6, 16);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(58, 13);
            this.label_UserName.TabIndex = 1;
            this.label_UserName.Text = "Username:";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(6, 55);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(53, 13);
            this.label_Password.TabIndex = 2;
            this.label_Password.Text = "Password";
            this.label_Password.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(9, 32);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(185, 20);
            this.textBox_UserName.TabIndex = 3;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(9, 74);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(185, 20);
            this.textBox_Password.TabIndex = 4;
            // 
            // GroupBox_UserDetails
            // 
            this.GroupBox_UserDetails.Controls.Add(this.button_Login);
            this.GroupBox_UserDetails.Controls.Add(this.label_UserName);
            this.GroupBox_UserDetails.Controls.Add(this.textBox_Password);
            this.GroupBox_UserDetails.Controls.Add(this.textBox_UserName);
            this.GroupBox_UserDetails.Controls.Add(this.label_Password);
            this.GroupBox_UserDetails.Location = new System.Drawing.Point(257, 83);
            this.GroupBox_UserDetails.Name = "GroupBox_UserDetails";
            this.GroupBox_UserDetails.Size = new System.Drawing.Size(200, 140);
            this.GroupBox_UserDetails.TabIndex = 5;
            this.GroupBox_UserDetails.TabStop = false;
            // 
            // button_Login
            // 
            this.button_Login.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_Login.Location = new System.Drawing.Point(3, 114);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(194, 23);
            this.button_Login.TabIndex = 5;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.GroupBox_UserDetails);
            this.Controls.Add(this.Text_DorksAndDice);
            this.Name = "Login";
            this.Text = "Login";
            this.GroupBox_UserDetails.ResumeLayout(false);
            this.GroupBox_UserDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Text_DorksAndDice;
        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.GroupBox GroupBox_UserDetails;
        private System.Windows.Forms.Button button_Login;
    }
}