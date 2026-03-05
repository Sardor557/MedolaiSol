using DevExpress.Spreadsheet.Charts;
using DevExpress.XtraBars;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Card;
using Medolai.App.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medolai.App
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void gridManControl_Load(object sender, EventArgs e)
        {
            var service = new GridService();
            var gr = await service.GetRowsAsync();
            this.gridManControl.DataSource = gr;

            gridManControl.ViewCollection.Add(this.goodsView);

            // настройки карточек
            goodsView.OptionsView.ShowQuickCustomizeButton = false;
            goodsView.OptionsBehavior.Editable = false;

            // связь master-detail
            GridLevelNode node = new GridLevelNode();
            node.RelationName = "Goods";   // имя коллекции
            node.LevelTemplate = goodsView;

            gridManControl.LevelTree.Nodes.Clear();
            gridManControl.LevelTree.Nodes.Add(node);

            goodsView.CustomDrawCardCaption += (s, e) =>
            {
                e.CardCaption = $"Товар № {e.RowHandle + 1}";
            };

            // создать колонки
            goodsView.PopulateColumns();
        }
    }
}