namespace MoneyTakerUI
{
    partial class AddGroupsForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopBar = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.AddGroupNameLabel = new System.Windows.Forms.Label();
            this.AddGroupNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddGroupYesBtn = new System.Windows.Forms.Button();
            this.AddGroupCancelBtn = new System.Windows.Forms.Button();
            this.TopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(230)))));
            this.TopBar.Controls.Add(this.ExitBtn);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(500, 30);
            this.TopBar.TabIndex = 0;
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
            this.ExitBtn.Location = new System.Drawing.Point(470, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(30, 30);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // AddGroupNameLabel
            // 
            this.AddGroupNameLabel.AutoSize = true;
            this.AddGroupNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.AddGroupNameLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AddGroupNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.AddGroupNameLabel.Location = new System.Drawing.Point(83, 219);
            this.AddGroupNameLabel.Name = "AddGroupNameLabel";
            this.AddGroupNameLabel.Size = new System.Drawing.Size(148, 28);
            this.AddGroupNameLabel.TabIndex = 3;
            this.AddGroupNameLabel.Text = "Group Name : ";
            // 
            // AddGroupNameText
            // 
            this.AddGroupNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddGroupNameText.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AddGroupNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.AddGroupNameText.Location = new System.Drawing.Point(88, 250);
            this.AddGroupNameText.MaxLength = 20;
            this.AddGroupNameText.Name = "AddGroupNameText";
            this.AddGroupNameText.Size = new System.Drawing.Size(300, 23);
            this.AddGroupNameText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(83, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please write down the group name.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddGroupYesBtn
            // 
            this.AddGroupYesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.AddGroupYesBtn.FlatAppearance.BorderSize = 0;
            this.AddGroupYesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(129)))));
            this.AddGroupYesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.AddGroupYesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddGroupYesBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AddGroupYesBtn.ForeColor = System.Drawing.Color.White;
            this.AddGroupYesBtn.Location = new System.Drawing.Point(0, 452);
            this.AddGroupYesBtn.Name = "AddGroupYesBtn";
            this.AddGroupYesBtn.Size = new System.Drawing.Size(248, 49);
            this.AddGroupYesBtn.TabIndex = 19;
            this.AddGroupYesBtn.Text = "Add";
            this.AddGroupYesBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddGroupYesBtn.UseVisualStyleBackColor = false;
            this.AddGroupYesBtn.Click += new System.EventHandler(this.AddGroupYesBtn_Click);
            // 
            // AddGroupCancelBtn
            // 
            this.AddGroupCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.AddGroupCancelBtn.FlatAppearance.BorderSize = 0;
            this.AddGroupCancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(129)))));
            this.AddGroupCancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.AddGroupCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddGroupCancelBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AddGroupCancelBtn.ForeColor = System.Drawing.Color.White;
            this.AddGroupCancelBtn.Location = new System.Drawing.Point(252, 452);
            this.AddGroupCancelBtn.Name = "AddGroupCancelBtn";
            this.AddGroupCancelBtn.Size = new System.Drawing.Size(248, 49);
            this.AddGroupCancelBtn.TabIndex = 19;
            this.AddGroupCancelBtn.Text = "Cancel";
            this.AddGroupCancelBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddGroupCancelBtn.UseVisualStyleBackColor = false;
            this.AddGroupCancelBtn.Click += new System.EventHandler(this.AddGroupCancelBtn_Click);
            // 
            // AddGroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.AddGroupCancelBtn);
            this.Controls.Add(this.AddGroupYesBtn);
            this.Controls.Add(this.AddGroupNameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddGroupNameLabel);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddGroupsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label AddGroupNameLabel;
        private System.Windows.Forms.TextBox AddGroupNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddGroupYesBtn;
        private System.Windows.Forms.Button AddGroupCancelBtn;
    }
}

