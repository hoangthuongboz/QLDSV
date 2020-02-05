namespace PTQLDSV
{
    partial class FormSinhVien
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
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label mALOPLabel1;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label nOISINHLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label gHICHULabel;
            System.Windows.Forms.Label nGHIHOCLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSinhVien));
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
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new PTQLDSV.DS();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lOPTableAdapter = new PTQLDSV.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new PTQLDSV.DSTableAdapters.TableAdapterManager();
            this.dIEMTableAdapter = new PTQLDSV.DSTableAdapters.DIEMTableAdapter();
            this.hOCPHITableAdapter = new PTQLDSV.DSTableAdapters.HOCPHITableAdapter();
            this.sINHVIENTableAdapter = new PTQLDSV.DSTableAdapters.SINHVIENTableAdapter();
            this.bdsSV = new System.Windows.Forms.BindingSource(this.components);
            this.gcSV = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOISINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGHICHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGHIHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsHP = new System.Windows.Forms.BindingSource(this.components);
            this.bdsD = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkNghiHoc = new System.Windows.Forms.CheckBox();
            this.txtNote = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtNoiSinh = new DevExpress.XtraEditors.TextEdit();
            this.dateNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.checkPhai = new System.Windows.Forms.CheckBox();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSV = new DevExpress.XtraEditors.TextEdit();
            mASVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            mALOPLabel1 = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            nOISINHLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            gHICHULabel = new System.Windows.Forms.Label();
            nGHIHOCLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsD)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiSinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(80, 50);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(40, 13);
            mASVLabel.TabIndex = 0;
            mASVLabel.Text = "MASV:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(295, 48);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(26, 13);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(560, 46);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(32, 13);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TEN:";
            // 
            // mALOPLabel1
            // 
            mALOPLabel1.AutoSize = true;
            mALOPLabel1.Location = new System.Drawing.Point(779, 46);
            mALOPLabel1.Name = "mALOPLabel1";
            mALOPLabel1.Size = new System.Drawing.Size(47, 13);
            mALOPLabel1.TabIndex = 6;
            mALOPLabel1.Text = "MALOP:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(85, 103);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(35, 13);
            pHAILabel.TabIndex = 8;
            pHAILabel.Text = "PHAI:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(255, 103);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(66, 13);
            nGAYSINHLabel.TabIndex = 10;
            nGAYSINHLabel.Text = "NGAYSINH:";
            // 
            // nOISINHLabel
            // 
            nOISINHLabel.AutoSize = true;
            nOISINHLabel.Location = new System.Drawing.Point(537, 100);
            nOISINHLabel.Name = "nOISINHLabel";
            nOISINHLabel.Size = new System.Drawing.Size(55, 13);
            nOISINHLabel.TabIndex = 12;
            nOISINHLabel.Text = "NOISINH:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(780, 100);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(46, 13);
            dIACHILabel.TabIndex = 14;
            dIACHILabel.Text = "DIACHI:";
            // 
            // gHICHULabel
            // 
            gHICHULabel.AutoSize = true;
            gHICHULabel.Location = new System.Drawing.Point(269, 153);
            gHICHULabel.Name = "gHICHULabel";
            gHICHULabel.Size = new System.Drawing.Size(52, 13);
            gHICHULabel.TabIndex = 16;
            gHICHULabel.Text = "GHICHU:";
            // 
            // nGHIHOCLabel
            // 
            nGHIHOCLabel.AutoSize = true;
            nGHIHOCLabel.Location = new System.Drawing.Point(532, 149);
            nGHIHOCLabel.Name = "nGHIHOCLabel";
            nGHIHOCLabel.Size = new System.Drawing.Size(60, 13);
            nGHIHOCLabel.TabIndex = 18;
            nGHIHOCLabel.Text = "NGHIHOC:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(391, 9);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(55, 15);
            mALOPLabel.TabIndex = 2;
            mALOPLabel.Text = "MALOP:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1035, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 711);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1035, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 687);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1035, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 687);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(mALOPLabel);
            this.groupBox1.Controls.Add(this.cbLop);
            this.groupBox1.Controls.Add(this.cbKhoa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1035, 28);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // cbLop
            // 
            this.cbLop.DataSource = this.bdsLop;
            this.cbLop.DisplayMember = "TENLOP";
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(452, 5);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(140, 23);
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
            this.cbKhoa.Location = new System.Drawing.Point(122, 6);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(138, 23);
            this.cbKhoa.TabIndex = 1;
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
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
            this.tableAdapterManager.HOCPHITableAdapter = this.hOCPHITableAdapter;
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
            // hOCPHITableAdapter
            // 
            this.hOCPHITableAdapter.ClearBeforeFill = true;
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
            // gcSV
            // 
            this.gcSV.DataSource = this.bdsSV;
            this.gcSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcSV.Location = new System.Drawing.Point(0, 52);
            this.gcSV.MainView = this.gvData;
            this.gcSV.MenuManager = this.barManager1;
            this.gcSV.Name = "gcSV";
            this.gcSV.Size = new System.Drawing.Size(1035, 220);
            this.gcSV.TabIndex = 29;
            this.gcSV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // gvData
            // 
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colMALOP,
            this.colPHAI,
            this.colNGAYSINH,
            this.colNOISINH,
            this.colDIACHI,
            this.colGHICHU,
            this.colNGHIHOC});
            this.gvData.GridControl = this.gcSV;
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
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.ReadOnly = true;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.ReadOnly = true;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.OptionsColumn.ReadOnly = true;
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 3;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.OptionsColumn.ReadOnly = true;
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.OptionsColumn.ReadOnly = true;
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 5;
            // 
            // colNOISINH
            // 
            this.colNOISINH.FieldName = "NOISINH";
            this.colNOISINH.Name = "colNOISINH";
            this.colNOISINH.OptionsColumn.ReadOnly = true;
            this.colNOISINH.Visible = true;
            this.colNOISINH.VisibleIndex = 6;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.ReadOnly = true;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 7;
            // 
            // colGHICHU
            // 
            this.colGHICHU.FieldName = "GHICHU";
            this.colGHICHU.Name = "colGHICHU";
            this.colGHICHU.OptionsColumn.ReadOnly = true;
            this.colGHICHU.Visible = true;
            this.colGHICHU.VisibleIndex = 8;
            // 
            // colNGHIHOC
            // 
            this.colNGHIHOC.FieldName = "NGHIHOC";
            this.colNGHIHOC.Name = "colNGHIHOC";
            this.colNGHIHOC.OptionsColumn.ReadOnly = true;
            this.colNGHIHOC.Visible = true;
            this.colNGHIHOC.VisibleIndex = 9;
            // 
            // bdsHP
            // 
            this.bdsHP.DataMember = "FK_HOCPHI_SINHVIEN";
            this.bdsHP.DataSource = this.bdsSV;
            // 
            // bdsD
            // 
            this.bdsD.DataMember = "FK_DIEM_SINHVIEN";
            this.bdsD.DataSource = this.bdsSV;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(nGHIHOCLabel);
            this.groupBox2.Controls.Add(this.checkNghiHoc);
            this.groupBox2.Controls.Add(gHICHULabel);
            this.groupBox2.Controls.Add(this.txtNote);
            this.groupBox2.Controls.Add(dIACHILabel);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(nOISINHLabel);
            this.groupBox2.Controls.Add(this.txtNoiSinh);
            this.groupBox2.Controls.Add(nGAYSINHLabel);
            this.groupBox2.Controls.Add(this.dateNgaySinh);
            this.groupBox2.Controls.Add(pHAILabel);
            this.groupBox2.Controls.Add(this.checkPhai);
            this.groupBox2.Controls.Add(mALOPLabel1);
            this.groupBox2.Controls.Add(this.txtMaLop);
            this.groupBox2.Controls.Add(tENLabel);
            this.groupBox2.Controls.Add(this.txtTen);
            this.groupBox2.Controls.Add(hOLabel);
            this.groupBox2.Controls.Add(this.txtHo);
            this.groupBox2.Controls.Add(mASVLabel);
            this.groupBox2.Controls.Add(this.txtMaSV);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1035, 378);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // checkNghiHoc
            // 
            this.checkNghiHoc.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bdsSV, "NGHIHOC", true));
            this.checkNghiHoc.Location = new System.Drawing.Point(616, 142);
            this.checkNghiHoc.Name = "checkNghiHoc";
            this.checkNghiHoc.Size = new System.Drawing.Size(104, 24);
            this.checkNghiHoc.TabIndex = 19;
            this.checkNghiHoc.UseVisualStyleBackColor = true;
            // 
            // txtNote
            // 
            this.txtNote.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "GHICHU", true));
            this.txtNote.Location = new System.Drawing.Point(334, 146);
            this.txtNote.MenuManager = this.barManager1;
            this.txtNote.Name = "txtNote";
            this.txtNote.Properties.ReadOnly = true;
            this.txtNote.Size = new System.Drawing.Size(100, 20);
            this.txtNote.TabIndex = 17;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(841, 97);
            this.txtDiaChi.MenuManager = this.barManager1;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(100, 20);
            this.txtDiaChi.TabIndex = 15;
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "NOISINH", true));
            this.txtNoiSinh.Location = new System.Drawing.Point(616, 97);
            this.txtNoiSinh.MenuManager = this.barManager1;
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Properties.ReadOnly = true;
            this.txtNoiSinh.Size = new System.Drawing.Size(100, 20);
            this.txtNoiSinh.TabIndex = 13;
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "NGAYSINH", true));
            this.dateNgaySinh.EditValue = null;
            this.dateNgaySinh.Location = new System.Drawing.Point(334, 97);
            this.dateNgaySinh.MenuManager = this.barManager1;
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgaySinh.Properties.ReadOnly = true;
            this.dateNgaySinh.Size = new System.Drawing.Size(100, 20);
            this.dateNgaySinh.TabIndex = 11;
            // 
            // checkPhai
            // 
            this.checkPhai.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bdsSV, "PHAI", true));
            this.checkPhai.Location = new System.Drawing.Point(131, 98);
            this.checkPhai.Name = "checkPhai";
            this.checkPhai.Size = new System.Drawing.Size(104, 24);
            this.checkPhai.TabIndex = 9;
            this.checkPhai.Text = "Nam";
            this.checkPhai.UseVisualStyleBackColor = true;
            // 
            // txtMaLop
            // 
            this.txtMaLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "MALOP", true));
            this.txtMaLop.Location = new System.Drawing.Point(841, 43);
            this.txtMaLop.MenuManager = this.barManager1;
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Properties.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(100, 20);
            this.txtMaLop.TabIndex = 7;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(616, 43);
            this.txtTen.MenuManager = this.barManager1;
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.ReadOnly = true;
            this.txtTen.Size = new System.Drawing.Size(100, 20);
            this.txtTen.TabIndex = 5;
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "HO", true));
            this.txtHo.Location = new System.Drawing.Point(334, 43);
            this.txtHo.MenuManager = this.barManager1;
            this.txtHo.Name = "txtHo";
            this.txtHo.Properties.ReadOnly = true;
            this.txtHo.Size = new System.Drawing.Size(100, 20);
            this.txtHo.TabIndex = 3;
            // 
            // txtMaSV
            // 
            this.txtMaSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "MASV", true));
            this.txtMaSV.Location = new System.Drawing.Point(132, 43);
            this.txtMaSV.MenuManager = this.barManager1;
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Properties.ReadOnly = true;
            this.txtMaSV.Size = new System.Drawing.Size(100, 20);
            this.txtMaSV.TabIndex = 1;
            // 
            // FormSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 731);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gcSV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormSinhVien";
            this.Text = "FormSinhVien";
            this.Load += new System.EventHandler(this.FormSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsD)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiSinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bdsLop;
        private DS dS;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource bdsSV;
        private DevExpress.XtraGrid.GridControl gcSV;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colNOISINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colGHICHU;
        private DevExpress.XtraGrid.Columns.GridColumn colNGHIHOC;
        private DSTableAdapters.HOCPHITableAdapter hOCPHITableAdapter;
        private System.Windows.Forms.BindingSource bdsHP;
        private DSTableAdapters.DIEMTableAdapter dIEMTableAdapter;
        private System.Windows.Forms.BindingSource bdsD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkNghiHoc;
        private DevExpress.XtraEditors.TextEdit txtNote;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtNoiSinh;
        private DevExpress.XtraEditors.DateEdit dateNgaySinh;
        private System.Windows.Forms.CheckBox checkPhai;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private DevExpress.XtraEditors.TextEdit txtMaSV;
        private System.Windows.Forms.ComboBox cbLop;
    }
}