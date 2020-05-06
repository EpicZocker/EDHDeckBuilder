using System.Windows;

namespace EDHDeckBuilder
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void ScaleFontSize(object sender, SizeChangedEventArgs e)
		{
			FontSize = e.NewSize.Height / 20;
		}

		private void CreateDeckButtonClicked(object sender, RoutedEventArgs e)
		{
			MainMenu.Visibility = Visibility.Collapsed;
		}

		private void OpenDeckRepositoryClicked(object sender, RoutedEventArgs e)
		{
			MainMenu.Visibility = Visibility.Collapsed;
		}

		private void UpdateCardsAndSymbolsClicked(object sender, RoutedEventArgs e)
		{
			MainMenu.Visibility = Visibility.Collapsed;
		}

		private void SettingsClicked(object sender, RoutedEventArgs e)
		{
			MainMenu.Visibility = Visibility.Collapsed;
		}
	}
}
