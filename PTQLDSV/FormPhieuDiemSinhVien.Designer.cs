namespace PTQLDSV
{
    partial class FormPhieuDiemSinhVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.cbMaSV = new System.Windows.Forms.ComboBox();
            this.bdsSV = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new PTQLDSV.DS();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sINHVIENTableAdapter = new PTQLDSV.DSTableAdapters.SINHVIENTableAdapter();
            this.tableAdapterManager = new PTQLDSV.DSTableAdapters.TableAdapterManager();
            this.lbltest = new System.Windows.Forms.Label();
            this.bdsSinhVien = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIEN1TableAdapter = new PTQLDSV.DSTableAdapters.SINHVIEN1TableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTest);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnView);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Controls.Add(this.cbMaSV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbKhoa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(313, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(273, 72);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(100, 20);
            this.txtTest.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(164, 175);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(51, 175);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Location = new System.Drawing.Point(119, 118);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(121, 22);
            this.txtMaSV.TabIndex = 5;
            // 
            // cbMaSV
            // 
            this.cbMaSV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSV, "MASV", true));
            this.cbMaSV.DataSource = this.bdsSinhVien;
            this.cbMaSV.DisplayMember = "Ho va Ten";
            this.cbMaSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaSV.FormattingEnabled = true;
            this.cbMaSV.Location = new System.Drawing.Point(119, 72);
            this.cbMaSV.Name = "cbMaSV";
            this.cbMaSV.Size = new System.Drawing.Size(121, 21);
            this.cbMaSV.TabIndex = 4;
            this.cbMaSV.ValueMember = "MASV";
            this.cbMaSV.SelectedIndexChanged += new System.EventHandler(this.cbMaSV_SelectedIndexChanged);
            // 
            // bdsSV
            // 
            this.bdsSV.DataMember = "SINHVIEN";
            this.bdsSV.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã SV:";
            // 
            // cbKhoa
            // 
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(119, 28);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(121, 21);
            this.cbKhoa.TabIndex = 1;
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khoa:";
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIEN1TableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = PTQLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lbltest
            // 
            this.lbltest.AutoSize = true;
            this.lbltest.Location = new System.Drawing.Point(277, 73);
            this.lbltest.Name = "lbltest";
            this.lbltest.Size = new System.Drawing.Size(0, 13);
            this.lbltest.TabIndex = 1;
            // 
            // bdsSinhVien
            // 
            this.bdsSinhVien.DataMember = "SINHVIEN1";
            this.bdsSinhVien.DataSource = this.dS;
            // 
            // sINHVIEN1TableAdapter
            // 
            this.sINHVIEN1TableAdapter.ClearBeforeFill = true;
            // 
            // FormPhieuDiemSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.lbltest);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPhieuDiemSinhVien";
            this.Text = "FormPhieuDiemSinhVien";
            this.Load += new System.EventHandler(this.FormPhieuDiemSinhVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label label1;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsSV;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.ComboBox cbMaSV;
        private System.Windows.Forms.Label lbltest;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.BindingSource bdsSinhVien;
        private DSTableAdapters.SINHVIEN1TableAdapter sINHVIEN1TableAdapter;
    }
}