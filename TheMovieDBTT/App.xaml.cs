﻿using System;
using TheMovieDBTT.Views.Home;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TheMovieDBTT
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new MovieList();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
