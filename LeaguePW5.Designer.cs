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
            this.btn_addBots = new System.Windows.Forms.Button();
            this.botDifficulty = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boostFuck = new System.Windows.Forms.Button();
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
            this.createLobby.Location = new System.Drawing.Point(262, 12);
            this.createLobby.Name = "createLobby";
            this.createLobby.Size = new System.Drawing.Size(168, 26);
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
            this.lblSite.Location = new System.Drawing.Point(12, 107);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(50, 13);
            this.lblSite.TabIndex = 3;
            this.lblSite.TabStop = true;
            this.lblSite.Text = "leftspace";
            this.lblSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSite_LinkClicked);
            // 
            // btn_addBots
            // 
            this.btn_addBots.Location = new System.Drawing.Point(262, 44);
            this.btn_addBots.Name = "btn_addBots";
            this.btn_addBots.Size = new System.Drawing.Size(168, 48);
            this.btn_addBots.TabIndex = 4;
            this.btn_addBots.Text = "Add Bots";
            this.btn_addBots.UseVisualStyleBackColor = true;
            this.btn_addBots.Click += new System.EventHandler(this.btn_addBots_Click);
            // 
            // botDifficulty
            // 
            this.botDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.botDifficulty.FormattingEnabled = true;
            this.botDifficulty.Items.AddRange(new object[] {
            "MEDIUM",
            "EASY"});
            this.botDifficulty.Location = new System.Drawing.Point(94, 44);
            this.botDifficulty.Name = "botDifficulty";
            this.botDifficulty.Size = new System.Drawing.Size(162, 21);
            this.botDifficulty.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "botDifficulty:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "FULL CC",
            "FULL MAGIC",
            "FULL ADC",
            "FULL TANK"});
            this.comboBox1.Location = new System.Drawing.Point(94, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "bot Comp:";
            // 
            // boostFuck
            // 
            this.boostFuck.Location = new System.Drawing.Point(436, 12);
            this.boostFuck.Name = "boostFuck";
            this.boostFuck.Size = new System.Drawing.Size(90, 80);
            this.boostFuck.TabIndex = 9;
            this.boostFuck.Text = "BoostRandom";
            this.boostFuck.UseVisualStyleBackColor = true;
            this.boostFuck.Click += new System.EventHandler(this.boostFuck_Click);
            // 
            // LeaguePW5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 121);
            this.Controls.Add(this.boostFuck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botDifficulty);
            this.Controls.Add(this.btn_addBots);
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
            this.Load += new System.EventHandler(this.LeaguePW5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lobbyName;
        private System.Windows.Forms.Button createLobby;
        private System.Windows.Forms.Label lblLobbyName;
        private System.Windows.Forms.LinkLabel lblSite;
        private System.Windows.Forms.Button btn_addBots;
        private System.Windows.Forms.ComboBox botDifficulty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button boostFuck;
    }
}

