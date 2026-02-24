namespace TCP_ServerClient_App
{
    partial class ClientForm
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
            this.ServerIpLabel = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.ServerIPTextBox = new System.Windows.Forms.TextBox();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.MessageBoxLabel = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.LogLabel = new System.Windows.Forms.Label();
            this.ClearLogButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ServerIpLabel
            // 
            this.ServerIpLabel.AutoSize = true;
            this.ServerIpLabel.Location = new System.Drawing.Point(96, 143);
            this.ServerIpLabel.Name = "ServerIpLabel";
            this.ServerIpLabel.Size = new System.Drawing.Size(78, 20);
            this.ServerIpLabel.TabIndex = 0;
            this.ServerIpLabel.Text = "Server IP:";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(96, 181);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(42, 20);
            this.PortLabel.TabIndex = 1;
            this.PortLabel.Text = "Port:";
            // 
            // ServerIPTextBox
            // 
            this.ServerIPTextBox.Location = new System.Drawing.Point(201, 143);
            this.ServerIPTextBox.Name = "ServerIPTextBox";
            this.ServerIPTextBox.Size = new System.Drawing.Size(260, 26);
            this.ServerIPTextBox.TabIndex = 2;
            this.ServerIPTextBox.Text = "127.0.0.1";
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(201, 178);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(260, 26);
            this.PortTextBox.TabIndex = 3;
            this.PortTextBox.Text = "3490";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(100, 210);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(173, 36);
            this.ConnectButton.TabIndex = 4;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Enabled = false;
            this.DisconnectButton.Location = new System.Drawing.Point(288, 210);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(173, 36);
            this.DisconnectButton.TabIndex = 5;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(201, 262);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MessageTextBox.Size = new System.Drawing.Size(260, 133);
            this.MessageTextBox.TabIndex = 6;
            // 
            // MessageBoxLabel
            // 
            this.MessageBoxLabel.AutoSize = true;
            this.MessageBoxLabel.Location = new System.Drawing.Point(100, 262);
            this.MessageBoxLabel.Name = "MessageBoxLabel";
            this.MessageBoxLabel.Size = new System.Drawing.Size(78, 20);
            this.MessageBoxLabel.TabIndex = 7;
            this.MessageBoxLabel.Text = "Message:";
            // 
            // SendButton
            // 
            this.SendButton.Enabled = false;
            this.SendButton.Location = new System.Drawing.Point(104, 402);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(357, 48);
            this.SendButton.TabIndex = 8;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(538, 174);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTextBox.Size = new System.Drawing.Size(320, 221);
            this.LogTextBox.TabIndex = 9;
            // 
            // LogLabel
            // 
            this.LogLabel.AutoSize = true;
            this.LogLabel.Location = new System.Drawing.Point(538, 148);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(40, 20);
            this.LogLabel.TabIndex = 10;
            this.LogLabel.Text = "Log:";
            // 
            // ClearLogButton
            // 
            this.ClearLogButton.Location = new System.Drawing.Point(538, 402);
            this.ClearLogButton.Name = "ClearLogButton";
            this.ClearLogButton.Size = new System.Drawing.Size(320, 48);
            this.ClearLogButton.TabIndex = 11;
            this.ClearLogButton.Text = "Clear Log";
            this.ClearLogButton.UseVisualStyleBackColor = true;
            this.ClearLogButton.Click += new System.EventHandler(this.ClearLogButton_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 548);
            this.Controls.Add(this.ClearLogButton);
            this.Controls.Add(this.LogLabel);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.MessageBoxLabel);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.ServerIPTextBox);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.ServerIpLabel);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ServerIpLabel;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox ServerIPTextBox;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Label MessageBoxLabel;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.Label LogLabel;
        private System.Windows.Forms.Button ClearLogButton;
    }
}