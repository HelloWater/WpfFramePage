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

namespace WpfFrameDemo
{
    /// <summary>
    /// Interaction logic for PageA.xaml
    /// </summary>
    public partial class PageA : Page
    {
        public PageA()
        {
            InitializeComponent();
        }

        private MainWindow _parentWin;
        public MainWindow ParentWindow
        {
            get { return _parentWin; }
            set { _parentWin = value; }
        }

        private void btnCall_Click(object sender, RoutedEventArgs e)
        {
            if(ParentWindow != null)
            {
                ParentWindow.CallFromChild("PageA");
            }
        }
    }
}
