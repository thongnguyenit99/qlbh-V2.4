﻿namespace Quan_Ly_Ban_Hang.GUI
{
    partial class UC_DanhSachPhieuCongNoPhaiChi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.grvctdspcn = new DevExpress.XtraGrid.GridControl();
            this.grvrootdspcn = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btndong = new DevExpress.XtraEditors.SimpleButton();
            this.btnxuat = new DevExpress.XtraEditors.SimpleButton();
            this.btnlapphieuchi = new DevExpress.XtraEditors.SimpleButton();
            this.btnxem = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbluachon = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txttungay = new DevExpress.XtraEditors.DateEdit();
            this.txtdenngay = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvctdspcn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvrootdspcn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbluachon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttungay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttungay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdenngay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdenngay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.grvctdspcn);
            this.layoutControl1.Controls.Add(this.btndong);
            this.layoutControl1.Controls.Add(this.btnxuat);
            this.layoutControl1.Controls.Add(this.btnlapphieuchi);
            this.layoutControl1.Controls.Add(this.btnxem);
            this.layoutControl1.Controls.Add(this.groupControl1);
            this.layoutControl1.Controls.Add(this.cbluachon);
            this.layoutControl1.Controls.Add(this.txttungay);
            this.layoutControl1.Controls.Add(this.txtdenngay);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1131, 372);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // grvctdspcn
            // 
            this.grvctdspcn.Location = new System.Drawing.Point(12, 63);
            this.grvctdspcn.MainView = this.grvrootdspcn;
            this.grvctdspcn.Name = "grvctdspcn";
            this.grvctdspcn.Size = new System.Drawing.Size(1107, 297);
            this.grvctdspcn.TabIndex = 21;
            this.grvctdspcn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvrootdspcn});
            // 
            // grvrootdspcn
            // 
            this.grvrootdspcn.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn6,
            this.gridColumn5,
            this.gridColumn7});
            this.grvrootdspcn.GridControl = this.grvctdspcn;
            this.grvrootdspcn.Name = "grvrootdspcn";
            this.grvrootdspcn.OptionsView.ShowAutoFilterRow = true;
            this.grvrootdspcn.OptionsView.ShowFooter = true;
            this.grvrootdspcn.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Chứng Từ";
            this.gridColumn1.FieldName = "ChungTu";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Ngày";
            this.gridColumn2.FieldName = "Ngay";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mã NCC";
            this.gridColumn3.FieldName = "MaNCC";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Nhà Cung Cấp";
            this.gridColumn4.FieldName = "NhaCungCap";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Số Tiền";
            this.gridColumn6.FieldName = "SoTien";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Diễn Giải";
            this.gridColumn5.FieldName = "DienGiai";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Nhà Cung Cấp";
            this.gridColumn7.FieldName = "NhaCungCap";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // btndong
            // 
            this.btndong.ImageOptions.Image = global::Quan_Ly_Ban_Hang.Properties.Resources.closeheaderandfooter_16x16;
            this.btndong.Location = new System.Drawing.Point(803, 37);
            this.btndong.Name = "btndong";
            this.btndong.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btndong.Size = new System.Drawing.Size(54, 22);
            this.btndong.StyleController = this.layoutControl1;
            this.btndong.TabIndex = 20;
            this.btndong.Text = "Đóng";
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnxuat
            // 
            this.btnxuat.ImageOptions.Image = global::Quan_Ly_Ban_Hang.Properties.Resources.pagecolor_16x16;
            this.btnxuat.Location = new System.Drawing.Point(749, 37);
            this.btnxuat.Name = "btnxuat";
            this.btnxuat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnxuat.Size = new System.Drawing.Size(50, 22);
            this.btnxuat.StyleController = this.layoutControl1;
            this.btnxuat.TabIndex = 19;
            this.btnxuat.Text = "Xuất";
            this.btnxuat.Click += new System.EventHandler(this.btnxuat_Click);
            // 
            // btnlapphieuchi
            // 
            this.btnlapphieuchi.ImageOptions.Image = global::Quan_Ly_Ban_Hang.Properties.Resources.report_16x16;
            this.btnlapphieuchi.Location = new System.Drawing.Point(653, 37);
            this.btnlapphieuchi.Name = "btnlapphieuchi";
            this.btnlapphieuchi.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnlapphieuchi.Size = new System.Drawing.Size(92, 22);
            this.btnlapphieuchi.StyleController = this.layoutControl1;
            this.btnlapphieuchi.TabIndex = 17;
            this.btnlapphieuchi.Text = "Lập Phiếu Chi";
            this.btnlapphieuchi.Click += new System.EventHandler(this.btnlapphieuchi_Click);
            // 
            // btnxem
            // 
            this.btnxem.ImageOptions.Image = global::Quan_Ly_Ban_Hang.Properties.Resources.zoom_16x162;
            this.btnxem.Location = new System.Drawing.Point(601, 37);
            this.btnxem.Name = "btnxem";
            this.btnxem.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnxem.Size = new System.Drawing.Size(48, 22);
            this.btnxem.StyleController = this.layoutControl1;
            this.btnxem.TabIndex = 14;
            this.btnxem.Text = "Xem";
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1107, 21);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Danh Sách Công Nợ Phải Chi";
            // 
            // cbluachon
            // 
            this.cbluachon.Location = new System.Drawing.Point(20, 37);
            this.cbluachon.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cbluachon.Name = "cbluachon";
            this.cbluachon.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbluachon.Properties.Appearance.Options.UseFont = true;
            this.cbluachon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbluachon.Size = new System.Drawing.Size(186, 20);
            this.cbluachon.StyleController = this.layoutControl1;
            this.cbluachon.TabIndex = 4;
            this.cbluachon.SelectedIndexChanged += new System.EventHandler(this.cbluachon_SelectedIndexChanged);
            // 
            // txttungay
            // 
            this.txttungay.EditValue = null;
            this.txttungay.Location = new System.Drawing.Point(228, 37);
            this.txttungay.Name = "txttungay";
            this.txttungay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txttungay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txttungay.Properties.DisplayFormat.FormatString = "";
            this.txttungay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txttungay.Properties.EditFormat.FormatString = "";
            this.txttungay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txttungay.Properties.Mask.EditMask = "";
            this.txttungay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txttungay.Size = new System.Drawing.Size(176, 20);
            this.txttungay.StyleController = this.layoutControl1;
            this.txttungay.TabIndex = 6;
            // 
            // txtdenngay
            // 
            this.txtdenngay.EditValue = null;
            this.txtdenngay.Location = new System.Drawing.Point(433, 37);
            this.txtdenngay.Name = "txtdenngay";
            this.txtdenngay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtdenngay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtdenngay.Properties.DisplayFormat.FormatString = "";
            this.txtdenngay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtdenngay.Properties.EditFormat.FormatString = "";
            this.txtdenngay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtdenngay.Properties.Mask.EditMask = "";
            this.txtdenngay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtdenngay.Size = new System.Drawing.Size(164, 20);
            this.txtdenngay.StyleController = this.layoutControl1;
            this.txtdenngay.TabIndex = 7;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.emptySpaceItem1,
            this.layoutControlItem9});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1131, 372);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(0, 25);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(5, 25);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1111, 25);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txttungay;
            this.layoutControlItem4.CustomizationFormText = "Từ";
            this.layoutControlItem4.Location = new System.Drawing.Point(198, 25);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(198, 26);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(198, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(198, 26);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "Từ";
            this.layoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(13, 13);
            this.layoutControlItem4.TextToControlDistance = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbluachon;
            this.layoutControlItem2.CustomizationFormText = " ";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 25);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(198, 26);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(198, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(198, 26);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = " ";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(3, 13);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnxem;
            this.layoutControlItem3.Location = new System.Drawing.Point(589, 25);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(52, 26);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(52, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(52, 26);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtdenngay;
            this.layoutControlItem5.CustomizationFormText = "Đến";
            this.layoutControlItem5.Location = new System.Drawing.Point(396, 25);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(193, 26);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(193, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(193, 26);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "Đến";
            this.layoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(20, 13);
            this.layoutControlItem5.TextToControlDistance = 5;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnlapphieuchi;
            this.layoutControlItem6.Location = new System.Drawing.Point(641, 25);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(96, 26);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(96, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(96, 26);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnxuat;
            this.layoutControlItem7.Location = new System.Drawing.Point(737, 25);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(54, 26);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(54, 26);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(54, 26);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btndong;
            this.layoutControlItem8.Location = new System.Drawing.Point(791, 25);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(58, 26);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(58, 26);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(58, 26);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(849, 25);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(262, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.grvctdspcn;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 51);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(1111, 301);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // UC_DanhSachPhieuCongNoPhaiChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "UC_DanhSachPhieuCongNoPhaiChi";
            this.Size = new System.Drawing.Size(1131, 372);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvctdspcn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvrootdspcn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbluachon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttungay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttungay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdenngay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdenngay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.ComboBoxEdit cbluachon;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.DateEdit txttungay;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.DateEdit txtdenngay;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton btnxem;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnlapphieuchi;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton btnxuat;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.SimpleButton btndong;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraGrid.GridControl grvctdspcn;
        private DevExpress.XtraGrid.Views.Grid.GridView grvrootdspcn;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
    }
}
