using System.Windows;

namespace discord_clone {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        private void ButtonMinimize_Click(object sender, RoutedEventArgs e) {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
        private void ButtonMaximize_Click(object sender, RoutedEventArgs e) {
            if (Application.Current.MainWindow.WindowState != WindowState.Maximized) {
                App.Current.MainWindow.WindowState = WindowState.Maximized;
            } else {
                App.Current.MainWindow.WindowState = WindowState.Normal;
            }
        }
        private void ButtonClose_Click(object sender, RoutedEventArgs e) {
            Application.Current.Shutdown();
        }
    }
}
