﻿namespace Xamarin.Forms.Controls.GalleryPages.VisualStateManagerGalleries
{
	public class VisualStateManagerGallery : ContentPage
	{
		public VisualStateManagerGallery()
		{
			var entryDisabledStatesButton = new Button { Text = "Entry Disabled States" };
			
			entryDisabledStatesButton.Clicked += (sender, args) => { Navigation.PushAsync (new EntryDisabledStatesGallery()); };

			var entryFocusStatesButton = new Button { Text = "Entry Focus States" };

			entryFocusStatesButton.Clicked += (sender, args) => { Navigation.PushAsync(new EntryFocusStatesGallery()); };

			Content = new StackLayout
			{
				Children = { entryDisabledStatesButton, entryFocusStatesButton }
			};
		}
	}
}
