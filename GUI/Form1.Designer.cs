namespace GUI
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
            this.components = new System.ComponentModel.Container();
            this.dgv_ThongTin = new System.Windows.Forms.DataGridView();
            this.txb_MSSV = new System.Windows.Forms.TextBox();
            this.txb_HoTen = new System.Windows.Forms.TextBox();
            this.cmb_ChuyenNganh = new System.Windows.Forms.ComboBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.txb_Diem = new System.Windows.Forms.TextBox();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.schoolDBDataSet = new GUI.SchoolDBDataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new GUI.SchoolDBDataSetTableAdapters.StudentsTableAdapter();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongTin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ThongTin
            // 
            this.dgv_ThongTin.AutoGenerateColumns = false;
            this.dgv_ThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongTin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIdDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.majorDataGridViewTextBoxColumn});
            this.dgv_ThongTin.DataSource = this.studentsBindingSource;
            this.dgv_ThongTin.Location = new System.Drawing.Point(352, 24);
            this.dgv_ThongTin.Name = "dgv_ThongTin";
            this.dgv_ThongTin.RowHeadersWidth = 51;
            this.dgv_ThongTin.RowTemplate.Height = 24;
            this.dgv_ThongTin.Size = new System.Drawing.Size(544, 414);
            this.dgv_ThongTin.TabIndex = 0;
            this.dgv_ThongTin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ThongTin_CellContentClick);
            // 
            // txb_MSSV
            // 
            this.txb_MSSV.Location = new System.Drawing.Point(48, 24);
            this.txb_MSSV.Name = "txb_MSSV";
            this.txb_MSSV.Size = new System.Drawing.Size(184, 22);
            this.txb_MSSV.TabIndex = 1;
            this.txb_MSSV.TextChanged += new System.EventHandler(this.txb_MSSV_TextChanged);
            // 
            // txb_HoTen
            // 
            this.txb_HoTen.Location = new System.Drawing.Point(48, 64);
            this.txb_HoTen.Name = "txb_HoTen";
            this.txb_HoTen.Size = new System.Drawing.Size(184, 22);
            this.txb_HoTen.TabIndex = 2;
            this.txb_HoTen.TextChanged += new System.EventHandler(this.txb_HoTen_TextChanged);
            // 
            // cmb_ChuyenNganh
            // 
            this.cmb_ChuyenNganh.FormattingEnabled = true;
            this.cmb_ChuyenNganh.Location = new System.Drawing.Point(48, 128);
            this.cmb_ChuyenNganh.Name = "cmb_ChuyenNganh";
            this.cmb_ChuyenNganh.Size = new System.Drawing.Size(184, 24);
            this.cmb_ChuyenNganh.TabIndex = 3;
            this.cmb_ChuyenNganh.SelectedIndexChanged += new System.EventHandler(this.cmb_ChuyenNganh_SelectedIndexChanged);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(8, 184);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(88, 39);
            this.btn_Them.TabIndex = 4;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(240, 184);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(88, 39);
            this.btn_Xoa.TabIndex = 5;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(120, 184);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(88, 39);
            this.btn_Sua.TabIndex = 6;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // txb_Diem
            // 
            this.txb_Diem.Location = new System.Drawing.Point(48, 96);
            this.txb_Diem.Name = "txb_Diem";
            this.txb_Diem.Size = new System.Drawing.Size(184, 22);
            this.txb_Diem.TabIndex = 7;
            this.txb_Diem.TextChanged += new System.EventHandler(this.txb_Diem_TextChanged);
            // 
            // btn_Previous
            // 
            this.btn_Previous.Location = new System.Drawing.Point(32, 272);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(88, 39);
            this.btn_Previous.TabIndex = 8;
            this.btn_Previous.Text = "Previous";
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(144, 272);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(88, 39);
            this.btn_Next.TabIndex = 9;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // schoolDBDataSet
            // 
            this.schoolDBDataSet.DataSetName = "SchoolDBDataSet";
            this.schoolDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.schoolDBDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            this.studentIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.Width = 125;
            // 
            // majorDataGridViewTextBoxColumn
            // 
            this.majorDataGridViewTextBoxColumn.DataPropertyName = "Major";
            this.majorDataGridViewTextBoxColumn.HeaderText = "Major";
            this.majorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.majorDataGridViewTextBoxColumn.Name = "majorDataGridViewTextBoxColumn";
            this.majorDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 450);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Previous);
            this.Controls.Add(this.txb_Diem);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.cmb_ChuyenNganh);
            this.Controls.Add(this.txb_HoTen);
            this.Controls.Add(this.txb_MSSV);
            this.Controls.Add(this.dgv_ThongTin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongTin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ThongTin;
        private System.Windows.Forms.TextBox txb_MSSV;
        private System.Windows.Forms.TextBox txb_HoTen;
        private System.Windows.Forms.ComboBox cmb_ChuyenNganh;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.TextBox txb_Diem;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_Next;
        private SchoolDBDataSet schoolDBDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private SchoolDBDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorDataGridViewTextBoxColumn;
    }
}

