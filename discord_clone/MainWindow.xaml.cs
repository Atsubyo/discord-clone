using System;
using System.Windows;

namespace discord_clone {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(Window_Loaded);
            this.SourceInitialized += new EventHandler(Window_SourceInitialized);
        }
    }
}
