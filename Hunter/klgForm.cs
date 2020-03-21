using Hunter;
using KeyloggerExample;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class klgForm : Form
    {
        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);
        Process app = null;
        IntPtr h;
        string keyWord = File.ReadAllText("KeyWord.txt", Encoding.UTF8);

        public klgForm()
        {
            InitializeComponent();
        }

        private void cbKeyloggerEnabled_CheckedChanged(object sender, EventArgs e)
        {
            keylogger1.Enabled = cbKeyloggerEnabled.Checked ? true : false;
        }

        private void klgForm_Load(object sender, EventArgs e)
        {
            string inspect = File.ReadAllText("App.txt", Encoding.UTF8);
            app = Process.Start(inspect);
            Thread.Sleep(2000);
            app.WaitForInputIdle();
            h = app.MainWindowHandle;
            SetForegroundWindow(h);
        }

        private void keylogger1_VKCodeAsStringDown(string value, bool isChar)
        {
            if (value.ToUpper() == keyWord.ToUpper())
            {
                resourcesTxt.Clear();
                SetForegroundWindow(h);
                SendKeys.Send("^+4");
                resourcesTxt.Paste();
                showElementsTxt.Text += CreateElement.BuildElement(resourcesTxt.Text.ToString());
                AppTxt.Text = CreateElement.GetControlName(resourcesTxt.Text.ToString());
            }
        }

        private void CleanBtn_Click(object sender, EventArgs e)
        {
            showElementsTxt.Clear();
            resourcesTxt.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppXML appXML = new AppXML();
            appXML.StartFromProcess(AppTxt.Text);
            resourcesTxt.Clear();
            resourcesTxt.Text = appXML.WinAppDriver.PageSource;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void klgForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                app.Kill();
            }
            catch { }
        }
    }
}
