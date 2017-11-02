using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
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

            CollectionItems cItems = new CollectionItems();

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
                            WidthRequest = 350,
                            HeightRequest = 1000,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        };
                imageBox.SetBinding(Image.SourceProperty, "ImageItem");
                //imageBox.SetBinding(ImageSource.FromResource("ImageItem"));

                    return new ContentPage
                    {
                        Padding = padding,
                        Content = new StackLayout
                        {
                            Children =
                        {
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
