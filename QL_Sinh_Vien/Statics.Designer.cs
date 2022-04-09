namespace QL_Sinh_Vien
{
    partial class Statics
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lb_student = new System.Windows.Forms.Label();
            this.lb_Male = new System.Windows.Forms.Label();
            this.lb_Female = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lb_student);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 218);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(3, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 230);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(8, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(415, 230);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LimeGreen;
            this.panel4.Controls.Add(this.lb_Male);
            this.panel4.Location = new System.Drawing.Point(2, 215);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(449, 270);
            this.panel4.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Violet;
            this.panel7.Controls.Add(this.lb_Female);
            this.panel7.Location = new System.Drawing.Point(450, 215);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(416, 265);
            this.panel7.TabIndex = 3;
            // 
            // lb_student
            // 
            this.lb_student.AutoSize = true;
            this.lb_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_student.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_student.Location = new System.Drawing.Point(181, 78);
            this.lb_student.Name = "lb_student";
            this.lb_student.Size = new System.Drawing.Size(375, 55);
            this.lb_student.TabIndex = 2;
            this.lb_student.Text = "Total Students: ";
            // 
            // lb_Male
            // 
            this.lb_Male.AutoSize = true;
            this.lb_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Male.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Male.Location = new System.Drawing.Point(23, 113);
            this.lb_Male.Name = "lb_Male";
            this.lb_Male.Size = new System.Drawing.Size(160, 55);
            this.lb_Male.TabIndex = 3;
            this.lb_Male.Text = "Male: ";
            // 
            // lb_Female
            // 
            this.lb_Female.AutoSize = true;
            this.lb_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Female.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Female.Location = new System.Drawing.Point(18, 113);
            this.lb_Female.Name = "lb_Female";
            this.lb_Female.Size = new System.Drawing.Size(204, 55);
            this.lb_Female.TabIndex = 4;
            this.lb_Female.Text = "Female:";
            // 
            // Statics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 481);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Statics";
            this.Text = "Statics";
            this.Load += new System.EventHandler(this.Statics_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_student;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lb_Male;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lb_Female;
    }
}