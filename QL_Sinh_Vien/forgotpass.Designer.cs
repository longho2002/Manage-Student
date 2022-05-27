namespace QL_Sinh_Vien
{
    partial class forgotpass
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
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_repass = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_repass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_checkPassword = new System.Windows.Forms.Label();
            this.lb_CheckPassConfirm = new System.Windows.Forms.Label();
            this.btn_valid = new System.Windows.Forms.Button();
            this.lb_Login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(99, 129);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(229, 29);
            this.tb_id.TabIndex = 15;
            // 
            // tb_pass
            // 
            this.tb_pass.Enabled = false;
            this.tb_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pass.Location = new System.Drawing.Point(99, 241);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.Size = new System.Drawing.Size(229, 29);
            this.tb_pass.TabIndex = 16;
            this.tb_pass.Leave += new System.EventHandler(this.tb_pass_Leave);
            // 
            // tb_repass
            // 
            this.tb_repass.Enabled = false;
            this.tb_repass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_repass.Location = new System.Drawing.Point(99, 338);
            this.tb_repass.Name = "tb_repass";
            this.tb_repass.PasswordChar = '*';
            this.tb_repass.Size = new System.Drawing.Size(229, 29);
            this.tb_repass.TabIndex = 17;
            this.tb_repass.Leave += new System.EventHandler(this.tb_repass_Leave);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Lime;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(334, 84);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(126, 29);
            this.btn_Add.TabIndex = 44;
            this.btn_Add.Text = "Send code";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_repass
            // 
            this.btn_repass.BackColor = System.Drawing.Color.Lime;
            this.btn_repass.Enabled = false;
            this.btn_repass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_repass.Location = new System.Drawing.Point(157, 393);
            this.btn_repass.Name = "btn_repass";
            this.btn_repass.Size = new System.Drawing.Size(133, 46);
            this.btn_repass.TabIndex = 45;
            this.btn_repass.Text = "Reset Pass";
            this.btn_repass.UseVisualStyleBackColor = false;
            this.btn_repass.Click += new System.EventHandler(this.btn_repass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Re Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Code";
            // 
            // tb_mail
            // 
            this.tb_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mail.Location = new System.Drawing.Point(99, 84);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(229, 29);
            this.tb_mail.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Email";
            // 
            // lb_checkPassword
            // 
            this.lb_checkPassword.AutoSize = true;
            this.lb_checkPassword.ForeColor = System.Drawing.Color.Red;
            this.lb_checkPassword.Location = new System.Drawing.Point(99, 277);
            this.lb_checkPassword.Name = "lb_checkPassword";
            this.lb_checkPassword.Size = new System.Drawing.Size(35, 13);
            this.lb_checkPassword.TabIndex = 51;
            this.lb_checkPassword.Text = "label5";
            this.lb_checkPassword.Visible = false;
            // 
            // lb_CheckPassConfirm
            // 
            this.lb_CheckPassConfirm.AutoSize = true;
            this.lb_CheckPassConfirm.ForeColor = System.Drawing.Color.Red;
            this.lb_CheckPassConfirm.Location = new System.Drawing.Point(96, 370);
            this.lb_CheckPassConfirm.Name = "lb_CheckPassConfirm";
            this.lb_CheckPassConfirm.Size = new System.Drawing.Size(35, 13);
            this.lb_CheckPassConfirm.TabIndex = 52;
            this.lb_CheckPassConfirm.Text = "label6";
            this.lb_CheckPassConfirm.Visible = false;
            // 
            // btn_valid
            // 
            this.btn_valid.BackColor = System.Drawing.Color.Lime;
            this.btn_valid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valid.Location = new System.Drawing.Point(334, 129);
            this.btn_valid.Name = "btn_valid";
            this.btn_valid.Size = new System.Drawing.Size(126, 29);
            this.btn_valid.TabIndex = 53;
            this.btn_valid.Text = "Valid";
            this.btn_valid.UseVisualStyleBackColor = false;
            this.btn_valid.Click += new System.EventHandler(this.btn_valid_Click);
            // 
            // lb_Login
            // 
            this.lb_Login.AutoSize = true;
            this.lb_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_Login.Location = new System.Drawing.Point(101, 25);
            this.lb_Login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Login.Name = "lb_Login";
            this.lb_Login.Size = new System.Drawing.Size(227, 31);
            this.lb_Login.TabIndex = 54;
            this.lb_Login.Text = "Reset Password";
            // 
            // forgotpass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 451);
            this.Controls.Add(this.lb_Login);
            this.Controls.Add(this.btn_valid);
            this.Controls.Add(this.lb_CheckPassConfirm);
            this.Controls.Add(this.lb_checkPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_mail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_repass);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.tb_repass);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_id);
            this.Name = "forgotpass";
            this.Text = "forgotpass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tb_id;
        public System.Windows.Forms.TextBox tb_pass;
        public System.Windows.Forms.TextBox tb_repass;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_repass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_checkPassword;
        private System.Windows.Forms.Label lb_CheckPassConfirm;
        private System.Windows.Forms.Button btn_valid;
        private System.Windows.Forms.Label lb_Login;
    }
}