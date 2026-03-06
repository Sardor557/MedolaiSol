using DevExpress.XtraBars.Alerter;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace Medolai.App
{
    public class WaitFormManager
    {
        public static void Show(XtraForm form)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                form.UseWaitCursor = true;
                form.Enabled = false;
            }
            catch (Exception)
            {
            }
        }

        public static void Close(XtraForm form)
        {
            try
            {
                SplashScreenManager.CloseForm();
                form.UseWaitCursor = false;
                form.Enabled = true;
            }
            catch (Exception)
            {
            }
        }
    }

    public class AlertMessage
    {
        public static void ShowError()
        {
            using (var box = new FrmErrorMessage())
            {
                box.ShowDialog();
            }
        }

        public static void ShowAlertError(Form CurMainForm, string mes)
        {
            try
            {
                var box = new AlertControl();
                var ai = new AlertInfo("Ошибка", mes);
                box.AutoFormDelay = 3000;
                box.AllowHotTrack = false;
                box.FormDisplaySpeed = AlertFormDisplaySpeed.Slow;
                box.FormLocation = AlertFormLocation.BottomRight;
                box.AutoHeight = true;
                box.FormMaxCount = 3;
                box.Show(CurMainForm, ai);
            }
            catch (Exception)
            {
            }
        }

        public static void Show(Form CurMainForm, string mes, string caption = "Информация")
        {
            try
            {
                var box = new AlertControl();
                var ai = new AlertInfo(caption, mes);
                box.AutoFormDelay = 3000;
                box.AllowHotTrack = false;
                box.FormDisplaySpeed = AlertFormDisplaySpeed.Moderate;
                box.FormLocation = AlertFormLocation.BottomRight;
                box.AutoHeight = true;
                box.Show(CurMainForm, ai);
            }
            catch (Exception)
            {
            }
        }

        public static void Show(Form CurMainForm, string mes, bool isSucces)
        {
            if (!isSucces)
                ShowAlertError(CurMainForm, mes);
            else
                Show(CurMainForm, mes);
        }
    }
}