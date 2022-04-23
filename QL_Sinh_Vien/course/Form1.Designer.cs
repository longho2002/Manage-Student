namespace QL_Sinh_Vien
{
    partial class Form1
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
            this.lb_ID = new System.Windows.Forms.Label();
            this.lb_Label = new System.Windows.Forms.Label();
            this.lb_Period = new System.Windows.Forms.Label();
            this.lb_des = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_Label = new System.Windows.Forms.TextBox();
            this.tb_Period = new System.Windows.Forms.TextBox();
            this.tb_Des = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ID.Location = new System.Drawing.Point(149, 72);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(100, 25);
            this.lb_ID.TabIndex = 0;
            this.lb_ID.Text = "Course ID";
            // 
            // lb_Label
            // 
            this.lb_Label.AutoSize = true;
            this.lb_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Label.Location = new System.Drawing.Point(149, 129);
            this.lb_Label.Name = "lb_Label";
            this.lb_Label.Size = new System.Drawing.Size(60, 25);
            this.lb_Label.TabIndex = 1;
            this.lb_Label.Text = "Label";
            // 
            // lb_Period
            // 
            this.lb_Period.AutoSize = true;
            this.lb_Period.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Period.Location = new System.Drawing.Point(149, 180);
            this.lb_Period.Name = "lb_Period";
            this.lb_Period.Size = new System.Drawing.Size(68, 25);
            this.lb_Period.TabIndex = 2;
            this.lb_Period.Text = "Period";
            // 
            // lb_des
            // 
            this.lb_des.AutoSize = true;
            this.lb_des.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_des.Location = new System.Drawing.Point(149, 237);
            this.lb_des.Name = "lb_des";
            this.lb_des.Size = new System.Drawing.Size(109, 25);
            this.lb_des.TabIndex = 3;
            this.lb_des.Text = "Description";
            // 
            // tb_ID
            // 
            this.tb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(315, 69);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(211, 30);
            this.tb_ID.TabIndex = 4;
            // 
            // tb_Label
            // 
            this.tb_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Label.Location = new System.Drawing.Point(315, 124);
            this.tb_Label.Name = "tb_Label";
            this.tb_Label.Size = new System.Drawing.Size(211, 30);
            this.tb_Label.TabIndex = 5;
            // 
            // tb_Period
            // 
            this.tb_Period.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Period.Location = new System.Drawing.Point(315, 180);
            this.tb_Period.Name = "tb_Period";
            this.tb_Period.Size = new System.Drawing.Size(211, 30);
            this.tb_Period.TabIndex = 6;
            // 
            // tb_Des
            // 
            this.tb_Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Des.Location = new System.Drawing.Point(315, 232);
            this.tb_Des.Multiline = true;
            this.tb_Des.Name = "tb_Des";
            this.tb_Des.Size = new System.Drawing.Size(211, 139);
            this.tb_Des.TabIndex = 7;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(202, 395);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(365, 43);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_Des);
            this.Controls.Add(this.tb_Period);
            this.Controls.Add(this.tb_Label);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.lb_des);
            this.Controls.Add(this.lb_Period);
            this.Controls.Add(this.lb_Label);
            this.Controls.Add(this.lb_ID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.Label lb_Label;
        private System.Windows.Forms.Label lb_Period;
        private System.Windows.Forms.Label lb_des;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_Label;
        private System.Windows.Forms.TextBox tb_Period;
        private System.Windows.Forms.TextBox tb_Des;
        private System.Windows.Forms.Button btn_add;
    }
}