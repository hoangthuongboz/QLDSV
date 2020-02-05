namespace PTQLDSV
{
    partial class FormHocPhi
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
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label nIENKHOALabel;
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label hOCPHILabel;
            System.Windows.Forms.Label sOTIENDADONGLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHocPhi));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbltest = new System.Windows.Forms.Label();
            this.nudSTDD = new System.Windows.Forms.NumericUpDown();
            this.bdsHP = new System.Windows.Forms.BindingSource(this.components);
            this.bdsSV = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new PTQLDSV.DS();
            this.nudHP = new System.Windows.Forms.NumericUpDown();
            this.nudHK = new System.Windows.Forms.NumericUpDown();
            this.txtNK = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.cbMaSV = new System.Windows.Forms.ComboBox();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.sINHVIENTableAdapter = new PTQLDSV.DSTableAdapters.SINHVIENTableAdapter();
            this.hOCPHITableAdapter = new PTQLDSV.DSTableAdapters.HOCPHITableAdapter();
            this.tableAdapterManager = new PTQLDSV.DSTableAdapters.TableAdapterManager();
            this.gcHP = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENDADONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvHocPhi = new System.Windows.Forms.DataGridView();
            this.ColMaSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSTDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            mASVLabel = new System.Windows.Forms.Label();
            nIENKHOALabel = new System.Windows.Forms.Label();
            hOCKYLabel = new System.Windows.Forms.Label();
            hOCPHILabel = new System.Windows.Forms.Label();
            sOTIENDADONGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSTDD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocPhi)).BeginInit();
            this.SuspendLayout();
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(28, 17);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(40, 13);
            mASVLabel.TabIndex = 6;
            mASVLabel.Text = "MASV:";
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Location = new System.Drawing.Point(803, 37);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(66, 13);
            nIENKHOALabel.TabIndex = 10;
            nIENKHOALabel.Text = "NIENKHOA:";
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Location = new System.Drawing.Point(803, 69);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(47, 13);
            hOCKYLabel.TabIndex = 12;
            hOCKYLabel.Text = "HOCKY:";
            // 
            // hOCPHILabel
            // 
            hOCPHILabel.AutoSize = true;
            hOCPHILabel.Location = new System.Drawing.Point(1062, 37);
            hOCPHILabel.Name = "hOCPHILabel";
            hOCPHILabel.Size = new System.Drawing.Size(51, 13);
            hOCPHILabel.TabIndex = 14;
            hOCPHILabel.Text = "HOCPHI:";
            // 
            // sOTIENDADONGLabel
            // 
            sOTIENDADONGLabel.AutoSize = true;
            sOTIENDADONGLabel.Location = new System.Drawing.Point(1026, 67);
            sOTIENDADONGLabel.Name = "sOTIENDADONGLabel";
            sOTIENDADONGLabel.Size = new System.Drawing.Size(97, 13);
            sOTIENDADONGLabel.TabIndex = 16;
            sOTIENDADONGLabel.Text = "SOTIENDADONG:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnDelete,
            this.btnEdit,
            this.btnSave,
            this.btnCancel,
            this.btnUndo,
            this.btnReload,
            this.btnClose});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnClose, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.LargeImage")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xóa";
            this.btnDelete.Id = 1;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.LargeImage")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Sửa";
            this.btnEdit.Id = 2;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.LargeImage")));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Ghi";
            this.btnSave.Id = 3;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.LargeImage")));
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Phục hồi";
            this.btnUndo.Id = 5;
            this.btnUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.Image")));
            this.btnUndo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.LargeImage")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Refresh";
            this.btnReload.Id = 6;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Thoát";
            this.btnClose.Id = 7;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.LargeImage")));
            this.btnClose.Name = "btnClose";
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            this.bar3.Visible = false;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1306, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 392);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1306, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 368);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1306, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 368);
            // 
            // btnCancel
            // 
            this.btnCancel.Caption = "Cancle";
            this.btnCancel.Id = 4;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.LargeImage")));
            this.btnCancel.Name = "btnCancel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbltest);
            this.groupBox1.Controls.Add(sOTIENDADONGLabel);
            this.groupBox1.Controls.Add(this.nudSTDD);
            this.groupBox1.Controls.Add(hOCPHILabel);
            this.groupBox1.Controls.Add(this.nudHP);
            this.groupBox1.Controls.Add(hOCKYLabel);
            this.groupBox1.Controls.Add(this.nudHK);
            this.groupBox1.Controls.Add(nIENKHOALabel);
            this.groupBox1.Controls.Add(this.txtNK);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Controls.Add(mASVLabel);
            this.groupBox1.Controls.Add(this.cbMaSV);
            this.groupBox1.Controls.Add(this.txtHoVaTen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtLop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1306, 111);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lbltest
            // 
            this.lbltest.AutoSize = true;
            this.lbltest.Location = new System.Drawing.Point(32, 69);
            this.lbltest.Name = "lbltest";
            this.lbltest.Size = new System.Drawing.Size(0, 13);
            this.lbltest.TabIndex = 18;
            // 
            // nudSTDD
            // 
            this.nudSTDD.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsHP, "SOTIENDADONG", true));
            this.nudSTDD.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudSTDD.Location = new System.Drawing.Point(1129, 62);
            this.nudSTDD.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudSTDD.Name = "nudSTDD";
            this.nudSTDD.ReadOnly = true;
            this.nudSTDD.Size = new System.Drawing.Size(120, 20);
            this.nudSTDD.TabIndex = 17;
            // 
            // bdsHP
            // 
            this.bdsHP.DataMember = "FK_HOCPHI_SINHVIEN";
            this.bdsHP.DataSource = this.bdsSV;
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
            // nudHP
            // 
            this.nudHP.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsHP, "HOCPHI", true));
            this.nudHP.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudHP.Location = new System.Drawing.Point(1129, 30);
            this.nudHP.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudHP.Name = "nudHP";
            this.nudHP.ReadOnly = true;
            this.nudHP.Size = new System.Drawing.Size(120, 20);
            this.nudHP.TabIndex = 15;
            // 
            // nudHK
            // 
            this.nudHK.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsHP, "HOCKY", true));
            this.nudHK.Location = new System.Drawing.Point(875, 63);
            this.nudHK.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudHK.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHK.Name = "nudHK";
            this.nudHK.ReadOnly = true;
            this.nudHK.Size = new System.Drawing.Size(100, 20);
            this.nudHK.TabIndex = 13;
            this.nudHK.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtNK
            // 
            this.txtNK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsHP, "NIENKHOA", true));
            this.txtNK.Location = new System.Drawing.Point(875, 30);
            this.txtNK.MenuManager = this.barManager1;
            this.txtNK.Name = "txtNK";
            this.txtNK.Properties.ReadOnly = true;
            this.txtNK.Size = new System.Drawing.Size(100, 20);
            this.txtNK.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(613, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Thông tin sinh viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(252, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nhập mã sinh viên cần tìm:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(285, 36);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(121, 20);
            this.txtMaSV.TabIndex = 8;
            // 
            // cbMaSV
            // 
            this.cbMaSV.DataSource = this.bdsSV;
            this.cbMaSV.DisplayMember = "MASV";
            this.cbMaSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaSV.FormattingEnabled = true;
            this.cbMaSV.Location = new System.Drawing.Point(105, 14);
            this.cbMaSV.Name = "cbMaSV";
            this.cbMaSV.Size = new System.Drawing.Size(121, 21);
            this.cbMaSV.TabIndex = 7;
            this.cbMaSV.ValueMember = "MASV";
            this.cbMaSV.SelectedIndexChanged += new System.EventHandler(this.cbMaSV_SelectedIndexChanged);
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Location = new System.Drawing.Point(617, 62);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.ReadOnly = true;
            this.txtHoVaTen.Size = new System.Drawing.Size(121, 20);
            this.txtHoVaTen.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(539, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ho va ten:";
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(617, 36);
            this.txtLop.Name = "txtLop";
            this.txtLop.ReadOnly = true;
            this.txtLop.Size = new System.Drawing.Size(121, 20);
            this.txtLop.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(568, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lop:";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(303, 62);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // hOCPHITableAdapter
            // 
            this.hOCPHITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = this.hOCPHITableAdapter;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = PTQLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcHP
            // 
            this.gcHP.DataSource = this.bdsHP;
            this.gcHP.Dock = System.Windows.Forms.DockStyle.Left;
            this.gcHP.Location = new System.Drawing.Point(0, 135);
            this.gcHP.MainView = this.gvData;
            this.gcHP.MenuManager = this.barManager1;
            this.gcHP.Name = "gcHP";
            this.gcHP.Size = new System.Drawing.Size(596, 257);
            this.gcHP.TabIndex = 19;
            this.gcHP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // gvData
            // 
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colNIENKHOA,
            this.colHOCKY,
            this.colHOCPHI,
            this.colSOTIENDADONG});
            this.gvData.GridControl = this.gcHP;
            this.gvData.Name = "gvData";
            this.gvData.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.OptionsColumn.ReadOnly = true;
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.OptionsColumn.ReadOnly = true;
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 1;
            // 
            // colHOCKY
            // 
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.OptionsColumn.ReadOnly = true;
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 2;
            // 
            // colHOCPHI
            // 
            this.colHOCPHI.FieldName = "HOCPHI";
            this.colHOCPHI.Name = "colHOCPHI";
            this.colHOCPHI.OptionsColumn.ReadOnly = true;
            this.colHOCPHI.Visible = true;
            this.colHOCPHI.VisibleIndex = 3;
            // 
            // colSOTIENDADONG
            // 
            this.colSOTIENDADONG.FieldName = "SOTIENDADONG";
            this.colSOTIENDADONG.Name = "colSOTIENDADONG";
            this.colSOTIENDADONG.OptionsColumn.ReadOnly = true;
            this.colSOTIENDADONG.Visible = true;
            this.colSOTIENDADONG.VisibleIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(596, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(710, 40);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bảng học phí của sinh viên";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvHocPhi);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(596, 175);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(710, 217);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            // 
            // dgvHocPhi
            // 
            this.dgvHocPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocPhi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMaSinhVien,
            this.ColNK,
            this.ColHK,
            this.ColHP,
            this.ColSTDD});
            this.dgvHocPhi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHocPhi.Location = new System.Drawing.Point(3, 16);
            this.dgvHocPhi.Name = "dgvHocPhi";
            this.dgvHocPhi.Size = new System.Drawing.Size(704, 198);
            this.dgvHocPhi.TabIndex = 0;
            // 
            // ColMaSinhVien
            // 
            this.ColMaSinhVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColMaSinhVien.DataPropertyName = "MASV";
            this.ColMaSinhVien.HeaderText = "Mã sinh viên";
            this.ColMaSinhVien.Name = "ColMaSinhVien";
            this.ColMaSinhVien.ReadOnly = true;
            // 
            // ColNK
            // 
            this.ColNK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNK.DataPropertyName = "NIENKHOA";
            this.ColNK.HeaderText = "Niên khóa";
            this.ColNK.Name = "ColNK";
            this.ColNK.ReadOnly = true;
            // 
            // ColHK
            // 
            this.ColHK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColHK.DataPropertyName = "HOCKY";
            this.ColHK.HeaderText = "Học kỳ";
            this.ColHK.Name = "ColHK";
            this.ColHK.ReadOnly = true;
            // 
            // ColHP
            // 
            this.ColHP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColHP.DataPropertyName = "HOCPHI";
            this.ColHP.HeaderText = "Học phí";
            this.ColHP.Name = "ColHP";
            this.ColHP.ReadOnly = true;
            // 
            // ColSTDD
            // 
            this.ColSTDD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColSTDD.DataPropertyName = "SOTIENDADONG";
            this.ColSTDD.HeaderText = "Số tiền đã đóng";
            this.ColSTDD.Name = "ColSTDD";
            this.ColSTDD.ReadOnly = true;
            // 
            // FormHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 412);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gcHP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormHocPhi";
            this.Text = "FormHocPhi";
            this.Load += new System.EventHandler(this.FormHocPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSTDD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocPhi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnView;
        private DevExpress.XtraBars.BarButtonItem btnCancel;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsSV;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.ComboBox cbMaSV;
        private System.Windows.Forms.BindingSource bdsHP;
        private DSTableAdapters.HOCPHITableAdapter hOCPHITableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcHP;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCPHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENDADONG;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHocPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSTDD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudHK;
        private DevExpress.XtraEditors.TextEdit txtNK;
        private System.Windows.Forms.NumericUpDown nudSTDD;
        private System.Windows.Forms.NumericUpDown nudHP;
        private System.Windows.Forms.Label lbltest;
    }
}