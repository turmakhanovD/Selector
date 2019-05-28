using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SelectorApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DownloadCS(object sender, RoutedEventArgs e)
        {
            var currentDomain = AppDomain.CurrentDomain;
            var csDomain = AppDomain.CreateDomain("DownloadCS");
            var csApplicationPath = currentDomain.BaseDirectory + "DownloadCS.exe";

            csDomain.ExecuteAssembly(csApplicationPath);
                     
            AppDomain.Unload(csDomain);

        
        }

        private void Math(object sender, RoutedEventArgs e)
        {
            var currentDomain = AppDomain.CurrentDomain;
            var mathDomain = AppDomain.CreateDomain("BigMath");
            var ApplicationPath = currentDomain.BaseDirectory + "BigMath.exe";

            mathDomain.ExecuteAssembly(ApplicationPath);

            AppDomain.Unload(mathDomain);
        }
    }
}
