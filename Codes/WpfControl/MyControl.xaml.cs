using System.Windows;

namespace WpfControl
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class MyControl
    {
        public delegate void MessageHandler(object sender, string message);
        public event MessageHandler MessageReceived;

        public MyControl()
        {
            InitializeComponent();
        }

        private void MessageButton_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello, I'm from WPF.");
        }

        private void SendButton_OnClick(object sender, RoutedEventArgs e)
        {
            MessageReceived?.Invoke(this, MessageTextBox.Text);
        }

        private void WindowButton_OnClick(object sender, RoutedEventArgs e)
        {
            new MyWindow().ShowDialog();
        }
    }
}