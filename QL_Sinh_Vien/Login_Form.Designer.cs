namespace QL_Sinh_Vien
{
    partial class Login_Form
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
            this.components = new System.ComponentModel.Container();
            this.lb_Username = new System.Windows.Forms.Label();
            this.lb_Login = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip_Username = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_Pass = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.rBtn_std = new System.Windows.Forms.RadioButton();
            this.rBtn_hr = new System.Windows.Forms.RadioButton();
            this.picBox_Login = new System.Windows.Forms.PictureBox();
            this.lb_forgotpass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Username
            // 
            this.lb_Username.AutoSize = true;
            this.lb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Username.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_Username.Location = new System.Drawing.Point(11, 220);
            this.lb_Username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Username.Name = "lb_Username";
            this.lb_Username.Size = new System.Drawing.Size(102, 24);
            this.lb_Username.TabIndex = 0;
            this.lb_Username.Text = "Username:";
            // 
            // lb_Login
            // 
            this.lb_Login.AutoSize = true;
            this.lb_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Login.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_Login.Location = new System.Drawing.Point(111, 160);
            this.lb_Login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Login.Name = "lb_Login";
            this.lb_Login.Size = new System.Drawing.Size(199, 31);
            this.lb_Login.TabIndex = 1;
            this.lb_Login.Text = "Account Login";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Password.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_Password.Location = new System.Drawing.Point(11, 271);
            this.lb_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(97, 24);
            this.lb_Password.TabIndex = 2;
            this.lb_Password.Text = "Password:";
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(117, 216);
            this.tb_Username.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(255, 28);
            this.tb_Username.TabIndex = 1;
            this.toolTip_Username.SetToolTip(this.tb_Username, "Nhap ky tu");
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(117, 268);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(255, 28);
            this.tb_Password.TabIndex = 2;
            this.toolTip_Pass.SetToolTip(this.tb_Password, "Nhap Pass");
            this.tb_Password.UseSystemPasswordChar = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Crimson;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cancel.Location = new System.Drawing.Point(11, 351);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(167, 43);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Lime;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(201, 351);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(167, 43);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(8, 433);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "New user?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // toolTip_Username
            // 
            this.toolTip_Username.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // toolTip_Pass
            // 
            this.toolTip_Pass.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(141, 232);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(185, 32);
            this.progressBar1.TabIndex = 11;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // rBtn_std
            // 
            this.rBtn_std.AutoSize = true;
            this.rBtn_std.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rBtn_std.Location = new System.Drawing.Point(12, 405);
            this.rBtn_std.Name = "rBtn_std";
            this.rBtn_std.Size = new System.Drawing.Size(62, 17);
            this.rBtn_std.TabIndex = 12;
            this.rBtn_std.TabStop = true;
            this.rBtn_std.Text = "Student";
            this.rBtn_std.UseVisualStyleBackColor = true;
            // 
            // rBtn_hr
            // 
            this.rBtn_hr.AutoSize = true;
            this.rBtn_hr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rBtn_hr.Location = new System.Drawing.Point(90, 405);
            this.rBtn_hr.Name = "rBtn_hr";
            this.rBtn_hr.Size = new System.Drawing.Size(108, 17);
            this.rBtn_hr.TabIndex = 13;
            this.rBtn_hr.TabStop = true;
            this.rBtn_hr.Text = "Human Resource";
            this.rBtn_hr.UseVisualStyleBackColor = true;
            // 
            // picBox_Login
            // 
            this.picBox_Login.Location = new System.Drawing.Point(141, 30);
            this.picBox_Login.Margin = new System.Windows.Forms.Padding(2);
            this.picBox_Login.Name = "picBox_Login";
            this.picBox_Login.Size = new System.Drawing.Size(136, 114);
            this.picBox_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Login.TabIndex = 7;
            this.picBox_Login.TabStop = false;
            // 
            // lb_forgotpass
            // 
            this.lb_forgotpass.AutoSize = true;
            this.lb_forgotpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_forgotpass.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_forgotpass.Location = new System.Drawing.Point(218, 314);
            this.lb_forgotpass.Name = "lb_forgotpass";
            this.lb_forgotpass.Size = new System.Drawing.Size(154, 20);
            this.lb_forgotpass.TabIndex = 35;
            this.lb_forgotpass.Text = "Forgot Password?";
            this.lb_forgotpass.Click += new System.EventHandler(this.lb_forgotpass_Click);
            // 
            // Login_Form
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(394, 465);
            this.Controls.Add(this.lb_forgotpass);
            this.Controls.Add(this.rBtn_hr);
            this.Controls.Add(this.rBtn_std);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox_Login);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_Login);
            this.Controls.Add(this.lb_Username);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Username;
        private System.Windows.Forms.Label lb_Login;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.PictureBox picBox_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip_Username;
        private System.Windows.Forms.ToolTip toolTip_Pass;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        public System.Windows.Forms.RadioButton rBtn_hr;
        public System.Windows.Forms.RadioButton rBtn_std;
        private System.Windows.Forms.Label lb_forgotpass;
    }
}

