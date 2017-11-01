using System;
using Xamarin.Forms;

namespace KidsPictures
{
    public class KidsPicturesPageCS
    {
        public KidsPicturesPageCS()
        {
            Thickness padding;
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                case Device.Android:
                    padding = new Thickness(0, 40, 0, 0);
                    break;
                default:
                    padding = new Thickness();
                    break;
            }

           var ItemTemplate = new DataTemplate(() =>
                {
                    var nameLabel = new Label
                    {
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.Start
                    };
                    nameLabel.SetBinding(Label.TextProperty, "NameItem");

                var imageBox = new Image
                    {
                        WidthRequest = 200,
                        HeightRequest = 50,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    };
                imageBox.SetBinding(Image.SourceProperty, "ImageItem");

                    return new ContentPage
                    {
                        Padding = padding,
                        Content = new StackLayout
                        {
                            Children = {
                            nameLabel,
                            imageBox
                            }
                        }
                    };
                });

           var ItemsSource = CollectionItems.All;
        }
    }
}
