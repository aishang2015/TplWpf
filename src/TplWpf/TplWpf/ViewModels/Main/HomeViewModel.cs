﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TplWpf.ViewModels.Main
{
	public partial class HomeViewModel : ObservableObject
	{
		[ObservableProperty]
		int? count = 0;

		[ObservableProperty]
		bool isOpen = false;

		[RelayCommand]
		public async Task Increase()
		{
			Count++;
		}

		[RelayCommand]
		public void OpenHost()
		{
			IsOpen = true;
		}

	}
}
