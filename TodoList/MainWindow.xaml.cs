using System.Windows;
using TodoList.Data;
using TodoList.ViewModel;

namespace TodoList
{
    public partial class MainWindow : Window
    {
        private readonly TasksViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new TasksViewModel(new TaskDataProvider());
            DataContext = _viewModel;
            Loaded += MainWindow_Loaded;
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            await _viewModel.LoadAsync();
        }
    }
}