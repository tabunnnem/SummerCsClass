using System.Windows;
using System.Windows.Navigation;

namespace HelloWPF.View
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    internal partial class MainWindow : NavigationWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public int Str { get; set; }
    }
}


