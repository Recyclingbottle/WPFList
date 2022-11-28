using System;
using System.Collections.Generic;
using System.IO;
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

namespace WPFList
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

        private void OnChanged(object sender, SelectionChangedEventArgs e)
        {
            //ListViewItem item = (ListViewItem)FList.SelectedItem;
            //TextBlock t = (TextBlock)((StackPanel)item.Content).Children[1];

            //MessageBox.Show(t.Text);
            //try
            //{
            //    BitmapImage b = new BitmapImage(new Uri("pack://application:,,,/WPFList;" + $"component/Images/{t.Text}.jpg"));
            //    F_image.Source = b;
            //} catch(IOException err) {
            //    MessageBox.Show(err.Message);
            //    F_image.Source = null;
            //}
            //ctrl+k+c 주식화,  ctrl+k+u 풀기

            //BitmapImage b = new BitmapImage(new Uri($"Images/{t.Text}.jpg", UriKind.RelativeOrAbsolute));
            //F_image.Source = b;



        }

        private void Onselected(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            TreeViewItem item = (TreeViewItem)FTree.SelectedItem;
            BitmapImage b = new BitmapImage(new Uri($"Images/{item.Header}.jpg", UriKind.RelativeOrAbsolute));
            F_image.Source = b;
        }
    }
}
