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
            this.lb_student = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_Male = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lb_Female = new System.Windows.Forms.Label();
            this.btn_Chart = new System.Windows.Forms.Button();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 268);
            this.panel1.TabIndex = 0;
            // 
            // lb_student
            // 
            this.lb_student.AutoSize = true;
            this.lb_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_student.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_student.Location = new System.Drawing.Point(241, 96);
            this.lb_student.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_student.Name = "lb_student";
            this.lb_student.Size = new System.Drawing.Size(464, 69);
            this.lb_student.TabIndex = 2;
            this.lb_student.Text = "Total Students: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(4, 310);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 283);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(11, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(553, 283);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LimeGreen;
            this.panel4.Controls.Add(this.lb_Male);
            this.panel4.Location = new System.Drawing.Point(3, 265);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(598, 332);
            this.panel4.TabIndex = 2;
            // 
            // lb_Male
            // 
            this.lb_Male.AutoSize = true;
            this.lb_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Male.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Male.Location = new System.Drawing.Point(31, 139);
            this.lb_Male.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Male.Name = "lb_Male";
            this.lb_Male.Size = new System.Drawing.Size(198, 69);
            this.lb_Male.TabIndex = 3;
            this.lb_Male.Text = "Male: ";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Violet;
            this.panel7.Controls.Add(this.lb_Female);
            this.panel7.Location = new System.Drawing.Point(600, 265);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(555, 332);
            this.panel7.TabIndex = 3;
            // 
            // lb_Female
            // 
            this.lb_Female.AutoSize = true;
            this.lb_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Female.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Female.Location = new System.Drawing.Point(24, 139);
            this.lb_Female.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Female.Name = "lb_Female";
            this.lb_Female.Size = new System.Drawing.Size(253, 69);
            this.lb_Female.TabIndex = 4;
            this.lb_Female.Text = "Female:";
            // 
            // btn_Chart
            // 
            this.btn_Chart.BackColor = System.Drawing.Color.Turquoise;
            this.btn_Chart.Location = new System.Drawing.Point(494, 608);
            this.btn_Chart.Name = "btn_Chart";
            this.btn_Chart.Size = new System.Drawing.Size(210, 56);
            this.btn_Chart.TabIndex = 4;
            this.btn_Chart.Text = "To Chart";
            this.btn_Chart.UseVisualStyleBackColor = false;
            this.btn_Chart.Click += new System.EventHandler(this.btn_Chart_Click);
            // 
            // Statics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 676);
            this.Controls.Add(this.btn_Chart);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
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

        private System.Windows.Forms.Button btn_Chart;

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