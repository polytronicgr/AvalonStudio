using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvalonStudio.Controls
{
	public class MainMenu : UserControl
	{
		public MainMenu()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}