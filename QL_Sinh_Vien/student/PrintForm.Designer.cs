namespace QL_Sinh_Vien
{
    partial class PrintForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rBtn_Check = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rBtn_No = new System.Windows.Forms.RadioButton();
            this.rBtn_Yes = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rBtn_Male = new System.Windows.Forms.RadioButton();
            this.rBtn_Female = new System.Windows.Forms.RadioButton();
            this.rBtn_All = new System.Windows.Forms.RadioButton();
            this.qL_sinh_vienDataSet1 = new QL_Sinh_Vien.QL_sinh_vienDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.stdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLsinhvienDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stdTableAdapter = new QL_Sinh_Vien.QL_sinh_vienDataSetTableAdapters.stdTableAdapter();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.qL_sinh_vienDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.stdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.qLsinhvienDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rBtn_Check);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.rBtn_Male);
            this.panel1.Controls.Add(this.rBtn_Female);
            this.panel1.Controls.Add(this.rBtn_All);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 200);
            this.panel1.TabIndex = 0;
            // 
            // rBtn_Check
            // 
            this.rBtn_Check.BackColor = System.Drawing.Color.Red;
            this.rBtn_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.rBtn_Check.Location = new System.Drawing.Point(920, 60);
            this.rBtn_Check.Margin = new System.Windows.Forms.Padding(4);
            this.rBtn_Check.Name = "rBtn_Check";
            this.rBtn_Check.Size = new System.Drawing.Size(117, 43);
            this.rBtn_Check.TabIndex = 0;
            this.rBtn_Check.Text = "Check";
            this.rBtn_Check.UseVisualStyleBackColor = false;
            this.rBtn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.rBtn_No);
            this.panel2.Controls.Add(this.rBtn_Yes);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(295, 21);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 134);
            this.panel2.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(452, 90);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(124, 22);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(383, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "And";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(237, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(124, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // rBtn_No
            // 
            this.rBtn_No.AutoSize = true;
            this.rBtn_No.Checked = true;
            this.rBtn_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.rBtn_No.Location = new System.Drawing.Point(331, 14);
            this.rBtn_No.Margin = new System.Windows.Forms.Padding(4);
            this.rBtn_No.Name = "rBtn_No";
            this.rBtn_No.Size = new System.Drawing.Size(58, 29);
            this.rBtn_No.TabIndex = 10;
            this.rBtn_No.TabStop = true;
            this.rBtn_No.Text = "No";
            this.rBtn_No.UseVisualStyleBackColor = true;
            this.rBtn_No.CheckedChanged += new System.EventHandler(this.rBtn_No_CheckedChanged);
            // 
            // rBtn_Yes
            // 
            this.rBtn_Yes.AutoSize = true;
            this.rBtn_Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.rBtn_Yes.Location = new System.Drawing.Point(249, 14);
            this.rBtn_Yes.Margin = new System.Windows.Forms.Padding(4);
            this.rBtn_Yes.Name = "rBtn_Yes";
            this.rBtn_Yes.Size = new System.Drawing.Size(67, 29);
            this.rBtn_Yes.TabIndex = 4;
            this.rBtn_Yes.TabStop = true;
            this.rBtn_Yes.Text = "Yes";
            this.rBtn_Yes.UseVisualStyleBackColor = true;
            this.rBtn_Yes.CheckedChanged += new System.EventHandler(this.rBtn_Yes_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(33, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Use Date Range";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(33, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "BirthDate Between";
            // 
            // rBtn_Male
            // 
            this.rBtn_Male.AutoSize = true;
            this.rBtn_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.rBtn_Male.Location = new System.Drawing.Point(91, 60);
            this.rBtn_Male.Margin = new System.Windows.Forms.Padding(4);
            this.rBtn_Male.Name = "rBtn_Male";
            this.rBtn_Male.Size = new System.Drawing.Size(76, 29);
            this.rBtn_Male.TabIndex = 2;
            this.rBtn_Male.Text = "Male";
            this.rBtn_Male.UseVisualStyleBackColor = true;
            // 
            // rBtn_Female
            // 
            this.rBtn_Female.AutoSize = true;
            this.rBtn_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.rBtn_Female.Location = new System.Drawing.Point(180, 60);
            this.rBtn_Female.Margin = new System.Windows.Forms.Padding(4);
            this.rBtn_Female.Name = "rBtn_Female";
            this.rBtn_Female.Size = new System.Drawing.Size(98, 29);
            this.rBtn_Female.TabIndex = 1;
            this.rBtn_Female.Text = "Female";
            this.rBtn_Female.UseVisualStyleBackColor = true;
            // 
            // rBtn_All
            // 
            this.rBtn_All.AutoSize = true;
            this.rBtn_All.Checked = true;
            this.rBtn_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.rBtn_All.Location = new System.Drawing.Point(24, 60);
            this.rBtn_All.Margin = new System.Windows.Forms.Padding(4);
            this.rBtn_All.Name = "rBtn_All";
            this.rBtn_All.Size = new System.Drawing.Size(55, 29);
            this.rBtn_All.TabIndex = 0;
            this.rBtn_All.TabStop = true;
            this.rBtn_All.Text = "All";
            this.rBtn_All.UseVisualStyleBackColor = true;
            // 
            // qL_sinh_vienDataSet1
            // 
            this.qL_sinh_vienDataSet1.DataSetName = "QL_sinh_vienDataSet";
            this.qL_sinh_vienDataSet1.Namespace = "http://tempuri.org/QL_sinh_vienDataSet.xsd";
            this.qL_sinh_vienDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.idDataGridViewTextBoxColumn, this.fnameDataGridViewTextBoxColumn, this.lnameDataGridViewTextBoxColumn, this.genderDataGridViewTextBoxColumn, this.bdateDataGridViewTextBoxColumn, this.phoneDataGridViewTextBoxColumn, this.addressDataGridViewTextBoxColumn, this.pictureDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.stdBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 245);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1067, 356);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 70;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.FillWeight = 70F;
            this.fnameDataGridViewTextBoxColumn.HeaderText = "fname";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "lname";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // bdateDataGridViewTextBoxColumn
            // 
            this.bdateDataGridViewTextBoxColumn.DataPropertyName = "bdate";
            this.bdateDataGridViewTextBoxColumn.HeaderText = "bdate";
            this.bdateDataGridViewTextBoxColumn.Name = "bdateDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "picture";
            this.pictureDataGridViewImageColumn.HeaderText = "picture";
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            this.pictureDataGridViewImageColumn.Width = 130;
            // 
            // stdBindingSource
            // 
            this.stdBindingSource.DataMember = "std";
            this.stdBindingSource.DataSource = this.qLsinhvienDataSet1BindingSource;
            // 
            // qLsinhvienDataSet1BindingSource
            // 
            this.qLsinhvienDataSet1BindingSource.DataSource = this.qL_sinh_vienDataSet1;
            this.qLsinhvienDataSet1BindingSource.Position = 0;
            // 
            // stdTableAdapter
            // 
            this.stdTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(337, 608);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(252, 62);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save To TextFile";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btn_Print.Location = new System.Drawing.Point(665, 608);
            this.btn_Print.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(252, 62);
            this.btn_Print.TabIndex = 5;
            this.btn_Print.Text = "To Printer";
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1127, 684);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print";
            this.Load += new System.EventHandler(this.Print_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.qL_sinh_vienDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.stdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.qLsinhvienDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DateTimePicker dateTimePicker2;

        private System.Windows.Forms.DateTimePicker dateTimePicker1;

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button rBtn_Check;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rBtn_Male;
        private System.Windows.Forms.RadioButton rBtn_Female;
        private System.Windows.Forms.RadioButton rBtn_All;
        private QL_sinh_vienDataSet qL_sinh_vienDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource qLsinhvienDataSet1BindingSource;
        private System.Windows.Forms.BindingSource stdBindingSource;
        private QL_sinh_vienDataSetTableAdapters.stdTableAdapter stdTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rBtn_No;
        private System.Windows.Forms.RadioButton rBtn_Yes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
    }
}