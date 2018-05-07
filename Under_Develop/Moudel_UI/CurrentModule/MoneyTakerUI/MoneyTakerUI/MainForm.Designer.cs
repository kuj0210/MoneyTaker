namespace MoneyTakerUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TopBar = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.ComeBackMain = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProfileBtn = new System.Windows.Forms.Button();
            this.friendsbtn = new System.Windows.Forms.Button();
            this.Settingsbtn = new System.Windows.Forms.Button();
            this.dealbtn = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TopBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComeBackMain)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(230)))));
            this.TopBar.Controls.Add(this.ExitBtn);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(1200, 30);
            this.TopBar.TabIndex = 1;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            this.TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseMove);
            this.TopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseUp);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(210)))));
            this.ExitBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExitBtn.ForeColor = System.Drawing.Color.Red;
            this.ExitBtn.Location = new System.Drawing.Point(1170, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(30, 30);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.LogOutBtn);
            this.panel1.Controls.Add(this.ComeBackMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 85);
            this.panel1.TabIndex = 2;
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.LogOutBtn.FlatAppearance.BorderSize = 0;
            this.LogOutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(129)))));
            this.LogOutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.LogOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutBtn.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LogOutBtn.ForeColor = System.Drawing.Color.White;
            this.LogOutBtn.Location = new System.Drawing.Point(1083, 21);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(87, 37);
            this.LogOutBtn.TabIndex = 9;
            this.LogOutBtn.Text = "Logout";
            this.LogOutBtn.UseVisualStyleBackColor = false;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // ComeBackMain
            // 
            this.ComeBackMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComeBackMain.Image = ((System.Drawing.Image)(resources.GetObject("ComeBackMain.Image")));
            this.ComeBackMain.Location = new System.Drawing.Point(0, 0);
            this.ComeBackMain.Name = "ComeBackMain";
            this.ComeBackMain.Size = new System.Drawing.Size(274, 85);
            this.ComeBackMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ComeBackMain.TabIndex = 0;
            this.ComeBackMain.TabStop = false;
            this.ComeBackMain.Click += new System.EventHandler(this.ComeBackMain_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panel2.Controls.Add(this.ProfileBtn);
            this.panel2.Controls.Add(this.friendsbtn);
            this.panel2.Controls.Add(this.Settingsbtn);
            this.panel2.Controls.Add(this.dealbtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 585);
            this.panel2.TabIndex = 3;
            // 
            // ProfileBtn
            // 
            this.ProfileBtn.FlatAppearance.BorderSize = 0;
            this.ProfileBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(230)))));
            this.ProfileBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.ProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileBtn.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ProfileBtn.Image = ((System.Drawing.Image)(resources.GetObject("ProfileBtn.Image")));
            this.ProfileBtn.Location = new System.Drawing.Point(0, 0);
            this.ProfileBtn.Name = "ProfileBtn";
            this.ProfileBtn.Size = new System.Drawing.Size(272, 127);
            this.ProfileBtn.TabIndex = 4;
            this.ProfileBtn.Text = "profile";
            this.ProfileBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ProfileBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ProfileBtn.UseVisualStyleBackColor = true;
            this.ProfileBtn.Click += new System.EventHandler(this.ProfileBtn_Click);
            // 
            // friendsbtn
            // 
            this.friendsbtn.FlatAppearance.BorderSize = 0;
            this.friendsbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(230)))));
            this.friendsbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.friendsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.friendsbtn.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.friendsbtn.Image = ((System.Drawing.Image)(resources.GetObject("friendsbtn.Image")));
            this.friendsbtn.Location = new System.Drawing.Point(0, 133);
            this.friendsbtn.Name = "friendsbtn";
            this.friendsbtn.Size = new System.Drawing.Size(272, 127);
            this.friendsbtn.TabIndex = 5;
            this.friendsbtn.Text = "friends";
            this.friendsbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.friendsbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.friendsbtn.UseVisualStyleBackColor = true;
            this.friendsbtn.Click += new System.EventHandler(this.friendsbtn_Click);
            // 
            // Settingsbtn
            // 
            this.Settingsbtn.FlatAppearance.BorderSize = 0;
            this.Settingsbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(230)))));
            this.Settingsbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Settingsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settingsbtn.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Settingsbtn.Image = ((System.Drawing.Image)(resources.GetObject("Settingsbtn.Image")));
            this.Settingsbtn.Location = new System.Drawing.Point(0, 399);
            this.Settingsbtn.Name = "Settingsbtn";
            this.Settingsbtn.Size = new System.Drawing.Size(272, 127);
            this.Settingsbtn.TabIndex = 7;
            this.Settingsbtn.Text = "Settings";
            this.Settingsbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Settingsbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Settingsbtn.UseVisualStyleBackColor = true;
            // 
            // dealbtn
            // 
            this.dealbtn.FlatAppearance.BorderSize = 0;
            this.dealbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(230)))));
            this.dealbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.dealbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dealbtn.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dealbtn.Image = ((System.Drawing.Image)(resources.GetObject("dealbtn.Image")));
            this.dealbtn.Location = new System.Drawing.Point(0, 266);
            this.dealbtn.Name = "dealbtn";
            this.dealbtn.Size = new System.Drawing.Size(272, 127);
            this.dealbtn.TabIndex = 6;
            this.dealbtn.Text = "deal";
            this.dealbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dealbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.dealbtn.UseVisualStyleBackColor = true;
            this.dealbtn.Click += new System.EventHandler(this.dealbtn_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(274, 115);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(926, 585);
            this.MainPanel.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TopBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComeBackMain)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ComeBackMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button friendsbtn;
        private System.Windows.Forms.Button Settingsbtn;
        private System.Windows.Forms.Button dealbtn;
        private System.Windows.Forms.Button ProfileBtn;
        private System.Windows.Forms.Button LogOutBtn;
    }
}