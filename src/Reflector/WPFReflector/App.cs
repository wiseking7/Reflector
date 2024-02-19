using Jamesnet.Wpf.Controls;
using System.Windows;
using System.Windows.Controls;

namespace WPFReflector
{
    internal class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            Window window = new Window();
            window.Title = "Heimdall Reflector";
            window.Content = new Slider();

            return window;
        }
    }
}
