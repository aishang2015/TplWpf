using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Prism.Common;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TplWpf.ViewModels
{
	public partial class MainWindowViewModel : ObservableObject
	{
		private readonly IRegionManager _regionManager;

		public MainWindowViewModel(IRegionManager regionManager)
		{
			_regionManager = regionManager;
		}

		[RelayCommand]
		public void NavTo(string uri)
		{
			_regionManager.RequestNavigate(MainWindow.ContentRegionName, uri);
		}
	}
}
