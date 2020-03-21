using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunter
{
    public class AppXML
    {
        public WindowsDriver<WindowsElement> WinAppDriver;
        private AppiumOptions _winAppCapabilities;
        private TimeSpan _explicitWait;
        private TimeSpan _implicitWait;
        private Uri _driverUri;

        public AppXML()
        {
            _implicitWait = TimeSpan.FromSeconds(20);
            _explicitWait = TimeSpan.FromSeconds(20);
            string winPort = File.ReadAllText("winPort.txt", Encoding.UTF8);
            _driverUri = new Uri(winPort);
        }

         
        public void StartFromProcess(string windowTitle)
        {
            SwitchToWindow(windowTitle);
        }

        public void SwitchToWindow(string windowTitle)
        {
            string windowHandle = GetWindowHandle(windowTitle);
            SwitchToWindowByWindowHandle(windowHandle);
        }

        public string GetWindowHandle(string windowTitle)
        {
            string windowHandle = GetWindowHandleByWindowTitle(windowTitle);
            return windowHandle;
        }

        public void SwitchToWindowByWindowHandle(string windowHandle)
        {
            _winAppCapabilities = new AppiumOptions();
            _winAppCapabilities.AddAdditionalCapability("platformName", "Windows");
            _winAppCapabilities.AddAdditionalCapability("appTopLevelWindow", windowHandle);
            WinAppDriver = new WindowsDriver<WindowsElement>(_driverUri, _winAppCapabilities);
            WinAppDriver.Manage().Timeouts().ImplicitWait = _implicitWait;
        }

        private string GetWindowHandleByWindowTitle(string windowTitle)
        {
            var process = Process.GetProcesses().Where(p => p.MainWindowTitle.Contains(windowTitle)).FirstOrDefault();
            return process != null ? process.MainWindowHandle.ToString("X4") : string.Empty;
        }
    }
}
