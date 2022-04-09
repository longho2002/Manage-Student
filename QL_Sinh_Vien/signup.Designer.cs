namespace QL_Sinh_Vien
{
    partial class signup
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
            this.lb_signup = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.lb_Password = new System.Windows.Forms.Label();
            this.lb_Username = new System.Windows.Forms.Label();
            this.tb_passwordConfirm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Singup = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lb_checkUsername = new System.Windows.Forms.Label();
            this.lb_checkPassword = new System.Windows.Forms.Label();
            this.lb_CheckPassConfirm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_signup
            // 
            this.lb_signup.AutoSize = true;
            this.lb_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_signup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_signup.Location = new System.Drawing.Point(237, 73);
            this.lb_signup.Name = "lb_signup";
            this.lb_signup.Size = new System.Drawing.Size(242, 69);
            this.lb_signup.TabIndex = 0;
            this.lb_signup.Text = "Sign Up";
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(358, 228);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(251, 34);
            this.tb_Password.TabIndex = 5;
            this.tb_Password.UseSystemPasswordChar = true;
            this.tb_Password.Leave += new System.EventHandler(this.tb_Password_Leave);
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(358, 175);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(251, 34);
            this.tb_Username.TabIndex = 4;
            this.tb_Username.Leave += new System.EventHandler(this.tb_Username_Leave);
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Password.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_Password.Location = new System.Drawing.Point(136, 228);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(126, 29);
            this.lb_Password.TabIndex = 6;
            this.lb_Password.Text = "Password:";
            // 
            // lb_Username
            // 
            this.lb_Username.AutoSize = true;
            this.lb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Username.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_Username.Location = new System.Drawing.Point(132, 180);
            this.lb_Username.Name = "lb_Username";
            this.lb_Username.Size = new System.Drawing.Size(130, 29);
            this.lb_Username.TabIndex = 3;
            this.lb_Username.Text = "Username:";
            // 
            // tb_passwordConfirm
            // 
            this.tb_passwordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_passwordConfirm.Location = new System.Drawing.Point(358, 281);
            this.tb_passwordConfirm.Name = "tb_passwordConfirm";
            this.tb_passwordConfirm.Size = new System.Drawing.Size(251, 34);
            this.tb_passwordConfirm.TabIndex = 7;
            this.tb_passwordConfirm.UseSystemPasswordChar = true;
            this.tb_passwordConfirm.Leave += new System.EventHandler(this.tb_passwordConfirm_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(132, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Password Confirm:";
            // 
            // btn_Singup
            // 
            this.btn_Singup.BackColor = System.Drawing.Color.Lime;
            this.btn_Singup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Singup.Location = new System.Drawing.Point(386, 334);
            this.btn_Singup.Name = "btn_Singup";
            this.btn_Singup.Size = new System.Drawing.Size(223, 53);
            this.btn_Singup.TabIndex = 9;
            this.btn_Singup.Text = "Sign Up";
            this.btn_Singup.UseVisualStyleBackColor = false;
            this.btn_Singup.Click += new System.EventHandler(this.btn_Singup_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Crimson;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cancel.Location = new System.Drawing.Point(137, 334);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(231, 53);
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lb_checkUsername
            // 
            this.lb_checkUsername.AutoSize = true;
            this.lb_checkUsername.Font = new System.Drawing.Font("Microsoft New Tai Lue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_checkUsername.ForeColor = System.Drawing.Color.White;
            this.lb_checkUsername.Location = new System.Drawing.Point(628, 192);
            this.lb_checkUsername.Name = "lb_checkUsername";
            this.lb_checkUsername.Size = new System.Drawing.Size(43, 17);
            this.lb_checkUsername.TabIndex = 11;
            this.lb_checkUsername.Text = "label2";
            this.lb_checkUsername.Visible = false;
            // 
            // lb_checkPassword
            // 
            this.lb_checkPassword.AutoSize = true;
            this.lb_checkPassword.Font = new System.Drawing.Font("Microsoft New Tai Lue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_checkPassword.ForeColor = System.Drawing.Color.White;
            this.lb_checkPassword.Location = new System.Drawing.Point(628, 245);
            this.lb_checkPassword.Name = "lb_checkPassword";
            this.lb_checkPassword.Size = new System.Drawing.Size(43, 17);
            this.lb_checkPassword.TabIndex = 12;
            this.lb_checkPassword.Text = "label3";
            this.lb_checkPassword.Visible = false;
            // 
            // lb_CheckPassConfirm
            // 
            this.lb_CheckPassConfirm.AutoSize = true;
            this.lb_CheckPassConfirm.Font = new System.Drawing.Font("Microsoft New Tai Lue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CheckPassConfirm.ForeColor = System.Drawing.Color.White;
            this.lb_CheckPassConfirm.Location = new System.Drawing.Point(628, 298);
            this.lb_CheckPassConfirm.Name = "lb_CheckPassConfirm";
            this.lb_CheckPassConfirm.Size = new System.Drawing.Size(43, 17);
            this.lb_CheckPassConfirm.TabIndex = 13;
            this.lb_CheckPassConfirm.Text = "label4";
            this.lb_CheckPassConfirm.Visible = false;
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1074, 480);
            this.Controls.Add(this.lb_CheckPassConfirm);
            this.Controls.Add(this.lb_checkPassword);
            this.Controls.Add(this.lb_checkUsername);
            this.Controls.Add(this.btn_Singup);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.tb_passwordConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_Username);
            this.Controls.Add(this.lb_signup);
            this.Name = "signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_signup;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.Label lb_Username;
        private System.Windows.Forms.TextBox tb_passwordConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Singup;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lb_checkUsername;
        private System.Windows.Forms.Label lb_checkPassword;
        private System.Windows.Forms.Label lb_CheckPassConfirm;
    }
}