namespace MoneyTakerUI
{
    partial class FriendsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FriendsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.FriendsData = new System.Windows.Forms.DataGridView();
            this.이메일 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.신용도 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.이름 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.룹그 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchFriendsText = new System.Windows.Forms.TextBox();
            this.SerchFriendsBtn = new System.Windows.Forms.Button();
            this.AddFriendsBtn = new System.Windows.Forms.Button();
            this.AddGroupBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FriendsData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddGroupBtn);
            this.panel1.Controls.Add(this.AddFriendsBtn);
            this.panel1.Controls.Add(this.SerchFriendsBtn);
            this.panel1.Controls.Add(this.SearchFriendsText);
            this.panel1.Controls.Add(this.FriendsData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 585);
            this.panel1.TabIndex = 0;
            // 
            // FriendsData
            // 
            this.FriendsData.AllowUserToAddRows = false;
            this.FriendsData.AllowUserToDeleteRows = false;
            this.FriendsData.AllowUserToResizeColumns = false;
            this.FriendsData.AllowUserToResizeRows = false;
            this.FriendsData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FriendsData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.FriendsData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FriendsData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FriendsData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FriendsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FriendsData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.룹그,
            this.이름,
            this.신용도,
            this.이메일});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FriendsData.DefaultCellStyle = dataGridViewCellStyle2;
            this.FriendsData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.FriendsData.Location = new System.Drawing.Point(44, 89);
            this.FriendsData.Name = "FriendsData";
            this.FriendsData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.FriendsData.RowHeadersVisible = false;
            this.FriendsData.RowTemplate.Height = 35;
            this.FriendsData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FriendsData.Size = new System.Drawing.Size(842, 455);
            this.FriendsData.TabIndex = 0;
            // 
            // 이메일
            // 
            this.이메일.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.이메일.HeaderText = "E-mail";
            this.이메일.Name = "이메일";
            this.이메일.ReadOnly = true;
            this.이메일.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 신용도
            // 
            this.신용도.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.신용도.FillWeight = 35F;
            this.신용도.HeaderText = "Rating";
            this.신용도.Name = "신용도";
            this.신용도.ReadOnly = true;
            // 
            // 이름
            // 
            this.이름.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.이름.FillWeight = 50F;
            this.이름.HeaderText = "Name";
            this.이름.Name = "이름";
            this.이름.ReadOnly = true;
            // 
            // 룹그
            // 
            this.룹그.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.룹그.FillWeight = 50F;
            this.룹그.HeaderText = "Group";
            this.룹그.Name = "룹그";
            this.룹그.ReadOnly = true;
            // 
            // SearchFriendsText
            // 
            this.SearchFriendsText.Location = new System.Drawing.Point(44, 31);
            this.SearchFriendsText.MaxLength = 15;
            this.SearchFriendsText.Multiline = true;
            this.SearchFriendsText.Name = "SearchFriendsText";
            this.SearchFriendsText.Size = new System.Drawing.Size(184, 33);
            this.SearchFriendsText.TabIndex = 1;
            // 
            // SerchFriendsBtn
            // 
            this.SerchFriendsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.SerchFriendsBtn.FlatAppearance.BorderSize = 0;
            this.SerchFriendsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(129)))));
            this.SerchFriendsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.SerchFriendsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SerchFriendsBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SerchFriendsBtn.ForeColor = System.Drawing.Color.White;
            this.SerchFriendsBtn.Location = new System.Drawing.Point(234, 31);
            this.SerchFriendsBtn.Name = "SerchFriendsBtn";
            this.SerchFriendsBtn.Size = new System.Drawing.Size(82, 33);
            this.SerchFriendsBtn.TabIndex = 18;
            this.SerchFriendsBtn.Text = "Search";
            this.SerchFriendsBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SerchFriendsBtn.UseVisualStyleBackColor = false;
            // 
            // AddFriendsBtn
            // 
            this.AddFriendsBtn.FlatAppearance.BorderSize = 0;
            this.AddFriendsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.AddFriendsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.AddFriendsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFriendsBtn.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AddFriendsBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddFriendsBtn.Image")));
            this.AddFriendsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddFriendsBtn.Location = new System.Drawing.Point(401, 0);
            this.AddFriendsBtn.Name = "AddFriendsBtn";
            this.AddFriendsBtn.Size = new System.Drawing.Size(189, 88);
            this.AddFriendsBtn.TabIndex = 19;
            this.AddFriendsBtn.Text = "   Add Friends";
            this.AddFriendsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddFriendsBtn.UseVisualStyleBackColor = true;
            this.AddFriendsBtn.Click += new System.EventHandler(this.AddFriendsBtn_Click);
            // 
            // AddGroupBtn
            // 
            this.AddGroupBtn.FlatAppearance.BorderSize = 0;
            this.AddGroupBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.AddGroupBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.AddGroupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddGroupBtn.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AddGroupBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddGroupBtn.Image")));
            this.AddGroupBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddGroupBtn.Location = new System.Drawing.Point(611, 0);
            this.AddGroupBtn.Name = "AddGroupBtn";
            this.AddGroupBtn.Size = new System.Drawing.Size(189, 88);
            this.AddGroupBtn.TabIndex = 19;
            this.AddGroupBtn.Text = "   Add Group";
            this.AddGroupBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddGroupBtn.UseVisualStyleBackColor = true;
            this.AddGroupBtn.Click += new System.EventHandler(this.AddGroupBtn_Click);
            // 
            // FriendsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(926, 585);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FriendsForm";
            this.Text = "FriendsForm";
            this.Load += new System.EventHandler(this.FriendsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FriendsData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView FriendsData;
        private System.Windows.Forms.DataGridViewTextBoxColumn 룹그;
        private System.Windows.Forms.DataGridViewTextBoxColumn 이름;
        private System.Windows.Forms.DataGridViewTextBoxColumn 신용도;
        private System.Windows.Forms.DataGridViewTextBoxColumn 이메일;
        private System.Windows.Forms.TextBox SearchFriendsText;
        private System.Windows.Forms.Button SerchFriendsBtn;
        private System.Windows.Forms.Button AddFriendsBtn;
        private System.Windows.Forms.Button AddGroupBtn;
    }
}