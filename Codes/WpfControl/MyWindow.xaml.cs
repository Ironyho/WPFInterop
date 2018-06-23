using System.Windows.Input;

namespace WpfControl
{
    /// <summary>
    /// Interaction logic for MyWindow.xaml
    /// </summary>
    public partial class MyWindow
    {
        public MyWindow()
        {
            InitializeComponent();

            // double click mouse to close this window
            MouseDoubleClick += (s, e) =>
            {
                Close();
            };

            // press and drag left mouse button to move this window
            MouseLeftButtonDown += (s, e) =>
            {
                if (e.ButtonState == MouseButtonState.Pressed)
                {
                    DragMove();
                }
            };
        }
    }
}