namespace QL_Sinh_Vien
{
    partial class EditCourseForm
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
            this.btn_edit = new System.Windows.Forms.Button();
            this.tb_Des = new System.Windows.Forms.TextBox();
            this.tb_Label = new System.Windows.Forms.TextBox();
            this.lb_des = new System.Windows.Forms.Label();
            this.lb_Period = new System.Windows.Forms.Label();
            this.lb_Label = new System.Windows.Forms.Label();
            this.lb_ID = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Honeydew;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(244, 367);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(365, 43);
            this.btn_edit.TabIndex = 17;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // tb_Des
            // 
            this.tb_Des.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Des.Location = new System.Drawing.Point(357, 204);
            this.tb_Des.Multiline = true;
            this.tb_Des.Name = "tb_Des";
            this.tb_Des.Size = new System.Drawing.Size(211, 139);
            this.tb_Des.TabIndex = 16;
            // 
            // tb_Label
            // 
            this.tb_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Label.Location = new System.Drawing.Point(357, 96);
            this.tb_Label.Name = "tb_Label";
            this.tb_Label.Size = new System.Drawing.Size(211, 30);
            this.tb_Label.TabIndex = 14;
            // 
            // lb_des
            // 
            this.lb_des.AutoSize = true;
            this.lb_des.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_des.Location = new System.Drawing.Point(191, 209);
            this.lb_des.Name = "lb_des";
            this.lb_des.Size = new System.Drawing.Size(109, 25);
            this.lb_des.TabIndex = 12;
            this.lb_des.Text = "Description";
            // 
            // lb_Period
            // 
            this.lb_Period.AutoSize = true;
            this.lb_Period.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Period.Location = new System.Drawing.Point(191, 152);
            this.lb_Period.Name = "lb_Period";
            this.lb_Period.Size = new System.Drawing.Size(68, 25);
            this.lb_Period.TabIndex = 11;
            this.lb_Period.Text = "Period";
            // 
            // lb_Label
            // 
            this.lb_Label.AutoSize = true;
            this.lb_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Label.Location = new System.Drawing.Point(191, 101);
            this.lb_Label.Name = "lb_Label";
            this.lb_Label.Size = new System.Drawing.Size(60, 25);
            this.lb_Label.TabIndex = 10;
            this.lb_Label.Text = "Label";
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ID.Location = new System.Drawing.Point(191, 44);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(160, 25);
            this.lb_ID.TabIndex = 9;
            this.lb_ID.Text = "Select Course ID";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(357, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(211, 33);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(357, 154);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(211, 30);
            this.numericUpDown1.TabIndex = 19;
            // 
            // EditCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.tb_Des);
            this.Controls.Add(this.tb_Label);
            this.Controls.Add(this.lb_des);
            this.Controls.Add(this.lb_Period);
            this.Controls.Add(this.lb_Label);
            this.Controls.Add(this.lb_ID);
            this.Name = "EditCourseForm";
            this.Text = "EditCourseForm";
            this.Load += new System.EventHandler(this.EditCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox tb_Des;
        private System.Windows.Forms.TextBox tb_Label;
        private System.Windows.Forms.Label lb_des;
        private System.Windows.Forms.Label lb_Period;
        private System.Windows.Forms.Label lb_Label;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}