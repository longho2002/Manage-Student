namespace QL_Sinh_Vien
{
    partial class ManageStudentsForm
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
            this.btn_Remove = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.btn_UploadImg = new System.Windows.Forms.Button();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_LName = new System.Windows.Forms.TextBox();
            this.tb_FName = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.stdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLsinhvienDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_sinh_vienDataSet = new QL_Sinh_Vien.QL_sinh_vienDataSet();
            this.PictureBoxStudentImage1 = new QL_Sinh_Vien.RJCircularPictureBox();
            this.lb_Total = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_find = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.stdTableAdapter = new QL_Sinh_Vien.QL_sinh_vienDataSetTableAdapters.stdTableAdapter();
            this.btn_addcourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLsinhvienDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_sinh_vienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStudentImage1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.Color.Red;
            this.btn_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.Location = new System.Drawing.Point(355, 684);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(148, 46);
            this.btn_Remove.TabIndex = 67;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = false;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 161);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 20);
            this.dateTimePicker1.TabIndex = 65;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonFemale.Location = new System.Drawing.Point(244, 186);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(86, 24);
            this.radioButtonFemale.TabIndex = 64;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButtonMale.Location = new System.Drawing.Point(142, 186);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(65, 24);
            this.radioButtonMale.TabIndex = 63;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // btn_UploadImg
            // 
            this.btn_UploadImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UploadImg.Location = new System.Drawing.Point(118, 582);
            this.btn_UploadImg.Name = "btn_UploadImg";
            this.btn_UploadImg.Size = new System.Drawing.Size(101, 31);
            this.btn_UploadImg.TabIndex = 62;
            this.btn_UploadImg.Text = "Upload";
            this.btn_UploadImg.UseVisualStyleBackColor = true;
            this.btn_UploadImg.Click += new System.EventHandler(this.ButtonUpload_Click);
            // 
            // tb_Phone
            // 
            this.tb_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Phone.Location = new System.Drawing.Point(129, 219);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(220, 26);
            this.tb_Phone.TabIndex = 61;
            // 
            // tb_Address
            // 
            this.tb_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(129, 251);
            this.tb_Address.Multiline = true;
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(220, 99);
            this.tb_Address.TabIndex = 60;
            // 
            // tb_LName
            // 
            this.tb_LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_LName.Location = new System.Drawing.Point(129, 123);
            this.tb_LName.Name = "tb_LName";
            this.tb_LName.Size = new System.Drawing.Size(220, 26);
            this.tb_LName.TabIndex = 59;
            // 
            // tb_FName
            // 
            this.tb_FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_FName.Location = new System.Drawing.Point(129, 91);
            this.tb_FName.Name = "tb_FName";
            this.tb_FName.Size = new System.Drawing.Size(220, 26);
            this.tb_FName.TabIndex = 58;
            // 
            // tb_ID
            // 
            this.tb_ID.AcceptsTab = true;
            this.tb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(129, 59);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(220, 26);
            this.tb_ID.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(41, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 55;
            this.label7.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(56, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 54;
            this.label6.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(47, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 53;
            this.label5.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(30, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "BirthDate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(21, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(21, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(21, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Student ID:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(248, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 31);
            this.button1.TabIndex = 72;
            this.button1.Text = "Download";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonDownload_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.Gray;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(182, 684);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(148, 46);
            this.btn_Edit.TabIndex = 73;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(12, 684);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(148, 46);
            this.btn_Add.TabIndex = 74;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.ButtonAddStudent_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(524, 684);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(148, 46);
            this.btn_Reset.TabIndex = 75;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AutoGenerateColumns = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.bdateDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn});
            this.DataGridView1.DataSource = this.stdBindingSource;
            this.DataGridView1.Location = new System.Drawing.Point(379, 59);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(865, 598);
            this.DataGridView1.TabIndex = 76;
            this.DataGridView1.Click += new System.EventHandler(this.DataGridView1_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
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
            this.pictureDataGridViewImageColumn.Width = 120;
            // 
            // stdBindingSource
            // 
            this.stdBindingSource.DataMember = "std";
            this.stdBindingSource.DataSource = this.qLsinhvienDataSetBindingSource;
            // 
            // qLsinhvienDataSetBindingSource
            // 
            this.qLsinhvienDataSetBindingSource.DataSource = this.qL_sinh_vienDataSet;
            this.qLsinhvienDataSetBindingSource.Position = 0;
            // 
            // qL_sinh_vienDataSet
            // 
            this.qL_sinh_vienDataSet.DataSetName = "QL_sinh_vienDataSet";
            this.qL_sinh_vienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PictureBoxStudentImage1
            // 
            this.PictureBoxStudentImage1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.PictureBoxStudentImage1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.PictureBoxStudentImage1.BorderColor2 = System.Drawing.Color.HotPink;
            this.PictureBoxStudentImage1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.PictureBoxStudentImage1.BorderSize = 5;
            this.PictureBoxStudentImage1.GradientAngle = 50F;
            this.PictureBoxStudentImage1.Location = new System.Drawing.Point(129, 356);
            this.PictureBoxStudentImage1.Name = "PictureBoxStudentImage1";
            this.PictureBoxStudentImage1.Size = new System.Drawing.Size(220, 220);
            this.PictureBoxStudentImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxStudentImage1.TabIndex = 71;
            this.PictureBoxStudentImage1.TabStop = false;
            // 
            // lb_Total
            // 
            this.lb_Total.AutoSize = true;
            this.lb_Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lb_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Total.Location = new System.Drawing.Point(925, 670);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(296, 37);
            this.lb_Total.TabIndex = 77;
            this.lb_Total.Text = "Total Students: 300";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(579, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(255, 25);
            this.label9.TabIndex = 78;
            this.label9.Text = "Enter A Value To Search:";
            // 
            // tb_find
            // 
            this.tb_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_find.Location = new System.Drawing.Point(837, 13);
            this.tb_find.Name = "tb_find";
            this.tb_find.Size = new System.Drawing.Size(241, 31);
            this.tb_find.TabIndex = 79;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Gray;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Search.Location = new System.Drawing.Point(1084, 12);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(137, 35);
            this.btn_Search.TabIndex = 80;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // stdTableAdapter
            // 
            this.stdTableAdapter.ClearBeforeFill = true;
            // 
            // btn_addcourse
            // 
            this.btn_addcourse.BackColor = System.Drawing.Color.Snow;
            this.btn_addcourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addcourse.Location = new System.Drawing.Point(704, 684);
            this.btn_addcourse.Name = "btn_addcourse";
            this.btn_addcourse.Size = new System.Drawing.Size(148, 46);
            this.btn_addcourse.TabIndex = 81;
            this.btn_addcourse.Text = "Add Course";
            this.btn_addcourse.UseVisualStyleBackColor = false;
            this.btn_addcourse.Click += new System.EventHandler(this.btn_addcourse_Click);
            // 
            // ManageStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1246, 742);
            this.Controls.Add(this.btn_addcourse);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_find);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lb_Total);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PictureBoxStudentImage1);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.btn_UploadImg);
            this.Controls.Add(this.tb_Phone);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.tb_LName);
            this.Controls.Add(this.tb_FName);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageStudentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageStudentsForm";
            this.Load += new System.EventHandler(this.ManageStudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLsinhvienDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_sinh_vienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStudentImage1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal RJCircularPictureBox PictureBoxStudentImage1;
        private System.Windows.Forms.Button btn_Remove;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.RadioButton radioButtonFemale;
        public System.Windows.Forms.RadioButton radioButtonMale;
        protected System.Windows.Forms.Button btn_UploadImg;
        public System.Windows.Forms.TextBox tb_Phone;
        public System.Windows.Forms.TextBox tb_Address;
        public System.Windows.Forms.TextBox tb_LName;
        public System.Windows.Forms.TextBox tb_FName;
        public System.Windows.Forms.TextBox tb_ID;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Label lb_Total;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_find;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.BindingSource qLsinhvienDataSetBindingSource;
        private QL_sinh_vienDataSet qL_sinh_vienDataSet;
        private System.Windows.Forms.BindingSource stdBindingSource;
        private QL_sinh_vienDataSetTableAdapters.stdTableAdapter stdTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.Button btn_addcourse;
    }
}