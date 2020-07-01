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
using System.Windows.Shapes;

namespace Reyuko.App.Views.Pos
{
    /// <summary>
    /// Interaction logic for totalpembayaran.xaml
    /// </summary>
    public partial class totalpembayaran : Window
    {
        public totalpembayaran()
        {
            InitializeComponent();
        }

        private void Cancel_Clicks(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
