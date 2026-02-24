namespace TCP_ServerClient_App
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
            this.txtLogLabel = new System.Windows.Forms.Label();
            this.txtPortLabel = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnStopServer = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLogLabel
            // 
            this.txtLogLabel.AutoSize = true;
            this.txtLogLabel.Location = new System.Drawing.Point(107, 153);
            this.txtLogLabel.Name = "txtLogLabel";
            this.txtLogLabel.Size = new System.Drawing.Size(94, 20);
            this.txtLogLabel.TabIndex = 11;
            this.txtLogLabel.Text = "Server Log: ";
            // 
            // txtPortLabel
            // 
            this.txtPortLabel.AutoSize = true;
            this.txtPortLabel.Location = new System.Drawing.Point(107, 124);
            this.txtPortLabel.Name = "txtPortLabel";
            this.txtPortLabel.Size = new System.Drawing.Size(42, 20);
            this.txtPortLabel.TabIndex = 10;
            this.txtPortLabel.Text = "Port:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(207, 121);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(368, 26);
            this.txtPort.TabIndex = 9;
            this.txtPort.Text = "3490";
            // 
            // btnStopServer
            // 
            this.btnStopServer.Enabled = false;
            this.btnStopServer.Location = new System.Drawing.Point(394, 287);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Size = new System.Drawing.Size(181, 52);
            this.btnStopServer.TabIndex = 8;
            this.btnStopServer.Text = "Stop Server";
            this.btnStopServer.UseVisualStyleBackColor = true;
            this.btnStopServer.Click += new System.EventHandler(this.btnStopServer_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(207, 153);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(368, 128);
            this.txtLog.TabIndex = 7;
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(207, 287);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(181, 52);
            this.btnStartServer.TabIndex = 6;
            this.btnStartServer.Text = "Start Server";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 569);
            this.Controls.Add(this.txtLogLabel);
            this.Controls.Add(this.txtPortLabel);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.btnStopServer);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnStartServer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtLogLabel;
        private System.Windows.Forms.Label txtPortLabel;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnStopServer;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnStartServer;
    }
}

