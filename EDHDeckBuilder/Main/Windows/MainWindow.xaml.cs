using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Linq;

namespace EDHDeckBuilder.Main.Windows
{
	public partial class MainWindow : Window
	{
		private List<Grid> Menus;

		public MainWindow()
		{
			InitializeComponent();
			Menus = new List<Grid>(MainGrid.Children.Cast<UIElement>().Where(e => e.GetType() == typeof(Grid)).Cast<Grid>());
		}

		private void ScaleFontSize(object sender, SizeChangedEventArgs e)
		{
			FontSize = e.NewSize.Height / 20;
		}

		private void CreateDeckButtonClicked(object sender, RoutedEventArgs ev)
		{
			EnableMenuDisableOthers("CreateDeck");
		}

		private void OpenDeckRepositoryClicked(object sender, RoutedEventArgs ev)
		{
			EnableMenuDisableOthers("OpenDeckRepo");
		}

		private void UpdateCardsAndSymbolsClicked(object sender, RoutedEventArgs ev)
		{
			EnableMenuDisableOthers("Update");
		}

		private void SettingsClicked(object sender, RoutedEventArgs ev)
		{
			EnableMenuDisableOthers("Settings");
		}

		private void EnableMenuDisableOthers(string name)
		{
			Menus.ForEach(e => e.Visibility = Visibility.Collapsed);
			Menus.Where(e => e.Name == name).First().Visibility = Visibility.Visible;
		}
	}
}
