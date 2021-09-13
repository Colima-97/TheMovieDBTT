using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace TheMovieDBTT.Customs.Controls
{
	public partial class StarsControl : ContentView
	{
		#region Public BindableProperties

		public static readonly BindableProperty StarsVoteProperty =
			BindableProperty.Create(
                nameof(StarsVoteValue),
				typeof(float),
				typeof(StarsControl),
                defaultValue: 10.0,
				defaultBindingMode: BindingMode.OneWay,
				propertyChanged: StarsPropertyChanged
            );

		public float StarsVoteValue 
        {
			get => (float)base.GetValue(StarsVoteProperty);
            set => base.SetValue(StarsVoteProperty, value); 
        }

		#endregion

		public StarsControl()
		{
			InitializeComponent();
		}

		#region Private Methods

		private static void StarsPropertyChanged(BindableObject bindable, object oldValue, object newValue)
		{
			var control = (StarsControl)bindable;

			var firstStar = control.firstStar;
			var secondStar = control.secondStar;
			var thirdStar = control.thirdStar;
			var fourthStar = control.fourthStar;
			var fifthStar = control.fifthStar;

			var starsVote = control.StarsVoteValue;
			var minOpacity = 0.5;

			if(starsVote == 0)
			{
				firstStar.Opacity = minOpacity;
				secondStar.Opacity = minOpacity;
				thirdStar.Opacity = minOpacity;
				fourthStar.Opacity = minOpacity;
				fifthStar.Opacity = minOpacity;
            }

			if(starsVote > 0 && starsVote <= 2)
			{
				secondStar.Opacity = minOpacity;
				thirdStar.Opacity = minOpacity;
				fourthStar.Opacity = minOpacity;
				fifthStar.Opacity = minOpacity;
			}

			if(starsVote >= 2.1 && starsVote <= 4)
			{
				thirdStar.Opacity = minOpacity;
				fourthStar.Opacity = minOpacity;
				fifthStar.Opacity = minOpacity;
			}

			if(starsVote >= 4.1 && starsVote <= 6)
			{
				fourthStar.Opacity = minOpacity;
				fifthStar.Opacity = minOpacity;
			}

			if(starsVote >= 6.1 && starsVote <= 8)
			{
				fifthStar.Opacity = minOpacity;
			}
		}

		#endregion
	}
}
