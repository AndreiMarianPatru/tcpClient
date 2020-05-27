namespace tcpClient
{
    partial class chat
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
            this.bSend = new System.Windows.Forms.Button();
            this.tConsole = new System.Windows.Forms.TextBox();
            this.tChat = new System.Windows.Forms.TextBox();
            this.bConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(639, 344);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(149, 68);
            this.bSend.TabIndex = 0;
            this.bSend.Text = "Send!";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // tConsole
            // 
            this.tConsole.Location = new System.Drawing.Point(27, 33);
            this.tConsole.Multiline = true;
            this.tConsole.Name = "tConsole";
            this.tConsole.Size = new System.Drawing.Size(585, 310);
            this.tConsole.TabIndex = 1;
            this.tConsole.TabStop = false;
            this.tConsole.TextChanged += new System.EventHandler(this.tConsole_TextChanged);
            // 
            // tChat
            // 
            this.tChat.Location = new System.Drawing.Point(27, 350);
            this.tChat.Multiline = true;
            this.tChat.Name = "tChat";
            this.tChat.Size = new System.Drawing.Size(585, 62);
            this.tChat.TabIndex = 2;
            this.tChat.TextChanged += new System.EventHandler(this.tChat_TextChanged);
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(639, 35);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(149, 48);
            this.bConnect.TabIndex = 3;
            this.bConnect.Text = "Connect to Server";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bConnect);
            this.Controls.Add(this.tChat);
            this.Controls.Add(this.tConsole);
            this.Controls.Add(this.bSend);
            this.Name = "chat";
            this.Text = "chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.TextBox tConsole;
        private System.Windows.Forms.TextBox tChat;
        private System.Windows.Forms.Button bConnect;
    }
}