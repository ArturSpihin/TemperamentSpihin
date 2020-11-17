using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TemperamentSpihin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sangvinik : ContentPage
    {
        public Sangvinik()
        {
            var redContentPage = new ContentPage//Sangvinik
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Жизнерадостные люди, которые легко адаптируются в любой компании и в результате оказываются в центре внимания.",//Temperament
                            FontSize = Device.GetNamedSize ( NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        {
                            new BoxView
                            {
                                Color = Color.Red,//Purple
                                WidthRequest = 175,
                                HeightRequest = 150,
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