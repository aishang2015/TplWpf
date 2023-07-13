using Prism.DryIoc;
using Prism.Ioc;
using Prism.Mvvm;
using System.Windows;
using TplWpf.ViewModels;
using TplWpf.ViewModels.Main;
using TplWpf.Views.Main;

namespace TplWpf
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : PrismApplication
	{
		protected override Window CreateShell()
		{
			return Container.Resolve<MainWindow>();
		}

		protected override void RegisterTypes(IContainerRegistry containerRegistry)
		{
			containerRegistry.RegisterForNavigation<Home>();
		}

		protected override void ConfigureViewModelLocator()
		{
			base.ConfigureViewModelLocator();
			ViewModelLocationProvider.Register<MainWindow, MainWindowViewModel>();
			ViewModelLocationProvider.Register<Home, HomeViewModel>();
		}
	}
}
