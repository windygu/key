﻿namespace YindanSoft.Emr.QcManagerNew
{
    partial class QC_ScoreRecord
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
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonReset = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textEditPatID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dateEditEndInTime = new DevExpress.XtraEditors.DateEdit();
            this.dateEditBeginInTime = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEditorDepartment = new YidanSoft.Common.Library.LookUpEditor();
            this.lookUpWindowDepartment = new YidanSoft.Common.Library.LookUpWindow(this.components);
            this.labelControlInfo = new DevExpress.XtraEditors.LabelControl();
            this.labPatCount = new DevExpress.XtraEditors.LabelControl();
            this.labelControlTotalPats = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPatID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEndInTime.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEndInTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBeginInTime.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBeginInTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditorDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpWindowDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 70);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1195, 552);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.TabStop = false;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Green;
            this.gridView1.Appearance.ViewCaption.Options.UseForeColor = true;
            this.gridView1.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridView1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn8,
            this.gridColumn1,
            this.gridColumn5,
            this.gridColumn3,
            this.gridColumn6,
            this.gridColumn4,
            this.gridColumn10,
            this.gridColumn2});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 40;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView1.OptionsFilter.AllowFilterEditor = false;
            this.gridView1.OptionsFilter.AllowMRUFilterList = false;
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "  质控评分记录统计";
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.Caption = "科室";
            this.gridColumn8.FieldName = "DEPTNAME";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "住院号";
            this.gridColumn1.FieldName = "PATID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.Caption = "患者姓名";
            this.gridColumn5.FieldName = "IPNAME";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.Caption = "质控类型";
            this.gridColumn3.FieldName = "QCTYPE";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 93;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.Caption = "名称";
            this.gridColumn6.FieldName = "RECORDNAME";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 300;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.Caption = "入院日期";
            this.gridColumn4.FieldName = "INWARDDATE";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            this.gridColumn4.Width = 120;
            // 
            // gridColumn10
            // 
            this.gridColumn10.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gridColumn10.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn10.Caption = "分数";
            this.gridColumn10.FieldName = "SCORE";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 6;
            this.gridColumn10.Width = 50;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.Caption = "质控医生";
            this.gridColumn2.FieldName = "CREATEUSERNAME";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 7;
            this.gridColumn2.Width = 100;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.comboBox1);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.simpleButtonReset);
            this.panelControl1.Controls.Add(this.btnPrint);
            this.panelControl1.Controls.Add(this.btnExport);
            this.panelControl1.Controls.Add(this.textEditName);
            this.panelControl1.Controls.Add(this.textEditPatID);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.dateEditEndInTime);
            this.panelControl1.Controls.Add(this.dateEditBeginInTime);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.btnQuery);
            this.panelControl1.Controls.Add(this.lookUpEditorDepartment);
            this.panelControl1.Controls.Add(this.labelControlInfo);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1195, 70);
            this.panelControl1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "环节质控",
            "终末质控"});
            this.comboBox1.Location = new System.Drawing.Point(520, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 20);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(455, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "质控类型：";
            // 
            // simpleButtonReset
            // 
            this.simpleButtonReset.Image = global::YindanSoft.Emr.QcManagerNew.Properties.Resources.重置;
            this.simpleButtonReset.Location = new System.Drawing.Point(784, 21);
            this.simpleButtonReset.Name = "simpleButtonReset";
            this.simpleButtonReset.Size = new System.Drawing.Size(80, 27);
            this.simpleButtonReset.TabIndex = 10;
            this.simpleButtonReset.Text = "重置(&B)";
            this.simpleButtonReset.Click += new System.EventHandler(this.simpleButtonReset_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::YindanSoft.Emr.QcManagerNew.Properties.Resources.打印;
            this.btnPrint.Location = new System.Drawing.Point(868, 21);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 27);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "打印(&P)";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExport
            // 
            this.btnExport.Image = global::YindanSoft.Emr.QcManagerNew.Properties.Resources.导出;
            this.btnExport.Location = new System.Drawing.Point(952, 21);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(80, 27);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "导出(&I)";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // textEditName
            // 
            this.textEditName.Location = new System.Drawing.Point(519, 11);
            this.textEditName.Name = "textEditName";
            this.textEditName.Properties.ContextMenuStrip = this.contextMenuStrip;
            this.textEditName.Size = new System.Drawing.Size(120, 21);
            this.textEditName.TabIndex = 2;
            this.textEditName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // textEditPatID
            // 
            this.textEditPatID.Location = new System.Drawing.Point(318, 11);
            this.textEditPatID.Name = "textEditPatID";
            this.textEditPatID.Properties.ContextMenuStrip = this.contextMenuStrip;
            this.textEditPatID.Size = new System.Drawing.Size(120, 21);
            this.textEditPatID.TabIndex = 1;
            this.textEditPatID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(455, 14);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 14);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "患者姓名：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(269, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "住院号：";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(272, 39);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(12, 14);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "至";
            // 
            // dateEditEndInTime
            // 
            this.dateEditEndInTime.EditValue = null;
            this.dateEditEndInTime.Location = new System.Drawing.Point(318, 36);
            this.dateEditEndInTime.Name = "dateEditEndInTime";
            this.dateEditEndInTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditEndInTime.Properties.ContextMenuStrip = this.contextMenuStrip;
            this.dateEditEndInTime.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateEditEndInTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEditEndInTime.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateEditEndInTime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEditEndInTime.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEditEndInTime.Size = new System.Drawing.Size(120, 21);
            this.dateEditEndInTime.TabIndex = 4;
            this.dateEditEndInTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // dateEditBeginInTime
            // 
            this.dateEditBeginInTime.EditValue = null;
            this.dateEditBeginInTime.Location = new System.Drawing.Point(88, 36);
            this.dateEditBeginInTime.Name = "dateEditBeginInTime";
            this.dateEditBeginInTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditBeginInTime.Properties.ContextMenuStrip = this.contextMenuStrip;
            this.dateEditBeginInTime.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateEditBeginInTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEditBeginInTime.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateEditBeginInTime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEditBeginInTime.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEditBeginInTime.Size = new System.Drawing.Size(150, 21);
            this.dateEditBeginInTime.TabIndex = 3;
            this.dateEditBeginInTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(24, 39);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 14);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "入院日期：";
            // 
            // btnQuery
            // 
            this.btnQuery.Image = global::YindanSoft.Emr.QcManagerNew.Properties.Resources.查询;
            this.btnQuery.Location = new System.Drawing.Point(700, 21);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(80, 27);
            this.btnQuery.TabIndex = 9;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lookUpEditorDepartment
            // 
            this.lookUpEditorDepartment.Kind = YidanSoft.Wordbook.WordbookKind.Sql;
            this.lookUpEditorDepartment.ListWindow = this.lookUpWindowDepartment;
            this.lookUpEditorDepartment.Location = new System.Drawing.Point(88, 11);
            this.lookUpEditorDepartment.Name = "lookUpEditorDepartment";
            this.lookUpEditorDepartment.ShowSButton = true;
            this.lookUpEditorDepartment.Size = new System.Drawing.Size(150, 20);
            this.lookUpEditorDepartment.TabIndex = 0;
            this.lookUpEditorDepartment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // lookUpWindowDepartment
            // 
            this.lookUpWindowDepartment.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lookUpWindowDepartment.GenShortCode = null;
            this.lookUpWindowDepartment.MatchType = YidanSoft.Common.Library.ShowListMatchType.Full;
            this.lookUpWindowDepartment.Owner = null;
            this.lookUpWindowDepartment.SqlHelper = null;
            // 
            // labelControlInfo
            // 
            this.labelControlInfo.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.labelControlInfo.Location = new System.Drawing.Point(49, 14);
            this.labelControlInfo.Name = "labelControlInfo";
            this.labelControlInfo.Size = new System.Drawing.Size(36, 14);
            this.labelControlInfo.TabIndex = 11;
            this.labelControlInfo.Text = "科室：";
            // 
            // labPatCount
            // 
            this.labPatCount.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labPatCount.Location = new System.Drawing.Point(77, 600);
            this.labPatCount.Name = "labPatCount";
            this.labPatCount.Size = new System.Drawing.Size(24, 14);
            this.labPatCount.TabIndex = 33;
            this.labPatCount.Text = "记录";
            // 
            // labelControlTotalPats
            // 
            this.labelControlTotalPats.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControlTotalPats.Location = new System.Drawing.Point(26, 600);
            this.labelControlTotalPats.Name = "labelControlTotalPats";
            this.labelControlTotalPats.Size = new System.Drawing.Size(40, 14);
            this.labelControlTotalPats.TabIndex = 32;
            this.labelControlTotalPats.Text = "评分项:";
            // 
            // QC_ScoreRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labPatCount);
            this.Controls.Add(this.labelControlTotalPats);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "QC_ScoreRecord";
            this.Size = new System.Drawing.Size(1195, 622);
            this.Load += new System.EventHandler(this.OutMedicalScore_Load);
            this.SizeChanged += new System.EventHandler(this.OutMedicalScore_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPatID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEndInTime.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditEndInTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBeginInTime.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBeginInTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditorDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpWindowDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private YidanSoft.Common.Library.LookUpEditor lookUpEditorDepartment;
        private YidanSoft.Common.Library.LookUpWindow lookUpWindowDepartment;
        private DevExpress.XtraEditors.LabelControl labelControlInfo;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit dateEditEndInTime;
        private DevExpress.XtraEditors.DateEdit dateEditBeginInTime;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEditName;
        private DevExpress.XtraEditors.TextEdit textEditPatID;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton simpleButtonReset;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private DevExpress.XtraEditors.LabelControl labPatCount;
        private DevExpress.XtraEditors.LabelControl labelControlTotalPats;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}
