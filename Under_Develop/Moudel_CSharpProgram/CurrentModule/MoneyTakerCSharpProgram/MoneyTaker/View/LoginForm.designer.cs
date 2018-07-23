namespace MoneyTaker
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.TopBar = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.MainLogo = new System.Windows.Forms.PictureBox();
            this.SPUserIDLabel = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SPPassWordLabel = new System.Windows.Forms.Label();
            this.PassWordText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StartPanel = new System.Windows.Forms.Panel();
            this.JoinUsPanel = new System.Windows.Forms.Panel();
            this.JSPrevLabel = new System.Windows.Forms.LinkLabel();
            this.JoinUsSignUpBtn = new System.Windows.Forms.Button();
            this.JoinUsPhoneNumber = new System.Windows.Forms.TextBox();
            this.JSPhoneNumberLabel = new System.Windows.Forms.Label();
            this.JoinUsEmail = new System.Windows.Forms.TextBox();
            this.JSEmailLabel = new System.Windows.Forms.Label();
            this.JoinUsPassWord = new System.Windows.Forms.TextBox();
            this.JoinUsREPassWord = new System.Windows.Forms.TextBox();
            this.JSPassWordLabel = new System.Windows.Forms.Label();
            this.JSREPassWordLabel = new System.Windows.Forms.Label();
            this.JoinUsName = new System.Windows.Forms.TextBox();
            this.JUUserNameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainLogo)).BeginInit();
            this.RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.StartPanel.SuspendLayout();
            this.JoinUsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.ExitBtn.Location = new System.Drawing.Point(1170, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(30, 30);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MainLogo
            // 
            this.MainLogo.Image = ((System.Drawing.Image)(resources.GetObject("MainLogo.Image")));
            this.MainLogo.Location = new System.Drawing.Point(50, 57);
            this.MainLogo.Name = "MainLogo";
            this.MainLogo.Size = new System.Drawing.Size(500, 100);
            this.MainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainLogo.TabIndex = 1;
            this.MainLogo.TabStop = false;
            // 
            // SPUserIDLabel
            // 
            this.SPUserIDLabel.AutoSize = true;
            this.SPUserIDLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SPUserIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(56)))), ((int)(((byte)(132)))));
            this.SPUserIDLabel.Location = new System.Drawing.Point(143, 214);
            this.SPUserIDLabel.Name = "SPUserIDLabel";
            this.SPUserIDLabel.Size = new System.Drawing.Size(132, 28);
            this.SPUserIDLabel.TabIndex = 3;
            this.SPUserIDLabel.Text = "User Name : ";
            // 
            // NameText
            // 
            this.NameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameText.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NameText.Location = new System.Drawing.Point(148, 245);
            this.NameText.Multiline = true;
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(206, 31);
            this.NameText.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.linkLabel1.Location = new System.Drawing.Point(348, 406);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(78, 23);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "회원가입";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // SPPassWordLabel
            // 
            this.SPPassWordLabel.AutoSize = true;
            this.SPPassWordLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SPPassWordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(56)))), ((int)(((byte)(132)))));
            this.SPPassWordLabel.Location = new System.Drawing.Point(143, 305);
            this.SPPassWordLabel.Name = "SPPassWordLabel";
            this.SPPassWordLabel.Size = new System.Drawing.Size(112, 28);
            this.SPPassWordLabel.TabIndex = 3;
            this.SPPassWordLabel.Text = "PassWord :";
            // 
            // PassWordText
            // 
            this.PassWordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassWordText.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PassWordText.Location = new System.Drawing.Point(148, 336);
            this.PassWordText.Multiline = true;
            this.PassWordText.Name = "PassWordText";
            this.PassWordText.PasswordChar = '*';
            this.PassWordText.Size = new System.Drawing.Size(206, 31);
            this.PassWordText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(56)))), ((int)(((byte)(132)))));
            this.label1.Location = new System.Drawing.Point(144, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "아직 회원이 아니신가요?";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.linkLabel2.Location = new System.Drawing.Point(402, 463);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(78, 23);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "찾아보기";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(210)))));
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(232)))));
            this.LoginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(210)))));
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LoginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(56)))), ((int)(((byte)(132)))));
            this.LoginBtn.Location = new System.Drawing.Point(360, 245);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(120, 120);
            this.LoginBtn.TabIndex = 8;
            this.LoginBtn.Text = "Join";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.RightPanel.Controls.Add(this.label2);
            this.RightPanel.Controls.Add(this.pictureBox1);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(600, 30);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(600, 670);
            this.RightPanel.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(56)))), ((int)(((byte)(132)))));
            this.label2.Location = new System.Drawing.Point(55, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(490, 96);
            this.label2.TabIndex = 1;
            this.label2.Text = "돈을 빌려주고부터 을의 입장이 되셨습니까?\r\n\r\n               지금 바로 시작하세요!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(155, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // StartPanel
            // 
            this.StartPanel.Controls.Add(this.JoinUsPanel);
            this.StartPanel.Controls.Add(this.MainLogo);
            this.StartPanel.Controls.Add(this.LoginBtn);
            this.StartPanel.Controls.Add(this.PassWordText);
            this.StartPanel.Controls.Add(this.SPPassWordLabel);
            this.StartPanel.Controls.Add(this.linkLabel2);
            this.StartPanel.Controls.Add(this.NameText);
            this.StartPanel.Controls.Add(this.label3);
            this.StartPanel.Controls.Add(this.label1);
            this.StartPanel.Controls.Add(this.linkLabel1);
            this.StartPanel.Controls.Add(this.SPUserIDLabel);
            this.StartPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.StartPanel.Location = new System.Drawing.Point(0, 30);
            this.StartPanel.Name = "StartPanel";
            this.StartPanel.Size = new System.Drawing.Size(600, 670);
            this.StartPanel.TabIndex = 10;
            // 
            // JoinUsPanel
            // 
            this.JoinUsPanel.Controls.Add(this.JSPrevLabel);
            this.JoinUsPanel.Controls.Add(this.JoinUsSignUpBtn);
            this.JoinUsPanel.Controls.Add(this.JoinUsPhoneNumber);
            this.JoinUsPanel.Controls.Add(this.JSPhoneNumberLabel);
            this.JoinUsPanel.Controls.Add(this.JoinUsEmail);
            this.JoinUsPanel.Controls.Add(this.JSEmailLabel);
            this.JoinUsPanel.Controls.Add(this.JoinUsPassWord);
            this.JoinUsPanel.Controls.Add(this.JoinUsREPassWord);
            this.JoinUsPanel.Controls.Add(this.JSPassWordLabel);
            this.JoinUsPanel.Controls.Add(this.JSREPassWordLabel);
            this.JoinUsPanel.Controls.Add(this.JoinUsName);
            this.JoinUsPanel.Controls.Add(this.JUUserNameLabel);
            this.JoinUsPanel.Controls.Add(this.label4);
            this.JoinUsPanel.Controls.Add(this.pictureBox2);
            this.JoinUsPanel.Controls.Add(this.pictureBox3);
            this.JoinUsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.JoinUsPanel.Location = new System.Drawing.Point(0, 0);
            this.JoinUsPanel.Name = "JoinUsPanel";
            this.JoinUsPanel.Size = new System.Drawing.Size(600, 670);
            this.JoinUsPanel.TabIndex = 9;
            this.JoinUsPanel.Visible = false;
            // 
            // JSPrevLabel
            // 
            this.JSPrevLabel.AutoSize = true;
            this.JSPrevLabel.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.JSPrevLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.JSPrevLabel.Location = new System.Drawing.Point(3, 3);
            this.JSPrevLabel.Name = "JSPrevLabel";
            this.JSPrevLabel.Size = new System.Drawing.Size(79, 32);
            this.JSPrevLabel.TabIndex = 4;
            this.JSPrevLabel.TabStop = true;
            this.JSPrevLabel.Text = "<Prev";
            this.JSPrevLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.JSPrevLabel_LinkClicked);
            // 
            // JoinUsSignUpBtn
            // 
            this.JoinUsSignUpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.JoinUsSignUpBtn.FlatAppearance.BorderSize = 0;
            this.JoinUsSignUpBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(129)))));
            this.JoinUsSignUpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.JoinUsSignUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JoinUsSignUpBtn.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.JoinUsSignUpBtn.ForeColor = System.Drawing.Color.White;
            this.JoinUsSignUpBtn.Location = new System.Drawing.Point(150, 599);
            this.JoinUsSignUpBtn.Name = "JoinUsSignUpBtn";
            this.JoinUsSignUpBtn.Size = new System.Drawing.Size(298, 45);
            this.JoinUsSignUpBtn.TabIndex = 3;
            this.JoinUsSignUpBtn.Text = "Sign Up";
            this.JoinUsSignUpBtn.UseVisualStyleBackColor = false;
            this.JoinUsSignUpBtn.Click += new System.EventHandler(this.JoinUsSignUpBtn_Click);
            // 
            // JoinUsPhoneNumber
            // 
            this.JoinUsPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JoinUsPhoneNumber.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.JoinUsPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.JoinUsPhoneNumber.Location = new System.Drawing.Point(148, 545);
            this.JoinUsPhoneNumber.MaxLength = 20;
            this.JoinUsPhoneNumber.Name = "JoinUsPhoneNumber";
            this.JoinUsPhoneNumber.Size = new System.Drawing.Size(300, 23);
            this.JoinUsPhoneNumber.TabIndex = 1;
            // 
            // JSPhoneNumberLabel
            // 
            this.JSPhoneNumberLabel.AutoSize = true;
            this.JSPhoneNumberLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.JSPhoneNumberLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.JSPhoneNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.JSPhoneNumberLabel.Location = new System.Drawing.Point(143, 514);
            this.JSPhoneNumberLabel.Name = "JSPhoneNumberLabel";
            this.JSPhoneNumberLabel.Size = new System.Drawing.Size(163, 28);
            this.JSPhoneNumberLabel.TabIndex = 2;
            this.JSPhoneNumberLabel.Text = "PhoneNumber : ";
            // 
            // JoinUsEmail
            // 
            this.JoinUsEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JoinUsEmail.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.JoinUsEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.JoinUsEmail.Location = new System.Drawing.Point(148, 475);
            this.JoinUsEmail.MaxLength = 20;
            this.JoinUsEmail.Name = "JoinUsEmail";
            this.JoinUsEmail.Size = new System.Drawing.Size(300, 23);
            this.JoinUsEmail.TabIndex = 1;
            // 
            // JSEmailLabel
            // 
            this.JSEmailLabel.AutoSize = true;
            this.JSEmailLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.JSEmailLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.JSEmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.JSEmailLabel.Location = new System.Drawing.Point(143, 444);
            this.JSEmailLabel.Name = "JSEmailLabel";
            this.JSEmailLabel.Size = new System.Drawing.Size(86, 28);
            this.JSEmailLabel.TabIndex = 2;
            this.JSEmailLabel.Text = "E-mail : ";
            // 
            // JoinUsPassWord
            // 
            this.JoinUsPassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JoinUsPassWord.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.JoinUsPassWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.JoinUsPassWord.Location = new System.Drawing.Point(148, 335);
            this.JoinUsPassWord.MaxLength = 20;
            this.JoinUsPassWord.Name = "JoinUsPassWord";
            this.JoinUsPassWord.PasswordChar = '*';
            this.JoinUsPassWord.Size = new System.Drawing.Size(300, 23);
            this.JoinUsPassWord.TabIndex = 1;
            // 
            // JoinUsREPassWord
            // 
            this.JoinUsREPassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JoinUsREPassWord.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.JoinUsREPassWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.JoinUsREPassWord.Location = new System.Drawing.Point(148, 405);
            this.JoinUsREPassWord.MaxLength = 20;
            this.JoinUsREPassWord.Name = "JoinUsREPassWord";
            this.JoinUsREPassWord.PasswordChar = '*';
            this.JoinUsREPassWord.Size = new System.Drawing.Size(300, 23);
            this.JoinUsREPassWord.TabIndex = 1;
            // 
            // JSPassWordLabel
            // 
            this.JSPassWordLabel.AutoSize = true;
            this.JSPassWordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.JSPassWordLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.JSPassWordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.JSPassWordLabel.Location = new System.Drawing.Point(143, 304);
            this.JSPassWordLabel.Name = "JSPassWordLabel";
            this.JSPassWordLabel.Size = new System.Drawing.Size(119, 28);
            this.JSPassWordLabel.TabIndex = 2;
            this.JSPassWordLabel.Text = "PassWord : ";
            // 
            // JSREPassWordLabel
            // 
            this.JSREPassWordLabel.AutoSize = true;
            this.JSREPassWordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.JSREPassWordLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.JSREPassWordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.JSREPassWordLabel.Location = new System.Drawing.Point(143, 374);
            this.JSREPassWordLabel.Name = "JSREPassWordLabel";
            this.JSREPassWordLabel.Size = new System.Drawing.Size(204, 28);
            this.JSREPassWordLabel.TabIndex = 2;
            this.JSREPassWordLabel.Text = "Re-Enter PassWord : ";
            // 
            // JoinUsName
            // 
            this.JoinUsName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JoinUsName.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.JoinUsName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.JoinUsName.Location = new System.Drawing.Point(150, 265);
            this.JoinUsName.MaxLength = 20;
            this.JoinUsName.Name = "JoinUsName";
            this.JoinUsName.Size = new System.Drawing.Size(300, 23);
            this.JoinUsName.TabIndex = 1;
            // 
            // JUUserNameLabel
            // 
            this.JUUserNameLabel.AutoSize = true;
            this.JUUserNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.JUUserNameLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.JUUserNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.JUUserNameLabel.Location = new System.Drawing.Point(145, 234);
            this.JUUserNameLabel.Name = "JUUserNameLabel";
            this.JUUserNameLabel.Size = new System.Drawing.Size(132, 28);
            this.JUUserNameLabel.TabIndex = 2;
            this.JUUserNameLabel.Text = "User Name : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(94)))), ((int)(((byte)(98)))));
            this.label4.Location = new System.Drawing.Point(183, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Create your Account!";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(150, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 135);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox3.Location = new System.Drawing.Point(0, 96);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(600, 574);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(56)))), ((int)(((byte)(132)))));
            this.label3.Location = new System.Drawing.Point(144, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "아이디/비밀번호를 잊으셨나요?";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.StartPanel);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainLogo)).EndInit();
            this.RightPanel.ResumeLayout(false);
            this.RightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.StartPanel.ResumeLayout(false);
            this.StartPanel.PerformLayout();
            this.JoinUsPanel.ResumeLayout(false);
            this.JoinUsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.PictureBox MainLogo;
        private System.Windows.Forms.Label SPUserIDLabel;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label SPPassWordLabel;
        private System.Windows.Forms.TextBox PassWordText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel StartPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel JoinUsPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox JoinUsName;
        private System.Windows.Forms.Label JUUserNameLabel;
        private System.Windows.Forms.TextBox JoinUsEmail;
        private System.Windows.Forms.Label JSEmailLabel;
        private System.Windows.Forms.TextBox JoinUsPassWord;
        private System.Windows.Forms.TextBox JoinUsREPassWord;
        private System.Windows.Forms.Label JSPassWordLabel;
        private System.Windows.Forms.Label JSREPassWordLabel;
        private System.Windows.Forms.TextBox JoinUsPhoneNumber;
        private System.Windows.Forms.Label JSPhoneNumberLabel;
        private System.Windows.Forms.Button JoinUsSignUpBtn;
        private System.Windows.Forms.LinkLabel JSPrevLabel;
    }
}

