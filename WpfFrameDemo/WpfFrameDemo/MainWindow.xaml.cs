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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void CallFromChild(string name)
        {
            MessageBox.Show("Hello " + name + "!");
        }

//         private void btnNav_Click(object sender, RoutedEventArgs e)
//         {
//             Button btn = sender as Button;
//             this.frmMain.Navigate(new Uri(btn.Tag.ToString() + ".xaml", UriKind.Relative));
//         }

        private void btnA_Click(object sender, RoutedEventArgs e)
        {
            PageA a = new PageA();
            this.frmMain.Content = a;
            a.ParentWindow = this;
        }

        private void btnB_Click(object sender, RoutedEventArgs e)
        {
            PageB b = new PageB();
            this.frmMain.Content = b;
            b.ParentWindow = this;
        }
    }
}
