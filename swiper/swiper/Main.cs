using ScnSideMenu.Forms;
using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace swiper
{
    public class MainPage : SideBarPage
    {
        public MainPage() : base(PanelSetEnum.psLeft)
        {
            var imgButton = new Button
            {
                Image = "right",
                WidthRequest = 32,
                HeightRequest = 32
            };

            imgButton.Clicked += (sender, e) =>
            {
                IsShowLeftPanel = !IsShowLeftPanel;
            };

            var sillyStack = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Padding = new Thickness(0, 8),
                Children = { imgButton, new WebView { HeightRequest = App.ScreenSize.Height, WidthRequest = App.ScreenSize.Width * .95, Source = "http://www.liverpoolfc.net" } }
            };

            ContentLayout.HorizontalOptions = LayoutOptions.Start;
            ContentLayout.VerticalOptions = LayoutOptions.Center;
            ContentLayout.Children.Add(sillyStack);

            LeftPanel.BackgroundColor = Color.Yellow;
            LeftPanelWidth = App.ScreenSize.Width * .4;
            LeftPanel.AddToContext(
                new StackLayout
                {
                    Padding = new Thickness(32),
                    Children =
                    {
                        new Label
                        {
                            Text = "left menu",
                            TextColor = Color.Green,
                        }
                    }
                });
        }
    }

}