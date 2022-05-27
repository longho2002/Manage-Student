namespace QL_Sinh_Vien.score
{
    partial class ManageScoreForm
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
            this.tb_score = new System.Windows.Forms.TextBox();
            this.cb_course = new System.Windows.Forms.ComboBox();
            this.tb_des = new System.Windows.Forms.TextBox();
            this.tb_stdID = new System.Windows.Forms.TextBox();
            this.lb_des = new System.Windows.Forms.Label();
            this.lb_Period = new System.Windows.Forms.Label();
            this.lb_Label = new System.Windows.Forms.Label();
            this.lb_ID = new System.Windows.Forms.Label();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_showAVG = new System.Windows.Forms.Button();
            this.btn_showSTD = new System.Windows.Forms.Button();
            this.btn_showscore = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_score
            // 
            this.tb_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_score.Location = new System.Drawing.Point(210, 182);
            this.tb_score.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_score.Name = "tb_score";
            this.tb_score.Size = new System.Drawing.Size(211, 30);
            this.tb_score.TabIndex = 35;
            // 
            // cb_course
            // 
            this.cb_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_course.FormattingEnabled = true;
            this.cb_course.Location = new System.Drawing.Point(210, 126);
            this.cb_course.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_course.Name = "cb_course";
            this.cb_course.Size = new System.Drawing.Size(343, 33);
            this.cb_course.TabIndex = 34;
            // 
            // tb_des
            // 
            this.tb_des.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_des.Location = new System.Drawing.Point(210, 237);
            this.tb_des.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_des.Multiline = true;
            this.tb_des.Name = "tb_des";
            this.tb_des.Size = new System.Drawing.Size(343, 208);
            this.tb_des.TabIndex = 33;
            // 
            // tb_stdID
            // 
            this.tb_stdID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_stdID.Location = new System.Drawing.Point(210, 70);
            this.tb_stdID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_stdID.Name = "tb_stdID";
            this.tb_stdID.Size = new System.Drawing.Size(211, 30);
            this.tb_stdID.TabIndex = 32;
            // 
            // lb_des
            // 
            this.lb_des.AutoSize = true;
            this.lb_des.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_des.Location = new System.Drawing.Point(43, 242);
            this.lb_des.Name = "lb_des";
            this.lb_des.Size = new System.Drawing.Size(109, 25);
            this.lb_des.TabIndex = 31;
            this.lb_des.Text = "Description";
            // 
            // lb_Period
            // 
            this.lb_Period.AutoSize = true;
            this.lb_Period.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Period.Location = new System.Drawing.Point(43, 186);
            this.lb_Period.Name = "lb_Period";
            this.lb_Period.Size = new System.Drawing.Size(64, 25);
            this.lb_Period.TabIndex = 30;
            this.lb_Period.Text = "Score";
            // 
            // lb_Label
            // 
            this.lb_Label.AutoSize = true;
            this.lb_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Label.Location = new System.Drawing.Point(43, 134);
            this.lb_Label.Name = "lb_Label";
            this.lb_Label.Size = new System.Drawing.Size(136, 25);
            this.lb_Label.TabIndex = 29;
            this.lb_Label.Text = "Select Course";
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ID.Location = new System.Drawing.Point(43, 77);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(104, 25);
            this.lb_ID.TabIndex = 28;
            this.lb_ID.Text = "Student ID";
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_remove.Location = new System.Drawing.Point(301, 511);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(252, 63);
            this.btn_remove.TabIndex = 36;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Red;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add.Location = new System.Drawing.Point(48, 511);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(247, 63);
            this.btn_add.TabIndex = 37;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_showAVG
            // 
            this.btn_showAVG.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_showAVG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showAVG.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_showAVG.Location = new System.Drawing.Point(48, 578);
            this.btn_showAVG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_showAVG.Name = "btn_showAVG";
            this.btn_showAVG.Size = new System.Drawing.Size(505, 63);
            this.btn_showAVG.TabIndex = 38;
            this.btn_showAVG.Text = "Average Score By Course";
            this.btn_showAVG.UseVisualStyleBackColor = false;
            this.btn_showAVG.Click += new System.EventHandler(this.btn_showAVG_Click);
            // 
            // btn_showSTD
            // 
            this.btn_showSTD.BackColor = System.Drawing.Color.Violet;
            this.btn_showSTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showSTD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_showSTD.Location = new System.Drawing.Point(660, 58);
            this.btn_showSTD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_showSTD.Name = "btn_showSTD";
            this.btn_showSTD.Size = new System.Drawing.Size(218, 42);
            this.btn_showSTD.TabIndex = 39;
            this.btn_showSTD.Text = "Show Students";
            this.btn_showSTD.UseVisualStyleBackColor = false;
            this.btn_showSTD.Click += new System.EventHandler(this.btn_showSTD_Click);
            // 
            // btn_showscore
            // 
            this.btn_showscore.BackColor = System.Drawing.Color.Violet;
            this.btn_showscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showscore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_showscore.Location = new System.Drawing.Point(1012, 58);
            this.btn_showscore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_showscore.Name = "btn_showscore";
            this.btn_showscore.Size = new System.Drawing.Size(218, 42);
            this.btn_showscore.TabIndex = 40;
            this.btn_showscore.Text = "Show Scores";
            this.btn_showscore.UseVisualStyleBackColor = false;
            this.btn_showscore.Click += new System.EventHandler(this.btn_showscore_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(660, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(570, 515);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ManageScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1257, 652);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_showscore);
            this.Controls.Add(this.btn_showSTD);
            this.Controls.Add(this.btn_showAVG);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.tb_score);
            this.Controls.Add(this.cb_course);
            this.Controls.Add(this.tb_des);
            this.Controls.Add(this.tb_stdID);
            this.Controls.Add(this.lb_des);
            this.Controls.Add(this.lb_Period);
            this.Controls.Add(this.lb_Label);
            this.Controls.Add(this.lb_ID);
            this.Name = "ManageScoreForm";
            this.Text = "ManageScoreForm";
            this.Load += new System.EventHandler(this.ManageScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_score;
        private System.Windows.Forms.ComboBox cb_course;
        private System.Windows.Forms.TextBox tb_des;
        private System.Windows.Forms.TextBox tb_stdID;
        private System.Windows.Forms.Label lb_des;
        private System.Windows.Forms.Label lb_Period;
        private System.Windows.Forms.Label lb_Label;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_showAVG;
        private System.Windows.Forms.Button btn_showSTD;
        private System.Windows.Forms.Button btn_showscore;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}