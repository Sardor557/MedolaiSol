using DevExpress.XtraBars;
using DevExpress.XtraGrid;
using Medolai.App.Services;

namespace Medolai.App
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly GridService gridService = new GridService();
        public MainForm()
        {
            InitializeComponent();
        }

        private async void gridManControl_Load(object sender, EventArgs e)
        {
            WaitFormManager.Show(this);
            try
            {
                var gr = await gridService.GetRowsAsync();
                this.gridManControl.DataSource = gr;

                gridManControl.ViewCollection.Add(this.goodsView);

                goodsView.OptionsView.ShowQuickCustomizeButton = false;
                goodsView.OptionsBehavior.Editable = false;

                GridLevelNode node = new GridLevelNode();
                node.RelationName = "Goods";
                node.LevelTemplate = goodsView;

                gridManControl.LevelTree.Nodes.Clear();
                gridManControl.LevelTree.Nodes.Add(node);

                goodsView.CustomDrawCardCaption += (s, e) =>
                {
                    e.CardCaption = $"Товар № {e.RowHandle + 1}";
                };

                goodsView.PopulateColumns();
            }
            finally
            {
                WaitFormManager.Close(this);
            }
        }

        private async void barLoadFileBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "XML files|*.xml";
                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                WaitFormManager.Show(this);
                try
                {
                    string filePath = ofd.FileName;
                    var res = await gridService.LoadAsync(filePath);
                    if (res.Code == 1)
                    {
                        MessageBox.Show("Файл успешно загружен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var gr = await gridService.GetRowsAsync();
                        this.gridManControl.DataSource = gr;
                    }
                    else
                        MessageBox.Show($"Ошибка загрузки файла: {res.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    WaitFormManager.Close(this);
                }
            }
        }
    }
}