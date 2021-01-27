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

namespace task4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }
        public event EventHandler EventSum = null;
        public event EventHandler EventSub = null;
        public event EventHandler EventMul = null;
        public event EventHandler EventDiv = null;
        private void Button_Click_Sum(object sender, RoutedEventArgs e)
        {
            EventSum.Invoke(sender, e);
        }

        private void Button_Click(object sender, RoutedEventArgs e)// -
        {
            EventSub.Invoke(sender, e);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) // *
        {
            EventMul.Invoke(sender, e);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) // /
        {
            EventDiv.Invoke(sender, e);
        }
    }
}
