using DevExpress.Xpf.Core;
using System.Windows.Controls;

namespace Reyuko.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            var vHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
        }

    }
}
