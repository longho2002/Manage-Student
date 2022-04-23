namespace QL_Sinh_Vien
{
    partial class PrintCourseForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lABELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERIODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOURSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_sinh_vienDataSet2 = new QL_Sinh_Vien.QL_sinh_vienDataSet2();
            this.cOURSETableAdapter = new QL_Sinh_Vien.QL_sinh_vienDataSet2TableAdapters.COURSETableAdapter();
            this.btn_tofile = new System.Windows.Forms.Button();
            this.btn_toPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_sinh_vienDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.lABELDataGridViewTextBoxColumn,
            this.pERIODDataGridViewTextBoxColumn,
            this.dESCRIPTIONDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cOURSEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(45, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // lABELDataGridViewTextBoxColumn
            // 
            this.lABELDataGridViewTextBoxColumn.DataPropertyName = "LABEL";
            this.lABELDataGridViewTextBoxColumn.HeaderText = "LABEL";
            this.lABELDataGridViewTextBoxColumn.Name = "lABELDataGridViewTextBoxColumn";
            // 
            // pERIODDataGridViewTextBoxColumn
            // 
            this.pERIODDataGridViewTextBoxColumn.DataPropertyName = "PERIOD";
            this.pERIODDataGridViewTextBoxColumn.HeaderText = "PERIOD";
            this.pERIODDataGridViewTextBoxColumn.Name = "pERIODDataGridViewTextBoxColumn";
            // 
            // dESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.Name = "dESCRIPTIONDataGridViewTextBoxColumn";
            this.dESCRIPTIONDataGridViewTextBoxColumn.Width = 300;
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "semester";
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            // 
            // cOURSEBindingSource
            // 
            this.cOURSEBindingSource.DataMember = "COURSE";
            this.cOURSEBindingSource.DataSource = this.qL_sinh_vienDataSet2;
            // 
            // qL_sinh_vienDataSet2
            // 
            this.qL_sinh_vienDataSet2.DataSetName = "QL_sinh_vienDataSet2";
            this.qL_sinh_vienDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOURSETableAdapter
            // 
            this.cOURSETableAdapter.ClearBeforeFill = true;
            // 
            // btn_tofile
            // 
            this.btn_tofile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_tofile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tofile.Location = new System.Drawing.Point(45, 442);
            this.btn_tofile.Name = "btn_tofile";
            this.btn_tofile.Size = new System.Drawing.Size(97, 48);
            this.btn_tofile.TabIndex = 1;
            this.btn_tofile.Text = "To File";
            this.btn_tofile.UseVisualStyleBackColor = false;
            this.btn_tofile.Click += new System.EventHandler(this.btn_tofile_Click);
            // 
            // btn_toPrint
            // 
            this.btn_toPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_toPrint.Location = new System.Drawing.Point(189, 442);
            this.btn_toPrint.Name = "btn_toPrint";
            this.btn_toPrint.Size = new System.Drawing.Size(97, 48);
            this.btn_toPrint.TabIndex = 2;
            this.btn_toPrint.Text = "Print";
            this.btn_toPrint.UseVisualStyleBackColor = true;
            this.btn_toPrint.Click += new System.EventHandler(this.btn_toPrint_Click);
            // 
            // PrintCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(850, 502);
            this.Controls.Add(this.btn_toPrint);
            this.Controls.Add(this.btn_tofile);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PrintCourseForm";
            this.Text = "PrintCourseForm";
            this.Load += new System.EventHandler(this.PrintCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_sinh_vienDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private QL_sinh_vienDataSet2 qL_sinh_vienDataSet2;
        private System.Windows.Forms.BindingSource cOURSEBindingSource;
        private QL_sinh_vienDataSet2TableAdapters.COURSETableAdapter cOURSETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lABELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERIODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_tofile;
        private System.Windows.Forms.Button btn_toPrint;
    }
}