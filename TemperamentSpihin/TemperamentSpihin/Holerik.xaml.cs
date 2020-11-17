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
    public partial class Holerik : ContentPage
    {
        public Holerik()
        {
            var redContentPage = new ContentPage//Holerik
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Горячий, импульсивный, стремительно реагирующий на ситуацию, страстный и неуравновешенный — вот основные характеристики человека с типом темперамента холерика.",//Temperament
                            FontSize = Device.GetNamedSize ( NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        {
                            new BoxView
                            {
                                Color = Color.DarkGoldenrod,//DarkGoldenrod
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
