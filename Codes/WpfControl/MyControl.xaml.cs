using System.Windows;

namespace WpfControl
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class MyControl
    {
        public MyControl()
        {
            InitializeComponent();
        }

        private void MessageButton_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello, I'm from WPF.");
        }


        private void WindowButton_OnClick(object sender, RoutedEventArgs e)
        {
            new MyWindow().ShowDialog();
        }
    }
}