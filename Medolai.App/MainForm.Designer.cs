namespace Medolai.App
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            goodsView = new DevExpress.XtraGrid.Views.Card.CardView();
            gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridManControl = new DevExpress.XtraGrid.GridControl();
            gtdDeclarationGridRowBindingSource = new BindingSource(components);
            gridMainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            colDeclarationType = new DevExpress.XtraGrid.Columns.GridColumn();
            colImporterName = new DevExpress.XtraGrid.Columns.GridColumn();
            colImporterAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            colImporterPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            colImporterEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            colExporterName = new DevExpress.XtraGrid.Columns.GridColumn();
            colTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            colGoodsCount = new DevExpress.XtraGrid.Columns.GridColumn();
            colGoodsSummary = new DevExpress.XtraGrid.Columns.GridColumn();
            colDocumentsSummary = new DevExpress.XtraGrid.Columns.GridColumn();
            colPaymentsSummary = new DevExpress.XtraGrid.Columns.GridColumn();
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barLoadFileBtn = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            gtdGoodsGridRowBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)goodsView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridManControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gtdDeclarationGridRowBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridMainView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gtdGoodsGridRowBindingSource).BeginInit();
            SuspendLayout();
            // 
            // goodsView
            // 
            goodsView.AccessibleName = "";
            goodsView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn6, gridColumn1, gridColumn2, gridColumn3, gridColumn4, gridColumn5, gridColumn7, gridColumn8 });
            goodsView.GridControl = gridManControl;
            goodsView.Name = "goodsView";
            goodsView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // gridColumn6
            // 
            gridColumn6.FieldName = "Id";
            gridColumn6.Name = "gridColumn6";
            gridColumn6.Visible = true;
            gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn1
            // 
            gridColumn1.FieldName = "ItemNo";
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            gridColumn2.FieldName = "HsCode";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            gridColumn3.FieldName = "Name";
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            gridColumn4.FieldName = "Quantity";
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            gridColumn5.FieldName = "WeightOrParam";
            gridColumn5.Name = "gridColumn5";
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            gridColumn7.FieldName = "PaymentsSummary";
            gridColumn7.Name = "gridColumn7";
            gridColumn7.Visible = true;
            gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            gridColumn8.FieldName = "DocumentsSummary";
            gridColumn8.Name = "gridColumn8";
            gridColumn8.Visible = true;
            gridColumn8.VisibleIndex = 7;
            // 
            // gridManControl
            // 
            gridManControl.DataSource = gtdDeclarationGridRowBindingSource;
            gridManControl.Dock = DockStyle.Fill;
            gridLevelNode1.LevelTemplate = goodsView;
            gridLevelNode1.RelationName = "Level1";
            gridManControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] { gridLevelNode1 });
            gridManControl.Location = new Point(0, 158);
            gridManControl.MainView = gridMainView;
            gridManControl.MenuManager = ribbon;
            gridManControl.Name = "gridManControl";
            gridManControl.Size = new Size(1354, 659);
            gridManControl.TabIndex = 2;
            gridManControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridMainView, goodsView });
            gridManControl.Load += gridManControl_Load;
            // 
            // gtdDeclarationGridRowBindingSource
            // 
            gtdDeclarationGridRowBindingSource.DataSource = typeof(Shared.Models.GtdDeclarationGridRow);
            // 
            // gridMainView
            // 
            gridMainView.ChildGridLevelName = "goodsView";
            gridMainView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colDeclarationType, colImporterName, colImporterAddress, colImporterPhone, colImporterEmail, colExporterName, colTotalAmount, colGoodsCount, colGoodsSummary, colDocumentsSummary, colPaymentsSummary });
            gridMainView.GridControl = gridManControl;
            gridMainView.Name = "gridMainView";
            // 
            // colId
            // 
            colId.FieldName = "Id";
            colId.Name = "colId";
            colId.OptionsColumn.AllowEdit = false;
            colId.Visible = true;
            colId.VisibleIndex = 0;
            // 
            // colDeclarationType
            // 
            colDeclarationType.FieldName = "DeclarationType";
            colDeclarationType.Name = "colDeclarationType";
            colDeclarationType.OptionsColumn.AllowEdit = false;
            colDeclarationType.Visible = true;
            colDeclarationType.VisibleIndex = 1;
            // 
            // colImporterName
            // 
            colImporterName.FieldName = "ImporterName";
            colImporterName.Name = "colImporterName";
            colImporterName.OptionsColumn.AllowEdit = false;
            colImporterName.Visible = true;
            colImporterName.VisibleIndex = 2;
            // 
            // colImporterAddress
            // 
            colImporterAddress.FieldName = "ImporterAddress";
            colImporterAddress.Name = "colImporterAddress";
            colImporterAddress.OptionsColumn.AllowEdit = false;
            colImporterAddress.Visible = true;
            colImporterAddress.VisibleIndex = 3;
            // 
            // colImporterPhone
            // 
            colImporterPhone.FieldName = "ImporterPhone";
            colImporterPhone.Name = "colImporterPhone";
            colImporterPhone.OptionsColumn.AllowEdit = false;
            colImporterPhone.Visible = true;
            colImporterPhone.VisibleIndex = 4;
            // 
            // colImporterEmail
            // 
            colImporterEmail.FieldName = "ImporterEmail";
            colImporterEmail.Name = "colImporterEmail";
            colImporterEmail.OptionsColumn.AllowEdit = false;
            colImporterEmail.Visible = true;
            colImporterEmail.VisibleIndex = 5;
            // 
            // colExporterName
            // 
            colExporterName.FieldName = "ExporterName";
            colExporterName.Name = "colExporterName";
            colExporterName.OptionsColumn.AllowEdit = false;
            colExporterName.Visible = true;
            colExporterName.VisibleIndex = 6;
            // 
            // colTotalAmount
            // 
            colTotalAmount.FieldName = "TotalAmount";
            colTotalAmount.Name = "colTotalAmount";
            colTotalAmount.OptionsColumn.AllowEdit = false;
            colTotalAmount.Visible = true;
            colTotalAmount.VisibleIndex = 7;
            // 
            // colGoodsCount
            // 
            colGoodsCount.FieldName = "GoodsCount";
            colGoodsCount.Name = "colGoodsCount";
            colGoodsCount.OptionsColumn.AllowEdit = false;
            colGoodsCount.Visible = true;
            colGoodsCount.VisibleIndex = 8;
            // 
            // colGoodsSummary
            // 
            colGoodsSummary.FieldName = "GoodsSummary";
            colGoodsSummary.Name = "colGoodsSummary";
            colGoodsSummary.OptionsColumn.AllowEdit = false;
            colGoodsSummary.Visible = true;
            colGoodsSummary.VisibleIndex = 9;
            // 
            // colDocumentsSummary
            // 
            colDocumentsSummary.FieldName = "DocumentsSummary";
            colDocumentsSummary.Name = "colDocumentsSummary";
            colDocumentsSummary.OptionsColumn.AllowEdit = false;
            colDocumentsSummary.Visible = true;
            colDocumentsSummary.VisibleIndex = 10;
            // 
            // colPaymentsSummary
            // 
            colPaymentsSummary.FieldName = "PaymentsSummary";
            colPaymentsSummary.Name = "colPaymentsSummary";
            colPaymentsSummary.OptionsColumn.AllowEdit = false;
            colPaymentsSummary.Visible = true;
            colPaymentsSummary.VisibleIndex = 11;
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, barLoadFileBtn });
            ribbon.Location = new Point(0, 0);
            ribbon.MaxItemId = 2;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbon.Size = new Size(1354, 158);
            ribbon.StatusBar = ribbonStatusBar;
            // 
            // barLoadFileBtn
            // 
            barLoadFileBtn.Caption = "Загрузить XML";
            barLoadFileBtn.Id = 1;
            barLoadFileBtn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barLoadFileBtn.ImageOptions.SvgImage");
            barLoadFileBtn.Name = "barLoadFileBtn";
            barLoadFileBtn.ItemClick += barLoadFileBtn_ItemClick;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Главное";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(barLoadFileBtn);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new Point(0, 817);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(1354, 24);
            // 
            // gtdGoodsGridRowBindingSource
            // 
            gtdGoodsGridRowBindingSource.DataSource = typeof(Shared.Models.GtdGoodsGridRow);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1354, 841);
            Controls.Add(gridManControl);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            Name = "MainForm";
            Ribbon = ribbon;
            StatusBar = ribbonStatusBar;
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)goodsView).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridManControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)gtdDeclarationGridRowBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridMainView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)gtdGoodsGridRowBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barLoadFileBtn;
        private DevExpress.XtraGrid.GridControl gridManControl;
        private BindingSource gtdGoodsGridRowBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridMainView;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDeclarationType;
        private DevExpress.XtraGrid.Columns.GridColumn colImporterName;
        private DevExpress.XtraGrid.Columns.GridColumn colImporterAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colImporterPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colImporterEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colExporterName;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodsCount;
        private DevExpress.XtraGrid.Columns.GridColumn colGoodsSummary;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumentsSummary;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentsSummary;
        private BindingSource gtdDeclarationGridRowBindingSource;
        private DevExpress.XtraGrid.Views.Card.CardView goodsView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}