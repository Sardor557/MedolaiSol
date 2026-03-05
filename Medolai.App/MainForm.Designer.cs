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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            barLoadFileBtn = new DevExpress.XtraBars.BarButtonItem();
            gridManControl = new DevExpress.XtraGrid.GridControl();
            gridMainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridManControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridMainView).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, barLoadFileBtn });
            ribbon.Location = new Point(0, 0);
            ribbon.MaxItemId = 2;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbon.Size = new Size(1164, 158);
            ribbon.StatusBar = ribbonStatusBar;
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
            ribbonStatusBar.Size = new Size(1164, 24);
            // 
            // barLoadFileBtn
            // 
            barLoadFileBtn.Caption = "Загрузить XML";
            barLoadFileBtn.Id = 1;
            barLoadFileBtn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barLoadFileBtn.ImageOptions.SvgImage");
            barLoadFileBtn.Name = "barLoadFileBtn";
            // 
            // gridManControl
            // 
            gridManControl.Dock = DockStyle.Fill;
            gridManControl.Location = new Point(0, 158);
            gridManControl.MainView = gridMainView;
            gridManControl.MenuManager = ribbon;
            gridManControl.Name = "gridManControl";
            gridManControl.Size = new Size(1164, 659);
            gridManControl.TabIndex = 2;
            gridManControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridMainView });
            // 
            // gridMainView
            // 
            gridMainView.GridControl = gridManControl;
            gridMainView.Name = "gridMainView";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 841);
            Controls.Add(gridManControl);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            Name = "MainForm";
            Ribbon = ribbon;
            StatusBar = ribbonStatusBar;
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridManControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridMainView).EndInit();
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
        private DevExpress.XtraGrid.Views.Grid.GridView gridMainView;
    }
}