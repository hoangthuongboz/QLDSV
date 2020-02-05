namespace PTQLDSV
{
    partial class FormDiem
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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label lANLabel;
            System.Windows.Forms.Label dIEMLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label mASVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiem));
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtML = new System.Windows.Forms.TextBox();
            this.lblSV = new System.Windows.Forms.Label();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new PTQLDSV.DS();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lOPTableAdapter = new PTQLDSV.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new PTQLDSV.DSTableAdapters.TableAdapterManager();
            this.dIEMTableAdapter = new PTQLDSV.DSTableAdapters.DIEMTableAdapter();
            this.sINHVIENTableAdapter = new PTQLDSV.DSTableAdapters.SINHVIENTableAdapter();
            this.bdsSV = new System.Windows.Forms.BindingSource(this.components);
            this.bdsD = new System.Windows.Forms.BindingSource(this.components);
            this.gcDiem = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsMH = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new PTQLDSV.DSTableAdapters.MONHOCTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMalop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.cbMaSinhVien = new System.Windows.Forms.ComboBox();
            this.cbMaMonHoc = new System.Windows.Forms.ComboBox();
            this.bdsGMH = new System.Windows.Forms.BindingSource(this.components);
            this.nudDiem = new System.Windows.Forms.NumericUpDown();
            this.nudLanThi = new System.Windows.Forms.NumericUpDown();
            this.gETDSMONHOCTableAdapter = new PTQLDSV.DSTableAdapters.GETDSMONHOCTableAdapter();
            mALOPLabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            dIEMLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            mASVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLanThi)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(345, 15);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(28, 13);
            mALOPLabel.TabIndex = 2;
            mALOPLabel.Text = "Lớp:";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Location = new System.Drawing.Point(345, 79);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(31, 13);
            lANLabel.TabIndex = 4;
            lANLabel.Text = "LAN:";
            // 
            // dIEMLabel
            // 
            dIEMLabel.AutoSize = true;
            dIEMLabel.Location = new System.Drawing.Point(345, 129);
            dIEMLabel.Name = "dIEMLabel";
            dIEMLabel.Size = new System.Drawing.Size(37, 13);
            dIEMLabel.TabIndex = 6;
            dIEMLabel.Text = "DIEM:";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(133, 124);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(43, 13);
            mAMHLabel.TabIndex = 7;
            mAMHLabel.Text = "MAMH:";
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(136, 74);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(40, 13);
            mASVLabel.TabIndex = 8;
            mASVLabel.Text = "MASV:";
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
            this.btnUndo,
            this.btnReload,
            this.btnClose});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
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
            this.btnUndo.Id = 4;
            this.btnUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.Image")));
            this.btnUndo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.LargeImage")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Refresh";
            this.btnReload.Id = 5;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Thoát";
            this.btnClose.Id = 6;
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
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1224, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 468);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1224, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 444);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1224, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 444);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtML);
            this.groupBox1.Controls.Add(this.lblSV);
            this.groupBox1.Controls.Add(mALOPLabel);
            this.groupBox1.Controls.Add(this.cbLop);
            this.groupBox1.Controls.Add(this.cbKhoa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1224, 33);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // txtML
            // 
            this.txtML.Location = new System.Drawing.Point(570, 8);
            this.txtML.Name = "txtML";
            this.txtML.ReadOnly = true;
            this.txtML.Size = new System.Drawing.Size(100, 20);
            this.txtML.TabIndex = 5;
            // 
            // lblSV
            // 
            this.lblSV.AutoSize = true;
            this.lblSV.Location = new System.Drawing.Point(567, 14);
            this.lblSV.Name = "lblSV";
            this.lblSV.Size = new System.Drawing.Size(0, 13);
            this.lblSV.TabIndex = 4;
            // 
            // cbLop
            // 
            this.cbLop.DataSource = this.bdsLop;
            this.cbLop.DisplayMember = "MALOP";
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(409, 7);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(121, 21);
            this.cbLop.TabIndex = 3;
            this.cbLop.ValueMember = "MALOP";
            this.cbLop.SelectedIndexChanged += new System.EventHandler(this.cbLop_SelectedIndexChanged);
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbKhoa
            // 
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(115, 7);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(121, 21);
            this.cbKhoa.TabIndex = 1;
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khoa:";
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = this.dIEMTableAdapter;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = PTQLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dIEMTableAdapter
            // 
            this.dIEMTableAdapter.ClearBeforeFill = true;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // bdsSV
            // 
            this.bdsSV.DataMember = "FK_SINHVIEN_LOP";
            this.bdsSV.DataSource = this.bdsLop;
            // 
            // bdsD
            // 
            this.bdsD.DataMember = "FK_DIEM_SINHVIEN";
            this.bdsD.DataSource = this.bdsSV;
            // 
            // gcDiem
            // 
            this.gcDiem.DataSource = this.bdsD;
            this.gcDiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDiem.Location = new System.Drawing.Point(0, 57);
            this.gcDiem.MainView = this.gvData;
            this.gcDiem.MenuManager = this.barManager1;
            this.gcDiem.Name = "gcDiem";
            this.gcDiem.Size = new System.Drawing.Size(1224, 220);
            this.gcDiem.TabIndex = 5;
            this.gcDiem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // gvData
            // 
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colMAMH,
            this.colLAN,
            this.colDIEM});
            this.gvData.GridControl = this.gcDiem;
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
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.ReadOnly = true;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 1;
            // 
            // colLAN
            // 
            this.colLAN.FieldName = "LAN";
            this.colLAN.Name = "colLAN";
            this.colLAN.OptionsColumn.ReadOnly = true;
            this.colLAN.Visible = true;
            this.colLAN.VisibleIndex = 2;
            // 
            // colDIEM
            // 
            this.colDIEM.FieldName = "DIEM";
            this.colDIEM.Name = "colDIEM";
            this.colDIEM.OptionsColumn.ReadOnly = true;
            this.colDIEM.Visible = true;
            this.colDIEM.VisibleIndex = 3;
            // 
            // bdsMH
            // 
            this.bdsMH.DataMember = "MONHOC";
            this.bdsMH.DataSource = this.dS;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(mASVLabel);
            this.groupBox2.Controls.Add(this.cbMaSinhVien);
            this.groupBox2.Controls.Add(mAMHLabel);
            this.groupBox2.Controls.Add(this.cbMaMonHoc);
            this.groupBox2.Controls.Add(dIEMLabel);
            this.groupBox2.Controls.Add(this.nudDiem);
            this.groupBox2.Controls.Add(lANLabel);
            this.groupBox2.Controls.Add(this.nudLanThi);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1224, 191);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtMalop);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtMaSinhVien);
            this.groupBox3.Controls.Add(this.btnView);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(553, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(668, 172);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(166, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tra cứu thông tin";
            // 
            // txtMalop
            // 
            this.txtMalop.Location = new System.Drawing.Point(89, 63);
            this.txtMalop.Name = "txtMalop";
            this.txtMalop.Size = new System.Drawing.Size(121, 20);
            this.txtMalop.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã sinh viên:";
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Location = new System.Drawing.Point(346, 63);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(120, 20);
            this.txtMaSinhVien.TabIndex = 13;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(223, 123);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 14;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // cbMaSinhVien
            // 
            this.cbMaSinhVien.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsD, "MASV", true));
            this.cbMaSinhVien.DataSource = this.bdsSV;
            this.cbMaSinhVien.DisplayMember = "MASV";
            this.cbMaSinhVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaSinhVien.FormattingEnabled = true;
            this.cbMaSinhVien.Location = new System.Drawing.Point(182, 71);
            this.cbMaSinhVien.Name = "cbMaSinhVien";
            this.cbMaSinhVien.Size = new System.Drawing.Size(121, 21);
            this.cbMaSinhVien.TabIndex = 9;
            this.cbMaSinhVien.ValueMember = "MASV";
            this.cbMaSinhVien.SelectedIndexChanged += new System.EventHandler(this.cbMaSinhVien_SelectedIndexChanged);
            // 
            // cbMaMonHoc
            // 
            this.cbMaMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsD, "MAMH", true));
            this.cbMaMonHoc.DataSource = this.bdsGMH;
            this.cbMaMonHoc.DisplayMember = "MAMH";
            this.cbMaMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaMonHoc.FormattingEnabled = true;
            this.cbMaMonHoc.Location = new System.Drawing.Point(182, 121);
            this.cbMaMonHoc.Name = "cbMaMonHoc";
            this.cbMaMonHoc.Size = new System.Drawing.Size(121, 21);
            this.cbMaMonHoc.TabIndex = 8;
            this.cbMaMonHoc.ValueMember = "MAMH";
            this.cbMaMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbMaMonHoc_SelectedIndexChanged);
            // 
            // bdsGMH
            // 
            this.bdsGMH.DataMember = "GETDSMONHOC";
            this.bdsGMH.DataSource = this.dS;
            // 
            // nudDiem
            // 
            this.nudDiem.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsD, "DIEM", true));
            this.nudDiem.DecimalPlaces = 2;
            this.nudDiem.Location = new System.Drawing.Point(392, 122);
            this.nudDiem.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDiem.Name = "nudDiem";
            this.nudDiem.ReadOnly = true;
            this.nudDiem.Size = new System.Drawing.Size(120, 20);
            this.nudDiem.TabIndex = 7;
            // 
            // nudLanThi
            // 
            this.nudLanThi.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsD, "LAN", true));
            this.nudLanThi.Location = new System.Drawing.Point(392, 72);
            this.nudLanThi.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudLanThi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLanThi.Name = "nudLanThi";
            this.nudLanThi.ReadOnly = true;
            this.nudLanThi.Size = new System.Drawing.Size(120, 20);
            this.nudLanThi.TabIndex = 5;
            this.nudLanThi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gETDSMONHOCTableAdapter
            // 
            this.gETDSMONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // FormDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 488);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gcDiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormDiem";
            this.Text = "FormDiem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLanThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private System.Windows.Forms.BindingSource bdsLop;
        private DS dS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label label1;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbLop;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource bdsSV;
        private DSTableAdapters.DIEMTableAdapter dIEMTableAdapter;
        private System.Windows.Forms.BindingSource bdsD;
        private DevExpress.XtraGrid.GridControl gcDiem;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colLAN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM;
        private System.Windows.Forms.BindingSource bdsMH;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.Label lblSV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudDiem;
        private System.Windows.Forms.NumericUpDown nudLanThi;
        private System.Windows.Forms.BindingSource bdsGMH;
        private DSTableAdapters.GETDSMONHOCTableAdapter gETDSMONHOCTableAdapter;
        private System.Windows.Forms.ComboBox cbMaMonHoc;
        private System.Windows.Forms.ComboBox cbMaSinhVien;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMalop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtML;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
    }
}