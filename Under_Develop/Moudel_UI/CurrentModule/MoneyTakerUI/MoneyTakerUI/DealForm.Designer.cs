namespace MoneyTakerUI
{
    partial class DealForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DealForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BorrowPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BorrowMondyBtn = new System.Windows.Forms.Button();
            this.LendMoneyBtn = new System.Windows.Forms.Button();
            this.DealListBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BorrowName = new System.Windows.Forms.TextBox();
            this.BorrowHowMuch = new System.Windows.Forms.TextBox();
            this.BorrowDate = new System.Windows.Forms.DateTimePicker();
            this.BorrowBtn = new System.Windows.Forms.Button();
            this.LendMoneyPanel = new System.Windows.Forms.Panel();
            this.LendBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LendHowMuch = new System.Windows.Forms.TextBox();
            this.LendName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DealListPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DealListData = new System.Windows.Forms.DataGridView();
            this.룹그 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.이름 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.신용도 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.LendMoneyPanel.SuspendLayout();
            this.DealListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DealListData)).BeginInit();
            this.SuspendLayout();
            // 
            // BorrowPanel
            // 
            this.BorrowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.BorrowPanel.Controls.Add(this.LendMoneyPanel);
            this.BorrowPanel.Controls.Add(this.BorrowBtn);
            this.BorrowPanel.Controls.Add(this.BorrowDate);
            this.BorrowPanel.Controls.Add(this.BorrowHowMuch);
            this.BorrowPanel.Controls.Add(this.BorrowName);
            this.BorrowPanel.Controls.Add(this.label5);
            this.BorrowPanel.Controls.Add(this.label3);
            this.BorrowPanel.Controls.Add(this.label2);
            this.BorrowPanel.Controls.Add(this.label1);
            this.BorrowPanel.Controls.Add(this.label4);
            this.BorrowPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BorrowPanel.Location = new System.Drawing.Point(0, 87);
            this.BorrowPanel.Name = "BorrowPanel";
            this.BorrowPanel.Size = new System.Drawing.Size(926, 498);
            this.BorrowPanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel2.Controls.Add(this.DealListBtn);
            this.panel2.Controls.Add(this.LendMoneyBtn);
            this.panel2.Controls.Add(this.BorrowMondyBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(926, 87);
            this.panel2.TabIndex = 1;
            // 
            // BorrowMondyBtn
            // 
            this.BorrowMondyBtn.FlatAppearance.BorderSize = 0;
            this.BorrowMondyBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(230)))));
            this.BorrowMondyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.BorrowMondyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrowMondyBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BorrowMondyBtn.Image = ((System.Drawing.Image)(resources.GetObject("BorrowMondyBtn.Image")));
            this.BorrowMondyBtn.Location = new System.Drawing.Point(66, 4);
            this.BorrowMondyBtn.Name = "BorrowMondyBtn";
            this.BorrowMondyBtn.Size = new System.Drawing.Size(260, 78);
            this.BorrowMondyBtn.TabIndex = 0;
            this.BorrowMondyBtn.Text = "Borrow Money";
            this.BorrowMondyBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BorrowMondyBtn.UseVisualStyleBackColor = true;
            this.BorrowMondyBtn.Click += new System.EventHandler(this.BorrowMondyBtn_Click);
            // 
            // LendMoneyBtn
            // 
            this.LendMoneyBtn.FlatAppearance.BorderSize = 0;
            this.LendMoneyBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(230)))));
            this.LendMoneyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.LendMoneyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LendMoneyBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LendMoneyBtn.Image = ((System.Drawing.Image)(resources.GetObject("LendMoneyBtn.Image")));
            this.LendMoneyBtn.Location = new System.Drawing.Point(332, 4);
            this.LendMoneyBtn.Name = "LendMoneyBtn";
            this.LendMoneyBtn.Size = new System.Drawing.Size(260, 78);
            this.LendMoneyBtn.TabIndex = 0;
            this.LendMoneyBtn.Text = "Lend Money";
            this.LendMoneyBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LendMoneyBtn.UseVisualStyleBackColor = true;
            this.LendMoneyBtn.Click += new System.EventHandler(this.LendMoneyBtn_Click);
            // 
            // DealListBtn
            // 
            this.DealListBtn.FlatAppearance.BorderSize = 0;
            this.DealListBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(230)))));
            this.DealListBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.DealListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DealListBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DealListBtn.Image = ((System.Drawing.Image)(resources.GetObject("DealListBtn.Image")));
            this.DealListBtn.Location = new System.Drawing.Point(598, 4);
            this.DealListBtn.Name = "DealListBtn";
            this.DealListBtn.Size = new System.Drawing.Size(260, 78);
            this.DealListBtn.TabIndex = 0;
            this.DealListBtn.Text = "Deal List";
            this.DealListBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DealListBtn.UseVisualStyleBackColor = true;
            this.DealListBtn.Click += new System.EventHandler(this.DealListBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.label4.Location = new System.Drawing.Point(83, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 41);
            this.label4.TabIndex = 3;
            this.label4.Text = "Borrow Money";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(86, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(779, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "                                                                                 " +
    "                             ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.label2.Location = new System.Drawing.Point(281, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.label3.Location = new System.Drawing.Point(230, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "How much? : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.label5.Location = new System.Drawing.Point(191, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Repayment date : ";
            // 
            // BorrowName
            // 
            this.BorrowName.Location = new System.Drawing.Point(370, 151);
            this.BorrowName.Multiline = true;
            this.BorrowName.Name = "BorrowName";
            this.BorrowName.Size = new System.Drawing.Size(222, 25);
            this.BorrowName.TabIndex = 6;
            // 
            // BorrowHowMuch
            // 
            this.BorrowHowMuch.Location = new System.Drawing.Point(369, 204);
            this.BorrowHowMuch.Multiline = true;
            this.BorrowHowMuch.Name = "BorrowHowMuch";
            this.BorrowHowMuch.Size = new System.Drawing.Size(222, 25);
            this.BorrowHowMuch.TabIndex = 6;
            // 
            // BorrowDate
            // 
            this.BorrowDate.Location = new System.Drawing.Point(370, 257);
            this.BorrowDate.Name = "BorrowDate";
            this.BorrowDate.Size = new System.Drawing.Size(222, 25);
            this.BorrowDate.TabIndex = 7;
            // 
            // BorrowBtn
            // 
            this.BorrowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.BorrowBtn.FlatAppearance.BorderSize = 0;
            this.BorrowBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(129)))));
            this.BorrowBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.BorrowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrowBtn.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BorrowBtn.ForeColor = System.Drawing.Color.White;
            this.BorrowBtn.Location = new System.Drawing.Point(369, 332);
            this.BorrowBtn.Name = "BorrowBtn";
            this.BorrowBtn.Size = new System.Drawing.Size(223, 45);
            this.BorrowBtn.TabIndex = 8;
            this.BorrowBtn.Text = "Borrow";
            this.BorrowBtn.UseVisualStyleBackColor = false;
            this.BorrowBtn.Click += new System.EventHandler(this.BorrowBtn_Click);
            // 
            // LendMoneyPanel
            // 
            this.LendMoneyPanel.Controls.Add(this.DealListPanel);
            this.LendMoneyPanel.Controls.Add(this.panel1);
            this.LendMoneyPanel.Controls.Add(this.LendBtn);
            this.LendMoneyPanel.Controls.Add(this.dateTimePicker1);
            this.LendMoneyPanel.Controls.Add(this.LendHowMuch);
            this.LendMoneyPanel.Controls.Add(this.LendName);
            this.LendMoneyPanel.Controls.Add(this.label6);
            this.LendMoneyPanel.Controls.Add(this.label7);
            this.LendMoneyPanel.Controls.Add(this.label8);
            this.LendMoneyPanel.Controls.Add(this.label9);
            this.LendMoneyPanel.Controls.Add(this.label10);
            this.LendMoneyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LendMoneyPanel.Location = new System.Drawing.Point(0, 0);
            this.LendMoneyPanel.Name = "LendMoneyPanel";
            this.LendMoneyPanel.Size = new System.Drawing.Size(926, 498);
            this.LendMoneyPanel.TabIndex = 9;
            this.LendMoneyPanel.Visible = false;
            // 
            // LendBtn
            // 
            this.LendBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.LendBtn.FlatAppearance.BorderSize = 0;
            this.LendBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(129)))));
            this.LendBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.LendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LendBtn.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LendBtn.ForeColor = System.Drawing.Color.White;
            this.LendBtn.Location = new System.Drawing.Point(369, 332);
            this.LendBtn.Name = "LendBtn";
            this.LendBtn.Size = new System.Drawing.Size(223, 45);
            this.LendBtn.TabIndex = 17;
            this.LendBtn.Text = "Lend";
            this.LendBtn.UseVisualStyleBackColor = false;
            this.LendBtn.Click += new System.EventHandler(this.LendBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(370, 257);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(222, 25);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // LendHowMuch
            // 
            this.LendHowMuch.Location = new System.Drawing.Point(369, 204);
            this.LendHowMuch.Multiline = true;
            this.LendHowMuch.Name = "LendHowMuch";
            this.LendHowMuch.Size = new System.Drawing.Size(222, 25);
            this.LendHowMuch.TabIndex = 14;
            // 
            // LendName
            // 
            this.LendName.Location = new System.Drawing.Point(370, 151);
            this.LendName.Multiline = true;
            this.LendName.Name = "LendName";
            this.LendName.Size = new System.Drawing.Size(222, 25);
            this.LendName.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.label6.Location = new System.Drawing.Point(191, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Repayment date : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.label7.Location = new System.Drawing.Point(230, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "How much? : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.label8.Location = new System.Drawing.Point(281, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Name : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.label9.Location = new System.Drawing.Point(86, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(779, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "                                                                                 " +
    "                             ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.label10.Location = new System.Drawing.Point(83, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 41);
            this.label10.TabIndex = 9;
            this.label10.Text = "Lend Money";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(598, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 18;
            // 
            // DealListPanel
            // 
            this.DealListPanel.Controls.Add(this.DealListData);
            this.DealListPanel.Controls.Add(this.label11);
            this.DealListPanel.Controls.Add(this.label12);
            this.DealListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DealListPanel.Location = new System.Drawing.Point(0, 0);
            this.DealListPanel.Name = "DealListPanel";
            this.DealListPanel.Size = new System.Drawing.Size(926, 498);
            this.DealListPanel.TabIndex = 19;
            this.DealListPanel.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.label11.Location = new System.Drawing.Point(86, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(779, 19);
            this.label11.TabIndex = 12;
            this.label11.Text = "                                                                                 " +
    "                             ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.label12.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.label12.Location = new System.Drawing.Point(83, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 41);
            this.label12.TabIndex = 11;
            this.label12.Text = "Deal List";
            // 
            // DealListData
            // 
            this.DealListData.AllowUserToAddRows = false;
            this.DealListData.AllowUserToDeleteRows = false;
            this.DealListData.AllowUserToResizeColumns = false;
            this.DealListData.AllowUserToResizeRows = false;
            this.DealListData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DealListData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.DealListData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DealListData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DealListData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DealListData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DealListData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.룹그,
            this.이름,
            this.Money,
            this.relation,
            this.신용도,
            this.Dday});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DealListData.DefaultCellStyle = dataGridViewCellStyle6;
            this.DealListData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.DealListData.Location = new System.Drawing.Point(90, 103);
            this.DealListData.Name = "DealListData";
            this.DealListData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DealListData.RowHeadersVisible = false;
            this.DealListData.RowTemplate.Height = 35;
            this.DealListData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DealListData.Size = new System.Drawing.Size(794, 352);
            this.DealListData.TabIndex = 13;
            // 
            // 룹그
            // 
            this.룹그.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.룹그.FillWeight = 50F;
            this.룹그.HeaderText = "Group";
            this.룹그.Name = "룹그";
            this.룹그.ReadOnly = true;
            // 
            // 이름
            // 
            this.이름.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.이름.FillWeight = 50F;
            this.이름.HeaderText = "Name";
            this.이름.Name = "이름";
            this.이름.ReadOnly = true;
            // 
            // Money
            // 
            this.Money.FillWeight = 50F;
            this.Money.HeaderText = "Money";
            this.Money.Name = "Money";
            // 
            // relation
            // 
            this.relation.FillWeight = 50F;
            this.relation.HeaderText = "relation";
            this.relation.Name = "relation";
            // 
            // 신용도
            // 
            this.신용도.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.신용도.FillWeight = 35F;
            this.신용도.HeaderText = "Rating";
            this.신용도.Name = "신용도";
            this.신용도.ReadOnly = true;
            // 
            // Dday
            // 
            this.Dday.FillWeight = 50F;
            this.Dday.HeaderText = "Dday";
            this.Dday.Name = "Dday";
            // 
            // DealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 585);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BorrowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DealForm";
            this.Text = "DealForm";
            this.Load += new System.EventHandler(this.DealForm_Load);
            this.BorrowPanel.ResumeLayout(false);
            this.BorrowPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.LendMoneyPanel.ResumeLayout(false);
            this.LendMoneyPanel.PerformLayout();
            this.DealListPanel.ResumeLayout(false);
            this.DealListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DealListData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BorrowMondyBtn;
        private System.Windows.Forms.Button DealListBtn;
        private System.Windows.Forms.Button LendMoneyBtn;
        private System.Windows.Forms.DateTimePicker BorrowDate;
        private System.Windows.Forms.TextBox BorrowHowMuch;
        private System.Windows.Forms.TextBox BorrowName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BorrowBtn;
        private System.Windows.Forms.Panel LendMoneyPanel;
        private System.Windows.Forms.Button LendBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox LendHowMuch;
        private System.Windows.Forms.TextBox LendName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel DealListPanel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DealListData;
        private System.Windows.Forms.DataGridViewTextBoxColumn 룹그;
        private System.Windows.Forms.DataGridViewTextBoxColumn 이름;
        private System.Windows.Forms.DataGridViewTextBoxColumn Money;
        private System.Windows.Forms.DataGridViewTextBoxColumn relation;
        private System.Windows.Forms.DataGridViewTextBoxColumn 신용도;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dday;
        public System.Windows.Forms.Panel BorrowPanel;
    }
}