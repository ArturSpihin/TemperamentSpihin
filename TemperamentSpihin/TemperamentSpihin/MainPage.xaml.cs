using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TemperamentSpihin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            var redContentPage = new ContentPage//Temperamet
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Red",//Temperament
                            FontSize = Device.GetNamedSize ( NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        {
                            new BoxView
                            {
                                Color = Color.Red,//Red
                                WidthRequest = 200,
                                HeightRequest = 200,
                                HorizontalOptions = LayoutOptions.Center,
                                VerticalOptions = LayoutOptions.CenterAndExpand

                            }

                        }
                    }
                }
            };
        }
    }
}