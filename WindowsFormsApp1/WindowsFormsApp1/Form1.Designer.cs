namespace WindowsFormsApp1
{
    partial class Form1
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
            this.ibUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btnloggin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ibUserName
            // 
            this.ibUserName.AutoSize = true;
            this.ibUserName.Location = new System.Drawing.Point(166, 86);
            this.ibUserName.Name = "ibUserName";
            this.ibUserName.Size = new System.Drawing.Size(73, 17);
            this.ibUserName.TabIndex = 0;
            this.ibUserName.Text = "Username";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(313, 81);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 22);
            this.txtUserName.TabIndex = 1;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(313, 133);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(100, 22);
            this.txtPassWord.TabIndex = 3;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(166, 138);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(69, 17);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Password";
            // 
            // btnloggin
            // 
            this.btnloggin.Location = new System.Drawing.Point(357, 270);
            this.btnloggin.Name = "btnloggin";
            this.btnloggin.Size = new System.Drawing.Size(87, 57);
            this.btnloggin.TabIndex = 4;
            this.btnloggin.Text = "Loggin";
            this.btnloggin.UseVisualStyleBackColor = true;
            this.btnloggin.Click += new System.EventHandler(this.btnloggin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnloggin);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.ibUserName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ibUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btnloggin;
    }
}

