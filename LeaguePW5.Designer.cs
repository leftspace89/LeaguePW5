namespace LeaguePW5
{
    partial class LeaguePW5
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
            this.lobbyName = new System.Windows.Forms.TextBox();
            this.createLobby = new System.Windows.Forms.Button();
            this.lblLobbyName = new System.Windows.Forms.Label();
            this.lblSite = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lobbyName
            // 
            this.lobbyName.Location = new System.Drawing.Point(94, 18);
            this.lobbyName.Name = "lobbyName";
            this.lobbyName.Size = new System.Drawing.Size(162, 20);
            this.lobbyName.TabIndex = 0;
            this.lobbyName.Text = "memoryhackers.org";
            // 
            // createLobby
            // 
            this.createLobby.Location = new System.Drawing.Point(94, 44);
            this.createLobby.Name = "createLobby";
            this.createLobby.Size = new System.Drawing.Size(162, 44);
            this.createLobby.TabIndex = 1;
            this.createLobby.Text = "Create Lobby";
            this.createLobby.UseVisualStyleBackColor = true;
            this.createLobby.Click += new System.EventHandler(this.createLobby_Click);
            // 
            // lblLobbyName
            // 
            this.lblLobbyName.AutoSize = true;
            this.lblLobbyName.Location = new System.Drawing.Point(12, 21);
            this.lblLobbyName.Name = "lblLobbyName";
            this.lblLobbyName.Size = new System.Drawing.Size(76, 13);
            this.lblLobbyName.TabIndex = 2;
            this.lblLobbyName.Text = "Lobby Name : ";
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(12, 75);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(50, 13);
            this.lblSite.TabIndex = 3;
            this.lblSite.TabStop = true;
            this.lblSite.Text = "leftspace";
            this.lblSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSite_LinkClicked);
            // 
            // LeaguePW5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 98);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.lblLobbyName);
            this.Controls.Add(this.createLobby);
            this.Controls.Add(this.lobbyName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LeaguePW5";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeaguePW5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lobbyName;
        private System.Windows.Forms.Button createLobby;
        private System.Windows.Forms.Label lblLobbyName;
        private System.Windows.Forms.LinkLabel lblSite;
    }
}

