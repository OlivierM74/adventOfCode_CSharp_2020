using AdventOfCode2020.ViewModels;
using System.Configuration;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows;

namespace AdventOfCode2020
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel()
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }

}
