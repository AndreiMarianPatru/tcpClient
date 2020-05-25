namespace tcpClient
{
    partial class FrontPage
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
            this.FPUsernameBox = new System.Windows.Forms.TextBox();
            this.FPUsertxt = new System.Windows.Forms.TextBox();
            this.FPPasstxt = new System.Windows.Forms.TextBox();
            this.bLogin = new System.Windows.Forms.Button();
            this.bRegister = new System.Windows.Forms.Button();
            this.FPConsole = new System.Windows.Forms.TextBox();
            this.FPPassBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FPUsernameBox
            // 
            this.FPUsernameBox.Location = new System.Drawing.Point(251, 87);
            this.FPUsernameBox.Multiline = true;
            this.FPUsernameBox.Name = "FPUsernameBox";
            this.FPUsernameBox.Size = new System.Drawing.Size(225, 47);
            this.FPUsernameBox.TabIndex = 0;
            this.FPUsernameBox.TextChanged += new System.EventHandler(this.FPUsernameBox_TextChanged);
            // 
            // FPUsertxt
            // 
            this.FPUsertxt.Location = new System.Drawing.Point(118, 87);
            this.FPUsertxt.Multiline = true;
            this.FPUsertxt.Name = "FPUsertxt";
            this.FPUsertxt.ReadOnly = true;
            this.FPUsertxt.Size = new System.Drawing.Size(127, 30);
            this.FPUsertxt.TabIndex = 3;
            this.FPUsertxt.Text = "Username";
            this.FPUsertxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FPPasstxt
            // 
            this.FPPasstxt.Location = new System.Drawing.Point(118, 217);
            this.FPPasstxt.Name = "FPPasstxt";
            this.FPPasstxt.ReadOnly = true;
            this.FPPasstxt.Size = new System.Drawing.Size(127, 26);
            this.FPPasstxt.TabIndex = 4;
            this.FPPasstxt.Text = "Password";
            this.FPPasstxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(251, 296);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(147, 44);
            this.bLogin.TabIndex = 5;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // bRegister
            // 
            this.bRegister.Location = new System.Drawing.Point(251, 346);
            this.bRegister.Name = "bRegister";
            this.bRegister.Size = new System.Drawing.Size(147, 44);
            this.bRegister.TabIndex = 6;
            this.bRegister.Text = "Register";
            this.bRegister.UseVisualStyleBackColor = true;
            this.bRegister.Click += new System.EventHandler(this.bRegister_Click);
            // 
            // FPConsole
            // 
            this.FPConsole.Location = new System.Drawing.Point(530, 87);
            this.FPConsole.Multiline = true;
            this.FPConsole.Name = "FPConsole";
            this.FPConsole.Size = new System.Drawing.Size(233, 303);
            this.FPConsole.TabIndex = 7;
            // 
            // FPPassBox
            // 
            this.FPPassBox.Location = new System.Drawing.Point(251, 196);
            this.FPPassBox.Multiline = true;
            this.FPPassBox.Name = "FPPassBox";
            this.FPPassBox.Size = new System.Drawing.Size(225, 47);
            this.FPPassBox.TabIndex = 8;
            this.FPPassBox.TextChanged += new System.EventHandler(this.FPPassBox_TextChanged);
            // 
            // FrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FPPassBox);
            this.Controls.Add(this.FPConsole);
            this.Controls.Add(this.bRegister);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.FPPasstxt);
            this.Controls.Add(this.FPUsertxt);
            this.Controls.Add(this.FPUsernameBox);
            this.Name = "FrontPage";
            this.Text = "FrontPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FPUsernameBox;
        private System.Windows.Forms.TextBox FPUsertxt;
        private System.Windows.Forms.TextBox FPPasstxt;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.Button bRegister;
        private System.Windows.Forms.TextBox FPConsole;
        private System.Windows.Forms.TextBox FPPassBox;
    }
}