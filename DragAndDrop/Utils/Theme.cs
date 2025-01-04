using DragAndDrop.Overrides;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace DragAndDrop.Utils
{
    public class Theme
    {
        private IntPtr _hwnd;
        private FormMain _currentForm;

        public Theme(IntPtr hwnd, FormMain currentForm)
        {
            _hwnd = hwnd;
            _currentForm = currentForm;
        }

        public void SetDefaultTheme()
        {
            int defaultTheme = GetDefaultTheme();

            if (defaultTheme == -1)
            {
                // Idk if this check works correctly. Needs testing -bulva2
                MessageBox.Show("Error getting default theme!\nThis may be caused by you using old version of windows!", "Compatibility Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (defaultTheme == 0)
            {
                SetDarkTheme();
            }
        }

        private int GetDefaultTheme()
        {
            string registryKeyPath = @"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
            string registryValueName = "AppsUseLightTheme";

            RegistryKey? key = Registry.CurrentUser.OpenSubKey(registryKeyPath);

            if (key == null || key.GetValue(registryValueName) == null)
                return -1;

            return (int)key.GetValue(registryValueName)!;
        }

        private void SetWindowDarkTheme(bool toggle)
        {
            
            [DllImport("dwmapi.dll")]
            //https://learn.microsoft.com/en-us/windows/win32/api/dwmapi/nf-dwmapi-dwmsetwindowattribute
            // dwAttribute - attribute, pvAttribute - value of the attribute, cbAttribute - size of the value 
            static extern int DwmSetWindowAttribute(IntPtr hwnd, int dwAttribute, ref int pvAttribute, int cbAttribute);

            //https://learn.microsoft.com/en-us/windows/win32/api/dwmapi/ne-dwmapi-dwmwindowattribute
            int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;
            int useDarkMode = toggle ? 1 : 0;

            int resultCode = DwmSetWindowAttribute(_hwnd, DWMWA_USE_IMMERSIVE_DARK_MODE, ref useDarkMode, sizeof(int));
        }

        private void SetDarkComponentColors(FormMain form)
        {
            form.BackColor = Color.FromArgb(30, 30, 30);

            form.PictureBox.BackColor = Color.FromArgb(45, 45, 45);
            form.PictureBox.Refresh();

            form.MenuStrip.Renderer = new DarkThemeToolStripRenderer();
            form.MenuStrip.BackColor = Color.FromArgb(35, 35, 35);
            form.MenuStrip.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void SetLightComponentColors(FormMain form)
        {
            form.BackColor = SystemColors.Control;

            form.PictureBox.BackColor = Color.White;
            form.PictureBox.Refresh();

            form.MenuStrip.Renderer = new ToolStripProfessionalRenderer();
            form.MenuStrip.BackColor = SystemColors.Control;
            form.MenuStrip.ForeColor = SystemColors.ControlText;
        }

        public void SetLightTheme()
        {
            SetLightComponentColors(_currentForm);
            SetWindowDarkTheme(false);
        }

        public void SetDarkTheme()
        {
            SetDarkComponentColors(_currentForm);
            SetWindowDarkTheme(true);
        }
    }
}
