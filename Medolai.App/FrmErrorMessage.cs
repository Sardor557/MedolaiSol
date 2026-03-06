using DevExpress.XtraEditors;

namespace Medolai.App
{
    public partial class FrmErrorMessage : XtraForm
    {
        public FrmErrorMessage()
        {
            InitializeComponent();

            // CLang.Init(this);
        }

        private void OnCloseClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}